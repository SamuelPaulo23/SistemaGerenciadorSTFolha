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


            string[] entries = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory(), "*.*", SearchOption.AllDirectories);

            /*string text = "";

            for(int i = 0; i < entries.Length; i++)
            {
                text = text + entries[i] + '\n';
            }

            MessageBox.Show(text, "oi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            //List<string> MyList = new List<string>();


            List<string> MyList = new List<string>(Directory.EnumerateDirectories(Directory.GetCurrentDirectory()));

            foreach (var txt in entries)
            {
                MyList.Add(txt);

            }

            listBox1.DataSource = MyList;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.GetItemText(listBox1.SelectedItem), "oi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
