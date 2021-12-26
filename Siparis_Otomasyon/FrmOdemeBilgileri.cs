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
    public partial class FrmOdemeBilgileri : Form
    {
        public FrmOdemeBilgileri()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataSet daset = new DataSet();
        private void radioBtnKartBilgileri_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnKartBilgileri.Checked==true)
            {
                groupBoxCheck.Enabled = false;
                groupBoxKart.Enabled = true;
                panel5.BackColor = Color.Black;
                panel4.BackColor = Color.Black;
                panel1.BackColor = Color.FromArgb(78, 184, 206);
                panel2.BackColor = Color.FromArgb(78, 184, 206);
                panel3.BackColor = Color.FromArgb(78, 184, 206);
                txtAdSoyadCheck.Text = "";
                maskedTxtKartNumarasiCheck.Text = "";
            }
        }

        private void radioBtnCheckBilgileri_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCheckBilgileri.Checked == true)
            {
                groupBoxKart.Enabled = false;
                groupBoxCheck.Enabled = true;
                panel3.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel1.BackColor = Color.Black;
                panel5.BackColor = Color.FromArgb(78, 184, 206);
                panel4.BackColor = Color.FromArgb(78, 184, 206);
                txtAdSoyad.Text = "";
                maskedTxtCVC.Text = "";
                maskedTxtGecerlilikTarihi.Text = "";
                maskedTxtKartNumarasi.Text = "";
            }
        }

        private void btnAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            FrmMusteriMenu frmMusteriMenu = new FrmMusteriMenu();
            frmMusteriMenu.Show();
            this.Hide();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
           

                //SqlCommand komut2 = new SqlCommand("Update Urun set miktari=miktari-'" + int.Parse(dataGridViewsatis.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridViewsatis.Rows[i].Cells["barkodno"].Value.ToString() + "' ", bgl.baglanti());
                //// Kayıtta Kaç tane varsa o kadarının stoktan düşmesi lazım.
                //komut2.ExecuteNonQuery();
                //bgl.baglanti().Close();

            MessageBox.Show("Siparişiniz alınmıştır.");
            SqlCommand komut = new SqlCommand("Delete from sepet ", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
