using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ClassNoteTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=ClassNoteTest;Integrated Security=True");

		void etutlistele()
		{
			connection.Open();
			//SqlDataAdapter da = new SqlDataAdapter("Select * From TBLETUT", connection);

			//SqlDataAdapter da3 = new SqlDataAdapter("Select DERSAD From TBLETUT inner join TBLDERSLER\r\non\r\nTBLDERSLER.DERSID = TBLETUT.DERSID", connection);
			SqlDataAdapter da3 = new SqlDataAdapter("Execute EtutList", connection);
			//SqlDataAdapter da3 = new SqlDataAdapter("Select TBLDERSLER.DERSAD as \"Ders Adı\", (TBLOGRETMEN.AD+ ' '+TBLOGRETMEN.SOYAD) as \"Öğretmen Ad\", (TBLOGRENCI.AD+ ' ' +TBLOGRENCI.SOYAD) as \"Öğrenci Ad\", TBLETUT.TARIH,TBLETUT.SAAT From TBLETUT inner join TBLDERSLER on TBLDERSLER.DERSID = TBLETUT.DERSID inner join TBLOGRETMEN on TBLETUT.TEACHERID = TBLOGRETMEN.TEACHERID inner join TBLOGRENCI on TBLETUT.STUDENTID = TBLOGRENCI.STUDENTID", connection);
			//SqlDataAdapter da3 = new SqlDataAdapter("Select TBLDERSLER.DERSAD as \"Ders Adı\", (TBLOGRETMEN.AD+ ' '+TBLOGRETMEN.SOYAD) as \"Öğretmen Ad\", (TBLOGRENCI.AD+ ' ' +TBLOGRENCI.SOYAD) as \"Öğrenci Ad\", TBLETUT.TARIH,TBLETUT.SAAT From TBLETUT inner join TBLDERSLER\r\n on\r\n TBLDERSLER.DERSID = TBLETUT.DERSID\r\n inner join TBLOGRETMEN\r\n on\r\n TBLETUT.TEACHERID = TBLOGRETMEN.TEACHERID\r\n inner join TBLOGRENCI\r\non\r\n TBLETUT.STUDENTID = TBLOGRENCI.STUDENTID", connection);
			//SqlDataAdapter da3 = new SqlDataAdapter("Select TBLDERSLER.DERSAD as 'Ders Adı', (TBLOGRETMEN.AD+ ' '+TBLOGRETMEN.SOYAD) as 'Öğretmen', (TBLOGRENCI.AD+ ' ' +TBLOGRENCI.SOYAD) as 'Öğrenci Ad', TBLETUT.TARIH,TBLETUT.SAAT From TBLETUT inner join TBLDERSLER on TBLDERSLER.DERSID = TBLETUT.DERSID inner join TBLOGRETMEN on TBLETUT.TEACHERID = TBLOGRETMEN.TEACHERID inner join TBLOGRENCI on TBLETUT.STUDENTID = TBLOGRENCI.STUDENTID", connection);
			DataTable dt3 = new DataTable();
			da3.Fill(dt3);
			dataGridView1.DataSource = dt3;
			connection.Close();

		}
		void etutekle()
		{
			connection.Open();
			SqlCommand command = new SqlCommand("insert into TBLETUT (DERSID, TEACHERID,TARIH, SAAT) values (@p1,@p2,@p3,@p4)", connection);

			command.Parameters.AddWithValue("@p1", CmbDers.SelectedValue);
			command.Parameters.AddWithValue("@p2", CmbOgretmen.SelectedValue);
			command.Parameters.AddWithValue("@p3", MskTarih.Text);
			command.Parameters.AddWithValue("@p4", MskSaat.Text);

			command.ExecuteNonQuery();
			connection.Close();
			//etutlistele();
		}


		void derslistesi()
		{
			connection.Open();
			SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", connection);
			DataTable dt = new DataTable();
			da.Fill(dt);

			CmbDers.ValueMember = "DERSID";
			CmbDers.DisplayMember = "DERSAD";
			CmbDers.DataSource = dt;

			//dataGridView1.DataSource = dt;
			connection.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			derslistesi();
			etutlistele();
		}

		private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlDataAdapter da2 = new SqlDataAdapter("Select TBLOGRETMEN.TEACHERID, (TBLOGRETMEN.AD + ' ' +TBLOGRETMEN.SOYAD) as ADSOYAD from TBLOGRETMEN where BRANSID=" + CmbDers.SelectedValue, connection);
			DataTable dt2 = new DataTable();
			da2.Fill(dt2);

			CmbOgretmen.ValueMember = "TEACHERID";
			CmbOgretmen.DisplayMember = "ADSOYAD";

			CmbOgretmen.DataSource = dt2;

		}


		private void BtnEtutOlustur_Click(object sender, EventArgs e)
		{
			etutekle();
			etutlistele();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			TxtEtutId.Text = secilen.ToString();



		}

		private void btnEtutVer_Click(object sender, EventArgs e)
		{
			connection.Open();

			SqlCommand komut = new SqlCommand("update TBLETUT set STUDENTID =@p1, DURUM=@p2 where ID=@p3", connection);


			komut.Parameters.AddWithValue("@p1", TxtOgrenciID.Text);
			komut.Parameters.AddWithValue("@p2", "True");
			komut.Parameters.AddWithValue("@p3", TxtEtutId.Text);

			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Etut ogrenciye verildi");

		}

		private void BtnFotograf_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileName;

		}

		private void BtnOgrenciEkle_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);

			komut.Parameters.AddWithValue("@p1", TxtOgrenciAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtOgrenciSoyad.Text);
			komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
			komut.Parameters.AddWithValue("@p4", TxtOgrenciSinif.Text);
			komut.Parameters.AddWithValue("@p5", MskOgrenciTelefon.Text);
			komut.Parameters.AddWithValue("@p6", TxtOgrenciMail.Text);

			komut.ExecuteNonQuery();
			connection.Close();
		}
	}
}
