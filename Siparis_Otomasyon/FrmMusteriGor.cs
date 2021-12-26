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
    public partial class FrmMusteriGor : Form
    {
        public FrmMusteriGor()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();
        FrmKullaniciAnaSayfa kullanicianasayfa;

        private void FrmMusteriGor_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From musteri",bgl.baglanti());
            adtr.Fill(daset, "musteri");
            dataGridViewmusterigor.DataSource = daset.Tables["musteri"];
            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanicianasayfa= new FrmKullaniciAnaSayfa();
            kullanicianasayfa.Show();
            this.Hide();
        }
    }
}
