using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestingApplication.AdminForms
{
    public partial class RemoveUserForm : Form
    {
        public string UserName { get; private set; }
        public string Surname { get; private set; }

        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(NameBox.Text, @"^\w+$") ||
                !Regex.IsMatch(SurnameBox.Text, @"^\w+$"))
            {
                MainForm.ThrowException("Name or surname has incorrect format. Try again.");
            }
            else
            {
                UserName = NameBox.Text;
                Surname = SurnameBox.Text;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
