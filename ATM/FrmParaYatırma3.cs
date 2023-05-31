using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ATM
{
    public partial class FrmParaYatırma3 : Form
    {
        public FrmParaYatırma3()
        {
            InitializeComponent();
        }

        private void PnlAnaMenu_MouseClick(object sender, MouseEventArgs e)
        {
            string musteriId = "1"; // Hesaba para yatırılacak müşteri ID'si
            decimal yatirilanTutar;

            if (decimal.TryParse(TxtTutar.Text, out yatirilanTutar))
            {
                string connectionString = "Data Source=ZEYNEPISERI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True"; // Veritabanı bağlantı dizesi
                string sqlSorgusu = $"UPDATE Tbl_Musteribilgi SET musteribakiye = musteribakiye + {yatirilanTutar} WHERE musteriId = '{musteriId}'";

                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                }

                FrmParaYatırma4 frpy = new FrmParaYatırma4();
                frpy.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tutar girin. En Fazla 10.000 TL yatırabilirsiniz!");
            }
        }

        private void PnlKartIade_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frpy = new FrmKartIade();
            frpy.Show();
            this.Hide();
        }

        private void FrmParaYatırma3_Load(object sender, EventArgs e)
        {

        }
    }
}
