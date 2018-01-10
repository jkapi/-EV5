using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev5
{
    class Project
    {
        private int projectid;
        private int userid;
        private string projectnaam;
        private string username;
        private DateTime uploaddate;
        private string inhoud;

        public string Inhoud
        {
            get { return inhoud; }
        }

        public override string ToString()
        {
            return "Projectnaam: " + projectnaam +
                    "\nGemaakt door: " + username +
                    "\nUpdloaddatum: " + Convert.ToString(uploaddate);
        }

        public Project(int projectid, int userid, string projectnaam, string username, DateTime uploaddate, string inhoud)
        {
            this.projectid = projectid;
            this.userid = userid;
            this.projectnaam = projectnaam;
            this.username = username;
            this.uploaddate = uploaddate;
            this.inhoud = inhoud;
        }
    }
}
