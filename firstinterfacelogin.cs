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
    public partial class firstinterfacelogin : Form
    {
        public firstinterfacelogin()
        {
            InitializeComponent();
        }

        private void firstinterfacelogin_Load(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            frmloginadmin frm = new frmloginadmin();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel7.Controls.Add(frm);

            frm.Show();

        }



        private void btncoustemer_Click(object sender, EventArgs e)
        {
            frmcstmrlogin frm = new frmcstmrlogin();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel7.Controls.Add(frm);

            frm.Show();

        }
    }
}
