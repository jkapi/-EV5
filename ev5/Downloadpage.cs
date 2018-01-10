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
    public partial class Downloadpage : Form
    {
        public Downloadpage()
        {
            InitializeComponent();
        }

        public Downloadpage(string searchcommand)
        {
            this.searchcommand = searchcommand;
        }

        private string searchcommand;

        private void Downloadpage_Load(object sender, EventArgs e)
        {
            List<UserProject> projects = Database.SearchProjects(searchcommand);

            foreach (UserProject project in projects)
            {
                Projectbox.Items.Add(project);
            }
        }
    }
}
