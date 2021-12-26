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
    public partial class FrmSipaisBilgi : Form
    {
        public FrmSipaisBilgi()
        {
            InitializeComponent();
        }

        private void FrmSipaisBilgi_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Today.ToString("d/MM/yyyy");
            DateTime tarih = new DateTime(2021, 12, 30);
            label9.Text = tarih.ToString();
            
        }
    }
}
