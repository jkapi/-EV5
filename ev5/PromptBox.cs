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
        public PromptBox(string message, string buttonText = "Ok", string placeholder = "")
        {
            InitializeComponent();
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
            this.Close();
            if (OnFinished != null)
            {
                OnFinished.Invoke(this, textBox1.Text);
            }
        }
    }
}
