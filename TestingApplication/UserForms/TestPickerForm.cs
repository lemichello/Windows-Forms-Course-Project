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
    public partial class TestPickerForm : Form
    {
        private const string TestsPath = "../../../ClassLibrary/XML/tests.xml";

        public string TestName { get; private set; }

        public TestPickerForm()
        {
            InitializeComponent();

            var xDoc = XDocument.Load(TestsPath);

            if (xDoc.Root.Elements("Category").Any(i => i.Element("Tests").HasElements))
            {
                foreach (var i in xDoc.Root.Elements("Category"))
                {
                    foreach (var j in i.Elements("Tests").Elements())
                    {
                        TestsBox.Items.Add($"{j.Element("Name").Value}");
                    }
                }
            }
            else
            {
                MainForm.ThrowException("There\'s no available tests. Check out later.");
                DialogResult = DialogResult.Cancel;

                Close();
            }
        }

        private void TestsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TestsBox.SelectedIndex != -1)
                ConfirmButton.Visible = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            TestName = (string)TestsBox.Items[TestsBox.SelectedIndex];

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
