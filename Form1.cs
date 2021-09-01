using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciadorSTFolha
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hwnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Util.ProcuraSTFolha(Directory.GetCurrentDirectory());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string executar = listBox1.Text;
            System.Diagnostics.Process.Start(executar + "\\STFolha.exe");

            Thread.Sleep(1000);

            var proc = Process.GetProcessesByName("STFolha").FirstOrDefault();
            if (proc != null)
            {
                string senha = Util.SenhaDoDia();
                var handle = proc.MainWindowHandle;
                SetForegroundWindow(handle);
                SendKeys.SendWait("0");
                SendKeys.SendWait("{TAB}");
                SendKeys.SendWait(senha);
                SendKeys.SendWait("{ENTER}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Util.ProcuraSTFolha(Directory.GetCurrentDirectory());
        }
    }
}
