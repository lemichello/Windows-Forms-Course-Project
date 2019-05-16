using System;
using System.Windows.Forms;
using TestingApplication.Classes;

namespace TestingApplication.AdminForms
{
    public partial class TestingResultsForm : Form
    {
        public IStrategy Strategy { get; set; }
        public string TestingResults { get; private set; }

        public TestingResultsForm()
        {
            InitializeComponent();

            TestingResults = "";
        }

        public void AddCategoryToList(string category)
        {
            CategoriesList.Items.Add(category);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryNameBox.Text))
            {
                MainForm.ThrowException("Incorrect format of the searching category name");

                return;
            }

            TestingResults = "";
            TestingResultsList.Items.Clear();

            Strategy.AddTestingResults(CategoryNameBox.Text, TestingResultsList);

            foreach(string i in TestingResultsList.Items)
                TestingResults += i;
        }

        private void ExitFormButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void TestingResultsForm_Shown(object sender, EventArgs e)
        {
            CriterionLabel.Text = Strategy.Criterion;
            CriterionDescriptionLabel.Text = Strategy.CriterionDescription;
        }

        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CategoriesList.SelectedIndex != -1)
                CategoryNameBox.Text = CategoriesList.Items[CategoriesList.SelectedIndex].ToString();
        }
    }
}