namespace ev5
{
    partial class AddnewSchool
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
            this.NieuwschoolGroupBox = new System.Windows.Forms.GroupBox();
            this.SchoolnaamLB = new System.Windows.Forms.Label();
            this.SchoolnaamTB = new System.Windows.Forms.TextBox();
            this.PlaatsnaamTB = new System.Windows.Forms.TextBox();
            this.SchoolpostcodeTB = new System.Windows.Forms.Label();
            this.SchoolAdresTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NieuwschoolGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NieuwschoolGroupBox
            // 
            this.NieuwschoolGroupBox.Controls.Add(this.SchoolnaamLB);
            this.NieuwschoolGroupBox.Controls.Add(this.SchoolnaamTB);
            this.NieuwschoolGroupBox.Controls.Add(this.PlaatsnaamTB);
            this.NieuwschoolGroupBox.Controls.Add(this.SchoolpostcodeTB);
            this.NieuwschoolGroupBox.Controls.Add(this.SchoolAdresTB);
            this.NieuwschoolGroupBox.Controls.Add(this.label3);
            this.NieuwschoolGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NieuwschoolGroupBox.Location = new System.Drawing.Point(41, 21);
            this.NieuwschoolGroupBox.Name = "NieuwschoolGroupBox";
            this.NieuwschoolGroupBox.Size = new System.Drawing.Size(398, 288);
            this.NieuwschoolGroupBox.TabIndex = 17;
            this.NieuwschoolGroupBox.TabStop = false;
            this.NieuwschoolGroupBox.Text = "New School";
            // 
            // SchoolnaamLB
            // 
            this.SchoolnaamLB.AutoSize = true;
            this.SchoolnaamLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolnaamLB.Location = new System.Drawing.Point(73, 73);
            this.SchoolnaamLB.Name = "SchoolnaamLB";
            this.SchoolnaamLB.Size = new System.Drawing.Size(101, 20);
            this.SchoolnaamLB.TabIndex = 14;
            this.SchoolnaamLB.Text = "Schoolnaam";
            // 
            // SchoolnaamTB
            // 
            this.SchoolnaamTB.Location = new System.Drawing.Point(77, 96);
            this.SchoolnaamTB.Name = "SchoolnaamTB";
            this.SchoolnaamTB.Size = new System.Drawing.Size(235, 26);
            this.SchoolnaamTB.TabIndex = 15;
            // 
            // PlaatsnaamTB
            // 
            this.PlaatsnaamTB.Location = new System.Drawing.Point(77, 213);
            this.PlaatsnaamTB.Name = "PlaatsnaamTB";
            this.PlaatsnaamTB.Size = new System.Drawing.Size(235, 26);
            this.PlaatsnaamTB.TabIndex = 13;
            // 
            // SchoolpostcodeTB
            // 
            this.SchoolpostcodeTB.AutoSize = true;
            this.SchoolpostcodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolpostcodeTB.Location = new System.Drawing.Point(74, 125);
            this.SchoolpostcodeTB.Name = "SchoolpostcodeTB";
            this.SchoolpostcodeTB.Size = new System.Drawing.Size(58, 20);
            this.SchoolpostcodeTB.TabIndex = 10;
            this.SchoolpostcodeTB.Text = "Adres:";
            // 
            // SchoolAdresTB
            // 
            this.SchoolAdresTB.Location = new System.Drawing.Point(77, 151);
            this.SchoolAdresTB.Name = "SchoolAdresTB";
            this.SchoolAdresTB.Size = new System.Drawing.Size(235, 26);
            this.SchoolAdresTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(73, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Plaatsnaam:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add school";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddnewSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NieuwschoolGroupBox);
            this.Name = "AddnewSchool";
            this.Text = "AddnewSchool";
            this.NieuwschoolGroupBox.ResumeLayout(false);
            this.NieuwschoolGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NieuwschoolGroupBox;
        private System.Windows.Forms.Label SchoolnaamLB;
        private System.Windows.Forms.TextBox SchoolnaamTB;
        private System.Windows.Forms.TextBox PlaatsnaamTB;
        private System.Windows.Forms.Label SchoolpostcodeTB;
        private System.Windows.Forms.TextBox SchoolAdresTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}