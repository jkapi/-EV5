using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev5
{
    public class UserProject
    {
        private int userid;
        private int projectid;
        private string username = "geen gebruikersnaam";
        private string projectname;
        private DateTime uploaddate;
        private string content;

        public string Content
        {
            get { return content; }
        }

        public string Projectname
        {
            get { return projectname; }
        }

        public override string ToString()
        {
            return "gemaakt door: " + username +
                    "projectnaam: " + projectname + 
                    "uploaddatum: " + Convert.ToString(uploaddate);
        }

        public UserProject(int userid, int projectid, string projectname, DateTime uploaddate, string content)
        {
            this.userid = userid;
            this.projectid = projectid;
            this.projectname = projectname;
            this.uploaddate = uploaddate;
            this.content = content;
        }
    }
}
