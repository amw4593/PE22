namespace PE21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            colorToolStripButton = new ToolStripButton();
            toolStripButton4 = new ToolStripDropDownButton();
            microsoftSansSerifToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            testToolStripButton = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicsToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            countdownLabel = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            fileToolStripMenuItem.ToolTipText = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.ToolTipText = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.ToolTipText = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.ToolTipText = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.ToolTipText = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.ToolTipText = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(126, 26);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.ToolTipText = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(126, 26);
            cutToolStripMenuItem.Text = "C&ut";
            cutToolStripMenuItem.ToolTipText = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(126, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.ToolTipText = "Paste";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, colorToolStripButton, toolStripButton4, toolStripSeparator2, testToolStripButton });
            toolStrip1.Location = new Point(-1, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(198, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "boldToolStripButton";
            toolStripButton1.ToolTipText = "Bold";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "italicsToolStripButton";
            toolStripButton2.ToolTipText = "Italics";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Underline";
            // 
            // colorToolStripButton
            // 
            colorToolStripButton.BackColor = Color.Black;
            colorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colorToolStripButton.ImageTransparentColor = Color.Magenta;
            colorToolStripButton.Name = "colorToolStripButton";
            colorToolStripButton.Size = new Size(29, 24);
            colorToolStripButton.Text = "colorToolStripButton";
            colorToolStripButton.ToolTipText = "Color";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.DropDownItems.AddRange(new ToolStripItem[] { microsoftSansSerifToolStripMenuItem, timesNewRomanToolStripMenuItem });
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 24);
            toolStripButton4.Text = "fontToolStripButton";
            // 
            // microsoftSansSerifToolStripMenuItem
            // 
            microsoftSansSerifToolStripMenuItem.Name = "microsoftSansSerifToolStripMenuItem";
            microsoftSansSerifToolStripMenuItem.Size = new Size(216, 26);
            microsoftSansSerifToolStripMenuItem.Text = "MS Sans Serif";
            microsoftSansSerifToolStripMenuItem.ToolTipText = "mSSansSerif";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(216, 26);
            timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            timesNewRomanToolStripMenuItem.ToolTipText = "Times New Roman";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // testToolStripButton
            // 
            testToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            testToolStripButton.Image = (Image)resources.GetObject("testToolStripButton.Image");
            testToolStripButton.ImageTransparentColor = Color.Magenta;
            testToolStripButton.Name = "testToolStripButton";
            testToolStripButton.Size = new Size(29, 24);
            testToolStripButton.Text = "toolStripButton5";
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Location = new Point(0, 31);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(914, 498);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { boldToolStripMenuItem, italicsToolStripMenuItem, underlineToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 76);
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(142, 24);
            boldToolStripMenuItem.Text = "&Bold";
            boldToolStripMenuItem.ToolTipText = "Bold Selected Text";
            // 
            // italicsToolStripMenuItem
            // 
            italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            italicsToolStripMenuItem.Size = new Size(142, 24);
            italicsToolStripMenuItem.Text = "&Italics";
            italicsToolStripMenuItem.ToolTipText = "Italicize Selected Text";
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.Size = new Size(142, 24);
            underlineToolStripMenuItem.Text = "&Underline";
            underlineToolStripMenuItem.ToolTipText = "Underline Selected Text";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Rich Text Files|*.rtf|Plain Text Files|*.txt|All Files|*.";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "Rich Text Files|*.rtf|Plain Text Files|*.txt|All Files|*.";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(countdownLabel);
            toolStripContainer1.ContentPanel.Controls.Add(toolStrip1);
            toolStripContainer1.ContentPanel.Controls.Add(richTextBox1);
            toolStripContainer1.ContentPanel.Size = new Size(914, 519);
            toolStripContainer1.Location = new Point(1, 31);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(914, 568);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(914, 24);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Maximum = 60;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(700, 16);
            toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
            toolStripProgressBar1.Click += toolStripProgressBar1_Click;
            // 
            // countdownLabel
            // 
            countdownLabel.Dock = DockStyle.Fill;
            countdownLabel.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            countdownLabel.ForeColor = Color.Coral;
            countdownLabel.Location = new Point(0, 0);
            countdownLabel.Name = "countdownLabel";
            countdownLabel.Size = new Size(914, 519);
            countdownLabel.TabIndex = 2;
            countdownLabel.Text = "3";
            countdownLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton colorToolStripButton;
        private ToolStripDropDownButton toolStripButton4;
        private ToolStripMenuItem microsoftSansSerifToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton toolStripButton3;
        private ColorDialog colorDialog;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicsToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton testToolStripButton;
        private System.Windows.Forms.Timer timer1;
        private ToolStripContainer toolStripContainer1;
        private Label countdownLabel;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}