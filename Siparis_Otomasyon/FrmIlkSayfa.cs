using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_Otomasyon
{
    public partial class FrmIlkSayfa : Form
    {
        public FrmIlkSayfa()
        {
            InitializeComponent();
        }

        FrmMusteriGirisi fr = new FrmMusteriGirisi();
        FrmKullaniciGirisi kullanicigiris = new FrmKullaniciGirisi();

        private void btnadmin_MouseMove(object sender, MouseEventArgs e)
        {
            btnadmin.BackgroundImage = Properties.Resources.admin1;
            //btnadmin.Image = Properties.Resources.admin1;
            label2.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnadmin_MouseLeave(object sender, EventArgs e)
        {
            btnadmin.BackgroundImage = Properties.Resources.admin2;
            label2.ForeColor = Color.WhiteSmoke;
        }

        private void btnmusteri_MouseMove(object sender, MouseEventArgs e)
        {
            btnmusteri.BackgroundImage = Properties.Resources.firstuser2;
            label3.ForeColor=Color.FromArgb(78, 184, 206);
        }

        private void btnmusteri_MouseLeave(object sender, EventArgs e)
        {
            btnmusteri.BackgroundImage = Properties.Resources.firstuser;
            label3.ForeColor = Color.WhiteSmoke;
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
           

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr.Left += 10;
            if (fr.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                fr.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fr.Left -= 10;
            if (fr.Left <= 525)
            {
                timer2.Stop();
            }
        }

        private void FrmIlkSayfa_Load(object sender, EventArgs e)
        {
            fr.Show();
            kullanicigiris.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            kullanicigiris.Left += 10;
            if (kullanicigiris.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                kullanicigiris.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            kullanicigiris.Left -= 10;
            if (kullanicigiris.Left <= 525)
            {
                timer4.Stop();
            }
        }
    }
}
