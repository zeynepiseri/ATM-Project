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
    public partial class FrmBakSifre3 : Form
    {
        public FrmBakSifre3()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_musteribilgi where musterisifre=@m1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@m1", MskMevcutSifre.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                FrmBakSifre4 fr4 = new FrmBakSifre4();
                fr4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Mevcut Şifre Yanlış!");
            }
        }

        private void PnlPc4_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frmia = new FrmKartIade();
            frmia.Show();
            this.Hide();
        }
    }
}
