using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApplication.UserForms
{
    public partial class TestForm : Form
    {
        public int AnswerResult { get; private set; }
        private Dictionary<string, Dictionary<string, bool>> _questions;
        private int _index;

        public TestForm(Dictionary<string, Dictionary<string, bool>> questions, int index)
        {
            InitializeComponent();

            _questions = questions;
            _index = index;

            QuestionDescription.Text = _questions.ElementAt(_index).Key;

            var answers = _questions.ElementAt(_index).Value;

            // Setting text of answer-variants.
            Answer1Text.Text = answers.ElementAt(0).Key;
            Answer2Text.Text = answers.ElementAt(1).Key;
            Answer3Text.Text = answers.ElementAt(2).Key;

            TestingProgress.Maximum = questions.Count;
            TestingProgress.Value = index;

            ProgressLabel.Text = $"{index} / {questions.Count}";
        }

        private void GetAnswerResult()
        {
            var answers = _questions.ElementAt(_index).Value;
            int variantOfAnswer = 0;

            if (Answer1Correct.Checked)
                variantOfAnswer = 0;
            if (Answer2Correct.Checked)
                variantOfAnswer = 1;
            if (Answer3Correct.Checked)
                variantOfAnswer = 2;

            AnswerResult = answers.ElementAt(variantOfAnswer).Value ? 1 : 2;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!Answer1Correct.Checked &&
                !Answer2Correct.Checked &&
                !Answer3Correct.Checked)
            {
                MainForm.ThrowException("You must choose your answer");

                return;
            }

            GetAnswerResult();

            ((TestsContainer) MdiParent).AcceptTestResult(AnswerResult);

            Close();
        }

        private void InterruptButton_Click(object sender, EventArgs e)
        {
            ((TestsContainer)MdiParent).AcceptTestResult(0);

            Close();
        }
    }
}
