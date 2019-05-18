using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApplication
{
    public partial class LoginForm : Form
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // User hasn't entered login or password.
            if (string.IsNullOrWhiteSpace(LoginBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Your login or password are incorrect. Try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Login = LoginBox.Text;
            Password = PasswordBox.Text;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // User hasn't entered login.
            if (string.IsNullOrWhiteSpace(LoginBox.Text))
            {
                MessageBox.Show("Your login is incorrect. Try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Login = LoginBox.Text;
            Password = "";

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
