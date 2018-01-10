using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace ev5
{
    public sealed class Block
    {
        private static int blockcount = 0;
        private static bool dragging = false;
        private static List<int> dropnext = new List<int>();

        private UI form;
        private PictureBox box;
        private TextBox parameterbox;
        private Button deletebutton;
        private Blocktype type;

        private int id;
        private bool dropped = false;

        private Thread mousethread;



        public static bool Dragging
        {
            get { return dragging; }
        }

        public PictureBox Box
        {
            get { return box; }
        }

        public TextBox Parameterbox
        {
            get { return parameterbox; }
        }

        public Button Deletebutton
        {
            get { return deletebutton; }
        }

        public int Id
        {
            get { return id; }
        }



        // deze methode kan worden aangeroepen na het decompilen, omdat de blokken anders op de positiie van de muis belanden
        public void ResetPosition()
        {
            dragging = false;
            box.Location = new Point(id * 100 + 50, 600);
            parameterbox.Location = new Point(box.Location.X + 10, box.Location.Y + 70);
            deletebutton.Location = new Point(box.Location.X + 70, box.Location.Y);
        }

        // event handler voor een klik op de picturebox
        public void OnClick(object sender, EventArgs e)
        {
            dragging = false;
            dropped = true;

            // verwijder de handler van de click event van de picturebox
            box.Click -= OnClick;

            // zet de controls op de juiste positie
            box.Location = new Point(id * 100 + 50, 600);
            parameterbox.Location = new Point(box.Location.X + 10, box.Location.Y + 70);
            deletebutton.Location = new Point(box.Location.X + 70, box.Location.Y);
        }

        // verander de text van de parameter textbox
        public void SetParameter(string param)
        {
            parameterbox.Text = param;
        }

        // dit is de thread voor het updaten van de muis positie binnen het block control
        // nodig voor betrouwbaar slepen en de positie van het blok veranderen
        private void UpdateMouse()
        {            
            while (!dropped)
            {
                form.Invoke((MethodInvoker)delegate
                {
                    box.Location = new Point(Cursor.Position.X - 10, Cursor.Position.Y - 10);
                    parameterbox.Location = new Point(Cursor.Position.X, Cursor.Position.Y + 60);
                    deletebutton.Location = new Point(Cursor.Position.X + 60, Cursor.Position.Y - 10);
                });
                Thread.Sleep(10);

                /******************************************************************************************** *
                    SNELLERE CODE, MAAR CRAHST IN DEBUG MODUS  

                    box.Location = new Point(Cursor.Position.X - 10, Cursor.Position.Y - 10);
                    parameterbox.Location = new Point(Cursor.Position.X, Cursor.Position.Y + 60);
                    deletebutton.Location = new Point(Cursor.Position.X + 60, Cursor.Position.Y - 10);
                    Thread.Sleep(10);
               
               /**********************************************************************************************/
            }
            mousethread.Abort();
        }

        // als er op de delete knop wordt gedrukt wordt de delete methode van het juiste blok uitgevoerd
        private void DeleteClick(object sender, EventArgs e)
        {
            Delete();
        }

        // delete alle bijbehorende instanties van het blok van de form
        public void Delete()
        {
            form.Controls.Remove(box);
            form.Controls.Remove(parameterbox);
            form.Controls.Remove(deletebutton);

            box.Dispose();
            parameterbox.Dispose();
            deletebutton.Dispose();

            dropnext.Add(id);
            blockcount--;
        }

        public override string ToString()
        {
            return type.ToString() + parameterbox.Text + "$";
        }

        public Block (UI form, PictureBox origin, Blocktype type)
        {
            dragging = true;
            // bepaal het id door eerst te kijken of er onlangs blokken zijn verwijderd
            if (dropnext.Count > 0)
            {
                id = dropnext[0];
                dropnext.RemoveAt(0);
                blockcount++;
            }
            // zo niet wordt er een basic increment uitgevoerd
            else
            {
                id = blockcount++;
            }
            this.form = form;
            this.type = type;

            // opmaak en functionaliteit voor de form controls van het blok
            box = new PictureBox
            {
                BackColor = origin.BackColor,
                Width = origin.Width,
                Height = origin.Height,
            };
            box.Click += OnClick;

            parameterbox = new TextBox
            {
                BackColor = Color.White,
                Width = 80,
                Height = 20,
            };

            deletebutton = new Button
            {
                BackColor = Color.LightGray,
                Width = 30,
                Height = 30,
                Text = "X",
                ForeColor = Color.Red,
            };
            deletebutton.Click += DeleteClick;

            form.Controls.Add(parameterbox);
            form.Controls.Add(deletebutton);
            form.Controls.Add(box);

            // start met het volgen van de muis
            mousethread = new Thread(new ThreadStart(UpdateMouse));
            mousethread.IsBackground = true;

            mousethread.Start();
        }
    }
}
