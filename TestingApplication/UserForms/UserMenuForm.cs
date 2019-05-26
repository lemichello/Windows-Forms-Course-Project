using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestingApplication.UserForms
{
    public partial class UserMenuForm : Form
    {
        private readonly XElement _user;
        private          XElement _unfinishedTest;

        private readonly List<string> _operations = new List<string>
        {
            "Pass a test",
            "Print previous testing results",
            "Exit"
        };

        private readonly List<Action> _methods;

        public UserMenuForm(XElement user)
        {
            InitializeComponent();

            _user = user;
            _methods = new List<Action>
            {
                PassTest,
                PrintPreviousResults,
                Exit
            };

            CheckForUnfinishedTest();
        }

        private void CheckForUnfinishedTest()
        {
            try
            {
                // If there's a unfinished test, adding a specific operation to Operations.
                _unfinishedTest = _user.Element("Tests")
                    ?.Elements("Test")
                    .First(i => i.Attribute("finished")?.Value == "false");

                // If Operations already has option to "continue an unfinished test".
                if (!_operations.Exists(i => i == "Continue an unfinished test"))
                {
                    _operations.Insert(2, "Continue an unfinished test");
                    // Adding null to pass a validation, when entering a number of operation.
                    _methods.Insert(2, PassUnfinishedTest);
                }
            }
            // Exception throws, when there's no non-ended tests.
            catch (Exception)
            {
                _unfinishedTest = null;
            }

            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            MenuClauses.DataSource = null;
            MenuClauses.DataSource = _operations;
        }

        /// <summary>
        /// When user finished passing an unfinished test.
        /// </summary>
        public void FinishedPassingTest()
        {
            CheckForUnfinishedTest();

            MenuClauses.ClearSelected();
        }

        /// <summary>
        /// Gives to user a test.
        /// </summary>
        private void PassTest()
        {
            var form = new TestPickerForm();

            if (form.DialogResult == DialogResult.Cancel || form.ShowDialog() != DialogResult.OK)
                return;

            var container = new TestsContainer(form.TestName, _user) {MenuParent = this};

            container.ShowDialog();
        }

        private void PassUnfinishedTest()
        {
            var container = new TestsContainer(_unfinishedTest, _user) {MenuParent = this};

            container.Show();

            _operations.RemoveAt(2);
            _methods.RemoveAt(2);
        }

        /// <summary>
        /// Prints previous testing result of user.
        /// </summary>
        private void PrintPreviousResults()
        {
            var form = new PreviousResultsForm(_user);

            form.ShowDialog();
        }

        private void MenuClauses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfirmButton.Visible = true;
        }

        private void Exit()
        {
            MdiParent.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            _methods[MenuClauses.SelectedIndex]();
        }
    }
}