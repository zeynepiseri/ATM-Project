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
    public partial class FrmBakSifre2 : Form
    {
        public FrmBakSifre2()
        {
            InitializeComponent();
        }

        private void PnlPc4_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frm = new FrmKartIade();    
            frm.Show();
            this.Hide();
        }

        private void PnlPcDiger_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBakSifre3 frm = new FrmBakSifre3();
            frm.Show();
            this.Hide();
        }
    }
}
