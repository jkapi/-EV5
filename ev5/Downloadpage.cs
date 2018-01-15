using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ev5
{
    public partial class Downloadpage : Form
    {

        private string searchcommand;
        public Downloadpage()
        {
            this.searchcommand = "";
            InitializeComponent();
        }

        public Downloadpage(string searchcommand)
        {
            this.searchcommand = searchcommand;
            InitializeComponent();
        }

        private void Downloadpage_Load(object sender, EventArgs e)
        {
            ShowProjects();
        }

        public event EventHandler<UserProject> SelectedProject;

        private void Projectbox_DoubleClick(object sender, MouseEventArgs e)
        {
            UserProject project = (UserProject)Projectbox.SelectedItem;
            Close();
        }

        private void ShowProjects()
        {
            Projectbox.Items.Clear();
            List<UserProject> projects = Database.SearchProjects(searchcommand);

            foreach (UserProject project in projects)
            {
                Projectbox.Items.Add(project);
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchcommand = textBox1.Text;
            ShowProjects();
        }
    }
}
