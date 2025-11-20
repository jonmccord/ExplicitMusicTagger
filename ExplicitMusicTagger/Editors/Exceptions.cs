using System;
using System.IO;
using System.Windows.Forms;

namespace ExplicitMusicTagger.Editors
{
    public partial class Exceptions : Form
    {
        string explicitBaseFileName = "ExplicitBaseWords.txt";
        string explicitFileName = "ExplicitWords.txt";
        string exceptionFileName = "Exceptions.txt";

        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDataAppPath = "";
        string exceptionFilePath = "";

        public Exceptions()
        {
            InitializeComponent();
        }
        
        private void Exceptions_Load(object sender, EventArgs e)
        {
            appDataAppPath = Path.Combine(appDataPath, "ExplicitMusicTagger");
            exceptionFilePath = Path.Combine(appDataAppPath, exceptionFileName);

            txtWords.Text = File.ReadAllText(exceptionFilePath);
            txtWords.SelectionStart = txtWords.Text.Length;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(exceptionFilePath, txtWords.Text);
            this.Close();
        }
    }
}
