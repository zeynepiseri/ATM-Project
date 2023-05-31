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

namespace ATM
{
    public partial class FrmParaCekme2 : Form
    {
        public FrmParaCekme2()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void PnlPc1_MouseClick(object sender, MouseEventArgs e)
        {
            string musteriId = "1"; // Güncellenmek istenen müşteri ID'si
            decimal azaltmaMiktari = 20; // Azaltılacak miktar

            string connectionString = "Data Source=ZEYNEPISERI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True"; // Veritabanı bağlantı dizesi
            string sqlSorgusu = $"UPDATE Tbl_Musteribilgi SET musteribakiye = musteribakiye - {azaltmaMiktari} WHERE musteriId = '{musteriId}'";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
            }

            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPc2_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPc3_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPc4_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPc5_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPc6_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPc7_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme3 frpc = new FrmParaCekme3();
            frpc.Show();
            this.Hide();
        }

        private void PnlPcDiger_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme4 frpc = new FrmParaCekme4();
            frpc.Show();
            this.Hide();
        }
    }
}
