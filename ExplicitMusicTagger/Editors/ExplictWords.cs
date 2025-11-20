using System;
using System.IO;
using System.Windows.Forms;

namespace ExplicitMusicTagger.Editors
{
    public partial class ExplictWords : Form
    {
        string explicitBaseFileName = "ExplicitBaseWords.txt";
        string explicitFileName = "ExplicitWords.txt";
        string exceptionFileName = "Exceptions.txt";

        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDataAppPath = "";
        string explicitFilePath = "";

        public ExplictWords()
        {
            InitializeComponent();
        }
        private void ExplictWords_Load(object sender, EventArgs e)
        {
            appDataAppPath = Path.Combine(appDataPath, "ExplicitMusicTagger");
            explicitFilePath = Path.Combine(appDataAppPath, explicitFileName);

            txtWords.Text = File.ReadAllText(explicitFilePath);
            txtWords.SelectionStart = txtWords.Text.Length;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(explicitFilePath, txtWords.Text);
            this.Close();
        }

        
    }
}
