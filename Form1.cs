using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciadorSTFolha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> MyList = new List<string>(Directory.EnumerateDirectories(Directory.GetCurrentDirectory()));

            List<string> sistemas = new List<string>();

            foreach(var elemento in MyList)
            {
                if(File.Exists(elemento + "\\STFolha.exe"))
                {
                    sistemas.Add(elemento);
                }
            }

            listBox1.DataSource = sistemas;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string executar = listBox1.Text;
            System.Diagnostics.Process.Start(executar + "\\STFolha.exe");

        }
    }
}
