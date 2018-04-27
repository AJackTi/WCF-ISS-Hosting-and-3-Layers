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
using BLL;

namespace GUI
{
    public partial class frmSale : MetroForm
    {
        private BLL.CheckBusineesRuleProduct bllBusineesRuleProduct;
        public frmSale()
        {
            bllBusineesRuleProduct = new CheckBusineesRuleProduct();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvListProducts.DataSource = bllBusineesRuleProduct.GetAllProduct();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }
    }
}
