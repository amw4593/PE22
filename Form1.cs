using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace PE21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.microsoftSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.testToolStripButton.Click += new EventHandler(TestToolStripButton__Click);

            this.toolStrip1.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);

            this.richTextBox1.SelectionChanged += new EventHandler(RichTextBox__SelectionChanged);

            this.countdownLabel.Visible = false;

            this.timer1.Tick += new EventHandler(Timer__Tick);


            this.Text = "MyEditor";
        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = "MyEditor";
        }

        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;
            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        private void TestToolStripButton__Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 500;

            this.toolStripProgressBar1.Value = 60;

            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = true;
            this.richTextBox1 .Visible = false;

            for(int i = 3; i > 0; i--)
            {
                this.countdownLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }
            this.countdownLabel.Visible = false;
            this.richTextBox1.Visible = true;

            this.timer1.Start();

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;

            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer1.Stop();
                string performance = "Congratulations! You Typed " + Math.Round(this.richTextBox1.TextLength / 30.0, 2) + " letters per second!";
                MessageBox.Show(performance);
            }
        }
        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;
            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;
            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        private void MSSansSerifToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);

            richTextBox1.SelectionFont = newFont;
        }

        private void TimesNewRomanToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);

            richTextBox1.SelectionFont = newFont;
        }

        private void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionFont != null)
            {
                this.boldToolStripMenuItem.Checked = richTextBox1.SelectionFont.Bold;
                this.italicsToolStripMenuItem.Checked = richTextBox1.SelectionFont.Italic;
                this.underlineToolStripMenuItem.Checked = richTextBox1.SelectionFont.Underline;
            }

            this.colorToolStripButton.BackColor = richTextBox1.SelectionColor;
        }

        private void OpenToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (openFileDialog1.FileName.ToLower().Contains(".rtf"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.LoadFile(openFileDialog1.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog1.FileName + ")";
            }
        }
        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (saveFileDialog1.FileName.ToLower().Contains(".rtf"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.SaveFile(saveFileDialog1.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog1.FileName + ")";
            }
        }

        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.toolStripButton1)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.toolStripButton1;
            }
            else if (e.ClickedItem == this.toolStripButton2)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.toolStripButton2;
            }
            else if (e.ClickedItem == this.toolStripButton3)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.toolStripButton3;
            }
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }
            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }
        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                //Underline = 4, Bold = 1, Italic = 2 
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox1.SelectionFont = newFont;
        }

    }
}
