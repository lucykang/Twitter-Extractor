namespace Assignment2
{
    partial class twitterNewsfeeder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(twitterNewsfeeder));
            this.hashTagBtn = new System.Windows.Forms.Button();
            this.twitterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterHandleLabel = new System.Windows.Forms.Label();
            this.handleTextBox = new System.Windows.Forms.TextBox();
            this.numOfTweetsTextBox = new System.Windows.Forms.TextBox();
            this.numOfTweetsLabel = new System.Windows.Forms.Label();
            this.userBtn = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.twitterTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.twitterMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashTagBtn
            // 
            this.hashTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hashTagBtn.Location = new System.Drawing.Point(430, 68);
            this.hashTagBtn.Name = "hashTagBtn";
            this.hashTagBtn.Size = new System.Drawing.Size(150, 27);
            this.hashTagBtn.TabIndex = 3;
            this.hashTagBtn.Text = "Search by Hash&Tag";
            this.twitterTooltip.SetToolTip(this.hashTagBtn, "Search tweets by hashtag");
            this.hashTagBtn.UseVisualStyleBackColor = true;
            this.hashTagBtn.Click += new System.EventHandler(this.hashTagBtn_Click);
            // 
            // twitterMenuStrip
            // 
            this.twitterMenuStrip.BackColor = System.Drawing.Color.LightPink;
            this.twitterMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.twitterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.twitterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.twitterMenuStrip.Name = "twitterMenuStrip";
            this.twitterMenuStrip.Size = new System.Drawing.Size(592, 28);
            this.twitterMenuStrip.TabIndex = 1;
            this.twitterMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // twitterHandleLabel
            // 
            this.twitterHandleLabel.AutoSize = true;
            this.twitterHandleLabel.Location = new System.Drawing.Point(13, 44);
            this.twitterHandleLabel.Name = "twitterHandleLabel";
            this.twitterHandleLabel.Size = new System.Drawing.Size(179, 15);
            this.twitterHandleLabel.TabIndex = 2;
            this.twitterHandleLabel.Text = "Twitter Handle or HashTag";
            // 
            // handleTextBox
            // 
            this.handleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.handleTextBox.Location = new System.Drawing.Point(16, 70);
            this.handleTextBox.Name = "handleTextBox";
            this.handleTextBox.Size = new System.Drawing.Size(300, 25);
            this.handleTextBox.TabIndex = 0;
            this.twitterTooltip.SetToolTip(this.handleTextBox, "Please enter a username or hashtag to search.");
            // 
            // numOfTweetsTextBox
            // 
            this.numOfTweetsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfTweetsTextBox.Location = new System.Drawing.Point(341, 70);
            this.numOfTweetsTextBox.Name = "numOfTweetsTextBox";
            this.numOfTweetsTextBox.Size = new System.Drawing.Size(64, 25);
            this.numOfTweetsTextBox.TabIndex = 1;
            this.twitterTooltip.SetToolTip(this.numOfTweetsTextBox, "Please enter number of tweets to see");
            // 
            // numOfTweetsLabel
            // 
            this.numOfTweetsLabel.AutoSize = true;
            this.numOfTweetsLabel.Location = new System.Drawing.Point(339, 44);
            this.numOfTweetsLabel.Name = "numOfTweetsLabel";
            this.numOfTweetsLabel.Size = new System.Drawing.Size(66, 15);
            this.numOfTweetsLabel.TabIndex = 5;
            this.numOfTweetsLabel.Text = "# Tweets";
            // 
            // userBtn
            // 
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userBtn.Location = new System.Drawing.Point(430, 35);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(150, 27);
            this.userBtn.TabIndex = 2;
            this.userBtn.Text = "Search by &User";
            this.twitterTooltip.SetToolTip(this.userBtn, "Search tweets by username");
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultRichTextBox.BackColor = System.Drawing.Color.White;
            this.resultRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultRichTextBox.Location = new System.Drawing.Point(16, 112);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(564, 242);
            this.resultRichTextBox.TabIndex = 7;
            this.resultRichTextBox.TabStop = false;
            this.resultRichTextBox.Text = "";
            this.twitterTooltip.SetToolTip(this.resultRichTextBox, "Results will be shown when you click a button");
            // 
            // twitterNewsfeeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(592, 375);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.numOfTweetsLabel);
            this.Controls.Add(this.numOfTweetsTextBox);
            this.Controls.Add(this.handleTextBox);
            this.Controls.Add(this.twitterHandleLabel);
            this.Controls.Add(this.hashTagBtn);
            this.Controls.Add(this.twitterMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.twitterMenuStrip;
            this.Name = "twitterNewsfeeder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Newsfeeder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.twitterMenuStrip.ResumeLayout(false);
            this.twitterMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hashTagBtn;
        private System.Windows.Forms.MenuStrip twitterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label twitterHandleLabel;
        private System.Windows.Forms.TextBox handleTextBox;
        private System.Windows.Forms.TextBox numOfTweetsTextBox;
        private System.Windows.Forms.Label numOfTweetsLabel;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.ToolTip twitterTooltip;
    }
}

