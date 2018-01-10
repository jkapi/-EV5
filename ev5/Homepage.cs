using System;
using System.Windows.Forms;

namespace ev5
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            foreach(string project in Database.allprojectslist)
            {
                listBox1.Items.Add(project);
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
