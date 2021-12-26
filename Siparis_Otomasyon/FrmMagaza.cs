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
    public partial class FrmMagaza : Form
    {
        public FrmMagaza()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        FrmAtistirmalik mgzurun = new FrmAtistirmalik();

        private void button1_Click(object sender, EventArgs e)
        {
            
            mgzurun.Show();
            this.Hide();
        }

        private void FrmMagaza_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmTemelGida temelgida = new FrmTemelGida();
            temelgida.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmIcecek icecek = new FrmIcecek();
            icecek.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmMusteriMenu frmMusteriMenu = new FrmMusteriMenu();
            frmMusteriMenu.Show();
            this.Hide();
        }
    }
}
