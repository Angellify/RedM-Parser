using System.ComponentModel;
using ParserLibrary;
using RedMParser.Properties;

namespace RDRPParser
{
    public partial class Parser : Form
    {
        private BindingList<string> log;



        private string redmPath
        {
            get { return logPath.Text; }
            set { logPath.Text = value; }
        }

        private string logsSavePath
        {
            get { return savePath.Text; }
            set { savePath.Text = value; }
        }


        public Parser()
        {
            InitializeComponent();
            HideInfo();

            Settings.Default.DefaultLogPath = PathClass.GetInitialPath(redmPath);
            redmPath = Settings.Default.DefaultSavePath;
            logsSavePath = Settings.Default.DefaultLogPath;

        }



        private void OnSearchClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "SearchRedmPathButton")
                GetRedmPath();
            else if (button.Name == "SearchSavePathButton")
                GetSavePath();




        }

        private void GetRedmPath()
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (Directory.Exists(openFileDialog.SelectedPath))
                {
                    redmPath = openFileDialog.SelectedPath;
                    Settings.Default.DefaultLogPath = openFileDialog.SelectedPath;
                    Settings.Default.Save();
                }
            }

        }
        private void GetSavePath()
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.DefaultSavePath = openFileDialog.SelectedPath;
                logsSavePath = Settings.Default.DefaultSavePath;
                Settings.Default.Save();
            }

        }


        private void OnParseClick(object sender, EventArgs e)
        {

            if (redmPath == String.Empty || !PathClass.bHasRightPath(redmPath))
            {
                MessageBox.Show(@"No directory specified for RedM logs", "Error: Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetRedmPath();
                return;
            }

            if (logsSavePath == String.Empty)
            {
                MessageBox.Show(@"No directory specified for saving logs", "Error: Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetSavePath();
                return;
            }

            else if (logsSavePath != String.Empty)
            {
                log = ParserClass.ParseLog(redmPath);

                foreach (string line in log)
                {
                    if (!logText.Items.Contains(line))
                        logText.Items.Add(line);
                }

                OnParsedLog();
            }




        }

        private void OnParsedLog()
        {

            string fileName = DateTime.Now.ToString("MMMM");
            string logName = DateTime.Now.ToString("D");
            string pathToFolder = Path.Combine(logsSavePath, fileName);
            string sessionTag = ParserClass.GetSessionTag(redmPath);
            string pathToLog = Path.Combine(pathToFolder, $"{logName + sessionTag}.txt");
            Directory.CreateDirectory(pathToFolder);

            if (!File.Exists(pathToLog))
            {
                // Create a file to write to.
                StreamWriter sw = File.CreateText(pathToLog);
                foreach (var line in log)
                {
                    sw.WriteLine(line.ToString());
                }
                sw.Close();


            }

            else
                File.WriteAllLines(pathToLog, log);



        }

        private void ShowInfo(object sender, EventArgs e)
        {
            infoLabel.Show();
            infoLabel2.Show();

        }

        private void HideInfo()
        {
            infoLabel.Hide();
            infoLabel2.Hide();


        }

        private void HideInfo(object sender, EventArgs e)
        {
            infoLabel.Hide();
            infoLabel2.Hide();


        }

        private void OnMinimizeForm(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}