namespace ExplicitTagger
{
    partial class frmMain
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
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.ckProcessExplict = new System.Windows.Forms.CheckBox();
            this.ckAddNoLyric = new System.Windows.Forms.CheckBox();
            this.labelExplict = new System.Windows.Forms.Label();
            this.lblExplicitProcessed = new System.Windows.Forms.Label();
            this.labelNoLyrics = new System.Windows.Forms.Label();
            this.lblNoLyrics = new System.Windows.Forms.Label();
            this.lbProcessFiles = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblTotalFilesToProcess = new System.Windows.Forms.Label();
            this.lblClean = new System.Windows.Forms.Label();
            this.labelClean = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProcessedFilesLabel = new System.Windows.Forms.Label();
            this.pbFilesProcessed = new System.Windows.Forms.ProgressBar();
            this.lblFilesToProcessLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseExplicitWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explicitWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.AllowDrop = true;
            this.lbSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(3, 23);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.ScrollAlwaysVisible = true;
            this.lbSongs.Size = new System.Drawing.Size(374, 290);
            this.lbSongs.TabIndex = 0;
            this.lbSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbSongs_DragDrop);
            this.lbSongs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbSongs_DragEnter);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 376);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ckProcessExplict
            // 
            this.ckProcessExplict.AutoSize = true;
            this.ckProcessExplict.Location = new System.Drawing.Point(112, 380);
            this.ckProcessExplict.Name = "ckProcessExplict";
            this.ckProcessExplict.Size = new System.Drawing.Size(163, 17);
            this.ckProcessExplict.TabIndex = 2;
            this.ckProcessExplict.Text = "Process Existing Explicit Files";
            this.ckProcessExplict.UseVisualStyleBackColor = true;
            // 
            // ckAddNoLyric
            // 
            this.ckAddNoLyric.AutoSize = true;
            this.ckAddNoLyric.Location = new System.Drawing.Point(112, 403);
            this.ckAddNoLyric.Name = "ckAddNoLyric";
            this.ckAddNoLyric.Size = new System.Drawing.Size(117, 17);
            this.ckAddNoLyric.TabIndex = 3;
            this.ckAddNoLyric.Text = "Add [NoLyrics] Tag";
            this.ckAddNoLyric.UseVisualStyleBackColor = true;
            // 
            // labelExplict
            // 
            this.labelExplict.AutoSize = true;
            this.labelExplict.Location = new System.Drawing.Point(324, 427);
            this.labelExplict.Name = "labelExplict";
            this.labelExplict.Size = new System.Drawing.Size(71, 13);
            this.labelExplict.TabIndex = 4;
            this.labelExplict.Text = "Explict Songs";
            // 
            // lblExplicitProcessed
            // 
            this.lblExplicitProcessed.AutoSize = true;
            this.lblExplicitProcessed.Location = new System.Drawing.Point(439, 427);
            this.lblExplicitProcessed.Name = "lblExplicitProcessed";
            this.lblExplicitProcessed.Size = new System.Drawing.Size(13, 13);
            this.lblExplicitProcessed.TabIndex = 5;
            this.lblExplicitProcessed.Text = "0";
            // 
            // labelNoLyrics
            // 
            this.labelNoLyrics.AutoSize = true;
            this.labelNoLyrics.Location = new System.Drawing.Point(324, 450);
            this.labelNoLyrics.Name = "labelNoLyrics";
            this.labelNoLyrics.Size = new System.Drawing.Size(48, 13);
            this.labelNoLyrics.TabIndex = 6;
            this.labelNoLyrics.Text = "NoLyrics";
            // 
            // lblNoLyrics
            // 
            this.lblNoLyrics.AutoSize = true;
            this.lblNoLyrics.Location = new System.Drawing.Point(439, 450);
            this.lblNoLyrics.Name = "lblNoLyrics";
            this.lblNoLyrics.Size = new System.Drawing.Size(13, 13);
            this.lblNoLyrics.TabIndex = 7;
            this.lblNoLyrics.Text = "0";
            // 
            // lbProcessFiles
            // 
            this.lbProcessFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProcessFiles.BackColor = System.Drawing.SystemColors.Info;
            this.lbProcessFiles.FormattingEnabled = true;
            this.lbProcessFiles.HorizontalScrollbar = true;
            this.lbProcessFiles.Location = new System.Drawing.Point(383, 23);
            this.lbProcessFiles.Name = "lbProcessFiles";
            this.lbProcessFiles.Size = new System.Drawing.Size(374, 290);
            this.lbProcessFiles.TabIndex = 10;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(324, 381);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 13);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total Files";
            // 
            // lblTotalFilesToProcess
            // 
            this.lblTotalFilesToProcess.AutoSize = true;
            this.lblTotalFilesToProcess.Location = new System.Drawing.Point(439, 381);
            this.lblTotalFilesToProcess.Name = "lblTotalFilesToProcess";
            this.lblTotalFilesToProcess.Size = new System.Drawing.Size(13, 13);
            this.lblTotalFilesToProcess.TabIndex = 14;
            this.lblTotalFilesToProcess.Text = "0";
            // 
            // lblClean
            // 
            this.lblClean.AutoSize = true;
            this.lblClean.Location = new System.Drawing.Point(439, 404);
            this.lblClean.Name = "lblClean";
            this.lblClean.Size = new System.Drawing.Size(13, 13);
            this.lblClean.TabIndex = 16;
            this.lblClean.Text = "0";
            // 
            // labelClean
            // 
            this.labelClean.AutoSize = true;
            this.labelClean.Location = new System.Drawing.Point(324, 404);
            this.labelClean.Name = "labelClean";
            this.labelClean.Size = new System.Drawing.Size(90, 13);
            this.labelClean.TabIndex = 15;
            this.labelClean.Text = "Considered Clean";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblProcessedFilesLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSongs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbProcessFiles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbFilesProcessed, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFilesToProcessLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 343);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblProcessedFilesLabel
            // 
            this.lblProcessedFilesLabel.Location = new System.Drawing.Point(383, 0);
            this.lblProcessedFilesLabel.Name = "lblProcessedFilesLabel";
            this.lblProcessedFilesLabel.Size = new System.Drawing.Size(97, 20);
            this.lblProcessedFilesLabel.TabIndex = 21;
            this.lblProcessedFilesLabel.Text = "Completed File Info";
            this.lblProcessedFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFilesProcessed
            // 
            this.pbFilesProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.pbFilesProcessed, 2);
            this.pbFilesProcessed.Location = new System.Drawing.Point(3, 319);
            this.pbFilesProcessed.Name = "pbFilesProcessed";
            this.pbFilesProcessed.Size = new System.Drawing.Size(754, 21);
            this.pbFilesProcessed.TabIndex = 12;
            // 
            // lblFilesToProcessLabel
            // 
            this.lblFilesToProcessLabel.Location = new System.Drawing.Point(3, 0);
            this.lblFilesToProcessLabel.Name = "lblFilesToProcessLabel";
            this.lblFilesToProcessLabel.Size = new System.Drawing.Size(142, 20);
            this.lblFilesToProcessLabel.TabIndex = 20;
            this.lblFilesToProcessLabel.Text = "Files to Process (drag here)";
            this.lblFilesToProcessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseExplicitWordListToolStripMenuItem,
            this.explicitWordsToolStripMenuItem,
            this.exceptionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // baseExplicitWordListToolStripMenuItem
            // 
            this.baseExplicitWordListToolStripMenuItem.Name = "baseExplicitWordListToolStripMenuItem";
            this.baseExplicitWordListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.baseExplicitWordListToolStripMenuItem.Text = "Base Explicit Words";
            this.baseExplicitWordListToolStripMenuItem.Click += new System.EventHandler(this.baseExplicitWordListToolStripMenuItem_Click);
            // 
            // explicitWordsToolStripMenuItem
            // 
            this.explicitWordsToolStripMenuItem.Name = "explicitWordsToolStripMenuItem";
            this.explicitWordsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.explicitWordsToolStripMenuItem.Text = "Explicit Words";
            this.explicitWordsToolStripMenuItem.Click += new System.EventHandler(this.explicitWordsToolStripMenuItem_Click);
            // 
            // exceptionsToolStripMenuItem
            // 
            this.exceptionsToolStripMenuItem.Name = "exceptionsToolStripMenuItem";
            this.exceptionsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exceptionsToolStripMenuItem.Text = "Exceptions";
            this.exceptionsToolStripMenuItem.Click += new System.EventHandler(this.exceptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADMEToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rEADMEToolStripMenuItem
            // 
            this.rEADMEToolStripMenuItem.Name = "rEADMEToolStripMenuItem";
            this.rEADMEToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.rEADMEToolStripMenuItem.Text = "READ ME";
            this.rEADMEToolStripMenuItem.Click += new System.EventHandler(this.rEADMEToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblClean);
            this.Controls.Add(this.labelClean);
            this.Controls.Add(this.lblTotalFilesToProcess);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.lblNoLyrics);
            this.Controls.Add(this.labelNoLyrics);
            this.Controls.Add(this.lblExplicitProcessed);
            this.Controls.Add(this.labelExplict);
            this.Controls.Add(this.ckAddNoLyric);
            this.Controls.Add(this.ckProcessExplict);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 515);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Explicit Music Tagger";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.CheckBox ckProcessExplict;
        private System.Windows.Forms.CheckBox ckAddNoLyric;
        private System.Windows.Forms.Label labelExplict;
        private System.Windows.Forms.Label lblExplicitProcessed;
        private System.Windows.Forms.Label labelNoLyrics;
        private System.Windows.Forms.Label lblNoLyrics;
        private System.Windows.Forms.ListBox lbProcessFiles;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblTotalFilesToProcess;
        private System.Windows.Forms.Label lblClean;
        private System.Windows.Forms.Label labelClean;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProcessedFilesLabel;
        private System.Windows.Forms.ProgressBar pbFilesProcessed;
        private System.Windows.Forms.Label lblFilesToProcessLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseExplicitWordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEADMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explicitWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceptionsToolStripMenuItem;
    }
}

