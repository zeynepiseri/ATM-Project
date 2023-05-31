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
    public partial class FrmKartsızBasvuru1 : Form
    {
        public FrmKartsızBasvuru1()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl= new SqlBaglantisi();
        private void BtnTamam_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_musteribilgi where musteriTC=@m1",bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", MskTC.Text);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read())
            {
                FrmKartsızBasvuru2 frb= new FrmKartsızBasvuru2();
                frb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik Numarası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
