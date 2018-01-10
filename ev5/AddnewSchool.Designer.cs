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
            this.NieuwschoolGroupBox.Location = new System.Drawing.Point(31, 17);
            this.NieuwschoolGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NieuwschoolGroupBox.Name = "NieuwschoolGroupBox";
            this.NieuwschoolGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NieuwschoolGroupBox.Size = new System.Drawing.Size(298, 234);
            this.NieuwschoolGroupBox.TabIndex = 17;
            this.NieuwschoolGroupBox.TabStop = false;
            this.NieuwschoolGroupBox.Text = "New School";
            // 
            // SchoolnaamLB
            // 
            this.SchoolnaamLB.AutoSize = true;
            this.SchoolnaamLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolnaamLB.Location = new System.Drawing.Point(55, 59);
            this.SchoolnaamLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SchoolnaamLB.Name = "SchoolnaamLB";
            this.SchoolnaamLB.Size = new System.Drawing.Size(86, 17);
            this.SchoolnaamLB.TabIndex = 14;
            this.SchoolnaamLB.Text = "Schoolnaam";
            // 
            // SchoolnaamTB
            // 
            this.SchoolnaamTB.Location = new System.Drawing.Point(58, 78);
            this.SchoolnaamTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SchoolnaamTB.Name = "SchoolnaamTB";
            this.SchoolnaamTB.Size = new System.Drawing.Size(177, 23);
            this.SchoolnaamTB.TabIndex = 0;
            // 
            // PlaatsnaamTB
            // 
            this.PlaatsnaamTB.Location = new System.Drawing.Point(58, 173);
            this.PlaatsnaamTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlaatsnaamTB.Name = "PlaatsnaamTB";
            this.PlaatsnaamTB.Size = new System.Drawing.Size(177, 23);
            this.PlaatsnaamTB.TabIndex = 2;
            // 
            // SchoolpostcodeTB
            // 
            this.SchoolpostcodeTB.AutoSize = true;
            this.SchoolpostcodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SchoolpostcodeTB.Location = new System.Drawing.Point(56, 102);
            this.SchoolpostcodeTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SchoolpostcodeTB.Name = "SchoolpostcodeTB";
            this.SchoolpostcodeTB.Size = new System.Drawing.Size(49, 17);
            this.SchoolpostcodeTB.TabIndex = 10;
            this.SchoolpostcodeTB.Text = "Adres:";
            // 
            // SchoolAdresTB
            // 
            this.SchoolAdresTB.Location = new System.Drawing.Point(58, 123);
            this.SchoolAdresTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SchoolAdresTB.Name = "SchoolAdresTB";
            this.SchoolAdresTB.Size = new System.Drawing.Size(177, 23);
            this.SchoolAdresTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Plaatsnaam:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add school";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddnewSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NieuwschoolGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddnewSchool";
            this.Text = "Nieuwe school toevoegen";
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