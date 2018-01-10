namespace ev5
{
    partial class Inlogpagina
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
            this.WachtwoordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBttn = new System.Windows.Forms.Button();
            this.SignupBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WachtwoordTB
            // 
            this.WachtwoordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.WachtwoordTB.Location = new System.Drawing.Point(120, 102);
            this.WachtwoordTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WachtwoordTB.Name = "WachtwoordTB";
            this.WachtwoordTB.Size = new System.Drawing.Size(175, 20);
            this.WachtwoordTB.TabIndex = 1;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.UsernameTB.Location = new System.Drawing.Point(120, 53);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(175, 20);
            this.UsernameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord";
            // 
            // LoginBttn
            // 
            this.LoginBttn.Location = new System.Drawing.Point(120, 143);
            this.LoginBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(69, 32);
            this.LoginBttn.TabIndex = 2;
            this.LoginBttn.Text = "Login";
            this.LoginBttn.UseVisualStyleBackColor = true;
            this.LoginBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignupBttn
            // 
            this.SignupBttn.Location = new System.Drawing.Point(225, 143);
            this.SignupBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignupBttn.Name = "SignupBttn";
            this.SignupBttn.Size = new System.Drawing.Size(69, 32);
            this.SignupBttn.TabIndex = 3;
            this.SignupBttn.Text = "Sign up";
            this.SignupBttn.UseVisualStyleBackColor = true;
            this.SignupBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Inlogpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 200);
            this.Controls.Add(this.SignupBttn);
            this.Controls.Add(this.LoginBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.WachtwoordTB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inlogpagina";
            this.Text = "Inlogpagina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WachtwoordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.Button SignupBttn;
    }
}

