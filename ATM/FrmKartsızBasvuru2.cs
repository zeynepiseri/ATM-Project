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


namespace ATM
{
    public partial class FrmKartsızBasvuru2 : Form
    {
        public FrmKartsızBasvuru2()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnTamam_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_musteribilgi where musteriTel=@m1", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", MskTC.Text);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read())
            {
                FrmBasvuru4 frb = new FrmBasvuru4();
                frb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Telefon Numarası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
