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
    public partial class FrmKullaniciKayit : Form
    {
        public FrmKullaniciKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        FrmKullaniciGirisi kullanicigiris;

        private void txtadsoyad_Click(object sender, EventArgs e)
        {
            txtadsoyad.Clear();
            picadsoyad.Image = Properties.Resources.adsoyad2;
            paneladsoyad.ForeColor = Color.FromArgb(78, 184, 206);
            paneladsoyad.BackColor = Color.FromArgb(78, 184, 206);
            txtadsoyad.ForeColor = Color.FromArgb(78, 184, 206);

            picsifre.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;

            picmail.Image = Properties.Resources.mail1;
            panel4.ForeColor = Color.WhiteSmoke;
            txtmail.ForeColor = Color.WhiteSmoke;

            picuser.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;

            picadres.Image = Properties.Resources.adres;
            panel3.ForeColor = Color.WhiteSmoke;
            txtadres.ForeColor = Color.WhiteSmoke;

            pictelefon.Image = Properties.Resources.phone1;
            paneltel.ForeColor = Color.WhiteSmoke;
            msktelefon.ForeColor = Color.WhiteSmoke;
        }

        private void txtkullaniciadi_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Clear();
            picuser.Image = Properties.Resources.user2;
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtkullaniciadi.ForeColor = Color.FromArgb(78, 184, 206);

            picsifre.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;

            picmail.Image = Properties.Resources.mail1;
            panel4.ForeColor = Color.WhiteSmoke;
            txtmail.ForeColor = Color.WhiteSmoke;

            picadres.Image = Properties.Resources.adres;
            panel3.ForeColor = Color.WhiteSmoke;
            txtadres.ForeColor = Color.WhiteSmoke;

            pictelefon.Image = Properties.Resources.phone1;
            paneltel.ForeColor = Color.WhiteSmoke;
            msktelefon.ForeColor = Color.WhiteSmoke;

            picadsoyad.Image = Properties.Resources.adsoyad1;
            paneladsoyad.ForeColor = Color.WhiteSmoke;
            txtadsoyad.ForeColor = Color.WhiteSmoke;
        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
            txtsifre.Clear();
            picsifre.Image = Properties.Resources.sifre2;
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtsifre.ForeColor = Color.FromArgb(78, 184, 206);

            picuser.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;

            picmail.Image = Properties.Resources.mail1;
            panel4.ForeColor = Color.WhiteSmoke;
            txtmail.ForeColor = Color.WhiteSmoke;

            picadres.Image = Properties.Resources.adres;
            panel3.ForeColor = Color.WhiteSmoke;
            txtadres.ForeColor = Color.WhiteSmoke;

            pictelefon.Image = Properties.Resources.phone1;
            paneltel.ForeColor = Color.WhiteSmoke;
            msktelefon.ForeColor = Color.WhiteSmoke;

            picadsoyad.Image = Properties.Resources.adsoyad1;
            paneladsoyad.ForeColor = Color.WhiteSmoke;
            txtadsoyad.ForeColor = Color.WhiteSmoke;
        }

        private void txtmail_Click(object sender, EventArgs e)
        {
            txtmail.Clear();
            picmail.Image = Properties.Resources.mail2;
            panel4.ForeColor = Color.FromArgb(78, 184, 206);
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            txtmail.ForeColor = Color.FromArgb(78, 184, 206);

            picsifre.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;

            picuser.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;

            picadres.Image = Properties.Resources.adres;
            panel3.ForeColor = Color.WhiteSmoke;
            txtadres.ForeColor = Color.WhiteSmoke;

            pictelefon.Image = Properties.Resources.phone1;
            paneltel.ForeColor = Color.WhiteSmoke;
            msktelefon.ForeColor = Color.WhiteSmoke;

            picadsoyad.Image = Properties.Resources.adsoyad1;
            paneladsoyad.ForeColor = Color.WhiteSmoke;
            txtadsoyad.ForeColor = Color.WhiteSmoke;
        }

        private void msktelefon_Click(object sender, EventArgs e)
        {
            msktelefon.Clear();
            pictelefon.Image = Properties.Resources.phone2;
            paneltel.ForeColor = Color.FromArgb(78, 184, 206);
            paneltel.BackColor = Color.FromArgb(78, 184, 206);
            msktelefon.ForeColor = Color.FromArgb(78, 184, 206);

            picsifre.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;

            picmail.Image = Properties.Resources.mail1;
            panel4.ForeColor = Color.WhiteSmoke;
            txtmail.ForeColor = Color.WhiteSmoke;

            picuser.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;

            picadres.Image = Properties.Resources.adres;
            paneltel.ForeColor = Color.WhiteSmoke;
            txtadres.ForeColor = Color.WhiteSmoke;

            picadsoyad.Image = Properties.Resources.adsoyad1;
            paneladsoyad.ForeColor = Color.WhiteSmoke;
            txtadsoyad.ForeColor = Color.WhiteSmoke;
        }

        private void txtadres_Click(object sender, EventArgs e)
        {
            txtadres.Clear();
            picadres.Image = Properties.Resources.adres2;
            paneltel.ForeColor = Color.FromArgb(78, 184, 206);
            paneltel.BackColor = Color.FromArgb(78, 184, 206);
            txtadres.ForeColor = Color.FromArgb(78, 184, 206);

            picsifre.Image = Properties.Resources.sifre1;
            panel2.ForeColor = Color.WhiteSmoke;
            txtsifre.ForeColor = Color.WhiteSmoke;

            picmail.Image = Properties.Resources.mail1;
            panel4.ForeColor = Color.WhiteSmoke;
            txtmail.ForeColor = Color.WhiteSmoke;

            picuser.Image = Properties.Resources._456212;
            panel1.ForeColor = Color.WhiteSmoke;
            txtkullaniciadi.ForeColor = Color.WhiteSmoke;

            pictelefon.Image = Properties.Resources.phone1;
            panel3.ForeColor = Color.WhiteSmoke;
            msktelefon.ForeColor = Color.WhiteSmoke;

            picadsoyad.Image = Properties.Resources.adsoyad1;
            paneladsoyad.ForeColor = Color.WhiteSmoke;
            txtadsoyad.ForeColor = Color.WhiteSmoke;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into kullanici(adsoyad,kullaniciadi,sifre,mail,telefon,adres) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p3", txtsifre.Text);
            komut.Parameters.AddWithValue("@p4", txtmail.Text);
            komut.Parameters.AddWithValue("@p5", msktelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtadres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydınız Gerçekleşti");

            kullanicigiris = new FrmKullaniciGirisi();
            timer1.Start();
            kullanicigiris.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kullanicigiris.Left += 10;
            if (kullanicigiris.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                kullanicigiris.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kullanicigiris.Left -= 10;
            if (kullanicigiris.Left <= 525)
            {
                timer2.Stop();
            }
        }
    }
}
