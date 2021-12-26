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
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        FrmKullaniciKayit kullanicikayit = new FrmKullaniciKayit();
        FrmKullaniciAnaSayfa urunekle = new FrmKullaniciAnaSayfa();

        private void txtkullaniciadi_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Clear();
            pictureBox2.Image = Properties.Resources.user2;
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtkullaniciadi.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox3.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;
        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
            txtsifre.Clear();
            txtsifre.PasswordChar = '*';
            pictureBox3.Image = Properties.Resources.sifre2;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtsifre.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kullanicikayit.Left += 10;
            if (kullanicikayit.Left>=830)
            {
                timer1.Stop();
                this.TopMost = false;
                kullanicikayit.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kullanicikayit.Left -= 10;
            if (kullanicikayit.Left<=525)
            {
                timer2.Stop();
            }
        }

        private void FrmKullaniciGirisi_Load(object sender, EventArgs e)
        {
            kullanicikayit.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text=="" || txtsifre.Text=="")
            {
                MessageBox.Show("Kulanıcı Adı veya Şifre Boş Olamaz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select * From kullanici where kullaniciadi='" + txtkullaniciadi.Text + "'and sifre= '" + txtsifre.Text + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    
                    timer3.Start();
                    urunekle.Show();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "Uyarı-2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            urunekle.Left += 10;
            if (urunekle.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                urunekle.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            urunekle.Left -= 10;
            if (urunekle.Left <= 525)
            {
                timer4.Stop();
            }
        }

         private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState==CheckState.Checked)
            {
                txtsifre.UseSystemPasswordChar= true;
            }
            else if (checkBox2.CheckState==CheckState.Unchecked)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
