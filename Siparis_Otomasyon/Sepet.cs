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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
            hesapla();
        }

        private void hesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select sum(toplamfiyat) from sepet ", bgl.baglanti());
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void sepetlistele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From sepet", bgl.baglanti());
            adtr.Fill(daset, "sepet");
            dataGridViewsepet.DataSource = daset.Tables["sepet"];
            dataGridViewsepet.Columns[0].Visible = false;
            dataGridViewsepet.Columns[1].Visible = false;
            dataGridViewsepet.Columns[2].Visible = false;
            dataGridViewsepet.Columns[7].Visible = false;
            dataGridViewsepet.Columns[9].Visible = false;


            bgl.baglanti().Close();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();
        
        private void Sepet_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From sepet", bgl.baglanti());
            adtr.Fill(daset, "sepet");
            dataGridViewsepet.DataSource = daset.Tables["sepet"];
            dataGridViewsepet.Columns[0].Visible = false;
            dataGridViewsepet.Columns[1].Visible = false;
            dataGridViewsepet.Columns[2].Visible = false;
            dataGridViewsepet.Columns[7].Visible = false;
            dataGridViewsepet.Columns[9].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAtistirmalik atistir = new FrmAtistirmalik();
            atistir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMagaza magaza = new FrmMagaza();
            magaza.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from sepet where urunId='" + dataGridViewsepet.CurrentRow.Cells["urunId"].Value.ToString() + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from sepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdemeBilgileri frmOdemeBilgiler = new FrmOdemeBilgileri();
            frmOdemeBilgiler.Show();
            this.Hide();
        }
    }
}
