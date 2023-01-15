using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimplisticInjector
{
    public partial class Main : Form
    {
        private static string FilePath;

        public Main()
        {
            InitializeComponent();
        }

        private void SelectDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileIn = new OpenFileDialog();
            FileIn.Filter = "dll |*.dll";
            if (FileIn.ShowDialog() == DialogResult.OK)
            {
                if (FileIn.SafeFileName.ToLower().EndsWith(".dll"))
                {
                    FilePath = FileIn.FileName;
                    FilePathLabel.Text = $"File Path: <b>{FilePath}</b>";
                    Properties.Settings.Default.DllPath = FilePath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("File did not end with .dll", "Simplistic");
                }
            }
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FilePath))
            {
                Utils.InjectDLL(FilePath);
            } else
            {
                MessageBox.Show("File was not selected");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DllPath))
            {
                FilePath = Properties.Settings.Default.DllPath;
                FilePathLabel.Text = $"File Path: <b>{FilePath}</b>";
            }
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/founderroni");
        }
    }
}
