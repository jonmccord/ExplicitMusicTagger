using System;
using System.IO;
using System.Windows.Forms;

namespace ExplicitTagger
{
    public partial class BaseExplicitWords : Form
    {
        string explicitBaseFileName = "ExplicitBaseWords.txt";
        string explicitFileName = "ExplicitWords.txt";
        string exceptionFileName = "Exceptions.txt";

        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDataAppPath = "";
        string explicitBaseFilePath = "";

        public BaseExplicitWords()
        {
            InitializeComponent();
        }

        private void BaseExplicitWords_Load(object sender, EventArgs e)
        {
            appDataAppPath = Path.Combine(appDataPath, "ExplicitMusicTagger");
            explicitBaseFilePath = Path.Combine(appDataAppPath, explicitBaseFileName);

            txtWords.Text = File.ReadAllText(explicitBaseFilePath);
            txtWords.SelectionStart = txtWords.Text.Length;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(explicitBaseFilePath, txtWords.Text);
            this.Close();
        }
    }
}
