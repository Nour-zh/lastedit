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
    public partial class frmloginadmin : Form
    {
        public frmloginadmin()
        {
            InitializeComponent();
        }

        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            Frmadmin frm = new Frmadmin();
            frm.Show();
        }

        private void frmloginadmin_Load(object sender, EventArgs e)
        {
            string connectionstring = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:D://connection folder//registration.accdb";
            OleDbbConnection connection = new OleDbConnection(connectionstring);

            string commandstring = "Select * from Student";
            OleDbCommand command = new OleDbDataAdapter(command);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            adapter.Fill(table);
           
            dataGridView1.DataSource = table;

        }
    }
}
