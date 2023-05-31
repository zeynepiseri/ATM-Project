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
    public partial class FrmParaYatırma2 : Form
    {
        public FrmParaYatırma2()
        {
            InitializeComponent();
        }

        private void PanelHesap_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaYatırma3 frpy3 = new FrmParaYatırma3();
            frpy3.Show();
            this.Hide();
        }

        private void PnlAnaMenu_MouseClick(object sender, MouseEventArgs e)
        {
            FrmİslemlerAna fris = new FrmİslemlerAna();
            fris.Show();
            this.Hide();
        }

        private void PnlKartIade_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade fria = new FrmKartIade();
            fria.Show();
            this.Hide();
        }
    }
}
