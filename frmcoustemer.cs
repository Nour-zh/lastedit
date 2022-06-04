using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastedit
{
    public partial class frmcoustemer : Form
    {
        public frmcoustemer()
        {
            InitializeComponent();
        }

    

        private void btnmenue_Click(object sender, EventArgs e)
        {
            frmminue frm = new frmminue();
            this.Hide();
            frm.Show();

        }

        private void btnbasket_Click(object sender, EventArgs e)
        {
            frmbasket frm = new frmbasket();
            this.Hide();
            frm.Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            frmhelp frm = new frmhelp();
            this.Hide();
            frm.Show();
           
        }
    }
}
