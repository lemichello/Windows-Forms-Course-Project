using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestingApplication.UserForms
{
    public partial class RegisterUserForm : Form
    {
        public string UserName => NameBox.Text;
        public string Surname => SurnameBox.Text;
        public string MiddleName => MiddleNameBox.Text;
        public string Address => HomeAddressBox.Text;
        public string Password => PasswordBox.Text;

        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!CheckForCorrectivity(NameBox.Text, false) ||
                !CheckForCorrectivity(SurnameBox.Text, false) ||
                !CheckForCorrectivity(MiddleNameBox.Text, false) ||
                !CheckForCorrectivity(HomeAddressBox.Text, true) ||
                string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("One of your registration data has incorrect format",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private bool CheckForCorrectivity(string str, bool isHomeAddress)
        {
            if (isHomeAddress)
                return Regex.IsMatch(str, @"^[\w\s]+$");
            return Regex.IsMatch(str, @"^\w+$");
        }
    }
}
