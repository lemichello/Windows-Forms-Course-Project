using System;
using System.Windows.Forms;
using TestingApplication.Classes;

namespace TestingApplication.AdminForms
{
    public partial class FillTestForm : Form
    {
        public string QuestionText { get; private set; }
        public QuestionVariant[] Variants { get; private set; }

        public FillTestForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyBox())
            {
                MainForm.ThrowException("Incorrect form of the question or variant");

                return;
            }

            if (!IsUniqueBoxes())
            {
                MainForm.ThrowException("All question variants must be unique");

                return;
            }

            if (!Variant1RadioButton.Checked &&
                !Variant2RadioButton.Checked &&
                !Variant3RadioButton.Checked)
            {
                MainForm.ThrowException("One of the variants must be correct");

                return;
            }

            QuestionText = QuestionTextBox.Text;

            Variants = new[]
            {
                new QuestionVariant(Variant1TextBox.Text, Variant1RadioButton.Checked),
                new QuestionVariant(Variant2TextBox.Text, Variant2RadioButton.Checked),
                new QuestionVariant(Variant3TextBox.Text, Variant3RadioButton.Checked)
            };

            DialogResult = DialogResult.OK;

            Close();
        }

        private bool IsEmptyBox()
        {
            return string.IsNullOrWhiteSpace(QuestionTextBox.Text) ||
                   string.IsNullOrWhiteSpace(Variant1TextBox.Text) ||
                   string.IsNullOrWhiteSpace(Variant2TextBox.Text) ||
                   string.IsNullOrWhiteSpace(Variant3TextBox.Text);
        }

        private bool IsUniqueBoxes()
        {
            return Variant1TextBox.Text != Variant2TextBox.Text &&
                   Variant1TextBox.Text != Variant3TextBox.Text &&
                   Variant2TextBox.Text != Variant3TextBox.Text;
        }
    }
}