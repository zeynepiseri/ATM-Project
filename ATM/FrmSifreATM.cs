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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ATM
{
    public partial class FrmSifreATM : Form
    {
        public FrmSifreATM()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("update tbl_musteribilgi set musteriAd=@m1, musteriSoyad=@m2, musteriTC=@m4, musteriDT=@m5, musteriTel=@m6, musterisifre=@m7 where musteriAnKız=@m3", bgl.baglanti());
            cmd1.Parameters.AddWithValue("@m1", TxtAd.Text);
            cmd1.Parameters.AddWithValue("@m2", TxtSoyad.Text);
            cmd1.Parameters.AddWithValue("@m3", TxtAnKız.Text);
            cmd1.Parameters.AddWithValue("@m4", MskTC.Text);
            cmd1.Parameters.AddWithValue("@m5", TxtDT.Text);
            cmd1.Parameters.AddWithValue("@m6", MskTel.Text);
            cmd1.Parameters.AddWithValue("@m7", MskSifre.Text);

            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Şifre Güncelleme işlemi Tamamlandı. Giriş Ekranına Dönebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifre Güncelleme işlemi Tamamlanamadı. Bilgilerinizi Kontrol Edip Tekrar Deneyiniz ya da Diğer Şifre Güncelleme Adımlarına Gidiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
        
        private void TxtAnKız_TextChanged(object sender, EventArgs e)
        {
            // Sadece 2 karakter kabul edilsin
            if (TxtAnKız.Text.Length > 2)
            {
                // İzin verilen maksimum karakter sayısını aşan fazla karakterleri kırpar
                TxtAnKız.Text = TxtAnKız.Text.Substring(0, 2);
            }
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
