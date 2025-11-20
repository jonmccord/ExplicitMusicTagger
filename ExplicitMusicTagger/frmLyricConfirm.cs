using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplicitTagger
{
    public partial class frmLyricConfirm : Form
    {
        public string artist { get; set; }
        public string title { get; set; }
        public string lyrics { get; set; }
        public string badword { get; set; }
        public string context { get; set; }

        public frmLyricConfirm()
        {
            InitializeComponent();
        }

        private void frmLyricConfirm_Shown(object sender, EventArgs e)
        {
            lblArtist.Text = artist;
            lblSong.Text = title;
            lblContext.Text = context;
            lblBadWord.Text = badword;
            rtbLyrics.Text = lyrics;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }
    }
}
