using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev5
{
    public partial class PromptBox : Form
    {
        private Label label1;
        private Button button1;
        private TextBox textBox1;

        public PromptBox()
        {
            InitializeComponent();
        }

        public PromptBox(string message, string buttonText = "Ok", string placeholder = "")
        {
            InitializeComponent();
            AcceptButton = button1;
            label1.Text = message;
            button1.Text = buttonText;
            textBox1.Text = placeholder;
            this.Show();
            textBox1.Focus();
        }

        /// <summary>
        /// Returns the text of the textbox when the button is pressed
        /// </summary>
        public event EventHandler<string> OnFinished;

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(158, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PromptBox
            // 
            this.ClientSize = new System.Drawing.Size(554, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "PromptBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (OnFinished != null)
            {
                OnFinished.Invoke(this, textBox1.Text);
            }
            this.Close();
        }
    }
}
