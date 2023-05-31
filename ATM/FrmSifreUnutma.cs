using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class FrmSifreUnutma : Form
    {
        public FrmSifreUnutma()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnTelefon_Click(object sender, EventArgs e)
        {
            LblTel.Visible = true;
            LblMobil1.Visible = false;
            LblMobil2.Visible = false;
            LblInternet.Visible = false;

        }

        private void BtnInternet_Click(object sender, EventArgs e)
        {
            LblInternet.Visible = true;
            LblMobil1.Visible = false;
            LblMobil2.Visible = false;
            LblTel.Visible = false;
        }

        private void BtnMobil_Click(object sender, EventArgs e)
        {
            LblMobil1.Visible = true;
            LblMobil2.Visible = true;
            LblTel.Visible = false;
            LblInternet.Visible = false;
        }

        private void BtnAtm_Click(object sender, EventArgs e)
        {
            FrmSifreATM sa = new FrmSifreATM();
            sa.Show();
            this.Hide();
        }
    }
}
