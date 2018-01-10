using System.Collections.Generic;
using System.Windows.Forms;

namespace ev5
{
    public partial class Downloadpage : Form
    {
        public Downloadpage()
        {
            InitializeComponent();
        }

        public Downloadpage(string searchcommand)
        {
            InitializeComponent();

            this.searchcommand = searchcommand;

            List<UserProject> projects = Database.SearchProjects(searchcommand);

            foreach (UserProject project in projects)
            {
                Projectbox.Items.Add(project.ToString());
            }
        }

        private string searchcommand;

        private void Projectbox_Doubleclick(object sender, MouseEventArgs e)
        {
            UserProject project = (UserProject)Projectbox.SelectedItem;
            UI window = new UI(project.Projectname, project.Content);
            window.Show();
            Close();
        }
    }
}
