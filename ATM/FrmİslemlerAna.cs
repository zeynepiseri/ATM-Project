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
    public partial class FrmİslemlerAna : Form
    {
        public FrmİslemlerAna()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();





        private void ParaÇekme_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme1 frpc = new FrmParaCekme1();
            frpc.Show();
            this.Hide();
        }

        private void ParaYatırma_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaYatırma1 frpc = new FrmParaYatırma1();
            frpc.Show();
            this.Hide();
        }

        private void Basvuruİslem_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBasvuru1 frb = new FrmBasvuru1();
            frb.Show();
            this.Hide();
        }

        private void BakiyeBilgi_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBakSifre1 frb = new FrmBakSifre1();
            frb.Show();
            this.Hide();
        }
    }
}
