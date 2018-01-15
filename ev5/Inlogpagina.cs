using System;
using System.Windows.Forms;

namespace ev5
{
    public partial class Inlogpagina : Form
    {
        public Inlogpagina()
        {
            InitializeComponent();
            AcceptButton = LoginBttn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text;
            string wachtwoord = WachtwoordTB.Text;
            //Kijkt of de username/wachtoord velden niet leeg zijn
            if (username != "" && wachtwoord != "")
            {
                //Vraagt het wachtoord op bij de opgegeven username 
                //en kijkt of deze het zelfde is als het gegeven wachtwoord
                if (Database.Getpassword(username) == wachtwoord)
                {
                    //verschuilt dit form en maakt een nieuwe aan
                    //UI userinterface = new UI(username);
                    //userinterface.Show();
                    //userinterface.FormClosed += UIClosed;
                    Hide();
                }
                else
                {
                    WachtwoordTB.Text = "";
                    MessageBox.Show("Combinatie Username en Password incorrect");
                }
            }
            else
            {
                MessageBox.Show("In een of meerdere velden geen waarde ingevoerd");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UIClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newAccount MakeNewAccount = new newAccount();
            MakeNewAccount.Show();
            MakeNewAccount.FormClosed += Reshow;
            this.Hide();
        }

        private void Reshow(object a = null, object b = null)
        {
            Show();
        }
    }
}
