using System;
using System.Windows.Forms;

namespace TestingApplication.AdminForms
{
    public partial class ChangeLoginPasswordForm : Form
    {
        private bool _isLogin;
        public string Data { get; private set; }

        public ChangeLoginPasswordForm()
        {
            InitializeComponent();
        }

        public ChangeLoginPasswordForm(bool isLogin)
        {
            InitializeComponent();

            _isLogin = isLogin;

            if (!isLogin)
            {
                LoginPasswordLabel.Text = "Your new password";
                this.Text = "Changing password";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DataBox.Text))
            {
                MainForm.ThrowException(_isLogin ? "Your login has incorrect format" : 
                    "Your password has incorrect format");

                return;
            }

            Data = DataBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
