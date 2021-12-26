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
    public partial class FrmMarkaEkle : Form
    {
        public FrmMarkaEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        bool durum;
        private void markaengelle()
        {
            // Durumu istediğimiz işlemde true, istemediğimiz işlemde false olarak tanımlayacağız.
            durum = true;
            SqlCommand komut = new SqlCommand("Select * From marka_bilgi", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                // eğer aradığımız kategori veritabanında varsa durumu false yap
                if (cmbkategori.Text == read["kategori"].ToString() && txtmarka.Text == read["marka"].ToString() || cmbkategori.Text == "" || txtmarka.Text == "")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }

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

        private void btnekle_Click(object sender, EventArgs e)
        {
            markaengelle();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("Insert into marka_bilgi(kategori,marka) values('" + cmbkategori.Text + "','" + txtmarka.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var", "Uyarı");
            }

            txtmarka.Text = "";
            cmbkategori.Text = "";

        }

        private void FrmMarkaEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKullaniciAnaSayfa kullaniciAnaSayfa = new FrmKullaniciAnaSayfa();
            kullaniciAnaSayfa.Show();
            this.Hide();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.WhiteSmoke;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor=Color.FromArgb(78, 184, 206);
        }
    }
}
