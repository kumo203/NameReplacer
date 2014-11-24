using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameReplacer
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            InitializeComponent();
        }

        public void SetParams(string filePath, int line, string findWhat, string replaceWith, string oldLine, string newLine, int index)
        {
            fileNameLinkLabel.Text = filePath;
            lineTextBox.Text = line.ToString();
            findWhatTextBox.Text = findWhat;
            replaceWithTextBox.Text = replaceWith;
            oldLineTextBox.Text = oldLine;
            newLineTextBox.Text = newLine;

            indexTextBox.Text = (index+1).ToString();

            oldLineTextBox.Select(index, findWhat.Length);
            newLineTextBox.Select(index, replaceWith.Length);

            oldLineTextBox.SelectionColor = Color.Red;
            newLineTextBox.SelectionColor = Color.Red;

            fileNameLinkLabel.Links.Clear();
            fileNameLinkLabel.Links.Add(0, fileNameLinkLabel.Text.Length, filePath);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
