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
    public partial class AddnewSchool : Form
    {
        public AddnewSchool()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string schoolnaam = SchoolnaamTB.Text;
            string adres = SchoolAdresTB.Text;
            string plaats = PlaatsnaamTB.Text;

            Database.SetSchool(schoolnaam, adres, plaats);
            this.Close();
        }
    }
}
