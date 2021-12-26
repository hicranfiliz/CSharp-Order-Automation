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
    public partial class FrmTemelGida : Form
    {
        public FrmTemelGida()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmTemelGida_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From urun where kategori = 'Temel Gıda'", bgl.baglanti());
            adtr.Fill(dt);
            dataGridViewTemelgida.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMagaza maaza = new FrmMagaza();
            maaza.Show();
            this.Hide();
        }
    }
}
