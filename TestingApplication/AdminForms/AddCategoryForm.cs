using System;
using System.Windows.Forms;

namespace TestingApplication.AdminForms
{
    public partial class AddCategoryForm : Form
    {
        public string CategoryName { get; private set; }

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryBox.Text))
            {
                MainForm.ThrowException("Incorrect format of the category name");

                return;
            }

            CategoryName = CategoryBox.Text;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
