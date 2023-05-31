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
    public partial class FrmBakSifre4 : Form
    {
        public FrmBakSifre4()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_musteribilgi set musteriId=@m1 where musterisifre=@m2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@m1", lblid.Text);
            cmd.Parameters.AddWithValue("@m2", MskYeniSifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();

            FrmBakSifre5 frm = new FrmBakSifre5();
            frm.Show();
            this.Hide();

        }

        private void PnlPc4_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frmia = new FrmKartIade();
            frmia.Show();
            this.Hide();
        }
    }
}
