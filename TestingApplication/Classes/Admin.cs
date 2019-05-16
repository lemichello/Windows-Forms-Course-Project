using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[assembly: InternalsVisibleTo("TestingApplication")]

namespace TestingApplication.Classes
{
    internal static class Admin
    {
        private const string UsersPath = "../../../ClassLibrary/XML/users.xml";
        private const string TestsPath = "../../../ClassLibrary/XML/tests.xml";


        /// <summary>
        /// Registers a admin.
        /// </summary>
        internal static void Register(string password)
        {
            var xDocument = XDocument.Load(UsersPath);

            var admin = new XElement("User");

            admin.Add(new XAttribute("type", "admin"));

            admin.Add(new XElement("Login", StringCipher.Encrypt("admin")));
            admin.Add(new XElement("Password", StringCipher.Encrypt(password)));

            xDocument.Root?.Add(admin);

            xDocument.Save(UsersPath);
        }



        /// <summary>
        /// Encrypts test.
        /// </summary>
        /// <param name="test">Test, which need to encrypt.</param>
        /// <returns>Encrypted test.</returns>
        private static XElement EncryptTest(XElement test)
        {
            var encryptedTest = new XElement("Test");

            encryptedTest.Add(new XElement("Name", test.Element("Name").Value));

            foreach (var i in test.Elements("Question"))
            {
                var question = new XElement("Question", "");

                question.Add(new XElement("Text", StringCipher.Encrypt(i.Element("Text").Value)));
                question.Add(new XElement("Variants", ""));

                foreach (var j in i.Element("Variants").Elements("Variant"))
                {
                    var variant = new XElement("Variant", StringCipher.Encrypt(j.Value));

                    variant.Add(new XAttribute("correct", j.Attribute("correct").Value));

                    question.Element("Variants").Add(variant);
                }

                encryptedTest.Add(question);
            }

            return encryptedTest;
        }

        /// <summary>
        /// Appends to existing (original) XML-file with tests another XML-file with tests.
        /// </summary>
        /// <param name="path">Path to another XML-file.</param>
        private static void AppendXml(string path)
        {
            var xDoc = XDocument.Load(path);
            var xDocOriginal = XDocument.Load(TestsPath);
            var schemaSet = new XmlSchemaSet();
            bool isCorrect = true;

            schemaSet.Add("", "../../../ClassLibrary/XML/testsSchema.xsd");

            // Checking for correctivity of another XML-file.
            xDoc.Validate(schemaSet, (sender, eventArgs) =>
            {
                MainForm.ThrowException($"Error : {eventArgs.Message}");

                isCorrect = false;
            });

            if (!isCorrect)
                return;

            foreach (var category in xDoc.Root.Elements("Category"))
            {
                // If original file has the same category like another file.
                if (xDocOriginal.Root.Elements("Category").Any(j => category.Element("Name").Value == j.Element("Name").Value))
                {
                    // Assigning needed category from original file.
                    var originalCategory = xDocOriginal.Root.Elements("Category")
                        .First(j => category.Element("Name").Value == j.Element("Name").Value);

                    foreach (var test in category.Element("Tests").Elements("Test"))
                    {
                        // If there's identical names of both tests.
                        if (xDocOriginal.Root.Elements("Category").Elements("Tests").Elements("Test").
                            Any(n => n.Element("Name").Value == test.Element("Name").Value))
                            continue;

                        originalCategory.Element("Tests").Add(EncryptTest(test));
                    }

                    // Replacing old category with new category in original file.
                    xDocOriginal.Root.Elements("Category")
                        .First(j => j.Element("Name").Value == category.Element("Name").Value).ReplaceWith(originalCategory);
                }
                else
                {
                    var newCategory = new XElement("Category");

                    newCategory.Add(new XElement("Name", category.Element("Name").Value));

                    newCategory.Add(new XElement("Tests", ""));

                    foreach (var j in category.Element("Tests").Elements("Test"))
                    {
                        newCategory.Element("Tests").Add(EncryptTest(j));
                    }

                    xDocOriginal.Root.Add(newCategory);
                }
            }

            xDocOriginal.Save(TestsPath);
        }

        /// <summary>
        /// Replaces existing (original) XML-file with tests by another XML-file.
        /// </summary>
        /// <param name="path">Path to another XML-file.</param>
        private static void ReplaceXml(string path)
        {
            var xDoc = XDocument.Load(path);
            var xDocOriginal = XDocument.Load(TestsPath);
            var schemaSet = new XmlSchemaSet();
            bool isCorrect = true;

            schemaSet.Add("", "../../../ClassLibrary/XML/testsSchema.xsd");

            // Checking for correctivity of another XML-file.
            xDoc.Validate(schemaSet, (sender, eventArgs) =>
            {
                MainForm.ThrowException($"Error : {eventArgs.Message}");

                isCorrect = false;
            });

            if (!isCorrect)
                return;

            xDocOriginal.Root.RemoveNodes();

            foreach (var i in xDoc.Root.Elements("Category"))
            {
                var category = new XElement("Category", "");

                category.Add(new XElement("Name", i.Element("Name").Value));
                category.Add(new XElement("Tests", ""));

                foreach (var j in i.Element("Tests").Elements("Test"))
                {
                    category.Element("Tests").Add(EncryptTest(j));
                }

                xDocOriginal.Root.Add(category);
            }

            xDocOriginal.Save(TestsPath);
        }

        /// <summary>
        /// Imports another XML-file with tests to existing (original) XML-file with tests.
        /// </summary>
        /// <param name="path">Path of the XML-file, from which will be importing.</param>
        public static void ImportTests(string path)
        {
            var res = MessageBox
                .Show("Choose \"yes\" if you want to append another XML-file to current, " +
                              "\"no\", if you want to replace current file by another;",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                switch (res)
                {
                    case DialogResult.Yes:
                        AppendXml(path);
                        break;

                    case DialogResult.No:
                        ReplaceXml(path);
                        break;
                }
            }
            catch (Exception)
            {
                MainForm.ThrowException("This name or path is\'nt exists. Try again.");

                ImportTests(path);
            }
        }

        /// <summary>
        /// Exports this XML-file with tests to another.
        /// </summary>
        /// <param name="path">Path of the XML-file, to which will be exporting.</param>
        public static void ExportXml(string path)
        {
            using (var writer = XmlWriter.Create(path))
            {
                using (var reader = XmlReader.Create(TestsPath))
                {
                    while (reader.Read())
                    {
                        writer.WriteNode(reader, true);
                    }
                }
            }
        }
    }
}