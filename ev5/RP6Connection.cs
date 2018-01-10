using System;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace ev5
{
    sealed class RP6Connection
    {
        public SerialPort sPort;
        private bool connected;
        private int portnumber = 0;

        public bool Connected
        {
            get { return connected; }
        }

        public void Setup()
        {
            // rp6 instantie blijft constant naar een 
            // connectie zoeken en die ook onderhouden
            while (true)
            {
                // blijf zoeken tot een verbinding tot
                // stand is gebracht
                while (connected == false)
                {
                    // reset het poortnummer als het getal te hoog wordt
                    if (portnumber > 10)
                    {
                        portnumber = 0;
                    }
                    try
                    {
                        // probeer te verbinden
                        sPort = new SerialPort("COM" + portnumber, 38400, Parity.None, 8, StopBits.One);
                        sPort.Open();
                        connected = true;
                        MessageBox.Show("RP6 is verbonden met COM" + portnumber);
                    }
                    catch (System.IO.IOException)
                    {
                        portnumber++;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        portnumber++;
                    }
                    catch (StackOverflowException)
                    {
                        // het komt waarschijnlijk niet tot hier, maar deze exception is geïmplementeerd voor veiligheid
                        MessageBox.Show("Kon geen connectie maken.. sluit de applicatie a.u.b. opnieuw op en probeer opnieuw.");
                        break;
                    }
                    finally
                    {
                        // om de cpu niet te stressen
                        Thread.Sleep(100);
                    }
                }
                // kijk of de compoort is gesloten
                if (!sPort.IsOpen)
                {
                    connected = false;
                }
                Thread.Sleep(1000);
            }
        }

        public RP6Connection()
        {
            sPort = null;
            connected = false;
        }
    }
}
