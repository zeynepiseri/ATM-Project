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
    public partial class FrmParaCekme4 : Form
    {
        public FrmParaCekme4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmParaCekme3 frcek = new FrmParaCekme3();
            frcek.Show();
            this.Hide();
        }
    }
}
