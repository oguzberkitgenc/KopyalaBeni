using System;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KopyalaBeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\KopyalaBeni\DbCopy.accdb");
        private void button2_Click(object sender, EventArgs e) // timer1 start
        {
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e) // form açılış
        {
            //1 - Ş - Ü - İ - Ö - Ç - Ğ - 0 - O
            listData.Items.Add("abcdefg");
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
                    Console.Beep(1500, 125);
                    break;
                }
                else
                {
                    richTextBox1.ForeColor = Color.Black;
                }
            }
        }
        /// <summary>
        /// Hafızadaki değeri listData listesinde sorguluyor. Eğer varsa uyarı gönderir.
        /// </summary>
        void TekrarEngeller()
        {
            for (int i = 0; i < listData.Items.Count; i++)
            {
                string metin = Clipboard.GetText();
                string ara = listData.Items[i].ToString();
                int sonuc = metin.IndexOf(ara);
                if (sonuc >= 0)
                {
                    timer1.Stop();
                    Console.Beep(1500, 1000);
                    richTextBox1.BackColor = Color.FromArgb(252, 92, 101);
                    MessageBox.Show("Dikkatli Ol. Bu Kod Zaten Buralarda Mevcut", "İşini Düzgün Yap Beni Yorma Kanka", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                }
            }
        }
        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count - 1; // listbox adet -1
            string sondeger = listBox1.Items[adet].ToString(); // son değeri aldı
            string kopyalanan = Clipboard.GetText();
            if (sondeger != kopyalanan && kopyalanan != "")
            {
                say++;
                listBox1.Items.Add(kopyalanan);
                richTextBox1.Text += kopyalanan + "\n";
                KarakterBul();
                TekrarEngeller();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();

                listData.Items.Add(sondeger);
            }
        }
        private void button2_Click_1(object sender, EventArgs e) // timer 1 start
        {
            timer1.Start();
        }
        private void bTemizle_Click(object sender, EventArgs e) // temizle
        {
            DialogResult secenek = MessageBox.Show(" Hasss..\n Kodlar temizlenecek.\n Onay veriyor musun?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (secenek == DialogResult.Yes)
            {
                timer1.Stop();
                say = 0;
                listBox1.Items.Clear();
                listData.Items.Clear();
                listBox1.Items.Add("*/*/*/*");
                listBox1.Items.Add("----");
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Oh Tamam. İşlemi İptal Ettim", "Haberin Ola", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click_1(object sender, EventArgs e) // timer 1 stop
        {
            timer1.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            timer1.Start();
            richTextBox1.BackColor = Color.FromArgb(229, 205, 168);
        }
        private void BKarakterEkle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(TKarakter.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            KarakterBul();
            var satirSayisi = richTextBox1.Lines.Count();
            lSatirSayisi.Text = satirSayisi.ToString();
        }
        private void BCikar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void BData_Click(object sender, EventArgs e)
        {
            FData f = new FData();
            f.ShowDialog();
        }
    }
}
