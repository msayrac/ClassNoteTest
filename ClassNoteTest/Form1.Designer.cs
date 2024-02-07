namespace ClassNoteTest
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CmbDers = new System.Windows.Forms.ComboBox();
			this.MskTarih = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CmbOgretmen = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.MskSaat = new System.Windows.Forms.MaskedTextBox();
			this.BtnEtutOlustur = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnEtutVer = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.TxtOgrenciID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtEtutId = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtOgrenciAd = new System.Windows.Forms.TextBox();
			this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.TxtOgrenciSinif = new System.Windows.Forms.TextBox();
			this.TxtOgrenciMail = new System.Windows.Forms.TextBox();
			this.BtnOgrenciEkle = new System.Windows.Forms.Button();
			this.MskOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.BtnDersEkle = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnFotograf = new System.Windows.Forms.Button();
			this.TxtOgretmenSoyad = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.CmbOgretmenDers = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnEtutOlustur);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.MskSaat);
			this.groupBox1.Controls.Add(this.CmbOgretmen);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.MskTarih);
			this.groupBox1.Controls.Add(this.CmbDers);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(25, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(395, 311);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ders:";
			// 
			// CmbDers
			// 
			this.CmbDers.FormattingEnabled = true;
			this.CmbDers.Location = new System.Drawing.Point(94, 60);
			this.CmbDers.Name = "CmbDers";
			this.CmbDers.Size = new System.Drawing.Size(206, 32);
			this.CmbDers.TabIndex = 1;
			this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
			// 
			// MskTarih
			// 
			this.MskTarih.Location = new System.Drawing.Point(94, 157);
			this.MskTarih.Mask = "00/00/0000";
			this.MskTarih.Name = "MskTarih";
			this.MskTarih.Size = new System.Drawing.Size(206, 30);
			this.MskTarih.TabIndex = 3;
			this.MskTarih.ValidatingType = typeof(System.DateTime);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Öğretmen:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tarih:";
			// 
			// CmbOgretmen
			// 
			this.CmbOgretmen.FormattingEnabled = true;
			this.CmbOgretmen.Location = new System.Drawing.Point(94, 106);
			this.CmbOgretmen.Name = "CmbOgretmen";
			this.CmbOgretmen.Size = new System.Drawing.Size(206, 32);
			this.CmbOgretmen.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Saat:";
			// 
			// MskSaat
			// 
			this.MskSaat.Location = new System.Drawing.Point(94, 204);
			this.MskSaat.Mask = "00:00";
			this.MskSaat.Name = "MskSaat";
			this.MskSaat.Size = new System.Drawing.Size(206, 30);
			this.MskSaat.TabIndex = 4;
			this.MskSaat.ValidatingType = typeof(System.DateTime);
			// 
			// BtnEtutOlustur
			// 
			this.BtnEtutOlustur.Location = new System.Drawing.Point(94, 249);
			this.BtnEtutOlustur.Name = "BtnEtutOlustur";
			this.BtnEtutOlustur.Size = new System.Drawing.Size(206, 30);
			this.BtnEtutOlustur.TabIndex = 5;
			this.BtnEtutOlustur.Text = "Etüt Oluştur";
			this.BtnEtutOlustur.UseVisualStyleBackColor = true;
			this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.TxtEtutId);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.TxtOgrenciID);
			this.groupBox2.Controls.Add(this.btnEtutVer);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(447, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(395, 167);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			// 
			// btnEtutVer
			// 
			this.btnEtutVer.Location = new System.Drawing.Point(128, 106);
			this.btnEtutVer.Name = "btnEtutVer";
			this.btnEtutVer.Size = new System.Drawing.Size(174, 32);
			this.btnEtutVer.TabIndex = 3;
			this.btnEtutVer.Text = "Etüt Ver";
			this.btnEtutVer.UseVisualStyleBackColor = true;
			this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(53, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "Öğrenci:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(25, 350);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1058, 202);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1052, 173);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// TxtOgrenciID
			// 
			this.TxtOgrenciID.Location = new System.Drawing.Point(128, 68);
			this.TxtOgrenciID.Name = "TxtOgrenciID";
			this.TxtOgrenciID.Size = new System.Drawing.Size(177, 30);
			this.TxtOgrenciID.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(53, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Etut İd:";
			// 
			// TxtEtutId
			// 
			this.TxtEtutId.Enabled = false;
			this.TxtEtutId.Location = new System.Drawing.Point(128, 29);
			this.TxtEtutId.Name = "TxtEtutId";
			this.TxtEtutId.Size = new System.Drawing.Size(177, 30);
			this.TxtEtutId.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.BtnDersEkle);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Location = new System.Drawing.Point(447, 203);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(395, 141);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.MskOgrenciTelefon);
			this.groupBox5.Controls.Add(this.BtnOgrenciEkle);
			this.groupBox5.Controls.Add(this.TxtOgrenciMail);
			this.groupBox5.Controls.Add(this.TxtOgrenciSinif);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.TxtOgrenciSoyad);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.TxtOgrenciAd);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Location = new System.Drawing.Point(848, 36);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(235, 308);
			this.groupBox5.TabIndex = 15;
			this.groupBox5.TabStop = false;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.BtnFotograf);
			this.groupBox7.Controls.Add(this.pictureBox1);
			this.groupBox7.Location = new System.Drawing.Point(1089, 36);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(226, 261);
			this.groupBox7.TabIndex = 17;
			this.groupBox7.TabStop = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.button1);
			this.groupBox6.Controls.Add(this.label16);
			this.groupBox6.Controls.Add(this.CmbOgretmenDers);
			this.groupBox6.Controls.Add(this.label15);
			this.groupBox6.Controls.Add(this.TxtOgretmenSoyad);
			this.groupBox6.Controls.Add(this.label13);
			this.groupBox6.Controls.Add(this.TxtOgretmenAd);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Location = new System.Drawing.Point(1089, 303);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(226, 249);
			this.groupBox6.TabIndex = 18;
			this.groupBox6.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 24);
			this.label6.TabIndex = 14;
			this.label6.Text = "Ad:";
			// 
			// TxtOgrenciAd
			// 
			this.TxtOgrenciAd.Location = new System.Drawing.Point(70, 32);
			this.TxtOgrenciAd.Name = "TxtOgrenciAd";
			this.TxtOgrenciAd.Size = new System.Drawing.Size(154, 30);
			this.TxtOgrenciAd.TabIndex = 1;
			// 
			// TxtOgrenciSoyad
			// 
			this.TxtOgrenciSoyad.Location = new System.Drawing.Point(70, 81);
			this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
			this.TxtOgrenciSoyad.Size = new System.Drawing.Size(154, 30);
			this.TxtOgrenciSoyad.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 24);
			this.label8.TabIndex = 16;
			this.label8.Text = "Soyad:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(15, 132);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 24);
			this.label9.TabIndex = 18;
			this.label9.Text = "Sınıf:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 179);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 24);
			this.label10.TabIndex = 20;
			this.label10.Text = "Telefon:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(15, 218);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(50, 24);
			this.label11.TabIndex = 22;
			this.label11.Text = "Mail:";
			// 
			// TxtOgrenciSinif
			// 
			this.TxtOgrenciSinif.Location = new System.Drawing.Point(70, 126);
			this.TxtOgrenciSinif.Name = "TxtOgrenciSinif";
			this.TxtOgrenciSinif.Size = new System.Drawing.Size(154, 30);
			this.TxtOgrenciSinif.TabIndex = 3;
			// 
			// TxtOgrenciMail
			// 
			this.TxtOgrenciMail.Location = new System.Drawing.Point(71, 215);
			this.TxtOgrenciMail.Name = "TxtOgrenciMail";
			this.TxtOgrenciMail.Size = new System.Drawing.Size(153, 30);
			this.TxtOgrenciMail.TabIndex = 5;
			// 
			// BtnOgrenciEkle
			// 
			this.BtnOgrenciEkle.Location = new System.Drawing.Point(71, 256);
			this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
			this.BtnOgrenciEkle.Size = new System.Drawing.Size(153, 32);
			this.BtnOgrenciEkle.TabIndex = 14;
			this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
			this.BtnOgrenciEkle.UseVisualStyleBackColor = true;
			this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
			// 
			// MskOgrenciTelefon
			// 
			this.MskOgrenciTelefon.Location = new System.Drawing.Point(71, 173);
			this.MskOgrenciTelefon.Mask = "(999) 000-0000";
			this.MskOgrenciTelefon.Name = "MskOgrenciTelefon";
			this.MskOgrenciTelefon.Size = new System.Drawing.Size(153, 30);
			this.MskOgrenciTelefon.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(93, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(163, 30);
			this.textBox1.TabIndex = 15;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(9, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 24);
			this.label12.TabIndex = 16;
			this.label12.Text = "Ders Adı:";
			// 
			// BtnDersEkle
			// 
			this.BtnDersEkle.Location = new System.Drawing.Point(271, 45);
			this.BtnDersEkle.Name = "BtnDersEkle";
			this.BtnDersEkle.Size = new System.Drawing.Size(108, 32);
			this.BtnDersEkle.TabIndex = 27;
			this.BtnDersEkle.Text = "Ders Ekle";
			this.BtnDersEkle.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(7, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(213, 187);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BtnFotograf
			// 
			this.BtnFotograf.Location = new System.Drawing.Point(37, 213);
			this.BtnFotograf.Name = "BtnFotograf";
			this.BtnFotograf.Size = new System.Drawing.Size(153, 32);
			this.BtnFotograf.TabIndex = 27;
			this.BtnFotograf.Text = "Fotograf Yükle";
			this.BtnFotograf.UseVisualStyleBackColor = true;
			this.BtnFotograf.Click += new System.EventHandler(this.BtnFotograf_Click);
			// 
			// TxtOgretmenSoyad
			// 
			this.TxtOgretmenSoyad.Enabled = false;
			this.TxtOgretmenSoyad.Location = new System.Drawing.Point(66, 102);
			this.TxtOgretmenSoyad.Name = "TxtOgretmenSoyad";
			this.TxtOgretmenSoyad.Size = new System.Drawing.Size(154, 30);
			this.TxtOgretmenSoyad.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 105);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(57, 24);
			this.label13.TabIndex = 20;
			this.label13.Text = "Soyad:";
			// 
			// TxtOgretmenAd
			// 
			this.TxtOgretmenAd.Enabled = false;
			this.TxtOgretmenAd.Location = new System.Drawing.Point(66, 66);
			this.TxtOgretmenAd.Name = "TxtOgretmenAd";
			this.TxtOgretmenAd.Size = new System.Drawing.Size(154, 30);
			this.TxtOgretmenAd.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(24, 66);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(36, 24);
			this.label14.TabIndex = 18;
			this.label14.Text = "Ad:";
			// 
			// CmbOgretmenDers
			// 
			this.CmbOgretmenDers.FormattingEnabled = true;
			this.CmbOgretmenDers.Location = new System.Drawing.Point(66, 138);
			this.CmbOgretmenDers.Name = "CmbOgretmenDers";
			this.CmbOgretmenDers.Size = new System.Drawing.Size(154, 32);
			this.CmbOgretmenDers.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(12, 141);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 24);
			this.label15.TabIndex = 21;
			this.label15.Text = "Ders:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label16.Location = new System.Drawing.Point(9, 13);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(193, 37);
			this.label16.TabIndex = 23;
			this.label16.Text = "Öğretmen Paneli";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(66, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 32);
			this.button1.TabIndex = 27;
			this.button1.Text = "Öğretmen Ekle";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(1333, 577);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox CmbOgretmen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox MskTarih;
		private System.Windows.Forms.ComboBox CmbDers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnEtutOlustur;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox MskSaat;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnEtutVer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox TxtOgrenciID;
		private System.Windows.Forms.TextBox TxtEtutId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button BtnDersEkle;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.MaskedTextBox MskOgrenciTelefon;
		private System.Windows.Forms.Button BtnOgrenciEkle;
		private System.Windows.Forms.TextBox TxtOgrenciMail;
		private System.Windows.Forms.TextBox TxtOgrenciSinif;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TxtOgrenciSoyad;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TxtOgrenciAd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnFotograf;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox CmbOgretmenDers;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox TxtOgretmenSoyad;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox TxtOgretmenAd;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

