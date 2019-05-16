using System;
using System.Windows.Forms;

namespace TestingApplication.AdminForms
{
    public partial class AddTestForm : Form
    {
        public string CategoryName { get; private set; }
        public string TestName { get; private set; }
        public int CountOfQuestions { get; private set; }

        public AddTestForm()
        {
            InitializeComponent();
        }

        public void AddCategoryToList(string category)
        {
            CategoriesList.Items.Add(category);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryNameBox.Text) ||
                string.IsNullOrWhiteSpace(TestNameBox.Text))
            {
                MainForm.ThrowException("Incorrect format of name of category or test");

                return;
            }

            CategoryName = CategoryNameBox.Text;
            TestName = TestNameBox.Text;
            CountOfQuestions = (int)NumberOfQuestions.Value;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryNameBox.Text = (string)CategoriesList.Items[CategoriesList.SelectedIndex];
        }
    }
}
