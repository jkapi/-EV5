using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ev5
{
    public partial class UI : Form
    {
        public UI(string gebruikersnaam)
        {
            InitializeComponent();
            this.gebruikersnaam = gebruikersnaam;
        }

        private string gebruikersnaam;

        private List<Block> blocks = new List<Block>();

        BlockCollection collection = new BlockCollection();
        File_handling file = new File_handling();
        RP6Connection rp6 = new RP6Connection();

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            #region drawmenus
            Graphics g = CreateGraphics();

            Rectangle uppermenu = new Rectangle(0, 0, Width, 250);

            g.DrawRectangle(new Pen(Color.Aqua), uppermenu);
            g.FillRectangle(new SolidBrush(Color.FromArgb(18, 138, 174)), uppermenu);

            Rectangle submenu = new Rectangle(0, 250, Width, 75);

            g.DrawRectangle(new Pen(Color.LightGray), submenu);
            g.FillRectangle(new SolidBrush(Color.LightGray), submenu);

            LogoBox.BackColor = Color.FromArgb(18, 138, 174);
            HelpImage.BackColor = Color.FromArgb(18, 138, 174);

            Rectangle rect = new Rectangle(40, 550, Width - 80, 200);
            g.DrawRectangle(new Pen(Color.Black, 2), rect);

            g.Dispose();
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            // onderhoudt constant de rp6 connectie zonder de rest van de form controls in de weg te zitten
            Thread connectionthread = new Thread(new ThreadStart(rp6.Setup));
            connectionthread.IsBackground = true;
            connectionthread.Start();

            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].MouseHover += ObjHover;
            }

        }

        public void DeleteBlock(Block block)
        {
            blocks.Remove(block);
        }

        private void CompileButton_Click(object sender, EventArgs e)
        {
            // Stuur de blokjescode in een string door naar de rp6 via
            // seriele communicatie
            try
            {
                rp6.sPort.Write(collection.Compile());
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Rp6 not connected.");
            }
        }

        private void DecompileButton_Click(object sender, EventArgs e)
        {
            // in plaats van block.compile mee te geven als string moet hier natuurlijk de inhoud van een txt file of database
            // varchar meegegeven worden, maar die functionaliteit ontbreekt in deze solution
            // S.Decompile(Block.Compile(blocks));
        }

        private void Block_Click(object sender, EventArgs e)
        {
            // als er een blok wordt gesleept wordt deze event handler geblokkeerd, want anders kan er 
            // een blok in het standaardblok worden gezet waardoor de deleteknoppen niet meer gaan werken
            if (!Block.Dragging)
            {
                Block newblock;
                switch(((PictureBox)sender).Name)
                {
                    case "DisplayBlock": newblock = new Block(this, DisplayBlock, Blocktype.Disp); break;
                    case "MoveBlock": newblock = new Block(this, MoveBlock, Blocktype.Move); break;
                    case "BeepBlock": newblock = new Block(this, BeepBlock, Blocktype.Beep); break;
                    case "MoveuntilBlock": newblock = new Block(this, MoveuntilBlock, Blocktype.Umov); break;
                    case "SleepBlock": newblock = new Block(this, SleepBlock, Blocktype.Slep); break;
                    case "TurnBlock": newblock = new Block(this, TurnBlock, Blocktype.Turn); break;
                    default: throw new Exception("Invalid block sender");
                }
                blocks.Add(newblock);
                collection.AddBlock(newblock);
            }
        }

        private void SaveFileAsButton_Click(object sender, EventArgs e)
        {
            file.SaveAs(collection.Compile());
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            Decompile(file.OpenFile());
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            file.SaveFile(collection.Compile());
        }

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            // shortcut keys
            //
            //  Ctrl + S: save file
            //  Ctrl + Shift + S: save as
            //  Ctrl + O: open file
            //  Ctrl + N: new file
            if (e.KeyCode == Keys.S && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                file.SaveFile(collection.Compile());
            }
            if (e.KeyCode == Keys.O && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                Decompile(file.OpenFile());
            }
            if (e.KeyCode == Keys.N && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                DeleteAllBlocks();
                file.Currentfile = "";
            }
            if ((ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if ((ModifierKeys & Keys.Control) == Keys.Control)
                {
                    if (e.KeyCode == Keys.S)
                    {
                        file.SaveAs(collection.Compile());
                    }
                }
            }
            this.KeyPreview = true;
        }

        public void DeleteAllBlocks()
        {
            // verwijder alle blokken van de form
            foreach (Block block in blocks)
            {
                block.Delete();
            }
            blocks.Clear();
        }

        // zet een string om tot blokjescode
        // is niet in file handling of block klasse gezet
        // omdat alle pictureboxen anders als parameters mee moeten
        // worden gegeven, en dat is minder efficiënt
        private void Decompile(string command)
        {
            // reset de code environment
            DeleteAllBlocks();
            Thread.Sleep(100);
            command = command.Remove(0, 1);
            command = command.Remove(command.Length - 1, 1);

            while (command.Length > 0)
            {
                string parameter = "";

                try
                {
                    parameter = command.Substring(4, command.IndexOf('$') - 4);
                }
                catch (ArgumentException)
                {
                    // kijk of het bestand geldige ev5 code bevat
                    MessageBox.Show("File is not compatible.");
                    return;
                }

                Block block = null;

                // bepaal welk block moet worden toegevoegd
                switch (command.Substring(0, 4))
                {
                    case "Move":
                        block = new Block(this, MoveBlock, Blocktype.Move);
                        break;
                    case "Turn":
                        block = new Block(this, TurnBlock, Blocktype.Turn);
                        break;
                    case "Slep":
                        block = new Block(this, SleepBlock, Blocktype.Slep);
                        break;
                    case "Disp":
                        block = new Block(this, DisplayBlock, Blocktype.Disp);
                        break;
                    case "Beep":
                        block = new Block(this, BeepBlock, Blocktype.Beep);
                        break;
                    case "Umov":
                        block = new Block(this, MoveuntilBlock, Blocktype.Umov);
                        break;
                }
                if (block != null)
                {
                    // invoke de event handler voor click, zet de parameter,
                    // en voeg een juiste parameter toe
                    block.OnClick(block, new EventArgs());
                    block.SetParameter(parameter);
                    block.ResetPosition();
                    blocks.Add(block);
                }
                // verwijder het zojuist uitgelezen stuk code, 
                // zodat het programma niet oneindig hetzelfde
                // blok toevoegd.
                command = command.Remove(0, command.IndexOf('$') + 1);
            }
        }

        private void ObjHover(object sender, EventArgs e)
        {
            // zet de form control achter het gesleepte blok
            Control control = (Control)sender;

            control.SendToBack();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            // TODO: methode voor db maken
            PromptBox Givename = new PromptBox("Voer hier een naam voor je project in.");
            Givename.Show();
            Givename.OnFinished += Givename_OnFinished;  
        }

        private void Givename_OnFinished(object sender, string e)
        {
            string Projectnaam = e;
            int userid = Database.GetUserId(gebruikersnaam);
            DateTime thisDay = DateTime.Today;
            //thisDay.ToString
            Database.Upload(collection.Compile(), Projectnaam, ,userid);
        }

        private void HelpImage_Click(object sender, EventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.Show();
            help.FormClosed += Reshow;
            Hide();
        }

        private void Reshow(object a = null, object b = null)
        {
            Show();
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            rp6.Stop();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Downloadpage downloadpage = new Downloadpage(Searchbar.Text);
            downloadpage.Show();
        }
    }
}
