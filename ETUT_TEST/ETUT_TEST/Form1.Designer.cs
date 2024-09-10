namespace ETUT_TEST
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtOgrenci = new System.Windows.Forms.TextBox();
            this.TxtEtütİd = new System.Windows.Forms.TextBox();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdersad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSınıf = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.cmbogrders = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtogrsoyad = new System.Windows.Forms.TextBox();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.group1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(324, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etüt Oluştur";
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.BackColor = System.Drawing.Color.Gray;
            this.btnEtutOlustur.Location = new System.Drawing.Point(128, 214);
            this.btnEtutOlustur.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(182, 38);
            this.btnEtutOlustur.TabIndex = 3;
            this.btnEtutOlustur.Text = "Etüt Oluştur";
            this.btnEtutOlustur.UseVisualStyleBackColor = false;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtut_Click);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(128, 172);
            this.mskSaat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(179, 27);
            this.mskSaat.TabIndex = 2;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(128, 130);
            this.mskTarih.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(179, 27);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saat:";
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(128, 86);
            this.cmbOgretmen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(179, 26);
            this.cmbOgretmen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğretmen:";
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(128, 49);
            this.cmbDers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(179, 26);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtOgrenci);
            this.groupBox2.Controls.Add(this.TxtEtütİd);
            this.groupBox2.Controls.Add(this.btnEtutVer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(352, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(308, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etüt Detay";
            // 
            // TxtOgrenci
            // 
            this.TxtOgrenci.Location = new System.Drawing.Point(142, 81);
            this.TxtOgrenci.Name = "TxtOgrenci";
            this.TxtOgrenci.Size = new System.Drawing.Size(150, 27);
            this.TxtOgrenci.TabIndex = 4;
            // 
            // TxtEtütİd
            // 
            this.TxtEtütİd.Location = new System.Drawing.Point(142, 43);
            this.TxtEtütİd.Name = "TxtEtütİd";
            this.TxtEtütİd.Size = new System.Drawing.Size(150, 27);
            this.TxtEtütİd.TabIndex = 4;
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.BackColor = System.Drawing.Color.Gray;
            this.btnEtutVer.Location = new System.Drawing.Point(142, 119);
            this.btnEtutVer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(150, 38);
            this.btnEtutVer.TabIndex = 3;
            this.btnEtutVer.Text = "Etüt Ver";
            this.btnEtutVer.UseVisualStyleBackColor = false;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Öğrenci:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Etüt id : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 312);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(17, 287);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(642, 340);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtdersad);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(352, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 86);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ders Adı:";
            // 
            // txtdersad
            // 
            this.txtdersad.Location = new System.Drawing.Point(142, 14);
            this.txtdersad.Name = "txtdersad";
            this.txtdersad.Size = new System.Drawing.Size(150, 27);
            this.txtdersad.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(142, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ders Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mskTelefon);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtMail);
            this.groupBox5.Controls.Add(this.TxtSınıf);
            this.groupBox5.Controls.Add(this.TxtSoyad);
            this.groupBox5.Controls.Add(this.TxtAd);
            this.groupBox5.Controls.Add(this.btnOgrenci);
            this.groupBox5.Location = new System.Drawing.Point(668, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 262);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Öğrenci";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(142, 153);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(150, 27);
            this.mskTelefon.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telefon:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sınıf:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ad:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(142, 185);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(150, 27);
            this.TxtMail.TabIndex = 4;
            // 
            // TxtSınıf
            // 
            this.TxtSınıf.Location = new System.Drawing.Point(142, 119);
            this.TxtSınıf.Name = "TxtSınıf";
            this.TxtSınıf.Size = new System.Drawing.Size(150, 27);
            this.TxtSınıf.TabIndex = 4;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(142, 81);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(150, 27);
            this.TxtSoyad.TabIndex = 4;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(142, 46);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(150, 27);
            this.TxtAd.TabIndex = 4;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.Gray;
            this.btnOgrenci.Location = new System.Drawing.Point(142, 218);
            this.btnOgrenci.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(150, 31);
            this.btnOgrenci.TabIndex = 3;
            this.btnOgrenci.Text = "Öğrenci Ekle";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.cmbogrders);
            this.group1.Controls.Add(this.label15);
            this.group1.Controls.Add(this.label16);
            this.group1.Controls.Add(this.label17);
            this.group1.Controls.Add(this.txtogrsoyad);
            this.group1.Controls.Add(this.txtograd);
            this.group1.Controls.Add(this.button2);
            this.group1.Location = new System.Drawing.Point(994, 284);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(360, 206);
            this.group1.TabIndex = 6;
            this.group1.TabStop = false;
            this.group1.Text = "Öğretmen";
            // 
            // cmbogrders
            // 
            this.cmbogrders.FormattingEnabled = true;
            this.cmbogrders.Location = new System.Drawing.Point(142, 115);
            this.cmbogrders.Name = "cmbogrders";
            this.cmbogrders.Size = new System.Drawing.Size(150, 26);
            this.cmbogrders.TabIndex = 5;
            this.cmbogrders.SelectedIndexChanged += new System.EventHandler(this.cmbogrders_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ders:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Soyad:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ad:";
            // 
            // txtogrsoyad
            // 
            this.txtogrsoyad.Location = new System.Drawing.Point(142, 81);
            this.txtogrsoyad.Name = "txtogrsoyad";
            this.txtogrsoyad.Size = new System.Drawing.Size(150, 27);
            this.txtogrsoyad.TabIndex = 4;
            // 
            // txtograd
            // 
            this.txtograd.Location = new System.Drawing.Point(142, 46);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(150, 27);
            this.txtograd.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(142, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Öğretmen Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox7);
            this.groupBox8.Controls.Add(this.button5);
            this.groupBox8.Location = new System.Drawing.Point(994, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(360, 253);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Fotoğraf";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(6, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(348, 184);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Location = new System.Drawing.Point(86, 215);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 31);
            this.button5.TabIndex = 3;
            this.button5.Text = "Fotoğraf Yükle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dataGridView2);
            this.groupBox9.Location = new System.Drawing.Point(669, 284);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(319, 204);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Öğrenci";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(313, 178);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dataGridView3);
            this.groupBox10.Location = new System.Drawing.Point(994, 497);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(360, 130);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Öğretmen";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 23);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(354, 104);
            this.dataGridView3.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dataGridView4);
            this.groupBox11.Location = new System.Drawing.Point(667, 491);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(321, 133);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Ders";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 23);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(315, 107);
            this.dataGridView4.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1366, 624);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtOgrenci;
        private System.Windows.Forms.TextBox TxtEtütİd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdersad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSınıf;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtogrsoyad;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbogrders;
    }
}

