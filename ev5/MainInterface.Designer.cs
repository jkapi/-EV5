namespace ev5
{
    partial class MainInterface
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panelUI = new System.Windows.Forms.Panel();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.buttonFileSaveAs = new System.Windows.Forms.Button();
            this.buttonFileNew = new System.Windows.Forms.Button();
            this.buttonFileSave = new System.Windows.Forms.Button();
            this.pictureBoxEV5 = new System.Windows.Forms.PictureBox();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControlBlocks = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.blockChooseStop = new ev5.Block();
            this.blockChooseDraai = new ev5.Block();
            this.blockChooseRij = new ev5.Block();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.block5 = new ev5.Block();
            this.block4 = new ev5.Block();
            this.blockChooseWacht = new ev5.Block();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.blockChooseBeep = new ev5.Block();
            this.blockChooseDisplay = new ev5.Block();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.block3 = new ev5.Block();
            this.block2 = new ev5.Block();
            this.block1 = new ev5.Block();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.panelUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEV5)).BeginInit();
            this.tabControlBlocks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 33;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panelUI
            // 
            this.panelUI.Controls.Add(this.buttonDownload);
            this.panelUI.Controls.Add(this.buttonCompile);
            this.panelUI.Controls.Add(this.buttonFileSaveAs);
            this.panelUI.Controls.Add(this.buttonFileNew);
            this.panelUI.Controls.Add(this.buttonFileSave);
            this.panelUI.Controls.Add(this.pictureBoxEV5);
            this.panelUI.Controls.Add(this.buttonFileOpen);
            this.panelUI.Controls.Add(this.button3);
            this.panelUI.Controls.Add(this.tabControlBlocks);
            this.panelUI.Location = new System.Drawing.Point(0, 199);
            this.panelUI.Name = "panelUI";
            this.panelUI.Size = new System.Drawing.Size(955, 320);
            this.panelUI.TabIndex = 3;
            // 
            // buttonCompile
            // 
            this.buttonCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompile.Location = new System.Drawing.Point(597, 277);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(111, 40);
            this.buttonCompile.TabIndex = 9;
            this.buttonCompile.Text = "Compile";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // buttonFileSaveAs
            // 
            this.buttonFileSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFileSaveAs.Location = new System.Drawing.Point(472, 277);
            this.buttonFileSaveAs.Name = "buttonFileSaveAs";
            this.buttonFileSaveAs.Size = new System.Drawing.Size(119, 40);
            this.buttonFileSaveAs.TabIndex = 8;
            this.buttonFileSaveAs.Text = "Opslaan Als";
            this.buttonFileSaveAs.UseVisualStyleBackColor = true;
            this.buttonFileSaveAs.Click += new System.EventHandler(this.buttonFileSaveAs_Click);
            // 
            // buttonFileNew
            // 
            this.buttonFileNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFileNew.Location = new System.Drawing.Point(4, 277);
            this.buttonFileNew.Name = "buttonFileNew";
            this.buttonFileNew.Size = new System.Drawing.Size(111, 40);
            this.buttonFileNew.TabIndex = 7;
            this.buttonFileNew.Text = "Nieuw";
            this.buttonFileNew.UseVisualStyleBackColor = true;
            this.buttonFileNew.Click += new System.EventHandler(this.buttonFileNew_Click);
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFileSave.Location = new System.Drawing.Point(355, 277);
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(111, 40);
            this.buttonFileSave.TabIndex = 6;
            this.buttonFileSave.Text = "Opslaan";
            this.buttonFileSave.UseVisualStyleBackColor = true;
            this.buttonFileSave.Click += new System.EventHandler(this.buttonFileSave_Click);
            // 
            // pictureBoxEV5
            // 
            this.pictureBoxEV5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEV5.BackgroundImage = global::ev5.Properties.Resources.EV5Transparent;
            this.pictureBoxEV5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEV5.Location = new System.Drawing.Point(863, 222);
            this.pictureBoxEV5.Name = "pictureBoxEV5";
            this.pictureBoxEV5.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxEV5.TabIndex = 5;
            this.pictureBoxEV5.TabStop = false;
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFileOpen.Location = new System.Drawing.Point(121, 277);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(111, 40);
            this.buttonFileOpen.TabIndex = 4;
            this.buttonFileOpen.Text = "Open";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabControlBlocks
            // 
            this.tabControlBlocks.Controls.Add(this.tabPage1);
            this.tabControlBlocks.Controls.Add(this.tabPage2);
            this.tabControlBlocks.Controls.Add(this.tabPage4);
            this.tabControlBlocks.Controls.Add(this.tabPage3);
            this.tabControlBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBlocks.Location = new System.Drawing.Point(0, 0);
            this.tabControlBlocks.Name = "tabControlBlocks";
            this.tabControlBlocks.SelectedIndex = 0;
            this.tabControlBlocks.Size = new System.Drawing.Size(949, 220);
            this.tabControlBlocks.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.blockChooseStop);
            this.tabPage1.Controls.Add(this.blockChooseDraai);
            this.tabPage1.Controls.Add(this.blockChooseRij);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bewegen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // blockChooseStop
            // 
            this.blockChooseStop.BackColor = System.Drawing.Color.Red;
            this.blockChooseStop.Location = new System.Drawing.Point(265, 15);
            this.blockChooseStop.Margin = new System.Windows.Forms.Padding(4);
            this.blockChooseStop.Name = "blockChooseStop";
            this.blockChooseStop.Size = new System.Drawing.Size(120, 160);
            this.blockChooseStop.TabIndex = 3;
            this.blockChooseStop.Type = ev5.Blocktype.Stop;
            this.blockChooseStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // blockChooseDraai
            // 
            this.blockChooseDraai.BackColor = System.Drawing.Color.Aqua;
            this.blockChooseDraai.Location = new System.Drawing.Point(137, 15);
            this.blockChooseDraai.Margin = new System.Windows.Forms.Padding(4);
            this.blockChooseDraai.Name = "blockChooseDraai";
            this.blockChooseDraai.Size = new System.Drawing.Size(120, 160);
            this.blockChooseDraai.TabIndex = 2;
            this.blockChooseDraai.Type = ev5.Blocktype.Turn;
            this.blockChooseDraai.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // blockChooseRij
            // 
            this.blockChooseRij.BackColor = System.Drawing.Color.Green;
            this.blockChooseRij.Location = new System.Drawing.Point(9, 15);
            this.blockChooseRij.Margin = new System.Windows.Forms.Padding(4);
            this.blockChooseRij.Name = "blockChooseRij";
            this.blockChooseRij.Size = new System.Drawing.Size(120, 160);
            this.blockChooseRij.TabIndex = 1;
            this.blockChooseRij.Type = ev5.Blocktype.Move;
            this.blockChooseRij.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.block5);
            this.tabPage2.Controls.Add(this.block4);
            this.tabPage2.Controls.Add(this.blockChooseWacht);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flow";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.DarkMagenta;
            this.block5.Location = new System.Drawing.Point(265, 15);
            this.block5.Margin = new System.Windows.Forms.Padding(4);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(120, 160);
            this.block5.TabIndex = 2;
            this.block5.Type = ev5.Blocktype.GotoIf;
            this.block5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.Magenta;
            this.block4.Location = new System.Drawing.Point(137, 15);
            this.block4.Margin = new System.Windows.Forms.Padding(4);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(120, 160);
            this.block4.TabIndex = 1;
            this.block4.Type = ev5.Blocktype.Goto;
            this.block4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // blockChooseWacht
            // 
            this.blockChooseWacht.BackColor = System.Drawing.Color.Yellow;
            this.blockChooseWacht.Location = new System.Drawing.Point(9, 15);
            this.blockChooseWacht.Margin = new System.Windows.Forms.Padding(4);
            this.blockChooseWacht.Name = "blockChooseWacht";
            this.blockChooseWacht.Size = new System.Drawing.Size(120, 160);
            this.blockChooseWacht.TabIndex = 0;
            this.blockChooseWacht.Type = ev5.Blocktype.Wait;
            this.blockChooseWacht.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.blockChooseBeep);
            this.tabPage4.Controls.Add(this.blockChooseDisplay);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(941, 189);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Overig";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // blockChooseBeep
            // 
            this.blockChooseBeep.BackColor = System.Drawing.Color.BlueViolet;
            this.blockChooseBeep.Location = new System.Drawing.Point(137, 15);
            this.blockChooseBeep.Margin = new System.Windows.Forms.Padding(4);
            this.blockChooseBeep.Name = "blockChooseBeep";
            this.blockChooseBeep.Size = new System.Drawing.Size(120, 160);
            this.blockChooseBeep.TabIndex = 1;
            this.blockChooseBeep.Type = ev5.Blocktype.Beep;
            this.blockChooseBeep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // blockChooseDisplay
            // 
            this.blockChooseDisplay.BackColor = System.Drawing.Color.LimeGreen;
            this.blockChooseDisplay.Location = new System.Drawing.Point(9, 15);
            this.blockChooseDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.blockChooseDisplay.Name = "blockChooseDisplay";
            this.blockChooseDisplay.Size = new System.Drawing.Size(120, 160);
            this.blockChooseDisplay.TabIndex = 0;
            this.blockChooseDisplay.Type = ev5.Blocktype.Disp;
            this.blockChooseDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.block3);
            this.tabPage3.Controls.Add(this.block2);
            this.tabPage3.Controls.Add(this.block1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(941, 189);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Variabelen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.OrangeRed;
            this.block3.Location = new System.Drawing.Point(265, 15);
            this.block3.Margin = new System.Windows.Forms.Padding(4);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(120, 160);
            this.block3.TabIndex = 2;
            this.block3.Type = ev5.Blocktype.Sub;
            this.block3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Khaki;
            this.block2.Location = new System.Drawing.Point(137, 15);
            this.block2.Margin = new System.Windows.Forms.Padding(4);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(120, 160);
            this.block2.TabIndex = 1;
            this.block2.Type = ev5.Blocktype.Add;
            this.block2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Orange;
            this.block1.Location = new System.Drawing.Point(9, 15);
            this.block1.Margin = new System.Windows.Forms.Padding(4);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(120, 160);
            this.block1.TabIndex = 0;
            this.block1.Type = ev5.Blocktype.Var;
            this.block1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blockChoose_MouseDown);
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.Transparent;
            this.panelWorkspace.BackgroundImage = global::ev5.Properties.Resources.blueprintbackltbig;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 0);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(1223, 129);
            this.panelWorkspace.TabIndex = 2;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.Location = new System.Drawing.Point(238, 277);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(111, 40);
            this.buttonDownload.TabIndex = 10;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ev5.Properties.Resources.blueprintbackltbig;
            this.ClientSize = new System.Drawing.Size(1221, 542);
            this.Controls.Add(this.panelUI);
            this.Controls.Add(this.panelWorkspace);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainInterface_KeyDown);
            this.panelUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEV5)).EndInit();
            this.tabControlBlocks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel panelUI;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControlBlocks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.PictureBox pictureBoxEV5;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.Button buttonFileSaveAs;
        private System.Windows.Forms.Button buttonFileNew;
        private System.Windows.Forms.Button buttonFileSave;
        private Block blockChooseRij;
        private Block blockChooseDraai;
        private Block blockChooseWacht;
        private Block blockChooseStop;
        private System.Windows.Forms.TabPage tabPage4;
        private Block blockChooseBeep;
        private Block blockChooseDisplay;
        private System.Windows.Forms.TabPage tabPage3;
        private Block block1;
        private Block block3;
        private Block block2;
        private Block block5;
        private Block block4;
        private System.Windows.Forms.Button buttonDownload;
    }
}