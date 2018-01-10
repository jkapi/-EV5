using System;
using System.Windows.Forms;

namespace ev5
{
    public partial class newAccount : Form
    {
        public newAccount()
        {
            InitializeComponent();
            SchoolComboBox.Items.Clear();
            Database.Getschoolen();
            foreach (string school in Database.GeefAlleScholen)
            {
                SchoolComboBox.Items.Add(school);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string School;
            try
            {
                School = SchoolComboBox.SelectedItem.ToString();
            }
            catch(System.NullReferenceException)
            {
                School = "";
            }

            string username = NewUsernameTB.Text;
            string wachtwoord = NewWachtwoordTB.Text;

            string Voornaam = VoornaamTB.Text;
            string Tussenvoegsel = TussenvoegselTB.Text;
            string Achternaam = AchternaamTB.Text;
            if (Voornaam != "" && Achternaam != "" && username != "" && wachtwoord != "")
            {
                Database.CreateUser(username, wachtwoord);
                int id = Database.GetUserId(username);
                Database.SetName(id, Voornaam, Tussenvoegsel, Achternaam);

                string email = EmailTB.Text;
                Database.Setgebruiker(id, email, School);

                UI userinterface = new UI();
                userinterface.Show();
                Close();
            }
            else
            {
                MessageBox.Show("An field is empty, please fill in all needed boxes.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddnewSchool newschool = new AddnewSchool();
            newschool.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SchoolComboBox.Items.Clear();
            Database.Getschoolen();
            foreach (string school in Database.GeefAlleScholen)
            {
                SchoolComboBox.Items.Add(school);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
