using System;
using System.Windows.Forms;
using TestingApplication.Classes;

namespace TestingApplication.AdminForms
{
    public partial class RegisterAdminForm : Form
    {
        public RegisterAdminForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Admin.Register(PasswordBox.Text);
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
