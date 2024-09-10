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

namespace ETUT_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS01;Initial Catalog=EtutTest;Integrated Security=True;");

        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER",bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource = dt;

            
        }

        void ogrdersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbogrders.ValueMember = "DERSID";
            cmbogrders.DisplayMember = "DERSAD";
            cmbogrders.DataSource = dt;
        }
        void etutListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute etut", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void ogrenci()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLOGRENCİ", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void ogretmen()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLOGRETMEN", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        void ders()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
            ogrdersListesi();
            ogrenci();
            ogretmen();
            ders();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT OGRTID,(AD +' '+SOYAD) AS ADSOYAD FROM TBLOGRETMEN WHERE BRANSID=" +  cmbDers.SelectedValue,bgl);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "ADSOYAD";
            cmbOgretmen.DataSource = dt2;
        }

        private void btnEtut_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values " +
                "(@p1,@p2,@p3,@p4)",bgl);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen .SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4",mskSaat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Etüt oluşturuldu","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.Close();
            etutListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtEtütİd .Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Update TBLETUT set OGRENCIID=@p1,DURUM=@p2 " +
                "where ID=@p3",bgl);
            komut.Parameters.AddWithValue("@p1", TxtOgrenci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", TxtEtütİd.Text);
            komut .ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Etut Öğrenciye verildi","Bilgi",MessageBoxButtons.OK,
                MessageBoxIcon.Question);

            TxtOgrenci.Text = "";
            TxtEtütİd.Text = "";
            etutListesi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        { bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCİ (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) VALUES " +
                "(@p1,@p2,@p3,@p4,@p5,@p6)",bgl);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSınıf.Text);
            komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            
            bgl.Close() ;
            MessageBox.Show("Öğrenci Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ogrenci();

            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSınıf.Text = "";
            mskTelefon.Text = "";
            TxtMail.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand KOMUT8 = new SqlCommand("insert into TBLOGRETMEN (AD, SOYAD, BRANSID) VALUES (@P1,@P2,@P3)", bgl);
            KOMUT8.Parameters.AddWithValue("@P1", txtograd.Text);
            KOMUT8.Parameters.AddWithValue("@P2", txtogrsoyad.Text);
            KOMUT8.Parameters.AddWithValue("@P3", cmbogrders.SelectedValue);
            KOMUT8.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Teacher Added");
            txtograd.Text = "";
            txtogrsoyad.Text = "";
            ogretmen();
        }

        private void cmbogrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand KOMUT8 = new SqlCommand("insert into TBLDERSLER (DERSAD) VALUES (@P1)", bgl);
            KOMUT8.Parameters.AddWithValue("@P1", txtdersad.Text);
            KOMUT8.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("ders Added");
            txtdersad.Text = "";
            ders();
        }
    }
}
