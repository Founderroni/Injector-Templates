using System;
using System.IO;
using System.Windows.Forms;
using KekKinjector.Handlers;

namespace KekKinjector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            RPC.ClearRpc();
            Dispose();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kek Client by Xello\nInjector by Founder", "Credits");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RPC.StartRpc("Kek.Club+ Client", "Kek.Club+ Destroying Hive!");
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            if (!File.Exists($@"{Directory.GetCurrentDirectory()}\Kek.dll"))
            {
                MessageBox.Show("Kek.dll not found in Injector directory", "Could not find DLL");
                return;
            }

            Injection.InjectDLL($@"{Directory.GetCurrentDirectory()}\Kek.dll");
        }
    }
}
