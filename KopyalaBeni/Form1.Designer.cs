namespace KopyalaBeni
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listData = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lSatirSayisi = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BCikar = new System.Windows.Forms.Button();
            this.BKarakterEkle = new System.Windows.Forms.Button();
            this.TKarakter = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.BGrupAyarlari = new System.Windows.Forms.Button();
            this.BSat = new System.Windows.Forms.Button();
            this.ListPaket = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(566, 505);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(323, 505);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(205)))), ((int)(((byte)(168)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 429);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listData);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lSatirSayisi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 429);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 76);
            this.panel3.TabIndex = 9;
            // 
            // listData
            // 
            this.listData.FormattingEnabled = true;
            this.listData.Location = new System.Drawing.Point(311, 6);
            this.listData.Margin = new System.Windows.Forms.Padding(2);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(10, 17);
            this.listData.TabIndex = 2;
            this.listData.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Kod:";
            // 
            // lSatirSayisi
            // 
            this.lSatirSayisi.AutoSize = true;
            this.lSatirSayisi.Font = new System.Drawing.Font("ITC Avant Garde Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSatirSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(203)))), ((int)(((byte)(56)))));
            this.lSatirSayisi.Location = new System.Drawing.Point(131, 6);
            this.lSatirSayisi.Name = "lSatirSayisi";
            this.lSatirSayisi.Size = new System.Drawing.Size(52, 57);
            this.lSatirSayisi.TabIndex = 0;
            this.lSatirSayisi.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 505);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bTemizle, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 202);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gothamic", 12F);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(0, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 101);
            this.button3.TabIndex = 13;
            this.button3.Text = "HATALI VEYA MÜKERRER KODU SİLDİM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gothamic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::KopyalaBeni.Properties.Resources.icons8_start;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 101);
            this.button2.TabIndex = 9;
            this.button2.Text = "Başlat";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gothamic", 12F);
            this.button1.Image = global::KopyalaBeni.Properties.Resources.icons8_pause_button;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(119, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 101);
            this.button1.TabIndex = 10;
            this.button1.Text = "Durdur";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bTemizle
            // 
            this.bTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(49)))));
            this.bTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTemizle.FlatAppearance.BorderSize = 0;
            this.bTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTemizle.Font = new System.Drawing.Font("Gothamic", 12F);
            this.bTemizle.Image = global::KopyalaBeni.Properties.Resources.icons8_broom;
            this.bTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bTemizle.Location = new System.Drawing.Point(119, 101);
            this.bTemizle.Margin = new System.Windows.Forms.Padding(0);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(120, 101);
            this.bTemizle.TabIndex = 12;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTemizle.UseVisualStyleBackColor = false;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 202);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.87685F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.12315F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(239, 303);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 220);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.listBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(233, 220);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Consolas", 12F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Margin = new System.Windows.Forms.Padding(0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 220);
            this.listBox2.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.TKarakter, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(116, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(117, 220);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.BCikar, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.BKarakterEkle, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(117, 176);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // BCikar
            // 
            this.BCikar.BackColor = System.Drawing.Color.Tomato;
            this.BCikar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCikar.FlatAppearance.BorderSize = 0;
            this.BCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCikar.Font = new System.Drawing.Font("Gothamic", 12F);
            this.BCikar.Image = global::KopyalaBeni.Properties.Resources.icons8_delete_receipt;
            this.BCikar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCikar.Location = new System.Drawing.Point(0, 88);
            this.BCikar.Margin = new System.Windows.Forms.Padding(0);
            this.BCikar.Name = "BCikar";
            this.BCikar.Size = new System.Drawing.Size(117, 88);
            this.BCikar.TabIndex = 12;
            this.BCikar.Text = "Çıkar";
            this.BCikar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCikar.UseVisualStyleBackColor = false;
            this.BCikar.Click += new System.EventHandler(this.BCikar_Click);
            // 
            // BKarakterEkle
            // 
            this.BKarakterEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(209)))), ((int)(((byte)(55)))));
            this.BKarakterEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BKarakterEkle.FlatAppearance.BorderSize = 0;
            this.BKarakterEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BKarakterEkle.Font = new System.Drawing.Font("Gothamic", 12F);
            this.BKarakterEkle.Image = global::KopyalaBeni.Properties.Resources.icons8_add;
            this.BKarakterEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BKarakterEkle.Location = new System.Drawing.Point(0, 0);
            this.BKarakterEkle.Margin = new System.Windows.Forms.Padding(0);
            this.BKarakterEkle.Name = "BKarakterEkle";
            this.BKarakterEkle.Size = new System.Drawing.Size(117, 88);
            this.BKarakterEkle.TabIndex = 11;
            this.BKarakterEkle.Text = "Ekle";
            this.BKarakterEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BKarakterEkle.UseVisualStyleBackColor = false;
            this.BKarakterEkle.Click += new System.EventHandler(this.BKarakterEkle_Click);
            // 
            // TKarakter
            // 
            this.TKarakter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TKarakter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TKarakter.Font = new System.Drawing.Font("Consolas", 12F);
            this.TKarakter.Location = new System.Drawing.Point(0, 0);
            this.TKarakter.Margin = new System.Windows.Forms.Padding(0);
            this.TKarakter.Name = "TKarakter";
            this.TKarakter.Size = new System.Drawing.Size(117, 44);
            this.TKarakter.TabIndex = 4;
            this.TKarakter.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 77);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.5272F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.47281F));
            this.tableLayoutPanel8.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.BGrupAyarlari, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.BSat, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.ListPaket, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(239, 77);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(123)))), ((int)(((byte)(236)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Gothamic", 12F);
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(159, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 38);
            this.button5.TabIndex = 15;
            this.button5.Text = "*****";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // BGrupAyarlari
            // 
            this.BGrupAyarlari.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BGrupAyarlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(123)))), ((int)(((byte)(236)))));
            this.BGrupAyarlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGrupAyarlari.FlatAppearance.BorderSize = 0;
            this.BGrupAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGrupAyarlari.Font = new System.Drawing.Font("Gothamic", 12F);
            this.BGrupAyarlari.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGrupAyarlari.Location = new System.Drawing.Point(159, 38);
            this.BGrupAyarlari.Margin = new System.Windows.Forms.Padding(0);
            this.BGrupAyarlari.Name = "BGrupAyarlari";
            this.BGrupAyarlari.Size = new System.Drawing.Size(80, 39);
            this.BGrupAyarlari.TabIndex = 12;
            this.BGrupAyarlari.Text = "Gruplar";
            this.BGrupAyarlari.UseVisualStyleBackColor = false;
            this.BGrupAyarlari.Click += new System.EventHandler(this.BGrupAyarlari_Click);
            // 
            // BSat
            // 
            this.BSat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.BSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BSat.FlatAppearance.BorderSize = 0;
            this.BSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSat.Font = new System.Drawing.Font("Gothamic", 12F);
            this.BSat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSat.Location = new System.Drawing.Point(0, 38);
            this.BSat.Margin = new System.Windows.Forms.Padding(0);
            this.BSat.Name = "BSat";
            this.BSat.Size = new System.Drawing.Size(159, 39);
            this.BSat.TabIndex = 13;
            this.BSat.Text = "SATILDI";
            this.BSat.UseVisualStyleBackColor = false;
            this.BSat.Click += new System.EventHandler(this.BSat_Click);
            // 
            // ListPaket
            // 
            this.ListPaket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListPaket.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListPaket.FormattingEnabled = true;
            this.ListPaket.Location = new System.Drawing.Point(3, 3);
            this.ListPaket.Name = "ListPaket";
            this.ListPaket.Size = new System.Drawing.Size(153, 27);
            this.ListPaket.TabIndex = 14;
            this.ListPaket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListPaket_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 149);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(20, 17);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kopyala Beni BARAANN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button BCikar;
        private System.Windows.Forms.Button BKarakterEkle;
        private System.Windows.Forms.RichTextBox TKarakter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lSatirSayisi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button BGrupAyarlari;
        private System.Windows.Forms.Button BSat;
        private System.Windows.Forms.ComboBox ListPaket;
        private System.Windows.Forms.Button button5;
    }
}

