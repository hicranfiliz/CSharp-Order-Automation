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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();

        private void UrunListele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Urun", bgl.baglanti());
            adtr.Fill(daset, "Urun");
            dataGridViewurunler.DataSource = daset.Tables["Urun"];
            bgl.baglanti().Close();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKullaniciAnaSayfa fr11 = new FrmKullaniciAnaSayfa();
            fr11.Show();
            this.Hide();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.WhiteSmoke;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(78, 184, 206);
        }
    }
}
