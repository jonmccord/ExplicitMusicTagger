using CommonMark;
using System;
using System.IO;
using System.Windows.Forms;

namespace ExplicitTagger
{
    public partial class ReadMe : Form
    {
        public ReadMe()
        {
            InitializeComponent();
        }

        private void ReadMe_Load(object sender, EventArgs e)
        {
            string markdownContent = File.ReadAllText("Files/README.md");
            string htmlContent = "<style>* {font-family: Arial, Helvetica, sans-serif;}</style>";
            htmlContent += CommonMarkConverter.Convert(markdownContent);
            webBrowser1.DocumentText = htmlContent;
        }
    }
}
