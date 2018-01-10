namespace ev5
{
    partial class Downloadpage
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
            this.Projectbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Projectbox
            // 
            this.Projectbox.FormattingEnabled = true;
            this.Projectbox.Location = new System.Drawing.Point(45, 12);
            this.Projectbox.Name = "Projectbox";
            this.Projectbox.Size = new System.Drawing.Size(205, 147);
            this.Projectbox.TabIndex = 0;
            this.Projectbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Projectbox_DoubleClick);
            // 
            // Downloadpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Projectbox);
            this.Name = "Downloadpage";
            this.Text = "Downloadpage";
            this.Load += new System.EventHandler(this.Downloadpage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Projectbox;
    }
}