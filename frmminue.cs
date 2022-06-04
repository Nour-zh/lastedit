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
    public partial class frmminue : Form
    {
        public frmminue()
        {
            InitializeComponent();
        }

        private void btnadmeat_Click(object sender, EventArgs e)
        {
            frmbasket frm = new frmbasket();
            this.Hide();
            frm.Show();
            lblmeat.Text = "meat _overdose suce" + lblmeat.Text;

            //meat overdose suce
        }

        private void btnadshrimp_Click(object sender, EventArgs e)
        {
            frmbasket frm = new frmbasket();
            this.Hide();
            frm.Show();

            //shrimp overdose limon
        }

        private void btnadpasta_Click(object sender, EventArgs e)
        {
            frmbasket frm = new frmbasket();
            this.Hide();
            frm.Show();

            //pasta overdosecheese
        }

        private void btnadchicken_Click(object sender, EventArgs e)
        {
            frmbasket frm = new frmbasket();
            this.Hide();
            frm.Show();

            //chicken overdose cream
        }
    }
}
