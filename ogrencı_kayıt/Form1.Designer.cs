namespace ogrencı_kayıt
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbokul = new System.Windows.Forms.ComboBox();
            this.txtpuan = new System.Windows.Forms.TextBox();
            this.txtyasadıgısehir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogryasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrmezunturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrpuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsececegisehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrüniadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitst_veritabaniDataSet1 = new ogrencı_kayıt.kayitst_veritabaniDataSet1();
            this.btnkaıtouştur = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsececegisehir = new System.Windows.Forms.TextBox();
            this.txtuniversite = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbl_ogrenciTableAdapter = new ogrencı_kayıt.kayitst_veritabaniDataSet1TableAdapters.tbl_ogrenciTableAdapter();
            this.btnhesap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitst_veritabaniDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtad.Location = new System.Drawing.Point(194, 60);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(121, 28);
            this.txtad.TabIndex = 0;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(194, 97);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 28);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(194, 143);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(121, 28);
            this.txtyas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(132, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "T.C :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Okul Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Puanı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yaşadğı Şehir :";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(194, 183);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(121, 28);
            this.mskTC.TabIndex = 10;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbokul
            // 
            this.cmbokul.FormattingEnabled = true;
            this.cmbokul.Items.AddRange(new object[] {
            "Anadolu",
            "Meslek",
            "Fen ",
            "Sosyal.B",
            "İmamhatip",
            "Özel.L"});
            this.cmbokul.Location = new System.Drawing.Point(194, 221);
            this.cmbokul.Name = "cmbokul";
            this.cmbokul.Size = new System.Drawing.Size(121, 30);
            this.cmbokul.TabIndex = 11;
            // 
            // txtpuan
            // 
            this.txtpuan.Location = new System.Drawing.Point(192, 125);
            this.txtpuan.Name = "txtpuan";
            this.txtpuan.Size = new System.Drawing.Size(118, 28);
            this.txtpuan.TabIndex = 12;
            // 
            // txtyasadıgısehir
            // 
            this.txtyasadıgısehir.Location = new System.Drawing.Point(194, 257);
            this.txtyasadıgısehir.Name = "txtyasadıgısehir";
            this.txtyasadıgısehir.Size = new System.Drawing.Size(121, 28);
            this.txtyasadıgısehir.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(626, 49);
            this.label8.TabIndex = 14;
            this.label8.Text = "ÖĞRENCİ KAYIT OTAMASYONU";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(49, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 22);
            this.label11.TabIndex = 19;
            this.label11.Text = "Şehir Seçimi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(39, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Üniversite Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrSehirDataGridViewTextBoxColumn,
            this.ogryasDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrmezunturuDataGridViewTextBoxColumn,
            this.ogrpuanDataGridViewTextBoxColumn,
            this.ogrsececegisehirDataGridViewTextBoxColumn,
            this.ogrüniadıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblogrenciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 188);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "ogrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "ogrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "ogrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSehirDataGridViewTextBoxColumn
            // 
            this.ogrSehirDataGridViewTextBoxColumn.DataPropertyName = "ogrSehir";
            this.ogrSehirDataGridViewTextBoxColumn.HeaderText = "ogrSehir";
            this.ogrSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSehirDataGridViewTextBoxColumn.Name = "ogrSehirDataGridViewTextBoxColumn";
            this.ogrSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogryasDataGridViewTextBoxColumn
            // 
            this.ogryasDataGridViewTextBoxColumn.DataPropertyName = "ogryas";
            this.ogryasDataGridViewTextBoxColumn.HeaderText = "ogryas";
            this.ogryasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogryasDataGridViewTextBoxColumn.Name = "ogryasDataGridViewTextBoxColumn";
            this.ogryasDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrmezunturuDataGridViewTextBoxColumn
            // 
            this.ogrmezunturuDataGridViewTextBoxColumn.DataPropertyName = "ogrmezunturu";
            this.ogrmezunturuDataGridViewTextBoxColumn.HeaderText = "ogrmezunturu";
            this.ogrmezunturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrmezunturuDataGridViewTextBoxColumn.Name = "ogrmezunturuDataGridViewTextBoxColumn";
            this.ogrmezunturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrpuanDataGridViewTextBoxColumn
            // 
            this.ogrpuanDataGridViewTextBoxColumn.DataPropertyName = "ogrpuan";
            this.ogrpuanDataGridViewTextBoxColumn.HeaderText = "ogrpuan";
            this.ogrpuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrpuanDataGridViewTextBoxColumn.Name = "ogrpuanDataGridViewTextBoxColumn";
            this.ogrpuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrsececegisehirDataGridViewTextBoxColumn
            // 
            this.ogrsececegisehirDataGridViewTextBoxColumn.DataPropertyName = "ogrsececegisehir";
            this.ogrsececegisehirDataGridViewTextBoxColumn.HeaderText = "ogrsececegisehir";
            this.ogrsececegisehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsececegisehirDataGridViewTextBoxColumn.Name = "ogrsececegisehirDataGridViewTextBoxColumn";
            this.ogrsececegisehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrüniadıDataGridViewTextBoxColumn
            // 
            this.ogrüniadıDataGridViewTextBoxColumn.DataPropertyName = "ogrüniadı";
            this.ogrüniadıDataGridViewTextBoxColumn.HeaderText = "ogrüniadı";
            this.ogrüniadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrüniadıDataGridViewTextBoxColumn.Name = "ogrüniadıDataGridViewTextBoxColumn";
            this.ogrüniadıDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblogrenciBindingSource
            // 
            this.tblogrenciBindingSource.DataMember = "tbl_ogrenci";
            this.tblogrenciBindingSource.DataSource = this.kayitst_veritabaniDataSet1;
            // 
            // kayitst_veritabaniDataSet1
            // 
            this.kayitst_veritabaniDataSet1.DataSetName = "kayitst_veritabaniDataSet1";
            this.kayitst_veritabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnkaıtouştur
            // 
            this.btnkaıtouştur.BackColor = System.Drawing.Color.Lime;
            this.btnkaıtouştur.Location = new System.Drawing.Point(42, 172);
            this.btnkaıtouştur.Name = "btnkaıtouştur";
            this.btnkaıtouştur.Size = new System.Drawing.Size(141, 35);
            this.btnkaıtouştur.TabIndex = 25;
            this.btnkaıtouştur.Text = "Kayıt Oluştur";
            this.btnkaıtouştur.UseVisualStyleBackColor = false;
            this.btnkaıtouştur.Click += new System.EventHandler(this.btnkaıtouştur_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnguncelle.Location = new System.Drawing.Point(32, 60);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(228, 41);
            this.btnguncelle.TabIndex = 27;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btntemizle.Location = new System.Drawing.Point(32, 130);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(228, 44);
            this.btntemizle.TabIndex = 28;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Red;
            this.btnsil.Location = new System.Drawing.Point(32, 277);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(228, 39);
            this.btnsil.TabIndex = 29;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Red;
            this.btncikis.Location = new System.Drawing.Point(198, 169);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(112, 41);
            this.btncikis.TabIndex = 30;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnlistele);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btntemizle);
            this.groupBox1.Location = new System.Drawing.Point(798, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 349);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.Yellow;
            this.btnlistele.Location = new System.Drawing.Point(32, 208);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(228, 40);
            this.btnlistele.TabIndex = 30;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnhesap);
            this.groupBox2.Controls.Add(this.txtsececegisehir);
            this.groupBox2.Controls.Add(this.txtuniversite);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtpuan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btncikis);
            this.groupBox2.Controls.Add(this.btnkaıtouştur);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(405, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 352);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tecih Seçimi";
            // 
            // txtsececegisehir
            // 
            this.txtsececegisehir.Location = new System.Drawing.Point(192, 39);
            this.txtsececegisehir.Name = "txtsececegisehir";
            this.txtsececegisehir.Size = new System.Drawing.Size(118, 28);
            this.txtsececegisehir.TabIndex = 32;
            // 
            // txtuniversite
            // 
            this.txtuniversite.Location = new System.Drawing.Point(192, 82);
            this.txtuniversite.Name = "txtuniversite";
            this.txtuniversite.Size = new System.Drawing.Size(118, 28);
            this.txtuniversite.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(1097, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 352);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.txtad);
            this.groupBox3.Controls.Add(this.txtyasadıgısehir);
            this.groupBox3.Controls.Add(this.cmbokul);
            this.groupBox3.Controls.Add(this.mskTC);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtsoyad);
            this.groupBox3.Controls.Add(this.txtyas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 352);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğenci Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Aqua;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(0, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1180, 215);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // tbl_ogrenciTableAdapter
            // 
            this.tbl_ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // btnhesap
            // 
            this.btnhesap.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnhesap.Location = new System.Drawing.Point(42, 300);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(268, 36);
            this.btnhesap.TabIndex = 33;
            this.btnhesap.Text = "Hesap Makinası";
            this.btnhesap.UseVisualStyleBackColor = false;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 641);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitst_veritabaniDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbokul;
        private System.Windows.Forms.TextBox txtpuan;
        private System.Windows.Forms.TextBox txtyasadıgısehir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkaıtouştur;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtsececegisehir;
        private System.Windows.Forms.TextBox txtuniversite;
        private System.Windows.Forms.GroupBox groupBox4;
        private kayitst_veritabaniDataSet1 kayitst_veritabaniDataSet1;
        private System.Windows.Forms.BindingSource tblogrenciBindingSource;
        private kayitst_veritabaniDataSet1TableAdapters.tbl_ogrenciTableAdapter tbl_ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogryasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrmezunturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrpuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsececegisehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrüniadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnhesap;
    }
}

