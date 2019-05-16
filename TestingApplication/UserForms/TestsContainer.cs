using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using TestingApplication.Classes;

namespace TestingApplication.UserForms
{
    public partial class TestsContainer : Form
    {
        private const string TestsPath = "../../../ClassLibrary/XML/tests.xml";
        private int _correctAnswers;
        private int _currentQuestion;
        private int _id;
        private string _testName, _categoryName;
        private XElement _test, _user;
        private Dictionary<string, Dictionary<string, bool>> _questions;
        private static readonly Random Rand = new Random();
        
        public UserMenuForm MenuParent { get; set; }

        // Constructor for normal passing a test.
        public TestsContainer(string testName, XElement user)
        {
            InitializeComponent();

            var xDoc = XDocument.Load(TestsPath);

            _test = xDoc.Root?.Elements("Category").Elements("Tests").Elements()
                .First(i => i.Element("Name").Value == testName);

            _testName = testName;
            _categoryName = _test.Parent.Parent.Element("Name").Value;
            _user = user;

            _questions = User.GetTest(_testName);
            _currentQuestion = 0;
            _correctAnswers = 0;
            _id = Rand.Next();
        }

        // Constructor for passing an unfinished test.
        public TestsContainer(XElement unfinishedTest, XElement user)
        {
            InitializeComponent();

            _testName = unfinishedTest.Element("Subject").Value;
            _categoryName = unfinishedTest.Element("Category").Value;
            _test = unfinishedTest;

            _correctAnswers = int.Parse(unfinishedTest.Attribute("correctAnswers").Value);
            _currentQuestion = int.Parse(unfinishedTest.Attribute("position").Value);
            _id = int.Parse(unfinishedTest.Attribute("id").Value);

            _questions = User.GetTest(_testName);
            _user = user;
        }

        public void AcceptTestResult(int result)
        {
            if(result == 0)
            {
                User.AddTestResults(_user, _correctAnswers, _currentQuestion, 
                    _categoryName, _testName, _id, false);
                MenuParent.FinishedPassingTest();

                Close();
                return;
            }

            if (result == 1)
                _correctAnswers++;

            _currentQuestion++;
            RunTests();
        }

        private void RunTests()
        {
            // User is still passing the test.
            if (_currentQuestion < _questions.Count)
            {
                var form = new TestForm(_questions, _currentQuestion)
                {
                    MdiParent = this,
                    Dock      = DockStyle.Fill
                };

                form.Show();
            }
            // User finished the test.
            else
            {
                var percentage   = Math.Round(100 / ((double) _questions.Count / _correctAnswers), 1);
                var mark         = (int) Math.Round((double) _correctAnswers * 12 / _questions.Count);

                MessageBox.Show("Result of testing : \n" +
                                $"Number of correct answers : {_correctAnswers}\n" +
                                $"Percentage of correct answers : {percentage}%\n" +
                                $"Your mark : {mark}");

                User.AddTestResults(_user, mark, _questions.Count,
                    _categoryName, _testName, _id, true);
                MenuParent.FinishedPassingTest();

                Close();
            }
        }

        private void TestsContainer_Shown(object sender, EventArgs e)
        {
            RunTests();
        }
    }
}
