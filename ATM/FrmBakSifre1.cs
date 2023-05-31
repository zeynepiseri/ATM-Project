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
    public partial class FrmBakSifre1 : Form
    {
        public FrmBakSifre1()
        {
            InitializeComponent();
        }

        private void PnlPc6_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBakSifre2 frm = new FrmBakSifre2();
            frm.Show();
            this.Hide();
        }

        private void PnlPc4_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frmia = new FrmKartIade();    
            frmia.Show();
            this.Hide();
        }

        private void PnlPcDiger_MouseClick(object sender, MouseEventArgs e)
        {
            FrmİslemlerAna fr= new FrmİslemlerAna();
            fr.Show();
            this.Hide();
        }
    }
}
