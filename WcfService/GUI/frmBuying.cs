using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GUI
{
    public partial class frmBuying : MetroForm
    {
        public frmBuying()
        {
            InitializeComponent();
        }

        private void frmBuying_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmBuying_Load(object sender, EventArgs e)
        {
        }
    }
}
