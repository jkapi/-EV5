using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev5
{
    /// <summary>
    /// Block class
    /// Currently everything is handled in one class because I couldn't be bothered to make an abstact class
    /// and copy even more code than is used here.
    /// </summary>
    public partial class Block : UserControl
    {
        public List<string> Parameters
        {
            get
            {
                return new List<string> { comboBox1.Text, comboBox2.Text};
            }
        }

        public Blocktype Type { get; set; }
        /// <summary>
        /// Block initializer for demo blocks.
        /// Blocks called from forms use this constructor and set the blocktype above here accordingly.
        /// That's why the SetType function is called from the Load function
        /// </summary>
        public Block()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
        }
        public Block(Blocktype blocktype, bool demo = false)
        {
            InitializeComponent();
            Type = blocktype;
            if (demo)
            {
                label1.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
        }

        public void SetParameter(int parameter, string value)
        {
            switch(parameter)
            {
                case 1: comboBox1.Text = value; break;
                case 2: comboBox2.Text = value; break;
                default: throw new Exception("Tried to write to non-existing parameter");
            }
        }

        private void SetType(Blocktype blocktype)
        {
            this.Type = blocktype;
            if (this.Type == Blocktype.Wait || this.Type == Blocktype.Goto || 
                this.Type == Blocktype.Move || this.Type == Blocktype.Stop ||
                this.Type == Blocktype.Disp)
            {
                comboBox2.Visible = false;
                label2.Visible = false;
            }
            // Set Labels and background color
            switch (this.Type)
            {
                case Blocktype.Move: labelBlockType.Text = "Rij"; label1.Text = "Snelheid:"; this.BackColor = Color.Green; break;
                case Blocktype.Turn: labelBlockType.Text = "Draai"; label1.Text = "Richting:"; label2.Text = "Graden:"; this.BackColor = Color.Aqua; break;
                case Blocktype.Stop: labelBlockType.Text = "Stop"; label1.Visible = false; comboBox1.Visible = false; this.BackColor = Color.Red; break;
                case Blocktype.Wait: labelBlockType.Text = "Wacht"; label1.Text = "Lengte (ms):"; this.BackColor = Color.Yellow; break;
                case Blocktype.Beep: labelBlockType.Text = "Beep"; label1.Text = "Toon:"; label2.Text = "Lengte (ms):"; this.BackColor = Color.BlueViolet; break;
                case Blocktype.Disp: labelBlockType.Text = "Scrijf"; label1.Text = "Tekst:"; this.BackColor = Color.LimeGreen; break;
                case Blocktype.Var: labelBlockType.Text = "Variabele"; label1.Text = "Variabele:"; label2.Text = "Waarde:"; this.BackColor = Color.Orange; break;
                case Blocktype.Add: labelBlockType.Text = "Plus"; label1.Text = "Variabele:"; label2.Text = "Waarde:"; this.BackColor = Color.Khaki; break;
                case Blocktype.Sub: labelBlockType.Text = "Min"; label1.Text = "Variabele:"; label2.Text = "Waarde:"; this.BackColor = Color.OrangeRed; break;
                case Blocktype.Goto: labelBlockType.Text = "Ga naar"; label1.Text = "Blok:"; this.BackColor = Color.Magenta; break;
                case Blocktype.GotoIf: labelBlockType.Text = "Ga naar als"; label1.Text = "Blok:"; label2.Text = "Conditie"; this.BackColor = Color.DarkMagenta; break;
            }
            // Set Combo Types and values
            switch(this.Type)
            {
                case Blocktype.Turn: comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; comboBox1.Items.AddRange(new string[] { "Rechts", "Links"}); comboBox1.Text = "Rechts"; break;
                case Blocktype.Beep: comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; comboBox1.Items.AddRange(new string[] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "G", "G#" }); comboBox1.Text = "C"; break;
            }
        }

        private void Block_Load(object sender, EventArgs e)
        {
            SetType(Type);
        }
        
        /// <summary>
        /// Kijk of de variabele in comboBox1 klopt.
        /// Maakt de achtergrond van comboBox1 rood als er iets fout is
        /// </summary>
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            bool valueParsable = true;
            switch (Type)
            {
                case Blocktype.Disp:
                    if (comboBox1.Text.Length > 15) { valueParsable = false; } break;
                case Blocktype.Move:
                    if (!ExistingVariable(comboBox1.Text, -255, 255)) { valueParsable = false; } break;
                case Blocktype.Goto:
                case Blocktype.GotoIf:
                    if (!ExistingVariable(comboBox1.Text, 0, Compiler.BlockCount, false)) { valueParsable = false; }
                    break;
                case Blocktype.Wait:
                    if (!ExistingVariable(comboBox1.Text, 0, 65530)) { valueParsable = false; } break;
                case Blocktype.Add:
                case Blocktype.Sub:
                    if (!ExistingVariable(comboBox1.Text)) { valueParsable = false; } break;
            }
            if (valueParsable)
            {
                comboBox1.BackColor = Color.White;
            }
            else
            {
                comboBox1.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Kijk of de variabele in comboBox2 klopt.
        /// Maakt de achtergrond van comboBox2 rood als er iets fout is
        /// </summary>
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            bool valueParsable = true;
            switch (Type)
            {
                case Blocktype.Beep:
                case Blocktype.Turn:
                    if (!ExistingVariable(comboBox2.Text, 0, 65530)) { valueParsable = false; }
                    break;
                case Blocktype.Add:
                case Blocktype.Sub:
                    if (!ExistingVariable(comboBox2.Text, -65530, 65530)) { valueParsable = false; }
                    break;

            }
            if (valueParsable)
            {
                comboBox2.BackColor = Color.White;
            }
            else
            {
                comboBox2.BackColor = Color.Red;
            }
        }

        private bool ExistingVariable(string text, int minvalue, int maxvalue, bool canbeVariable = true)
        {
            if (int.TryParse(text, out int value))
            {
                if (value >= minvalue && value <= maxvalue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string variablename = text.ToLower().Trim();
                if (Compiler.GetGlobalVariables().Exists(name => name.Equals(variablename)) && canbeVariable) // And if it actually is an variable, do as told!
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool ExistingVariable(string text)
        {
            string variablename = text.ToLower().Trim();
            if (Compiler.GetGlobalVariables().Exists(name => name.Equals(variablename))) // And if it actually is an variable, do as told!
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
