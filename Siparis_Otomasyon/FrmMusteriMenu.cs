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
    public partial class FrmMusteriMenu : Form
    {
        public FrmMusteriMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmIlkSayfa frmIlkSayfa = new FrmIlkSayfa();
            frmIlkSayfa.Show();
            this.Hide();
        }

        private void btnMagaza_Click(object sender, EventArgs e)
        {
            FrmMagaza magaza = new FrmMagaza();
            magaza.Show();
            this.Hide();
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.Show();
            this.Hide();
        }

        private void btnSiparisDurunu_Click(object sender, EventArgs e)
        {
            FrmSipaisBilgi bilgi = new FrmSipaisBilgi();
            bilgi.Show();
            this.Hide();
        }

        
    }
}
