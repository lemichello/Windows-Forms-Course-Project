using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using TestingApplication.Classes;

namespace TestingApplication.AdminForms
{
    public partial class AdminMenuForm : Form
    {
        private const string UsersPath = "../../../ClassLibrary/XML/users.xml";
        private const string TestsPath = "../../../ClassLibrary/XML/tests.xml";

        // Operations for admin.
        private readonly string[] _operations =
        {
            "Create user",
            "Delete user",
            "Edit user",
            "Add category",
            "Add test and questions to it",
            "Print testing results by individual category",
            "Print testing results by individual test",
            "Print testing results by individual user",
            "Import categories and questions from XML-file",
            "Export categories and questions to XML-file",
            "Change login or password",
            "Exit"
        };

        private readonly Action[] _methods;

        public AdminMenuForm()
        {
            InitializeComponent();

            foreach (var i in _operations)
                MenuClauses.Items.Add(i);

            _methods = new Action[]
            {
                CreateUser,
                DeleteUser,
                EditUser,
                AddCategory,
                AddTest,
                PrintTestingResultsByCategory,
                PrintTestingResultsByTests,
                PrintTestingResultsByUser,
                ImportTests,
                ExportXml,
                ChangeLoginOrPassword
            };
        }

        /// <summary>
        /// Changes login or password of the admin.
        /// </summary>
        private void ChangeLoginOrPassword()
        {
            var xDoc = XDocument.Load(UsersPath);

            var res = MessageBox.Show("Choose \"Yes\", if you want to change login, " +
                                      "\"No\", if you want to change password", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var form = res == DialogResult.Yes ? new ChangeLoginPasswordForm(true) : 
                new ChangeLoginPasswordForm(false);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            switch (res)
            {
                case DialogResult.Yes:
                    var login = form.Data;

                    xDoc.Root.Element("User").Element("Login")
                        .SetValue(StringCipher.Encrypt(login));
                    break;

                case DialogResult.No:
                    var password = form.Data;

                    xDoc.Root.Element("User").Element("Password")
                        .SetValue(StringCipher.Encrypt(password));
                    break;
            }

            xDoc.Save(UsersPath);
        }

        /// <summary>
        /// Exports this XML-file with tests to another.
        /// </summary>
        private void ExportXml()
        {
            if (SaveXmlFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Admin.ExportXml(SaveXmlFileDialog.FileName);
        }

        /// <summary>
        /// Imports another XML-file with tests to existing (original) XML-file with tests.
        /// </summary>
        private void ImportTests()
        {
            if (OpenXmlFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Admin.ImportTests(OpenXmlFileDialog.FileName);
        }

        /// <summary>
        /// Prints testing results by individual user.
        /// </summary>
        private void PrintTestingResultsByUser()
        {
            var form = new TestingResultsForm {Strategy = new TestStrategy.UserStrategy(UsersPath)};
            var xDoc = XDocument.Load(UsersPath);

            if (xDoc.Root.Elements("User").Any(i => i.Attribute("type").Value == "user"))
            {
                foreach (var i in xDoc.Root.Elements("User"))
                {
                    if (i.Attribute("type").Value == "user")
                        form.AddCategoryToList($"{i.Element("Name").Value} " +
                                               $"{i.Element("Surname").Value}");
                }
            }
            else
            {
                MainForm.ThrowException("There\'s no any users. You can add them.");

                return;
            }

            if (form.ShowDialog() != DialogResult.OK)
                return;

            SaveTestingResultsToFile(form.TestingResults);
        }

        /// <summary>
        /// Prints testing results by individual test.
        /// </summary>
        private void PrintTestingResultsByTests()
        {
            var form = new TestingResultsForm { Strategy = new TestStrategy(UsersPath) };
            var xDoc = XDocument.Load(TestsPath);

            if (xDoc.Root.Elements("Category").Any(i => i.Element("Tests").HasElements))
            {
                foreach (var i in xDoc.Root.Elements("Category"))
                {
                    foreach (var j in i.Elements("Tests").Elements())
                    {
                        form.AddCategoryToList($"{j.Element("Name").Value}");
                    }
                }
            }
            else
            {
                MainForm.ThrowException("There\'s no available tests. You can add them.");

                return;
            }

            if (form.ShowDialog() != DialogResult.OK)
                return;

            SaveTestingResultsToFile(form.TestingResults);
        }

        /// <summary>
        /// Adds all information about user and test result.
        /// </summary>
        /// <param name="user">User.</param>
        /// <param name="test">Test of User.</param>
        /// <returns>Information about user and this test.</returns>
        public static IEnumerable<string> CalculateUserTest(XElement user, XElement test)
        {
            yield return $"Human : {user.Element("Surname").Value} " +
                              $"{user.Element("Name").Value} {user.Element("MiddleName").Value}\r\n";

            yield return $"Address : {user.Element("Address").Value}\r\n";

            yield return $"Is test finished : {test.Attribute("finished").Value}\r\n";
            yield return $"Subject: {test.Element("Subject").Value}\r\n";
            yield return $"Mark : {test.Element("Mark").Value}\r\n";

            yield return "\r\n";
        }

        /// <summary>
        /// Saves string of testing results to the .txt file.
        /// </summary>
        /// <param name="testingResults">Testing results.</param>
        private void SaveTestingResultsToFile(string testingResults)
        {
            var dialogResult = MessageBox.Show("Do you want to save these testing results to the .txt file?",
                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
                return;

            if (SaveTxtFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = SaveTxtFileDialog.FileName;

            using (var writer = new StreamWriter(filename))
            {
                writer.Write(testingResults);
            }
        }

        /// <summary>
        /// Prints testing results by individual category.
        /// </summary>
        private void PrintTestingResultsByCategory()
        {
            var form = new TestingResultsForm {Strategy = new CategoryStrategy(UsersPath)};
            var xDoc = XDocument.Load(TestsPath);

            if (xDoc.Root.Elements("Category").Any(i => i.HasElements))
            {
                foreach (var i in xDoc.Root.Elements("Category"))
                {
                    form.AddCategoryToList($"{i.Element("Name")?.Value}");
                }
            }
            else
            {
                MainForm.ThrowException("There\'s no any categories. You should add one.");

                return;
            }

            if (form.ShowDialog() != DialogResult.OK)
                return;

            SaveTestingResultsToFile(form.TestingResults);
        }

        /// <summary>
        /// Adds a test and questions to it in category.
        /// </summary>
        private void AddTest()
        {
            var form = new AddTestForm();
            var xDoc = XDocument.Load(TestsPath);
            XElement category;

            if (xDoc.Root.Elements("Category").Any(i => i.HasElements))
            {
                foreach (var i in xDoc.Root.Elements("Category"))
                {
                    form.AddCategoryToList($"{i.Element("Name")?.Value}");
                }
            }
            else
            {
                MainForm.ThrowException("There\'s no any categories. You should add one.");

                return;
            }

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var categoryName = form.CategoryName;

            try
            {
                category = xDoc.Root?.Elements("Category").First(i => i.Element("Name")?.Value == categoryName);
            }
            // Exception will throw if while-loop will not find a name of category in XML-file.
            catch (Exception)
            {
                MainForm.ThrowException("Not found a category name. Try again.");

                AddTest();

                return;
            }

            var testName = form.TestName;
            var test = new XElement("Test");

            test.Add(new XElement("Name", testName));

            int numberOfQuestions = form.CountOfQuestions;

            for (var i = 0; i < numberOfQuestions; i++)
            {
                var variantForm = new FillTestForm();
                var question = new XElement("Question");

                if (variantForm.ShowDialog() != DialogResult.OK)
                    return;

                var questionText = variantForm.QuestionText;

                question.Add(new XElement("Text", StringCipher.Encrypt(questionText)));
                question.Add(new XElement("Variants", ""));

                // Adding variants to the question.
                for (var j = 0; j < variantForm.Variants.Length; j++)
                {
                    var variant = new XElement("Variant",
                        StringCipher.Encrypt(variantForm.Variants[j].Text));

                    variant.Add(new XAttribute("correct", variantForm.Variants[j].IsCorrect));

                    question.Element("Variants")?.Add(variant);
                }

                test.Add(question);
            }

            category?.Element("Tests")?.Add(test);

            xDoc.Save(TestsPath);
        }

        /// <summary>
        /// Adds a new category to the XML-file.
        /// </summary>
        private void AddCategory()
        {
            var form = new AddCategoryForm();
            var xDoc = XDocument.Load(TestsPath);
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

            var categoryName = form.CategoryName;

            try
            {
                while (xDoc.Root?.Elements("Category").First(i => i.Element("Name")?.Value == categoryName) != null)
                {
                    MainForm.ThrowException("This category is already exists. Try another.");

                    AddCategory();
                }
            }
            // Exception will throw if while-loop will not find a name of category in XML-file.
            catch (Exception)
            {
                // ignored
            }

            var category = new XElement("Category");

            category.Add(new XElement("Name", categoryName));

            category.Add(new XElement("Tests", ""));

            xDoc.Root?.Add(category);

            xDoc.Save(TestsPath);
        }

        /// <summary>
        /// Edits a user.
        /// </summary>
        private void EditUser()
        {
            var form = new EditUserForm();
            var xDoc = XDocument.Load(UsersPath);
            XElement user;
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

            var name = form.UserName;
            var surname = form.Surname;

            try
            {
                user = xDoc.Root?.Elements("User").First(i => i.Element("Name")?.Value == name &&
                                                                  i.Element("Surname")?.Value == surname);
            }
            catch (Exception)
            {
                MainForm.ThrowException("Not found a user. Try again.");

                EditUser();

                return;
            }

            switch (form.EditingTarget)
            {
                case "Edit name":
                    user?.Element("Name")?.SetValue(form.Value);
                    break;

                case "Edit surname":
                    user?.Element("Surname")?.SetValue(form.Value);
                    break;

                case "Edit middle name":
                    user?.Element("MiddleName")?.SetValue(form.Value);
                    break;

                case "Edit home address":
                    user?.Element("Address")?.SetValue(form.Value);
                    break;
            }

            xDoc.Save(UsersPath);
        }

        /// <summary>
        /// Deletes a user from XML-file.
        /// </summary>
        private void DeleteUser()
        {
            var form = new RemoveUserForm();
            var xDoc = XDocument.Load(UsersPath);
            XElement user;

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var name = form.UserName;
            var surname = form.Surname;

            try
            {
                user = xDoc.Root?.Elements("User").First(i => i.Element("Name")?.Value == name &&
                                                              i.Element("Surname")?.Value == surname);
            }
            catch (Exception)
            {
                MainForm.ThrowException("Not found a user. Try again.");

                DeleteUser();

                return;
            }

            user?.Remove();

            xDoc.Save(UsersPath);

            MessageBox.Show($"Successfully deleted {name} {surname}");
        }

        /// <summary>
        /// Creates a new User (only login).
        /// Then User will enter this login and will register a new account.
        /// </summary>
        private void CreateUser()
        {
            var form = new CreateUserForm();
            var xDoc = XDocument.Load(UsersPath);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var login = form.Login;

            try
            {
                // If login already exists.
                if (xDoc.Root?.Elements("User").First(i =>
                 {
                     return StringCipher.Decrypt(i.Element("Login")?.Value) == login;
                 }) != null)
                {
                    MainForm.ThrowException("This login is already exists. Try another.");

                    CreateUser();

                    return;
                }
            }
            // Exception will throw if while-loop will not find a login in XML-file.
            catch (Exception)
            {
                // ignored
            }

            var user = new XElement("User");

            user.Add(new XAttribute("type", "user"));

            user.Add(new XElement("Login", StringCipher.Encrypt(login)));
            user.Add(new XElement("Password", ""));

            xDoc.Root?.Add(user);

            xDoc.Save(UsersPath);
        }

        
        private void MenuClauses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MenuClauses.SelectedIndex != -1)
                ConfirmButton.Visible = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (MenuClauses.SelectedIndex == _operations.Length - 1)
            {
                MdiParent.Close();
                return;
            }

            _methods[MenuClauses.SelectedIndex]();
        }
    }
}
