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
using DAL;
using GUI.ServiceReference;
using WcfService;

namespace GUI
{
    public partial class frmMain : MetroForm
    {
        ServiceReference.Service1Client obj;
        public frmMain()
        {
            obj = new Service1Client();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.dgvListProducts.DataSource = obj.GetALlProduct();
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
