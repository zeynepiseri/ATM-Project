using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEYNEPISERI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
