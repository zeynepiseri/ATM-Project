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
    public partial class FrmParaYatırma1 : Form
    {
        public FrmParaYatırma1()
        {
            InitializeComponent();
        }

        private void ParaÇekme_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaYatırma2 frpy2 = new FrmParaYatırma2();
            frpy2.Show();
            this.Hide();
        }

        private void PnlKartIade_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frpy = new FrmKartIade();
            frpy.Show();
            this.Hide();
        }

        private void PnlAnaMenu_MouseClick(object sender, MouseEventArgs e)
        {
            FrmİslemlerAna frislem= new FrmİslemlerAna();
            frislem.Show();
            this.Hide();
        }
    }
}
