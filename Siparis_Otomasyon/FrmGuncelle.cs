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
    public partial class FrmGuncelle : Form
    {
        public FrmGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();
        DataSet daset2 = new DataSet();

        private void dataGridViewguncelle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridViewguncelle.SelectedCells[0].RowIndex;
            txturunId.Text = dataGridViewguncelle.Rows[secilen].Cells[0].Value.ToString();
            cmbkategori.Text = dataGridViewguncelle.Rows[secilen].Cells[1].Value.ToString();
            cmbmarka.Text = dataGridViewguncelle.Rows[secilen].Cells[2].Value.ToString();
            txtmiktari.Text = dataGridViewguncelle.Rows[secilen].Cells[3].Value.ToString();
            txtfiyati.Text = dataGridViewguncelle.Rows[secilen].Cells[4].Value.ToString();
            txtkdv.Text = dataGridViewguncelle.Rows[secilen].Cells[5].Value.ToString();
            txturunadi.Text = dataGridViewguncelle.Rows[secilen].Cells[6].Value.ToString();
            txtaciklama.Text = dataGridViewguncelle.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update urun Set kategori=@p1,marka=@p2,urunadi=@p3,miktar=@p4,fiyat=@p5,KDV=@p6,aciklama=@p7 where urunId=@p8", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", cmbkategori.Text);
            komutguncelle.Parameters.AddWithValue("@p2", cmbmarka.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txturunadi.Text);
            komutguncelle.Parameters.AddWithValue("@p4", int.Parse(txtmiktari.Text));
            komutguncelle.Parameters.AddWithValue("@p5", float.Parse(txtfiyati.Text));
            komutguncelle.Parameters.AddWithValue("@p6", float.Parse(txtkdv.Text));
            komutguncelle.Parameters.AddWithValue("@p7", txtaciklama.Text);
            komutguncelle.Parameters.AddWithValue("@p8", txturunId.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Ürün Bilgileri Güncellendi");

            //Tabloyu temizleyip yeni kaydı getirme:
            daset.Tables["urun"].Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From urun", bgl.baglanti());
            adtr.Fill(daset, "urun");
            dataGridViewguncelle.DataSource = daset.Tables["urun"];
            bgl.baglanti().Close();

            

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



        private void FrmGuncelle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From urun ", bgl.baglanti());
            adtr.Fill(daset, "urun");
            dataGridViewguncelle.DataSource = daset.Tables["urun"];
            bgl.baglanti().Close();
        }

        private void txtvarurunıd_TextChanged(object sender, EventArgs e)
        {
            if (txtvarurunıd.Text=="")
            {
                lblmiktar.Text = "";
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

            //ürün ıd girildiği zamamn ürünün diğer bilgileri textlere gelsin
            SqlCommand komut = new SqlCommand("Select * From urun where urunId like '" + txtvarurunıd.Text + "'", bgl.baglanti());
            SqlDataReader dt = komut.ExecuteReader();
            while (dt.Read())
            {
                cmbvarkategori.Text = dt["kategori"].ToString();
                cmbvarmarka.Text = dt["marka"].ToString();
                txtvarurunadi.Text = dt["urunadi"].ToString();
                lblmiktar.Text = dt["miktar"].ToString();
                txtvarfiyat.Text = dt["fiyat"].ToString();
                txtvarkdv.Text = dt["KDV"].ToString();
                txtvaraciklama.Text = dt["aciklama"].ToString();
            }
        }

        private void btnvarekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update urun set miktar='"+ (int.Parse(lblmiktar.Text) +int.Parse(txtvarmiktari.Text)).ToString() +"' where urunId='"+txtvarurunıd.Text+"'",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");

            daset.Tables["urun"].Clear();
            SqlDataAdapter adtr2 = new SqlDataAdapter("Select * From urun", bgl.baglanti());
            adtr2.Fill(daset2, "urun");
            dataGridViewguncelle.DataSource = daset2.Tables["urun"];
            bgl.baglanti().Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from urun where urunId=@urunId", bgl.baglanti());
            komut2.Parameters.AddWithValue("@urunId", txturunId.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            daset.Tables["urun"].Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From urun ", bgl.baglanti());
            adtr.Fill(daset, "urun");
            dataGridViewguncelle.DataSource = daset.Tables["urun"];
            bgl.baglanti().Close();

            MessageBox.Show("Ürün Kaydı Silindi");

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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmKullaniciAnaSayfa frfr = new FrmKullaniciAnaSayfa();
            frfr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKullaniciAnaSayfa gerigit = new FrmKullaniciAnaSayfa();
            gerigit.Show();
            this.Hide();
        }
    }
    /*public class FormDuzenle
    {
        public void formDuzenle(Form duzenlenecekForm)
        {
            duzenlenecekForm.BackColor = Color.FromArgb(32, 36, 48);
            duzenlenecekForm.ForeColor = Color.FromArgb(78, 184, 206);
            duzenlenecekForm.FormBorderStyle = FormBorderStyle.None;
            duzenlenecekForm.Size = new Size(326, 487);
            duzenlenecekForm.StartPosition=FormStartPosition.CenterScreen;
        }
    }*/
}
