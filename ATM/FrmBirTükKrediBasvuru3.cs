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
    public partial class FrmBirTükKrediBasvuru3 : Form
    {
        public FrmBirTükKrediBasvuru3()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmBirKrediBasvuru4 frk = new FrmBirKrediBasvuru4();
            frk.Show();
            this.Hide();
        }

        private void PnlKartIade_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKartIade fri = new FrmKartIade();
            fri.Show();
            this.Hide();
        }
    }
}
