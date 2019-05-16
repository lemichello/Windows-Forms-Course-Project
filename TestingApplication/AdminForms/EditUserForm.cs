using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestingApplication.AdminForms
{
    public partial class EditUserForm : Form
    {
        private RadioButton _currentButton;
        public string UserName { get; private set; }
        public string Surname { get; private set; }
        public string Value { get; private set; }
        public string EditingTarget { get; private set; }

        public EditUserForm()
        {
            InitializeComponent();

            _currentButton = NameButton;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;

            if (!button.Checked)
                return;

            _currentButton = button;
        }

        private bool CheckForCorrectivity(string str, bool isHomeAddress)
        {
            if (isHomeAddress)
                return Regex.IsMatch(str, @"^[\w\s]+$");
            return Regex.IsMatch(str, @"^\w+$");
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!CheckForCorrectivity(NameBox.Text, false) ||
                !CheckForCorrectivity(SurnameBox.Text, false)
            )
            {
                MainForm.ThrowException("Incorrect format of name or surname");

                return;
            }

            // User chose to edit name or surname.
            if ((_currentButton == NameButton ||
                 _currentButton == SurnameButton ||
                 _currentButton == MiddleNameButton) &&
                !CheckForCorrectivity(NewValueBox.Text, false))
            {
                MainForm.ThrowException("Incorrect format of the new value");
            }
            else if (_currentButton == AddressButton &&
                     !CheckForCorrectivity(NewValueBox.Text, true))
            {
                MainForm.ThrowException("Incorrect format of the new value");
            }
            else
            {
                UserName      = NameBox.Text;
                Surname       = SurnameBox.Text;
                Value         = NewValueBox.Text;
                EditingTarget = _currentButton.Text;

                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
