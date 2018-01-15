using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ev5
{
    sealed class File_handling
    {
        private string currentfile;
        private string initialpath;
        private static int projectnumber;

        public string Currentfile
        {
            set => currentfile = value;
        }

        public string OpenFile()
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Filter = "ev5 files (*.ev5)|*.ev5";
            openfile.InitialDirectory = initialpath;
            openfile.Title = "Open an ev5 project.";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                currentfile = openfile.FileName;
                
                try
                {
                    return File.ReadAllText(currentfile);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Bestand heeft niet het juiste formaat.");
                    return "#%";
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Bestand niet gevonden.");
                    return "#%";
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Applicatie heeft geen toegang tot de bestandsmap!");
                }
            }
            return "#%";
        }

        public void SaveFile(string commands)
        {
            try
            {
                if (!File.Exists(currentfile))
                {
                    SaveAs(commands);
                }
                else
                {
                    StreamWriter file = new StreamWriter(currentfile);

                    file.WriteLine(commands);

                    file.Close();
                    file.Dispose();
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Applicatie heeft geen toegang tot de bestandsmap!");
            }
        }

        public void SaveAs(string commands)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "ev5 files (*.ev5)|*.ev5";
            saveDialog.InitialDirectory = initialpath;
            saveDialog.FileName = "myproject" + Convert.ToString(projectnumber) + ".ev5";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                currentfile = saveDialog.FileName;

                StreamWriter file = new StreamWriter(currentfile);

                file.WriteLine(commands);

                file.Close();
                file.Dispose();

                ++projectnumber;
            }
        }

        private void CreateDirectory()
        {
            if (!Directory.Exists(initialpath))
            {
                Directory.CreateDirectory(initialpath);
            }
        }

        public File_handling()
        {
            currentfile = "";
            projectnumber = 1;
            initialpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ev5";
            CreateDirectory();
        }
    }
}
