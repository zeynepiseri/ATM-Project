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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_MusteriBilgi where MusteriSifre=@m1", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", txtsifre.Text);

            SqlDataReader rdr = komut.ExecuteReader();
            if (rdr.Read())
            {
                FrmİslemlerAna fr = new FrmİslemlerAna();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre");
            }
            bgl.baglanti().Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreUnutma fsu = new FrmSifreUnutma();
            fsu.Show();
            this.Hide();
            bgl.baglanti().Close();
        }
    }
}
