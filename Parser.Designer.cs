using ParserLibrary;

namespace RDRPParser
{
    partial class Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parser));
            SidePanel = new Panel();
            logoAngellify = new PictureBox();
            ParserControl = new Button();
            logoPanel = new Panel();
            pictureBox1 = new PictureBox();
            PathPanel = new Panel();
            infoLabel = new Label();
            logPath = new TextBox();
            SearchRedmPathButton = new Button();
            infoLabel2 = new Label();
            savePath = new TextBox();
            SearchSavePathButton = new Button();
            label1 = new Label();
            redmPathLabel = new Label();
            parseButton = new Button();
            logText = new ListBox();
            notifyIcon = new NotifyIcon(components);
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoAngellify).BeginInit();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PathPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SidePanel.BackColor = Color.DarkRed;
            SidePanel.Controls.Add(logoAngellify);
            SidePanel.Controls.Add(ParserControl);
            SidePanel.Controls.Add(logoPanel);
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(250, 761);
            SidePanel.TabIndex = 7;
            // 
            // logoAngellify
            // 
            logoAngellify.Dock = DockStyle.Bottom;
            logoAngellify.Image = (Image)resources.GetObject("logoAngellify.Image");
            logoAngellify.Location = new Point(0, 633);
            logoAngellify.Name = "logoAngellify";
            logoAngellify.Size = new Size(250, 128);
            logoAngellify.SizeMode = PictureBoxSizeMode.CenterImage;
            logoAngellify.TabIndex = 12;
            logoAngellify.TabStop = false;
            // 
            // ParserControl
            // 
            ParserControl.BackColor = Color.Transparent;
            ParserControl.FlatAppearance.BorderSize = 0;
            ParserControl.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 20, 20);
            ParserControl.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 20, 20);
            ParserControl.FlatStyle = FlatStyle.Flat;
            ParserControl.Font = new Font("Niagara Solid", 28F, FontStyle.Bold, GraphicsUnit.Point);
            ParserControl.ForeColor = SystemColors.ButtonFace;
            ParserControl.Image = (Image)resources.GetObject("ParserControl.Image");
            ParserControl.Location = new Point(12, 164);
            ParserControl.Name = "ParserControl";
            ParserControl.Size = new Size(228, 50);
            ParserControl.TabIndex = 1;
            ParserControl.UseVisualStyleBackColor = false;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(pictureBox1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Padding = new Padding(10);
            logoPanel.Size = new Size(250, 142);
            logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // PathPanel
            // 
            PathPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PathPanel.Controls.Add(infoLabel);
            PathPanel.Controls.Add(logPath);
            PathPanel.Controls.Add(SearchRedmPathButton);
            PathPanel.Controls.Add(infoLabel2);
            PathPanel.Controls.Add(savePath);
            PathPanel.Controls.Add(SearchSavePathButton);
            PathPanel.Controls.Add(label1);
            PathPanel.Controls.Add(redmPathLabel);
            PathPanel.Location = new Point(253, 81);
            PathPanel.Name = "PathPanel";
            PathPanel.Size = new Size(527, 107);
            PathPanel.TabIndex = 11;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(244, 32);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(243, 18);
            infoLabel.TabIndex = 10;
            infoLabel.Text = "Path should be: RedM\\RedM.app\\logs";
            // 
            // logPath
            // 
            logPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            logPath.Location = new Point(244, 4);
            logPath.Name = "logPath";
            logPath.Size = new Size(189, 26);
            logPath.TabIndex = 1;
            logPath.MouseEnter += ShowInfo;
            logPath.MouseLeave += HideInfo;
            // 
            // SearchRedmPathButton
            // 
            SearchRedmPathButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SearchRedmPathButton.AutoSize = true;
            SearchRedmPathButton.Location = new Point(439, 3);
            SearchRedmPathButton.Name = "SearchRedmPathButton";
            SearchRedmPathButton.Size = new Size(75, 28);
            SearchRedmPathButton.TabIndex = 0;
            SearchRedmPathButton.Text = "Search";
            SearchRedmPathButton.UseVisualStyleBackColor = true;
            SearchRedmPathButton.Click += OnSearchClick;
            SearchRedmPathButton.MouseEnter += ShowInfo;
            SearchRedmPathButton.MouseLeave += HideInfo;
            // 
            // infoLabel2
            // 
            infoLabel2.AutoSize = true;
            infoLabel2.Location = new Point(244, 83);
            infoLabel2.Name = "infoLabel2";
            infoLabel2.Size = new Size(204, 18);
            infoLabel2.TabIndex = 11;
            infoLabel2.Text = "Path can be anywhere you want";
            // 
            // savePath
            // 
            savePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            savePath.Location = new Point(244, 54);
            savePath.Name = "savePath";
            savePath.Size = new Size(189, 26);
            savePath.TabIndex = 5;
            savePath.MouseEnter += ShowInfo;
            savePath.MouseLeave += HideInfo;
            // 
            // SearchSavePathButton
            // 
            SearchSavePathButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SearchSavePathButton.AutoSize = true;
            SearchSavePathButton.Location = new Point(439, 53);
            SearchSavePathButton.Name = "SearchSavePathButton";
            SearchSavePathButton.Size = new Size(75, 28);
            SearchSavePathButton.TabIndex = 6;
            SearchSavePathButton.Text = "Search";
            SearchSavePathButton.UseVisualStyleBackColor = true;
            SearchSavePathButton.Click += OnSearchClick;
            SearchSavePathButton.MouseEnter += ShowInfo;
            SearchSavePathButton.MouseLeave += HideInfo;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(157, 58);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 9;
            label1.Text = "Save Path:";
            label1.MouseEnter += ShowInfo;
            label1.MouseLeave += HideInfo;
            // 
            // redmPathLabel
            // 
            redmPathLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            redmPathLabel.AutoSize = true;
            redmPathLabel.Location = new Point(150, 8);
            redmPathLabel.Name = "redmPathLabel";
            redmPathLabel.Size = new Size(79, 18);
            redmPathLabel.TabIndex = 8;
            redmPathLabel.Text = "RedM Path:";
            redmPathLabel.MouseEnter += ShowInfo;
            redmPathLabel.MouseLeave += HideInfo;
            // 
            // parseButton
            // 
            parseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            parseButton.AutoSize = true;
            parseButton.Location = new Point(653, 721);
            parseButton.Name = "parseButton";
            parseButton.Size = new Size(114, 28);
            parseButton.TabIndex = 3;
            parseButton.Text = "Parse";
            parseButton.UseVisualStyleBackColor = true;
            parseButton.Click += OnParseClick;
            // 
            // logText
            // 
            logText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logText.FormattingEnabled = true;
            logText.ItemHeight = 18;
            logText.Location = new Point(256, 191);
            logText.Name = "logText";
            logText.Size = new Size(511, 508);
            logText.TabIndex = 2;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = "RedM Parser";
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "RedM Parser";
            notifyIcon.MouseDoubleClick += OnDoubleClick;
            // 
            // Parser
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(784, 761);
            Controls.Add(parseButton);
            Controls.Add(logText);
            Controls.Add(PathPanel);
            Controls.Add(SidePanel);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Parser";
            StartPosition = FormStartPosition.CenterScreen;
            Resize += OnMinimizeForm;
            SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoAngellify).EndInit();
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PathPanel.ResumeLayout(false);
            PathPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel SidePanel;
        private Panel logoPanel;
        private PictureBox pictureBox1;
        private Button ParserControl;
        private Panel PathPanel;
        private TextBox logPath;
        private Button SearchRedmPathButton;
        private TextBox savePath;
        private Button SearchSavePathButton;
        private Label label1;
        private Label redmPathLabel;
        private Button parseButton;
        private ListBox logText;
        private Label infoLabel2;
        private Label infoLabel;
        private NotifyIcon notifyIcon;
        private PictureBox logoAngellify;
    }
}