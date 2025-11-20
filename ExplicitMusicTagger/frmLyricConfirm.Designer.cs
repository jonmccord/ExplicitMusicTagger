namespace ExplicitTagger
{
    partial class frmLyricConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblBadWord = new System.Windows.Forms.Label();
            this.lblContextLabel = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbLyrics.Location = new System.Drawing.Point(12, 51);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(340, 344);
            this.rtbLyrics.TabIndex = 0;
            this.rtbLyrics.Text = "";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(354, 56);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(128, 15);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Is this a bad word?";
            // 
            // lblBadWord
            // 
            this.lblBadWord.AutoSize = true;
            this.lblBadWord.Location = new System.Drawing.Point(488, 58);
            this.lblBadWord.Name = "lblBadWord";
            this.lblBadWord.Size = new System.Drawing.Size(62, 13);
            this.lblBadWord.TabIndex = 2;
            this.lblBadWord.Text = "lblBadWord";
            // 
            // lblContextLabel
            // 
            this.lblContextLabel.AutoSize = true;
            this.lblContextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContextLabel.Location = new System.Drawing.Point(355, 125);
            this.lblContextLabel.Name = "lblContextLabel";
            this.lblContextLabel.Size = new System.Drawing.Size(55, 15);
            this.lblContextLabel.TabIndex = 3;
            this.lblContextLabel.Text = "Context";
            // 
            // lblContext
            // 
            this.lblContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContext.Location = new System.Drawing.Point(355, 153);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(273, 40);
            this.lblContext.TabIndex = 4;
            this.lblContext.Text = "lblContext";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(358, 77);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(439, 77);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 6;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(13, 13);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(55, 15);
            this.lblArtist.TabIndex = 7;
            this.lblArtist.Text = "lblArtist";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.Location = new System.Drawing.Point(13, 33);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(49, 15);
            this.lblSong.TabIndex = 8;
            this.lblSong.Text = "lblSong";
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(520, 77);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "SKIP";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // frmLyricConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 406);
            this.ControlBox = false;
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblContextLabel);
            this.Controls.Add(this.lblBadWord);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rtbLyrics);
            this.MinimumSize = new System.Drawing.Size(660, 445);
            this.Name = "frmLyricConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lyric Confirmation";
            this.Shown += new System.EventHandler(this.frmLyricConfirm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblBadWord;
        private System.Windows.Forms.Label lblContextLabel;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Button btnSkip;
    }
}