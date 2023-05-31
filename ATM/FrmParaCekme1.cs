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
    public partial class FrmParaCekme1 : Form
    {
        public FrmParaCekme1()
        {
            InitializeComponent();
        }



        private void PanelHesap_MouseClick(object sender, MouseEventArgs e)
        {
            FrmParaCekme2 frpc = new FrmParaCekme2();
            frpc.Show();
            this.Hide();
        }

        private void PnlKartIade_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade frki = new FrmKartIade();
            frki.Show();
            this.Hide();
        }

        private void PnlAnaMenu_MouseClick(object sender, MouseEventArgs e)
        {
            FrmİslemlerAna frislem=new FrmİslemlerAna();
            frislem.Show();
            this.Hide();
        }
    }
}
