using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestingApplication.UserForms
{
    public partial class PreviousResultsForm : Form
    {
        public PreviousResultsForm(XElement user)
        {
            InitializeComponent();

            foreach (var i in user.Element("Tests").Elements("Test"))
            {
                ResultsBox.Items.Add(i.Attribute("finished")?.Value == "true"
                    ? "Finished test"
                    : "Unfinished test" + $" in category \"{i.Element("Category")?.Value}\"");

                ResultsBox.Items.Add($"Subject : {i.Element("Subject")?.Value}");
                ResultsBox.Items.Add($"Mark : {i.Element("Mark")?.Value}");
                ResultsBox.Items.Add("");
            }
        }

        private void ExitFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
