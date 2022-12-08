using DevExpress.Data.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KopyalaBeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            listBox1.Items.Add("*/*/*/*");
            listBox1.Items.Add("----");
        }

        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count - 1; // adet
            string sondeger = listBox1.Items[adet].ToString(); // son değeri aldı

            if (sondeger != Clipboard.GetText())
            {
                say++;
                listBox1.Items.Add(Clipboard.GetText());
                richTextBox1.Text += "\n" + say + " -" + (Clipboard.GetText());
            }

        }
        private void listBox1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
