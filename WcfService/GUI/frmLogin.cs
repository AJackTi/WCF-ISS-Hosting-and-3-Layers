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
using GUI;

namespace GUI
{
    public partial class frmLogin : MetroForm
    {
        CheckBusineesRuleLogins checkBusineesRuleLogins;
        public frmLogin()
        {
            InitializeComponent();
            checkBusineesRuleLogins = new CheckBusineesRuleLogins();
            Init_Data();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Save_Data()
        {
            if (chkRem.Checked)
            {
                Properties.Settings.Default.UserName = mtbxUserName.Text;
                Properties.Settings.Default.Password = mtbxPassword.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = mtbxUserName.Text;
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
                    mtbxUserName.Text = Properties.Settings.Default.UserName;
                    mtbxPassword.Text = Properties.Settings.Default.Password;
                    chkRem.Checked = true;
                }
                else
                {
                    mtbxUserName.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(checkBusineesRuleLogins.CheckLogin(this.mtbxUserName.Text, this.mtbxPassword.Text))
            {
                if(this.mtbxUserName.Text == "admin")
                {
                    this.Hide();
                    frmSale frmsale = new frmSale();
                    frmsale.Show();
                }
                else
                {
                    this.Hide();
                    frmBuying frmbuying = new frmBuying();
                    frmbuying.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is not correct! Try again!!!");
                return;
            }
        }
    }
}
