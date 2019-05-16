using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace TestingApplication.Classes
{
    internal static class User
    {
        private const string UsersPath = "../../../ClassLibrary/XML/users.xml";
        private const string TestsPath = "../../../ClassLibrary/XML/tests.xml";

        private static Dictionary<string, Dictionary<string, Dictionary<string, bool>>> _allTests =
            new Dictionary<string, Dictionary<string, Dictionary<string, bool>>>();

        /// <summary>
        /// Registers an user.
        /// </summary>
        /// <param name="element">Old (not full) User.</param>
        /// <returns>Full user (with all fields).</returns>
        internal static XElement Register(XElement element, string[] registrationData)
        {
            element.Element("Password")?.SetValue(StringCipher.Encrypt(registrationData[0]));

            element.Add(new XElement("Name", registrationData[1]));

            element.Add(new XElement("Surname", registrationData[2]));

            element.Add(new XElement("MiddleName", registrationData[3]));

            element.Add(new XElement("Address", registrationData[4]));

            element.Add(new XElement("Tests", ""));

            return element;
        }

        /// <summary>
        /// Caches all tests to the dictionary.
        /// </summary>
        internal static void CacheTests()
        {
            var xDoc = XDocument.Load(TestsPath);
            var schemaSet = new XmlSchemaSet();
            var isCorrect = true;

            schemaSet.Add("", "../../../ClassLibrary/XML/testsSchema.xsd");

            xDoc.Validate(schemaSet, (sender, e) =>
            {
                Console.WriteLine("ERROR: Incorrect content of the tests.xml file.");

                isCorrect = false;
            });

            if (!isCorrect)
            {
                _allTests = null;

                return;
            }

            foreach (var i in xDoc.Root.Elements("Category").Elements("Tests").Elements("Test"))
            {
                var name = i.Element("Name").Value;
                var test = FillDictionary(i);

                _allTests.Add(name, test);
            }
        }

        /// <summary>
        /// Gives a test by name of the test.
        /// </summary>
        /// <param name="testName">Name of the test.</param>
        /// <returns>Test</returns>
        public static Dictionary<string, Dictionary<string, bool>> GetTest(string testName)
        {
            return _allTests[testName];
        }

        private static Dictionary<string, Dictionary<string, bool>> FillDictionary(XElement test)
        {
            // Key = text of question.
            // value = dictionary (key = text of answer, value = correctivity of answer).
            var questions = new Dictionary<string, Dictionary<string, bool>>(test.Elements("Question").Count());

            foreach (var i in test.Elements("Question"))
            {
                // Text of question.
                var key = StringCipher.Decrypt(i.Element("Text")?.Value);

                // Adding to dictionary key as a text of question and allocating memory for
                // value-dictionary based on number of variants of question.
                questions.Add(key,
                    new Dictionary<string, bool>(i.Element("Variants").Elements("Variant").Count()));

                // Adding to value-dictionary texts of variants of answers as keys
                // and their correctivities as values.
                foreach (var j in i.Element("Variants").Elements("Variant"))
                {
                    questions[key].Add(StringCipher.Decrypt(j.Value),
                        Convert.ToBoolean(j.Attribute("correct")?.Value));
                }
            }

            return questions;
        }

        /// <summary>
        /// Adds testing results to XML-file.
        /// </summary>
        /// <param name="user">User, to whom testing results will be added.</param>
        /// <param name="mark">A mark of user's testing result.</param>
        /// <param name="position">Means the current test, on which the user has stopped.</param>
        /// <param name="category">Name of the category of the test.</param>
        /// <param name="subject">Name of the test.</param>
        /// <param name="id">Id of test.</param>
        /// <param name="isFinished">Means whether the user has finished his test.</param>
        public static void AddTestResults(XElement user, int mark, int position, string category, string subject, int id,
            bool isFinished)
        {
            var xDoc = XDocument.Load(UsersPath);
            var testResult = new XElement("Test", "");

            testResult.Add(new XAttribute("id", id));

            testResult.Add(new XElement("Category", category));
            testResult.Add(new XElement("Subject", subject));

            if (isFinished)
            {
                // If user finished unfinished test.
                try
                {
                    user.Element("Tests")
                        ?.Elements("Test").First(i =>
                        i.Attribute("id")?.Value == id.ToString() &&
                        i.Attribute("finished")?.Value == "false");

                    testResult.Add(new XAttribute("finished", "true"));

                    testResult.Add(new XElement("Mark", mark));

                    user.Element("Tests")?.Elements("Test").First(i => i.Attribute("id")?.Value == id.ToString()).ReplaceWith(testResult);

                    xDoc.Root?.Elements("User").First(i => StringCipher.Decrypt(i.Element("Login")?.Value) ==
                                                          StringCipher.Decrypt(user.Element("Login")?.Value)).ReplaceWith(user);

                    xDoc.Save(UsersPath);

                    return;
                }
                catch (Exception)
                {
                    // ignored
                }

                testResult.Add(new XAttribute("finished", "true"));

                testResult.Add(new XElement("Mark", mark));
            }
            else
            {
                // If user choose to continue a unfinished test and not finished it.
                try
                {
                    var unfinishedTest = user.Element("Tests")
                        ?.Elements("Test").First(i =>
                        i.Attribute("id")?.Value == id.ToString() &&
                        i.Attribute("finished")?.Value == "false");

                    // Updating data of test.
                    unfinishedTest.Attribute("position")?.SetValue(position);
                    unfinishedTest.Attribute("correctAnswers")?.SetValue(mark);

                    user.Element("Tests")?.Elements("Test").First(i => i.Attribute("id")?.Value == id.ToString()).ReplaceWith(unfinishedTest);

                    xDoc.Root?.Elements("User").First(i => StringCipher.Decrypt(i.Element("Login")?.Value) ==
                                                          StringCipher.Decrypt(user.Element("Login")?.Value)).ReplaceWith(user);

                    xDoc.Save(UsersPath);

                    return;
                }
                catch (Exception)
                {
                    // ignored
                }

                testResult.Add(new XAttribute("finished", "false"),
                               new XAttribute("position", position),
                               new XAttribute("correctAnswers", mark));

                testResult.Add(new XElement("Mark", ""));
            }

            user.Element("Tests")?.Add(testResult);

            // Replacing old version of user (without this test) with new version of user.
            xDoc.Root.Elements("User").First(i => StringCipher.Decrypt(i.Element("Login")?.Value) ==
                                                  StringCipher.Decrypt(user.Element("Login")?.Value)).ReplaceWith(user);

            xDoc.Save(UsersPath);
        }
    }
}
