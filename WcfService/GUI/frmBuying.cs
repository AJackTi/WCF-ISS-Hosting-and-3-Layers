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
using MyProperties;

namespace GUI
{
    public partial class frmBuying : MetroForm
    {
        private BLL.CheckBusineesRuleProduct bllBusineesRuleProduct;
        public frmBuying()
        {
            bllBusineesRuleProduct = new CheckBusineesRuleProduct();
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
            DisplayToDataGrid(bllBusineesRuleProduct.GetAllProduct());
            PopulateTreeView();
        }
        
        public void PopulateTreeView()
        {
            HashSet<string> hashset = new HashSet<string>();
            this.trvListProductType.Nodes.Clear();
            foreach(var i in bllBusineesRuleProduct.GetAllProduct())
            {
                TreeNode node = new TreeNode(i.ProductTypeObj);
                node.Tag = i;
                hashset.Add(i.ProductTypeObj);
            }

            foreach(var i in hashset)
            {
                this.trvListProductType.Nodes.Add(i);
            }
        }

        public void DisplayToDataGrid(List<ProductsObj> listProduct)
        {
            this.dgvListProducts.DataSource = listProduct;
            this.dgvListProducts.Columns[0].HeaderText = "Product ID";
            this.dgvListProducts.Columns[1].HeaderText = "Product Name";
            this.dgvListProducts.Columns[2].HeaderText = "Product Price";
            this.dgvListProducts.Columns[3].HeaderText = "Stock";
            this.dgvListProducts.Columns[4].HeaderText = "Product Type";

            this.dgvListProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvListProducts.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void trvListProductType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(this.trvListProductType.SelectedNode!=null && this.trvListProductType.SelectedNode.Level>=0)
            {
                ProductsObj productObj = (ProductsObj)this.trvListProductType.SelectedNode.Tag;
                List<ProductsObj> listProductObj = bllBusineesRuleProduct.GetProductFromType(e.Node.Text);
                DisplayToDataGrid(listProductObj);
                this.mtbxProductType.Text = e.Node.Text;
            }
        }

        private void dgvListProducts_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(this.dgvListProducts.SelectedRows.Count>0)
            {
                this.mtbxNameProduct.Text = this.dgvListProducts.SelectedRows[0].Cells[1].Value.ToString();
                this.mtbxPrice.Text = this.dgvListProducts.SelectedRows[0].Cells[2].Value.ToString();
                this.mtbxStock.Text = this.dgvListProducts.SelectedRows[0].Cells[3].Value.ToString();
                this.mtbxProductType.Text = this.dgvListProducts.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void dgvListProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var item = this.dgvListProducts.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {
                var item = this.dgvListProducts.Rows[0].Cells[0].Value;
            }

            if (mtbxNameProduct.DataBindings.Count > 0)
                mtbxNameProduct.DataBindings.RemoveAt(0);
            if (mtbxPrice.DataBindings.Count > 0)
                mtbxPrice.DataBindings.RemoveAt(0);
            if (mtbxStock.DataBindings.Count > 0)
                mtbxStock.DataBindings.RemoveAt(0);
            if (mtbxProductType.DataBindings.Count > 0)
                mtbxProductType.DataBindings.RemoveAt(0);

            try
            {
                this.mtbxNameProduct.DataBindings.Add(new Binding("Text", dgvListProducts[1, e.RowIndex], "Value", false));
                this.mtbxPrice.DataBindings.Add(new Binding("Text", dgvListProducts[2, e.RowIndex], "Value", false));
                this.mtbxStock.DataBindings.Add(new Binding("Text", dgvListProducts[3, e.RowIndex], "Value", false));
                this.mtbxProductType.DataBindings.Add(new Binding("Text", dgvListProducts[4, e.RowIndex], "Value", false));
            }
            catch
            {
            }
        }

        private void mbtnFind_Click(object sender, EventArgs e)
        {
            try 
	        {
                int parsedValue;
                if (!int.TryParse(this.mtbxFindProduct.Text, out parsedValue))
                {
                    MessageBox.Show("Search with Id of Product and is is type int");
                    return;
                }
	        }
	        catch
	        {
		        MessageBox.Show("Search with Id of Product and is is type int");
                return;
	        }
            DisplayToDataGrid(bllBusineesRuleProduct.GetProductFromID(int.Parse( this.mtbxFindProduct.Text)));
        }

        private void mbtnLogout_Click(object sender, EventArgs e)
        {            
            this.Close();
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
        }
    }
}
