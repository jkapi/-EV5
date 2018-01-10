namespace ev5
{
    partial class UI
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
            this.CompileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.SaveFileAsButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.HelpImage = new System.Windows.Forms.PictureBox();
            this.SleepBlock = new System.Windows.Forms.PictureBox();
            this.DisplayBlock = new System.Windows.Forms.PictureBox();
            this.BeepBlock = new System.Windows.Forms.PictureBox();
            this.MoveuntilBlock = new System.Windows.Forms.PictureBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.TurnBlock = new System.Windows.Forms.PictureBox();
            this.MoveBlock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HelpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeepBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveuntilBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // CompileButton
            // 
            this.CompileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CompileButton.Location = new System.Drawing.Point(500, 250);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(150, 75);
            this.CompileButton.TabIndex = 2;
            this.CompileButton.Text = "Compile";
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OpenFileButton.Location = new System.Drawing.Point(32, 250);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(150, 75);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SaveFileButton.Location = new System.Drawing.Point(188, 250);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(150, 75);
            this.SaveFileButton.TabIndex = 5;
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SaveFileAsButton
            // 
            this.SaveFileAsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFileAsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SaveFileAsButton.Location = new System.Drawing.Point(344, 250);
            this.SaveFileAsButton.Name = "SaveFileAsButton";
            this.SaveFileAsButton.Size = new System.Drawing.Size(150, 75);
            this.SaveFileAsButton.TabIndex = 6;
            this.SaveFileAsButton.Text = "Save as";
            this.SaveFileAsButton.UseVisualStyleBackColor = true;
            this.SaveFileAsButton.Click += new System.EventHandler(this.SaveFileAsButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DownloadButton.Location = new System.Drawing.Point(1758, 250);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(150, 75);
            this.DownloadButton.TabIndex = 12;
            this.DownloadButton.Text = "Download a project";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UploadButton.Location = new System.Drawing.Point(1602, 250);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(150, 75);
            this.UploadButton.TabIndex = 13;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // HelpImage
            // 
            this.HelpImage.Image = global::ev5.Properties.Resources.help;
            this.HelpImage.Location = new System.Drawing.Point(1746, 12);
            this.HelpImage.Name = "HelpImage";
            this.HelpImage.Size = new System.Drawing.Size(162, 162);
            this.HelpImage.TabIndex = 14;
            this.HelpImage.TabStop = false;
            this.HelpImage.Click += new System.EventHandler(this.HelpImage_Click);
            // 
            // SleepBlock
            // 
            this.SleepBlock.BackColor = System.Drawing.Color.Blue;
            this.SleepBlock.Location = new System.Drawing.Point(854, 926);
            this.SleepBlock.Name = "SleepBlock";
            this.SleepBlock.Size = new System.Drawing.Size(100, 125);
            this.SleepBlock.TabIndex = 11;
            this.SleepBlock.TabStop = false;
            this.SleepBlock.Click += new System.EventHandler(this.SleepBlock_Click);
            // 
            // DisplayBlock
            // 
            this.DisplayBlock.BackColor = System.Drawing.Color.Yellow;
            this.DisplayBlock.Location = new System.Drawing.Point(960, 926);
            this.DisplayBlock.Name = "DisplayBlock";
            this.DisplayBlock.Size = new System.Drawing.Size(100, 125);
            this.DisplayBlock.TabIndex = 10;
            this.DisplayBlock.TabStop = false;
            this.DisplayBlock.Click += new System.EventHandler(this.DisplayBlock_Click);
            // 
            // BeepBlock
            // 
            this.BeepBlock.BackColor = System.Drawing.Color.Purple;
            this.BeepBlock.Location = new System.Drawing.Point(1066, 926);
            this.BeepBlock.Name = "BeepBlock";
            this.BeepBlock.Size = new System.Drawing.Size(100, 125);
            this.BeepBlock.TabIndex = 9;
            this.BeepBlock.TabStop = false;
            this.BeepBlock.Click += new System.EventHandler(this.BeepBlock_Click);
            // 
            // MoveuntilBlock
            // 
            this.MoveuntilBlock.BackColor = System.Drawing.Color.Orange;
            this.MoveuntilBlock.Location = new System.Drawing.Point(1172, 926);
            this.MoveuntilBlock.Name = "MoveuntilBlock";
            this.MoveuntilBlock.Size = new System.Drawing.Size(100, 125);
            this.MoveuntilBlock.TabIndex = 8;
            this.MoveuntilBlock.TabStop = false;
            this.MoveuntilBlock.Click += new System.EventHandler(this.MoveuntilBlock_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = global::ev5.Properties.Resources.RP6_Logo;
            this.LogoBox.InitialImage = global::ev5.Properties.Resources.RP6_Logo;
            this.LogoBox.Location = new System.Drawing.Point(-1, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(481, 208);
            this.LogoBox.TabIndex = 7;
            this.LogoBox.TabStop = false;
            // 
            // TurnBlock
            // 
            this.TurnBlock.BackColor = System.Drawing.Color.Green;
            this.TurnBlock.Location = new System.Drawing.Point(748, 926);
            this.TurnBlock.Name = "TurnBlock";
            this.TurnBlock.Size = new System.Drawing.Size(100, 125);
            this.TurnBlock.TabIndex = 1;
            this.TurnBlock.TabStop = false;
            this.TurnBlock.Click += new System.EventHandler(this.TurnBlock_Click);
            // 
            // MoveBlock
            // 
            this.MoveBlock.BackColor = System.Drawing.Color.Red;
            this.MoveBlock.Location = new System.Drawing.Point(642, 926);
            this.MoveBlock.Name = "MoveBlock";
            this.MoveBlock.Size = new System.Drawing.Size(100, 125);
            this.MoveBlock.TabIndex = 0;
            this.MoveBlock.TabStop = false;
            this.MoveBlock.Click += new System.EventHandler(this.MoveBlock_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.HelpImage);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.SleepBlock);
            this.Controls.Add(this.DisplayBlock);
            this.Controls.Add(this.BeepBlock);
            this.Controls.Add(this.MoveuntilBlock);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.SaveFileAsButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.TurnBlock);
            this.Controls.Add(this.MoveBlock);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_Keydown);
            ((System.ComponentModel.ISupportInitialize)(this.HelpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeepBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveuntilBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoveBlock;
        private System.Windows.Forms.PictureBox TurnBlock;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button SaveFileAsButton;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.PictureBox MoveuntilBlock;
        private System.Windows.Forms.PictureBox BeepBlock;
        private System.Windows.Forms.PictureBox DisplayBlock;
        private System.Windows.Forms.PictureBox SleepBlock;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.PictureBox HelpImage;
    }
}

