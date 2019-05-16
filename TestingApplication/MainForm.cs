using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestingApplication.AdminForms;
using TestingApplication.Classes;
using TestingApplication.UserForms;

namespace TestingApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RunApplication()
        {
            var testingSystem = TestingSystem.GetInstance();

            testingSystem.MainParent = this;

            testingSystem.Run();
        }

        public static void ThrowException(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void Login(out string login, out string password)
        {
            var form = new LoginForm();
            
            form.ShowDialog();

            if(form.DialogResult != DialogResult.OK)
                Close();

            login = form.Login;
            password = form.Password;
        }

        public void RegisterAdmin()
        {
            var form = new RegisterAdminForm();

            form.ShowDialog();
        }

        public XElement RegisterUser(XElement nonRegisteredUser)
        {
            var form = new RegisterUserForm();

            form.ShowDialog();

            if (form.DialogResult != DialogResult.OK)
            {
                Close();

                return null;
            }

            var res = User.Register(nonRegisteredUser, new[]
            {
                form.Password,
                form.UserName,
                form.Surname,
                form.MiddleName,
                form.Address
            });

            return res;
        }

        public void PrintAdminMenu()
        {
            var form = new AdminMenuForm {MdiParent = this, Dock = DockStyle.Fill};

            form.Show();
        }

        public void PrintUserMenu(XElement user)
        {
            var form = new UserMenuForm(user) {MdiParent = this, Dock = DockStyle.Fill};

            form.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            RunApplication();
        }
    }
}
