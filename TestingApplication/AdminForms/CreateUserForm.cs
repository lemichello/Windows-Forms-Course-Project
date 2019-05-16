using System;
using System.Windows.Forms;

namespace TestingApplication.AdminForms
{
    public partial class CreateUserForm : Form
    {
        public string Login { get; private set; }

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(LoginBox.Text))
                MainForm.ThrowException("You entered incorrect login. Try again");
            else
            {
                Login = LoginBox.Text;
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
