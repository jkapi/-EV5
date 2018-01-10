using System;
using System.Windows.Forms;

namespace ev5
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();

            HelpLabel.Text =  "MoveBlock: Beweeg de rp6 naar voren toe. Geef hierbij het aantal seconden dat de rp6 moet rijden mee. \n\n";
            HelpLabel.Text += "TurnBlock: Beweeg de rp6 een bepaald aantal graden. Geef hierbij het aantal graden om te draaien mee. \nnegatieve getallen gaan naar links en positieve getallen gaan naar rechts.\n\n";
            HelpLabel.Text += "SleepBlock: Laat de rp6 een aantal seconden slapen. Geef hierbij het aantal seconden dat de code moet wachten mee.\n\n";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();        
        }
    }
}
