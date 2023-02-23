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

namespace ogrencı_kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bagadres = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=kayitst_veritabani;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kayitst_veritabaniDataSet1.tbl_ogrenci' table. You can move, or remove it, as needed.
           // this.tbl_ogrenciTableAdapter.Fill(this.kayitst_veritabaniDataSet1.tbl_ogrenci);

        }
        void temize()
        {
            txtad.Text = " ";
            txtpuan.Text = " ";
            txtsececegisehir.Text = " ";
            txtsoyad.Text = " ";
            txtuniversite.Text = " ";
            txtyas.Text = " ";
            txtyasadıgısehir.Text = " ";
            cmbokul.Text = " ";
            mskTC.Text = " ";
            txtad.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            temize();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //Listeleme işlemi
            this.tbl_ogrenciTableAdapter.Fill(this.kayitst_veritabaniDataSet1.tbl_ogrenci);
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            //uygulamadan çıkma
            Application.Exit();
        }
        
        private void btnkaıtouştur_Click(object sender, EventArgs e)
        {
            
            //kayıt ekleme 
            bagadres.Open();
            SqlCommand gorev = new SqlCommand("insert into tbl_ogrenci (ogrAd,ogrSoyad,ogrSehir,ogryas,ogrmezunturu,ogrpuan,ogrsececegisehir,ogrüniadı,ogrtc) values (@e1,@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9)",bagadres);

           
           
            gorev.Parameters.AddWithValue("@e1", txtad.Text);
            gorev.Parameters.AddWithValue("@e2", txtsoyad.Text);
            gorev.Parameters.AddWithValue("@e3", txtyasadıgısehir.Text);
            gorev.Parameters.AddWithValue("@e4", txtyas.Text); 
            gorev.Parameters.AddWithValue("@e5", cmbokul.Text);
            gorev.Parameters.AddWithValue("@e6", txtpuan.Text);
            gorev.Parameters.AddWithValue("@e7", txtsececegisehir.Text);
            gorev.Parameters.AddWithValue("@e8", txtuniversite.Text);
            gorev.Parameters.AddWithValue("@e9", mskTC.Text);


            gorev.ExecuteNonQuery();
            bagadres.Close();
            MessageBox.Show("kayıt oluşturuldu");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //çift tıklayarak  veri taşıma
            int tıklanan = dataGridView1.SelectedCells[0].RowIndex;

            txtad.Text = dataGridView1.Rows[tıklanan].Cells[0].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[tıklanan].Cells[1].Value.ToString();
            txtyasadıgısehir.Text = dataGridView1.Rows[tıklanan].Cells[2].Value.ToString();
            txtyas.Text = dataGridView1.Rows[tıklanan].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[tıklanan].Cells[4].Value.ToString();
            cmbokul.Text = dataGridView1.Rows[tıklanan].Cells[5].Value.ToString();
            txtsececegisehir.Text = dataGridView1.Rows[tıklanan].Cells[8].Value.ToString();
            txtuniversite.Text = dataGridView1.Rows[tıklanan].Cells[7].Value.ToString();
            txtpuan.Text = dataGridView1.Rows[tıklanan].Cells[6].Value.ToString();
        }
        
        private void btnsil_Click(object sender, EventArgs e)
        {
            //Sillme işlemi
            bagadres.Open();
            SqlCommand gorevsil = new SqlCommand("Delete From tbl_ogrenci Where ogrAd=@s1", bagadres);
            gorevsil.Parameters.AddWithValue("@s1", txtad.Text);

            gorevsil.ExecuteNonQuery();
            bagadres.Close();
            MessageBox.Show("Kayt siliindi");
        }
        
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            //HATALI
            bagadres.Open();
            SqlCommand kytguncelle = new SqlCommand("Update tbl_ogrenci set ogrAd=@a1,ogrSoyad=@a2,ogrSehir=@a3,ogryas=@a4,ogrmezunturu=@a5,ogrpuan=@a6,ogrsececegisehir=@a7,ogrüniadı=@a8 where  ogrTC=@A9 ", bagadres);

            kytguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            kytguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            kytguncelle.Parameters.AddWithValue("@a3", txtsececegisehir.Text);
            kytguncelle.Parameters.AddWithValue("@a4", txtyas.Text);
            kytguncelle.Parameters.AddWithValue("@a5", cmbokul.Text);
            kytguncelle.Parameters.AddWithValue("@a6", txtpuan.Text);
            kytguncelle.Parameters.AddWithValue("@a7", txtsececegisehir.Text);
            kytguncelle.Parameters.AddWithValue("@a8", txtuniversite.Text);
            kytguncelle.Parameters.AddWithValue("@a9", mskTC.Text);

            kytguncelle.ExecuteNonQuery();
            bagadres.Close();
            MessageBox.Show("Güncelleme İşlemi Baarılı");
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
