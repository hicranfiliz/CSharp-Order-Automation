using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Siparis_Otomasyon
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-A0KGUVJ\\;Initial Catalog=Siparis_Otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
