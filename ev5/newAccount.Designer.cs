namespace ev5
{
    partial class newAccount
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
            this.VoornaamLB = new System.Windows.Forms.Label();
            this.VoornaamTB = new System.Windows.Forms.TextBox();
            this.TussenvoegselTB = new System.Windows.Forms.TextBox();
            this.TussenvoegselLB = new System.Windows.Forms.Label();
            this.AchternaamTB = new System.Windows.Forms.TextBox();
            this.AchternaamLB = new System.Windows.Forms.Label();
            this.groupBoxNaam = new System.Windows.Forms.GroupBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.EmailLB = new System.Windows.Forms.Label();
            this.GroupBoxUser = new System.Windows.Forms.GroupBox();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.NewUsernameTB = new System.Windows.Forms.TextBox();
            this.WachtwoordLB = new System.Windows.Forms.Label();
            this.NewWachtwoordTB = new System.Windows.Forms.TextBox();
            this.SchoolGroupBox = new System.Windows.Forms.GroupBox();
            this.SchoolComboBox = new System.Windows.Forms.ComboBox();
            this.SchoolnaamLB1 = new System.Windows.Forms.Label();
            this.TextLB1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Addschool = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxNaam.SuspendLayout();
            this.GroupBoxUser.SuspendLayout();
            this.SchoolGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoornaamLB
            // 
            this.VoornaamLB.AutoSize = true;
            this.VoornaamLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VoornaamLB.Location = new System.Drawing.Point(68, 35);
            this.VoornaamLB.Name = "VoornaamLB";
            this.VoornaamLB.Size = new System.Drawing.Size(90, 20);
            this.VoornaamLB.TabIndex = 0;
            this.VoornaamLB.Text = "Voornaam:";
            // 
            // VoornaamTB
            // 
            this.VoornaamTB.Location = new System.Drawing.Point(71, 65);
            this.VoornaamTB.Name = "VoornaamTB";
            this.VoornaamTB.Size = new System.Drawing.Size(235, 26);
            this.VoornaamTB.TabIndex = 1;
            // 
            // TussenvoegselTB
            // 
            this.TussenvoegselTB.Location = new System.Drawing.Point(71, 154);
            this.TussenvoegselTB.Name = "TussenvoegselTB";
            this.TussenvoegselTB.Size = new System.Drawing.Size(235, 26);
            this.TussenvoegselTB.TabIndex = 3;
            // 
            // TussenvoegselLB
            // 
            this.TussenvoegselLB.AutoSize = true;
            this.TussenvoegselLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TussenvoegselLB.Location = new System.Drawing.Point(68, 124);
            this.TussenvoegselLB.Name = "TussenvoegselLB";
            this.TussenvoegselLB.Size = new System.Drawing.Size(126, 20);
            this.TussenvoegselLB.TabIndex = 2;
            this.TussenvoegselLB.Text = "Tussenvoegsel:";
            // 
            // AchternaamTB
            // 
            this.AchternaamTB.Location = new System.Drawing.Point(71, 244);
            this.AchternaamTB.Name = "AchternaamTB";
            this.AchternaamTB.Size = new System.Drawing.Size(235, 26);
            this.AchternaamTB.TabIndex = 5;
            // 
            // AchternaamLB
            // 
            this.AchternaamLB.AutoSize = true;
            this.AchternaamLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AchternaamLB.Location = new System.Drawing.Point(68, 214);
            this.AchternaamLB.Name = "AchternaamLB";
            this.AchternaamLB.Size = new System.Drawing.Size(104, 20);
            this.AchternaamLB.TabIndex = 4;
            this.AchternaamLB.Text = "Achternaam:";
            // 
            // groupBoxNaam
            // 
            this.groupBoxNaam.Controls.Add(this.EmailTB);
            this.groupBoxNaam.Controls.Add(this.EmailLB);
            this.groupBoxNaam.Controls.Add(this.VoornaamLB);
            this.groupBoxNaam.Controls.Add(this.AchternaamTB);
            this.groupBoxNaam.Controls.Add(this.VoornaamTB);
            this.groupBoxNaam.Controls.Add(this.AchternaamLB);
            this.groupBoxNaam.Controls.Add(this.TussenvoegselLB);
            this.groupBoxNaam.Controls.Add(this.TussenvoegselTB);
            this.groupBoxNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxNaam.Location = new System.Drawing.Point(53, 27);
            this.groupBoxNaam.Name = "groupBoxNaam";
            this.groupBoxNaam.Size = new System.Drawing.Size(377, 403);
            this.groupBoxNaam.TabIndex = 6;
            this.groupBoxNaam.TabStop = false;
            this.groupBoxNaam.Text = "Persoonsgegevens";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(72, 341);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(235, 26);
            this.EmailTB.TabIndex = 7;
            this.EmailTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmailLB.Location = new System.Drawing.Point(68, 306);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(56, 20);
            this.EmailLB.TabIndex = 6;
            this.EmailLB.Text = "Email:";
            this.EmailLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // GroupBoxUser
            // 
            this.GroupBoxUser.Controls.Add(this.UsernameLB);
            this.GroupBoxUser.Controls.Add(this.NewUsernameTB);
            this.GroupBoxUser.Controls.Add(this.WachtwoordLB);
            this.GroupBoxUser.Controls.Add(this.NewWachtwoordTB);
            this.GroupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GroupBoxUser.Location = new System.Drawing.Point(475, 254);
            this.GroupBoxUser.Name = "GroupBoxUser";
            this.GroupBoxUser.Size = new System.Drawing.Size(398, 234);
            this.GroupBoxUser.TabIndex = 7;
            this.GroupBoxUser.TabStop = false;
            this.GroupBoxUser.Text = "Usergegevens";
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameLB.Location = new System.Drawing.Point(37, 44);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(91, 20);
            this.UsernameLB.TabIndex = 4;
            this.UsernameLB.Text = "Username:";
            // 
            // NewUsernameTB
            // 
            this.NewUsernameTB.Location = new System.Drawing.Point(40, 74);
            this.NewUsernameTB.Name = "NewUsernameTB";
            this.NewUsernameTB.Size = new System.Drawing.Size(235, 26);
            this.NewUsernameTB.TabIndex = 5;
            // 
            // WachtwoordLB
            // 
            this.WachtwoordLB.AutoSize = true;
            this.WachtwoordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WachtwoordLB.Location = new System.Drawing.Point(37, 133);
            this.WachtwoordLB.Name = "WachtwoordLB";
            this.WachtwoordLB.Size = new System.Drawing.Size(107, 20);
            this.WachtwoordLB.TabIndex = 6;
            this.WachtwoordLB.Text = "Wachtwoord:";
            // 
            // NewWachtwoordTB
            // 
            this.NewWachtwoordTB.Location = new System.Drawing.Point(40, 169);
            this.NewWachtwoordTB.Name = "NewWachtwoordTB";
            this.NewWachtwoordTB.Size = new System.Drawing.Size(235, 26);
            this.NewWachtwoordTB.TabIndex = 7;
            // 
            // SchoolGroupBox
            // 
            this.SchoolGroupBox.Controls.Add(this.button2);
            this.SchoolGroupBox.Controls.Add(this.Addschool);
            this.SchoolGroupBox.Controls.Add(this.SchoolComboBox);
            this.SchoolGroupBox.Controls.Add(this.SchoolnaamLB1);
            this.SchoolGroupBox.Controls.Add(this.TextLB1);
            this.SchoolGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolGroupBox.Location = new System.Drawing.Point(475, 29);
            this.SchoolGroupBox.Name = "SchoolGroupBox";
            this.SchoolGroupBox.Size = new System.Drawing.Size(398, 211);
            this.SchoolGroupBox.TabIndex = 8;
            this.SchoolGroupBox.TabStop = false;
            this.SchoolGroupBox.Text = "School info";
            // 
            // SchoolComboBox
            // 
            this.SchoolComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SchoolComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SchoolComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolComboBox.FormattingEnabled = true;
            this.SchoolComboBox.Location = new System.Drawing.Point(59, 151);
            this.SchoolComboBox.Name = "SchoolComboBox";
            this.SchoolComboBox.Size = new System.Drawing.Size(234, 28);
            this.SchoolComboBox.TabIndex = 10;
            // 
            // SchoolnaamLB1
            // 
            this.SchoolnaamLB1.AutoSize = true;
            this.SchoolnaamLB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolnaamLB1.Location = new System.Drawing.Point(55, 110);
            this.SchoolnaamLB1.Name = "SchoolnaamLB1";
            this.SchoolnaamLB1.Size = new System.Drawing.Size(106, 20);
            this.SchoolnaamLB1.TabIndex = 8;
            this.SchoolnaamLB1.Text = "Schoolnaam:";
            // 
            // TextLB1
            // 
            this.TextLB1.AutoSize = true;
            this.TextLB1.Location = new System.Drawing.Point(6, 53);
            this.TextLB1.Name = "TextLB1";
            this.TextLB1.Size = new System.Drawing.Size(318, 20);
            this.TextLB1.TabIndex = 0;
            this.TextLB1.Text = "Leeg laten als dit geen school account is.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Maak een account aan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addschool
            // 
            this.Addschool.Location = new System.Drawing.Point(299, 151);
            this.Addschool.Name = "Addschool";
            this.Addschool.Size = new System.Drawing.Size(93, 28);
            this.Addschool.TabIndex = 11;
            this.Addschool.Text = "Add";
            this.Addschool.UseVisualStyleBackColor = true;
            this.Addschool.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SchoolGroupBox);
            this.Controls.Add(this.GroupBoxUser);
            this.Controls.Add(this.groupBoxNaam);
            this.Name = "newAccount";
            this.Text = "newAccount";
            this.groupBoxNaam.ResumeLayout(false);
            this.groupBoxNaam.PerformLayout();
            this.GroupBoxUser.ResumeLayout(false);
            this.GroupBoxUser.PerformLayout();
            this.SchoolGroupBox.ResumeLayout(false);
            this.SchoolGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VoornaamLB;
        private System.Windows.Forms.TextBox VoornaamTB;
        private System.Windows.Forms.TextBox TussenvoegselTB;
        private System.Windows.Forms.Label TussenvoegselLB;
        private System.Windows.Forms.TextBox AchternaamTB;
        private System.Windows.Forms.Label AchternaamLB;
        private System.Windows.Forms.GroupBox groupBoxNaam;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.GroupBox GroupBoxUser;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.TextBox NewUsernameTB;
        private System.Windows.Forms.Label WachtwoordLB;
        private System.Windows.Forms.TextBox NewWachtwoordTB;
        private System.Windows.Forms.GroupBox SchoolGroupBox;
        private System.Windows.Forms.Label TextLB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SchoolComboBox;
        private System.Windows.Forms.Label SchoolnaamLB1;
        private System.Windows.Forms.Button Addschool;
        private System.Windows.Forms.Button button2;
    }
}