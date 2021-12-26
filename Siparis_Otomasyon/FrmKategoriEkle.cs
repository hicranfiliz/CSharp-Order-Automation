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
    public partial class FrmKategoriEkle : Form
    {
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        bool durum;
        private void kategoriengelle()
        {
            // Durumu istediğimiz işlemde true, istemediğimiz işlemde false olarak tanımlayacağız.
            durum = true;
            SqlCommand komut = new SqlCommand("Select * From kategori_bilgi", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                // eğer aradığımız kategori veritabanında varsa durumu false yap
                if (txtkategori.Text == read["kategori"].ToString() || txtkategori.Text == "")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("Insert into kategori_bilgi(kategori) values('" + txtkategori.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Zaten Var", "Uyarı");
            }
            txtkategori.Text = "";
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
