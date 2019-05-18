using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestingApplication.AdminForms;

namespace TestingApplication.Classes
{
    public interface IStrategy
    {
        string Criterion { get; }
        string CriterionDescription { get; }
        void AddTestingResults(string searchingCriterion, ListBox listBox);
    }

    public sealed class CategoryStrategy : IStrategy
    {
        private string Path { get; }
        public string Criterion { get; }
        public string CriterionDescription { get; }

        public CategoryStrategy(string path)
        {
            Path = path;

            Criterion = "Categories";
            CriterionDescription = "Name of the category, resulting tests of which you want to view";
        }

        public void AddTestingResults(string searchingCriterion, ListBox listBox)
        {
            var xDoc = XDocument.Load(Path);

            foreach (var i in xDoc.Root.Elements("User"))
            {
                var tests = i.Element("Tests")?.Elements();

                if (tests == null)
                    continue;

                foreach (var j in tests)
                {
                    if (j.Element("Category")?.Value == searchingCriterion)
                    {
                        foreach (var n in AdminMenuForm.CalculateUserTest(i, j))
                            listBox.Items.Add(n);
                    }
                }
            }
        }
    }

    public sealed class TestStrategy : IStrategy
    {
        private string Path { get; }
        public string Criterion { get; }
        public string CriterionDescription { get; }

        public TestStrategy(string path)
        {
            Path = path;
            Criterion = "Tests";
            CriterionDescription = "Name of the test, " +
                                   "results of which you want to view";
        }

        public void AddTestingResults(string searchingCriterion, ListBox listBox)
        {
            var xDoc = XDocument.Load(Path);

            foreach (var i in xDoc.Root.Elements("User"))
            {
                var tests = i.Element("Tests")?.Elements();

                if (tests == null)
                    continue;

                foreach (var j in tests)
                {
                    if (j.Element("Subject").Value == searchingCriterion)
                    {
                        foreach (var n in AdminMenuForm.CalculateUserTest(i, j))
                            listBox.Items.Add(n);
                    }
                }
            }
        }

        public sealed class UserStrategy : IStrategy
        {
            private string Path { get; }
            public string Criterion { get; }
            public string CriterionDescription { get; }

            public UserStrategy(string path)
            {
                Path = path;
                Criterion = "Users";
                CriterionDescription = "Enter name and surname of the user, " +
                                       "results of whom you want to find";
            }

            public void AddTestingResults(string searchingCriterion, ListBox listBox)
            {
                var xDoc = XDocument.Load(Path);

                var nameAndSurname = searchingCriterion.Split(new[] {' '},
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var i in xDoc.Root.Elements("User"))
                {
                    var tests = i.Element("Tests")?.Elements();

                    if (tests == null)
                        continue;

                    foreach (var j in tests)
                    {
                        if (i.Element("Name").Value == nameAndSurname[0] &&
                            i.Element("Surname").Value == nameAndSurname[1])
                        {
                            foreach (var n in AdminMenuForm.CalculateUserTest(i, j))
                                listBox.Items.Add(n);
                        }
                    }
                }
            }
        }
    }
}
