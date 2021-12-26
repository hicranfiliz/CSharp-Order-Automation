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
    public partial class FrmUrunEklemeSayfasi : Form
    {
        public FrmUrunEklemeSayfasi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        //bool durum;
       // //private void IdKontrol()
       //{
       //     // Durumu istediğimiz işlemde true, istemediğimiz işlemde false olarak tanımlayacağız.
       //     durum = true;
       //     SqlCommand komut3 = new SqlCommand("Select * From Urun", bgl.baglanti());
       //     SqlDataReader read = komut3.ExecuteReader();
       //     while (read.Read())
       //     {
       //         // eğer aradığımız kategori veritabanında varsa durumu false yap
       //         if (txturunId.Text == read["urunId"].ToString() || txturunId.Text == "")
       //         {
       //             durum = false;
       //         }
       //     }
       //     bgl.baglanti().Close();
       // }

        private void kategorigetir()
        {
            SqlCommand komut2 = new SqlCommand("Select * From kategori_bilgi", bgl.baglanti());
            //bilgileri çekme işleminde sqldatareader kullanıyoruz
            SqlDataReader read = komut2.ExecuteReader();
            //bilgiler okunurken şu işlemleri yap diyoruz.
            while (read.Read())
            {
                cmbkategori.Items.Add(read["kategori"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IdKontrol();
           // if (durum==true)
           // {
                SqlCommand komut = new SqlCommand("Insert into urun(kategori,marka,miktar,fiyat,KDV,urunadi,tarih,aciklama,toplamfiyat) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                //komut.Parameters.AddWithValue("@p1", txturunId.Text);
                komut.Parameters.AddWithValue("@p2", cmbkategori.Text);
                komut.Parameters.AddWithValue("@p3", cmbmarka.Text);
                komut.Parameters.AddWithValue("@p4", int.Parse(txtmiktar.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtfiyat.Text));
                komut.Parameters.AddWithValue("@p6", decimal .Parse(txtKDV.Text));
                komut.Parameters.AddWithValue("@p7", txturunadi.Text);
                komut.Parameters.AddWithValue("@p8", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@p9", txtaciklama.Text);
                txttoplamFiyat.Text = (decimal.Parse(txtKDV.Text) + decimal.Parse(txtfiyat.Text)).ToString();
                komut.Parameters.AddWithValue("@p10", decimal.Parse(txttoplamFiyat.Text));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Eklendi");
           // }
           // else
            //{
               // MessageBox.Show("Böyle Bir Ürün Id Zaten Var", "Uyarı");
           // }
            cmbmarka.Items.Clear();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }



        }

        private void FrmUrunEklemeSayfasi_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        

        private void cmbkategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();
            cmbmarka.Text = "";
            SqlCommand komut4 = new SqlCommand("Select * From marka_bilgi where kategori='" + cmbkategori.SelectedItem + "'", bgl.baglanti());
            SqlDataReader read = komut4.ExecuteReader();
            while (read.Read())
            {
                cmbmarka.Items.Add(read["marka"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmKullaniciAnaSayfa anasayfa = new FrmKullaniciAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void FrmUrunEklemeSayfasi_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.WhiteSmoke;

        }

        private void FrmUrunEklemeSayfasi_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor=Color.FromArgb(78, 184, 206);
        }
    }
}
