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
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            Init_Data();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Save_Data()
        {
            if (chkRem.Checked)
            {
                Properties.Settings.Default.UserName = tbxUserName.Text;
                Properties.Settings.Default.Password = tbxPassword.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = tbxUserName.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme=="yes")
                {
                    tbxUserName.Text = Properties.Settings.Default.UserName;
                    tbxPassword.Text = Properties.Settings.Default.Password;
                    chkRem.Checked = true;
                }
                else
                {
                    tbxUserName.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private bool Check_Account(string User, string Pass)
        {
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((tbxUserName.Text == "admin") && (tbxPassword.Text == "admin"))
            {
                Save_Data();
                frmSale frmmain = new frmSale();
                frmmain.Show();
            }
            else
            {
                MessageBox.Show("Account is not exist");
            }
        }
    }
}
