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
    public partial class FrmBirTükKrediBasvuru2 : Form
    {
        public FrmBirTükKrediBasvuru2()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmBirTükKrediBasvuru3 frk= new FrmBirTükKrediBasvuru3();
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
