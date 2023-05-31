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
    public partial class FrmBasvuru1 : Form
    {
        public FrmBasvuru1()
        {
            InitializeComponent();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartsızBasvuru1 frb = new FrmKartsızBasvuru1();
            frb.Show();
            this.Hide();
        }

        private void PnlKartIade_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frmKartIade = new FrmKartIade();
            frmKartIade.Show();
            this.Hide();
        }

        private void PnlAnaMenu_MouseClick(object sender, MouseEventArgs e)
        {
            FrmİslemlerAna frm = new FrmİslemlerAna();
            frm.Show();
            this.Hide();
        }

        private void ParaÇekme_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBirKrediBasvuru1 frk = new FrmBirKrediBasvuru1();
            frk.Show();
            this.Hide();
        }
    }
}
