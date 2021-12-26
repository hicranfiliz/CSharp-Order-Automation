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

namespace Siparis_Otomasyon
{
    public partial class FrmIcecek : Form
    {
        public FrmIcecek()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();

        private void FrmIcecek_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From urun where kategori = 'İçecek'", bgl.baglanti());
            adtr.Fill(dt);
            dataGridViewIcecek.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMagaza magaza = new FrmMagaza();
            magaza.Show();
            this.Hide();

        }

        private void dataGridViewIcecek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewIcecek.SelectedCells[0].RowIndex;
            cmbkategori.Text = dataGridViewIcecek.Rows[secilen].Cells[1].Value.ToString();
            cmbmarka.Text = dataGridViewIcecek.Rows[secilen].Cells[2].Value.ToString();
            txtıd.Text = dataGridViewIcecek.Rows[secilen].Cells[0].Value.ToString();
            txturunadi.Text = dataGridViewIcecek.Rows[secilen].Cells[6].Value.ToString();
            txtmiktari.Text = dataGridViewIcecek.Rows[secilen].Cells[3].Value.ToString();
            txtfiyat.Text = dataGridViewIcecek.Rows[secilen].Cells[4].Value.ToString();
            txtKDV.Text = dataGridViewIcecek.Rows[secilen].Cells[5].Value.ToString();
            txtaciklama.Text = dataGridViewIcecek.Rows[secilen].Cells[8].Value.ToString();
            txttoplamfiyat.Text = dataGridViewIcecek.Rows[secilen].Cells[9].Value.ToString();
            txtmiktari.Text = "1";
        }

        bool durum;
        private void IdKontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select * From sepet", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (txtıd.Text == dr["urunId"].ToString())
                {
                    durum = false;
                }
            }
        }

        private void hesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select sum(toplamfiyat) from sepet ", bgl.baglanti());
                txttoplamfiyat.Text = komut.ExecuteScalar() + "TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsepeteekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi.");
            IdKontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("Insert into sepet (urunId,kategori,marka,miktar,urunadi,tarih,aciklama,fiyat,toplamfiyat,KDV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ", bgl.baglanti());
                // txttoplamfiyat.Text = (decimal.Parse(txtKDV.Text) + decimal.Parse(txtfiyat.Text)).ToString();
                komut.Parameters.AddWithValue("@p1", txtıd.Text);
                komut.Parameters.AddWithValue("@p2", cmbkategori.Text);
                komut.Parameters.AddWithValue("@p3", cmbmarka.Text);
                komut.Parameters.AddWithValue("@p4", int.Parse(txtmiktari.Text));
                komut.Parameters.AddWithValue("@p5", txturunadi.Text);
                komut.Parameters.AddWithValue("@p6", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@p7", txtaciklama.Text);
                komut.Parameters.AddWithValue("@p8", decimal.Parse(txtfiyat.Text));
                komut.Parameters.AddWithValue("@p9", decimal.Parse(txttoplamfiyat.Text) * int.Parse(txtmiktari.Text));
                komut.Parameters.AddWithValue("@p10", decimal.Parse(txtKDV.Text));
                komut.ExecuteNonQuery();
                // SqlCommand komut2 = new SqlCommand("Update sepet set miktar=miktar+'" + int.Parse(txtmiktari.Text) + "'  where urunId= '" + txtıd.Text + "'", bgl.baglanti());
                // komut2.ExecuteNonQuery();
                //SqlCommand komut3 = new SqlCommand("Update sepet set toplamfiyat=miktar*(fiyat+KDV) where urunId= '" + txtıd.Text + "'", bgl.baglanti());
                // komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                hesapla();
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("Update sepet set miktar=miktar+'" + int.Parse(txtmiktari.Text) + "'  where urunId= '" + txtıd.Text + "'", bgl.baglanti());
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("Update sepet set toplamfiyat=miktar*(fiyat+KDV) where urunId= '" + txtıd.Text + "'", bgl.baglanti());
                bgl.baglanti().Close();
            }


            //daset.Tables["sepet"].Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From sepet", bgl.baglanti());
            adtr.Fill(daset, "sepet");
            hesapla();


            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtmiktari)
                    {
                        item.Text = "";
                    }
                }

            }

        }

        private void btnsepetegit_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.Show();
            this.Hide();
        }
    }
    
}
