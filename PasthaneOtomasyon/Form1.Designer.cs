namespace PasthaneOtomasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMalzemeId = new System.Windows.Forms.TextBox();
            this.txtMalzemeAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalzemeStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalzemeFıyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMalzemenot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMalzemekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnurunguncelle = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.txtUrunSfıyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunMfıyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUrunoluştur = new System.Windows.Forms.Button();
            this.txtMalıyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMıktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMalzemekle);
            this.groupBox1.Controls.Add(this.txtMalzemenot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMalzemeFıyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMalzemeStok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMalzemeAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMalzemeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEME GİRİŞİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtMalzemeId
            // 
            this.txtMalzemeId.Location = new System.Drawing.Point(119, 64);
            this.txtMalzemeId.Name = "txtMalzemeId";
            this.txtMalzemeId.Size = new System.Drawing.Size(152, 32);
            this.txtMalzemeId.TabIndex = 1;
            // 
            // txtMalzemeAd
            // 
            this.txtMalzemeAd.Location = new System.Drawing.Point(119, 129);
            this.txtMalzemeAd.Name = "txtMalzemeAd";
            this.txtMalzemeAd.Size = new System.Drawing.Size(152, 32);
            this.txtMalzemeAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // txtMalzemeStok
            // 
            this.txtMalzemeStok.Location = new System.Drawing.Point(119, 205);
            this.txtMalzemeStok.Name = "txtMalzemeStok";
            this.txtMalzemeStok.Size = new System.Drawing.Size(152, 32);
            this.txtMalzemeStok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOK:";
            // 
            // txtMalzemeFıyat
            // 
            this.txtMalzemeFıyat.Location = new System.Drawing.Point(119, 281);
            this.txtMalzemeFıyat.Name = "txtMalzemeFıyat";
            this.txtMalzemeFıyat.Size = new System.Drawing.Size(152, 32);
            this.txtMalzemeFıyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FIYAT:";
            // 
            // txtMalzemenot
            // 
            this.txtMalzemenot.Location = new System.Drawing.Point(119, 360);
            this.txtMalzemenot.Name = "txtMalzemenot";
            this.txtMalzemenot.Size = new System.Drawing.Size(152, 32);
            this.txtMalzemenot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOTLAR:";
            // 
            // btnMalzemekle
            // 
            this.btnMalzemekle.BackColor = System.Drawing.Color.Olive;
            this.btnMalzemekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMalzemekle.Location = new System.Drawing.Point(49, 431);
            this.btnMalzemekle.Name = "btnMalzemekle";
            this.btnMalzemekle.Size = new System.Drawing.Size(280, 42);
            this.btnMalzemekle.TabIndex = 10;
            this.btnMalzemekle.Text = "MALZEME EKLE";
            this.btnMalzemekle.UseVisualStyleBackColor = false;
            this.btnMalzemekle.Click += new System.EventHandler(this.btnMalzemekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1138, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MALZEMELER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnurunguncelle);
            this.groupBox3.Controls.Add(this.btnurunekle);
            this.groupBox3.Controls.Add(this.txtUrunSfıyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUrunMfıyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUrunStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtUrunId);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(403, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 493);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BİLGİ GİRİŞİ";
            // 
            // btnurunguncelle
            // 
            this.btnurunguncelle.BackColor = System.Drawing.Color.Olive;
            this.btnurunguncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnurunguncelle.Location = new System.Drawing.Point(107, 454);
            this.btnurunguncelle.Name = "btnurunguncelle";
            this.btnurunguncelle.Size = new System.Drawing.Size(280, 33);
            this.btnurunguncelle.TabIndex = 11;
            this.btnurunguncelle.Text = "GÜNCELLE";
            this.btnurunguncelle.UseVisualStyleBackColor = false;
            this.btnurunguncelle.Click += new System.EventHandler(this.btnurunguncelle_Click);
            // 
            // btnurunekle
            // 
            this.btnurunekle.BackColor = System.Drawing.Color.Olive;
            this.btnurunekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnurunekle.Location = new System.Drawing.Point(107, 409);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(280, 42);
            this.btnurunekle.TabIndex = 10;
            this.btnurunekle.Text = "ÜRÜN EKLE";
            this.btnurunekle.UseVisualStyleBackColor = false;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // txtUrunSfıyat
            // 
            this.txtUrunSfıyat.Location = new System.Drawing.Point(119, 360);
            this.txtUrunSfıyat.Name = "txtUrunSfıyat";
            this.txtUrunSfıyat.Size = new System.Drawing.Size(152, 32);
            this.txtUrunSfıyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "SFİYAT:";
            // 
            // txtUrunMfıyat
            // 
            this.txtUrunMfıyat.Location = new System.Drawing.Point(119, 281);
            this.txtUrunMfıyat.Name = "txtUrunMfıyat";
            this.txtUrunMfıyat.Size = new System.Drawing.Size(152, 32);
            this.txtUrunMfıyat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "MFIYAT:";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(119, 205);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(152, 32);
            this.txtUrunStok.TabIndex = 5;
            this.txtUrunStok.TextChanged += new System.EventHandler(this.txtUrunStok_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(119, 129);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(152, 32);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(119, 64);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(152, 32);
            this.txtUrunId.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbMalzeme);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Controls.Add(this.btnUrunoluştur);
            this.groupBox4.Controls.Add(this.txtMalıyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtMıktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(811, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 493);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜRÜN OLUŞTUR";
            // 
            // btnUrunoluştur
            // 
            this.btnUrunoluştur.BackColor = System.Drawing.Color.Olive;
            this.btnUrunoluştur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunoluştur.Location = new System.Drawing.Point(37, 418);
            this.btnUrunoluştur.Name = "btnUrunoluştur";
            this.btnUrunoluştur.Size = new System.Drawing.Size(280, 60);
            this.btnUrunoluştur.TabIndex = 10;
            this.btnUrunoluştur.Text = " EKLE";
            this.btnUrunoluştur.UseVisualStyleBackColor = false;
            this.btnUrunoluştur.Click += new System.EventHandler(this.btnUrunoluştur_Click);
            // 
            // txtMalıyet
            // 
            this.txtMalıyet.Enabled = false;
            this.txtMalıyet.Location = new System.Drawing.Point(119, 281);
            this.txtMalıyet.Name = "txtMalıyet";
            this.txtMalıyet.Size = new System.Drawing.Size(152, 32);
            this.txtMalıyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "MALİYET:";
            // 
            // txtMıktar
            // 
            this.txtMıktar.Location = new System.Drawing.Point(119, 205);
            this.txtMıktar.Name = "txtMıktar";
            this.txtMıktar.Size = new System.Drawing.Size(152, 32);
            this.txtMıktar.TabIndex = 5;
            this.txtMıktar.TextChanged += new System.EventHandler(this.txtMıktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1154, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(238, 488);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İŞLEMLER";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(16, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 59);
            this.button5.TabIndex = 0;
            this.button5.Text = "ÜRÜN LİSTESİ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(16, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 59);
            this.button7.TabIndex = 1;
            this.button7.Text = "MALZEME LİSTESİ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(16, 311);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(211, 59);
            this.button8.TabIndex = 2;
            this.button8.Text = "KASA";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(16, 389);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(211, 59);
            this.button9.TabIndex = 3;
            this.button9.Text = "ÇIKIŞ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(1154, 516);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 291);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "LİSTE";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 265);
            this.listBox1.TabIndex = 0;
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(119, 65);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(152, 33);
            this.CmbUrun.TabIndex = 11;
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(119, 125);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(152, 33);
            this.cmbMalzeme.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PasthaneOtomasyon.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(1398, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1548, 822);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMalzemekle;
        private System.Windows.Forms.TextBox txtMalzemenot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalzemeFıyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMalzemeStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalzemeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalzemeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnurunguncelle;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.TextBox txtUrunSfıyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunMfıyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUrunoluştur;
        private System.Windows.Forms.TextBox txtMalıyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMıktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

