using ExplicitMusicTagger.Editors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TagLib;
using TagLib.Mpeg4;
using File = System.IO.File;

namespace ExplicitTagger
{
    public partial class frmMain : Form
    {
        //Don't expand this for your health
        string[] badwords = new string[]
        {
            "fuck", "shit", "shits", "damn", "dammit", "dam", "bastard", "bitch", "whore", "sex", "cum", "hell",
            "ass", "cunt", "cock", "dick", "prostitute", "goddamn", "asshole", "fag", "gay", "homo", "blow", 
            "nig", "neg", "rape", "queer", "tran", "pus", "f*ck", "sh*t", "*", "$"
        };

        string[] okaywords = new string[]
        {
            "night", "tonight", "blowing", "midnight", "goodnight", "nights", "strange", "glasses", "transform", "cocked", "blow",
            "scrapes", "blown", "nightly", "glass", "strangers", "blows", "strangest", "passion", "pushed", "transistor", "passed",
            "pass", "grass", "hello", "knight", "push", "assume", "reassured", "scrape", "cockroach", "pushin", "nightmare",
            "stranger", "pushing", "hoppus", "surpass", "passionately", "molasses", "passin", "mass", "tassels", "scraped", "transmit",
            "succumbing", "eggshells", "grassroots", "circumvent", "homo-sapiens", "shells", "transmission", "translation", "untranslatable", "massive", "nightmares",
            "password", "circumstance", "nightfall", "passes", "pushes", "carcass", "blowin", "compassion", "draped", "knights", "strangle",
            "trance", "compass", "class", "strangely", "passengers", "middle-class", "embarrassed", "assault", "blowup", "transmitting", "assistance",
            "accumulate", "nightsky", "transmissions", "passions", "passing", "transcriptions", "shell", "scum", "passer-by", "stranded", "passers-by",
            "assasination", "hourglass", "seashell", "alnight", "assured", "nighttime", "overblown", "passages", "passionate", "assurance", "assumed",
            "assembely", "transformation", "assure", "reassembled", "night-time", "assures", "strands", "sunglasses", "trapezes", "grapevine", "night-night",
            "classic", "assimilation", "transfixed", "passage", "reassure", "self-assigned", "document", "passenger", "transcend", "passionless", "assuring",
            "strangled", "cocktail", "passive", "massacre", "overnight", "assaulting", "classroom", "cockleshell", "cockleshell", "passports", "self-assured",
            "bass", "brass", "nightswimming", "shellback", "classes", "masses", "nightcrawler", "strangulation", "strangeness", "circumstances", "eyeglass",
            "transport", "glassy", "transmitted", "transitory", "night-sea", "transcripts", "transparent", "entrance", "amassing", "assembled", "translated",
            "pussycat", "assumption", "strand", "unassured", "enigma", "cassettes", "tranquilized", "assembly", "nightward", "assemble", "transformed",
            "pushin’", "the grapevine", "assaulted", "transparency", "association", "assets", "grapes", "stranglehold", "assassin", "assailant", "assisted",
            "denigrate", "accumulates", "assembling", "steniga", "transylvania", "all-encompassing", "shotglass", "hassles", "all-night", "transcendental", "reassures",
            "overpass", "assess", "unsurpassed", "compasses", "succumb", "assimilate", "accumulations", "encompass", "assassinate", "push-ups", "nigh",
            "assorted", "embrassé", "seashells", "circumference", "poppycock", "transition", "shenanigans", "lower-class", "underpasses", "stranding", "passivity",
            "embarrassing", "hassle", "benign", "lassoed", "nightingale", "assortment", "embarrass", "transfusion", "whistleblower", "nightclub", "transmittal",
            "tasse", "wenig", "transmutate", "jurassic", "blower", "harrass", "michelle", "casserole", "grapefruit", "gassy", "sassy",
            "classy", "chassis", "transient", "glasshouse", "talcum", "drapes", "drape", "passive-aggressive", "enigmatic", "assassinations", "translucent",
            "scum-littered", "assumptions", "skyscraper", "transforming", "circumventing", "circumcisions", "cockles", "cumpleaños", "one-night", "octopus", "looking-glass",
            "rainig", "harassment", "interpass", "this glass house", "scummy", "nightness", "opus", "nightingales", "nightdreaming", "the midnight train", "assuming"
        };

        List<string> baseBadList = new List<string>();        
        List<string> knownBadList = new List<string>();
        List<string> okayList = new List<string>();

        string explicitBaseFileName = "ExplicitBaseWords.txt";
        string explicitFileName = "ExplicitWords.txt";
        string exceptionFileName = "Exceptions.txt";        

        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDataAppPath = "";
        string explicitBaseFilePath = "";
        string explicitFilePath = "";
        string exceptionFilePath = "";

        public frmMain()
        {
            InitializeComponent();

            //On Load
            appDataAppPath = Path.Combine(appDataPath, "ExplicitMusicTagger");

            explicitBaseFilePath = Path.Combine(appDataAppPath, explicitBaseFileName);
            explicitFilePath = Path.Combine(appDataAppPath, explicitFileName);
            exceptionFilePath = Path.Combine(appDataAppPath, exceptionFileName);

            //Fill local list for exception words.
            if (File.Exists(exceptionFilePath))
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(exceptionFilePath);
                while ((line = file.ReadLine()) != null)
                {
                    okayList.Add(line.Trim().ToLower());
                }

                file.Close();
            }
            else
            {
                //Doesn't exist, create a new one.
                if (!Directory.Exists(appDataAppPath))
                {
                    Directory.CreateDirectory(appDataAppPath);
                }
                File.Create(exceptionFilePath).Close();

                //Fill this file with base bad words.
                foreach (var ow in okaywords)
                {
                    File.AppendAllText(exceptionFilePath, ow.Trim().ToLower() + Environment.NewLine);
                    okayList.Add(ow.Trim().ToLower());
                }
            }

            //Fill local list for explicit words.
            if (File.Exists(explicitFilePath))
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(explicitFilePath);
                while ((line = file.ReadLine()) != null)
                {
                    knownBadList.Add(line.Trim().ToLower());
                }

                file.Close();
            }
            else
            {
                //Doesn't exist. Create a new one.
                if (!Directory.Exists(appDataAppPath))
                {
                    Directory.CreateDirectory(appDataAppPath);
                }
                File.Create(explicitFilePath).Close();              
            }

            //Fill local list for explicit base words.
            if(File.Exists(explicitBaseFilePath))
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(explicitBaseFilePath);
                while ((line = file.ReadLine()) != null)
                {
                    baseBadList.Add(line.Trim().ToLower());
                }

                file.Close();
            }
            else
            {
                //Doesn't exist, create a new one.
                if (!Directory.Exists(appDataAppPath))
                {
                    Directory.CreateDirectory(appDataAppPath);
                }

                //Fill this file with base bad words.
                foreach (var bw in badwords)
                {
                    File.AppendAllText(explicitBaseFilePath, bw.Trim().ToLower() + Environment.NewLine);
                    baseBadList.Add(bw.Trim().ToLower());
                }
            }
        }

        private void lbSongs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lbSongs_DragDrop(object sender, DragEventArgs e)
        {
            lbSongs.Items.Clear();

            foreach (var s in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                addFilesToListBox(s);
            }

            lblTotalFilesToProcess.Text = lbSongs.Items.Count.ToString();
        }

        private void addFilesToListBox(string filename)
        {
            if (Directory.Exists(filename))
            {
                foreach(string folder in Directory.GetDirectories(filename))
                {
                    addFilesToListBox(folder);
                }
                foreach(string file in Directory.GetFiles(filename))
                {
                    addFilesToListBox(file);
                }
            }
            else
            {
                if(Path.GetExtension(filename).ToString() == ".m4a" || Path.GetExtension(filename).ToString() == ".m4p")
                {
                    lbSongs.Items.Add(filename);
                }
            }
        }

        private void explicitCheck(bool processExistingExplicit, bool addNoLyricTag)
        {
            lblExplicitProcessed.Text = "0";
            lblNoLyrics.Text = "0";
            lblClean.Text = "0";
            lblExplicitProcessed.Refresh();
            lblNoLyrics.Refresh();
            lblClean.Refresh();

            lbProcessFiles.Items.Clear();

            btnProcess.Enabled = false;
            btnProcess.Refresh();
            pbFilesProcessed.Maximum = lbSongs.Items.Count;
            pbFilesProcessed.Value = 0;

            foreach (var item in lbSongs.Items)
            {
                var file = TagLib.File.Create(item.ToString());

                if(processExistingExplicit && file.Tag.Comment != null)
                {
                    file.Tag.Comment = file.Tag.Comment.Replace("[Explicit]", "");
                    lbProcessFiles.Items.Add(item + "  |  Removed [Explicit]");
                    lbProcessFiles.Refresh();
                }

                //Check if explicit tag already exists. This would mainly come from Apple's music.
                AppleTag appleTag = (AppleTag)file.GetTag(TagTypes.Apple, false);
                TagLib.ByteVector rtng = "rtng";
                var info = appleTag.GetText(rtng);

                if (info[0].ToString() == "\u0001")
                {
                    file.Tag.Comment = file.Tag.Comment + "[Explicit]";
                    lbProcessFiles.Items.Add(item + "  |  Added [Explicit]");
                    lbProcessFiles.Refresh();
                }


                //Check lyrics.
                if (file.Tag.Lyrics == null || file.Tag.Lyrics.Length == 0)
                {
                    if (file.Tag.Comment == null)
                    {
                        if (addNoLyricTag)
                        {
                            file.Tag.Comment = file.Tag.Comment + "[NoLyrics]";
                            lbProcessFiles.Items.Add(item + "  |  Added [NoLyrics]");
                            lbProcessFiles.Refresh();
                        }
                    }
                    else if (!file.Tag.Comment.Contains("[NoLyrics]"))
                    {
                        if (addNoLyricTag)
                        {
                            lbProcessFiles.Items.Add(item + "  |  Added [NoLyrics]");
                            lbProcessFiles.Items.Add(item);
                            lbProcessFiles.Refresh();
                        }                        
                    }
                    lblNoLyrics.Text = (int.Parse(lblNoLyrics.Text) + 1).ToString();
                    lblNoLyrics.Refresh();

                    lblClean.Text = (int.Parse(lblClean.Text) + 1).ToString();
                    lblClean.Refresh();
                }
                else
                {
                    //Has Lyrics so far.

                    if ((file.Tag.Comment == null || !file.Tag.Comment.Contains("[Explicit]")) && file.Tag.Lyrics != null)
                    {
                        string lyric = file.Tag.Lyrics.Replace(",", " ")
                                                        .Replace(".", " ")
                                                        .Replace(";", " ")
                                                        .Replace("\n"," ")
                                                        .Replace("\r", " ")
                                                        .Replace("\t", " ")
                                                        .Replace("'", " ")
                                                        .Replace(","," ")
                                                        .Replace("?", " ")
                                                        .Replace("(", " ")
                                                        .Replace(")", " ")
                                                        .Replace("!", " ")
                                                        .Replace("[", " ")
                                                        .Replace("]", " ")
                                                        .Replace("<", " ")
                                                        .Replace(">", " ")
                                                        .Replace(":", " ")
                                                        .Replace("\'", " ")
                                                        .Replace("\"", " ")
                                                        .Replace("\0", " ")
                                                        .Replace("\a", " ")
                                                        .Replace("\f", " ")
                                                        .Replace("\\", " ")
                                                        .Replace("/", " ")
                                                        .Replace("_", " ");

                        bool hadBadWord = checkLyricsForBadWords(lyric, file);

                        if (hadBadWord)
                        {
                            file.Tag.Comment = file.Tag.Comment + "[Explicit]";
                            lbProcessFiles.Items.Add(item + "  |  Added [Explicit]");
                            lbProcessFiles.Refresh();
                            lblExplicitProcessed.Text = (int.Parse(lblExplicitProcessed.Text) + 1).ToString();
                            lblExplicitProcessed.Refresh();

                            int visibleItems = lbProcessFiles.ClientSize.Height / lbProcessFiles.ItemHeight;
                            lbProcessFiles.TopIndex = Math.Max(lbProcessFiles.Items.Count - visibleItems + 1, 0);
                        }
                        else
                        {
                            //Considered clean
                            lblClean.Text = (int.Parse(lblClean.Text) + 1).ToString();
                            lblClean.Refresh();
                        }
                    }
                    else
                    {
                        //Considered clean
                        lblClean.Text = (int.Parse(lblClean.Text) + 1).ToString();
                        lblClean.Refresh();
                    }                 
                }
                pbFilesProcessed.Value = pbFilesProcessed.Value + 1;
                pbFilesProcessed.Refresh();
                file.Save();
            }

            MessageBox.Show("Done!");
            btnProcess.Enabled = true;
            btnProcess.Refresh();
        }

        private bool checkLyricsForBadWords(string lyric, TagLib.File songFile)
        {
            bool hadBadWord = false;
            bool wordIsOkay = false;
            int letterIndex = -1;
            int wordIndex = -1;

            foreach (var word in lyric.Split(' '))
            {
                letterIndex += word.Length;
                wordIndex += 1;

                foreach(string okayW in okayList)
                {
                    if(word.Trim().ToLower() == okayW.Trim().ToLower())
                    {
                        wordIsOkay = true;
                    }
                }

                foreach(string badW in knownBadList)
                {
                    if(word.Trim().ToLower() == badW.Trim().ToLower())
                    {
                        hadBadWord = true;
                        return hadBadWord;
                    }
                }

                if (!wordIsOkay)
                {
                    foreach (var badword in baseBadList)
                    {
                        if (word.Trim().ToLower().Contains(badword.Trim().ToLower()) && word != "*" && word != "$")
                        {
                            frmLyricConfirm lc = new frmLyricConfirm();
                            lc.artist = songFile.Tag.FirstPerformer;
                            lc.title = songFile.Tag.Title;
                            lc.lyrics = songFile.Tag.Lyrics;
                            lc.badword = word;

                            int start;
                            int end;

                            start = letterIndex + wordIndex - word.Length  - 30;
                            if (start < 0)
                                start = 0;

                            end = letterIndex + wordIndex + 30;

                            if (end > lyric.Length)
                                end = lyric.Length;
                            
                            lc.context = "..." + lyric.Substring(start, end - start) + "...";

                            DialogResult dialogResult = lc.ShowDialog();

                            if (dialogResult == DialogResult.Yes)
                            {
                                hadBadWord = true;

                                //add word to local list.
                                knownBadList.Add(word.Trim().ToLower());

                                //Add the word to explicit words file.
                                if(!File.Exists(explicitFilePath))
                                {
                                    var file = File.CreateText(explicitFilePath);
                                    file.Close();
                                }

                                File.AppendAllText(explicitFilePath, word.Trim().ToLower() + Environment.NewLine);

                                return hadBadWord;
                            }
                            else if(dialogResult == DialogResult.No)
                            {
                                //add word to local list
                                okayList.Add(word.Trim().ToLower());

                                //Add the word to exception file.
                                if (!File.Exists(exceptionFilePath))
                                {
                                    var file = File.CreateText(exceptionFilePath);
                                    file.Close();
                                }

                                File.AppendAllText(exceptionFilePath, word.Trim().ToLower() + Environment.NewLine);
                            }
                            else if(dialogResult != DialogResult.Ignore)
                            {

                            }
                        }
                    }
                }
            }

            return hadBadWord;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            explicitCheck(ckProcessExplict.Checked, ckAddNoLyric.Checked);
        }

        private void rEADMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMe frmReadMe = new ReadMe();
            frmReadMe.ShowDialog();
        }
        
        private void baseExplicitWordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseExplicitWords frmBaseExplicit = new BaseExplicitWords();
            frmBaseExplicit.ShowDialog();
        }        

        private void explicitWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExplictWords frmExplicit = new ExplictWords();
            frmExplicit.ShowDialog();
        }

        private void exceptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exceptions frmExceptions = new Exceptions();
            frmExceptions.ShowDialog();
        }
    }
}