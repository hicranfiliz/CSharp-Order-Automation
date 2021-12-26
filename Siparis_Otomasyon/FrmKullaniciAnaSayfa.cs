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
    public partial class FrmKullaniciAnaSayfa : Form
    {
        public FrmKullaniciAnaSayfa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEklemeSayfasi fr = new FrmUrunEklemeSayfasi();
            fr.Show();
            this.Hide();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriEkle fr = new FrmKategoriEkle();
            fr.Show();
            this.Hide();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            FrmMarkaEkle fr = new FrmMarkaEkle();
            fr.Show();
            this.Hide();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FrmUrunler urunler = new FrmUrunler();
            urunler.Show();
            this.Hide();

            
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            FrmGuncelle urunguncelle = new FrmGuncelle();
            urunguncelle.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmMusteriGor fr = new FrmMusteriGor();
            fr.Show();
            this.Hide();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmIlkSayfa ılksayfa = new FrmIlkSayfa();
            ılksayfa.Show();
            this.Hide();
        }
    }
}
