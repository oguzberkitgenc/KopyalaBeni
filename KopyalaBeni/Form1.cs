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
        private void button2_Click(object sender, EventArgs e) // timer1 start
        {
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e) // form açılış
        {
            //1 - Ş - Ü - İ - Ö - Ç - Ğ - 0 - O
            listBox2.Items.Add("1");
            listBox2.Items.Add("Ş");
            listBox2.Items.Add("Ü");
            listBox2.Items.Add("İ");
            listBox2.Items.Add("Ö");
            listBox2.Items.Add("Ğ");
            listBox2.Items.Add("0");
            listBox2.Items.Add("O");

            listBox1.Visible = false;
            listBox1.Items.Add("*/*/*/*");
            listBox1.Items.Add("----");
        }
        int say = 0;
        void KarakterBul()
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string metin = richTextBox1.Text;
                string ara = listBox2.Items[i].ToString();
                int sonuc = metin.IndexOf(ara);
                if (sonuc >= 0)
                {
                    richTextBox1.ForeColor = Color.Red;
                    break;
                }
                else
                {
                    richTextBox1.ForeColor = Color.Black;
                }
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count - 1; // adet
            string sondeger = listBox1.Items[adet].ToString(); // son değeri aldı
            if (sondeger != Clipboard.GetText())
            {
                say++;
                listBox1.Items.Add(Clipboard.GetText());
                richTextBox1.Text += "\n" + Clipboard.GetText();
                //  KarakterBul();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }

        }

        private void button2_Click_1(object sender, EventArgs e) // timer 1 start
        {
            timer1.Start();
        }

        private void bTemizle_Click(object sender, EventArgs e) // temizle
        {
            DialogResult secenek = MessageBox.Show(" Kodlar temizlenecek. \n Onay veriyor musun?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (secenek == DialogResult.Yes)
            {
                timer1.Stop();
                say = 0;
                listBox1.Items.Clear();
                listBox1.Items.Add("*/*/*/*");
                listBox1.Items.Add("----");
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click_1(object sender, EventArgs e) // timer 1 stop
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        } // rictextbox siyah fore color
        private void BKarakterEkle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add(TKarakter.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            KarakterBul();
            var satirSayisi = richTextBox1.Lines.Count();
            lSatirSayisi.Text = "Satır Sayısı: "+satirSayisi.ToString();
        }

        private void BCikar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
