namespace GUI
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvListProductType = new System.Windows.Forms.TreeView();
            this.trvListProType = new System.Windows.Forms.TreeView();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.mtbxNameProduct = new MetroFramework.Controls.MetroTextBox();
            this.mtbxStock = new MetroFramework.Controls.MetroTextBox();
            this.mtbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtbxProductType = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.mbtnFind = new MetroFramework.Controls.MetroButton();
            this.mtbxFindProduct = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(5, 147);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvListProductType);
            this.splitContainer1.Panel1.Controls.Add(this.trvListProType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvListProducts);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 406);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvListProductType
            // 
            this.trvListProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvListProductType.Location = new System.Drawing.Point(0, 0);
            this.trvListProductType.Name = "trvListProductType";
            this.trvListProductType.Size = new System.Drawing.Size(238, 406);
            this.trvListProductType.TabIndex = 1;
            this.trvListProductType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvListProductType_AfterSelect);
            // 
            // trvListProType
            // 
            this.trvListProType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvListProType.Location = new System.Drawing.Point(0, 0);
            this.trvListProType.Name = "trvListProType";
            this.trvListProType.Size = new System.Drawing.Size(238, 406);
            this.trvListProType.TabIndex = 0;
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.Size = new System.Drawing.Size(852, 406);
            this.dgvListProducts.TabIndex = 0;
            this.dgvListProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProducts_CellClick);
            this.dgvListProducts.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvListProducts_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "I\'m";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(248, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(852, 23);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "List Products";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(12, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Name Product";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(337, 28);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Price";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(337, 69);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Stock";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(606, 28);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 564);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 564);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(475, 564);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(710, 564);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(153, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(945, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackgroundImage = global::GUI.Properties.Resources.human_icon_png_1901;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton6.Enabled = false;
            this.metroButton6.Location = new System.Drawing.Point(995, 26);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(105, 32);
            this.metroButton6.TabIndex = 9;
            this.metroButton6.Text = "Admin";
            this.metroButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton6.UseSelectable = true;
            // 
            // mtbxNameProduct
            // 
            this.mtbxNameProduct.Lines = new string[0];
            this.mtbxNameProduct.Location = new System.Drawing.Point(115, 69);
            this.mtbxNameProduct.MaxLength = 32767;
            this.mtbxNameProduct.Name = "mtbxNameProduct";
            this.mtbxNameProduct.PasswordChar = '\0';
            this.mtbxNameProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxNameProduct.SelectedText = "";
            this.mtbxNameProduct.Size = new System.Drawing.Size(179, 23);
            this.mtbxNameProduct.TabIndex = 1;
            this.mtbxNameProduct.UseSelectable = true;
            // 
            // mtbxStock
            // 
            this.mtbxStock.Lines = new string[0];
            this.mtbxStock.Location = new System.Drawing.Point(389, 69);
            this.mtbxStock.MaxLength = 32767;
            this.mtbxStock.Name = "mtbxStock";
            this.mtbxStock.PasswordChar = '\0';
            this.mtbxStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxStock.SelectedText = "";
            this.mtbxStock.Size = new System.Drawing.Size(179, 23);
            this.mtbxStock.TabIndex = 3;
            this.mtbxStock.UseSelectable = true;
            // 
            // mtbxPrice
            // 
            this.mtbxPrice.Lines = new string[0];
            this.mtbxPrice.Location = new System.Drawing.Point(389, 26);
            this.mtbxPrice.MaxLength = 32767;
            this.mtbxPrice.Name = "mtbxPrice";
            this.mtbxPrice.PasswordChar = '\0';
            this.mtbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxPrice.SelectedText = "";
            this.mtbxPrice.Size = new System.Drawing.Size(179, 23);
            this.mtbxPrice.TabIndex = 2;
            this.mtbxPrice.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(5, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(237, 23);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "List Product Type";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(12, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Product Type";
            // 
            // mtbxProductType
            // 
            this.mtbxProductType.Lines = new string[0];
            this.mtbxProductType.Location = new System.Drawing.Point(115, 26);
            this.mtbxProductType.MaxLength = 32767;
            this.mtbxProductType.Name = "mtbxProductType";
            this.mtbxProductType.PasswordChar = '\0';
            this.mtbxProductType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxProductType.SelectedText = "";
            this.mtbxProductType.Size = new System.Drawing.Size(179, 23);
            this.mtbxProductType.TabIndex = 12;
            this.mtbxProductType.UseSelectable = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(675, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 21);
            this.numericUpDown1.TabIndex = 13;
            // 
            // mbtnFind
            // 
            this.mbtnFind.Location = new System.Drawing.Point(869, 69);
            this.mbtnFind.Name = "mbtnFind";
            this.mbtnFind.Size = new System.Drawing.Size(75, 23);
            this.mbtnFind.TabIndex = 15;
            this.mbtnFind.Text = "Find";
            this.mbtnFind.UseSelectable = true;
            this.mbtnFind.Click += new System.EventHandler(this.mbtnFind_Click);
            // 
            // mtbxFindProduct
            // 
            this.mtbxFindProduct.Lines = new string[0];
            this.mtbxFindProduct.Location = new System.Drawing.Point(675, 69);
            this.mtbxFindProduct.MaxLength = 32767;
            this.mtbxFindProduct.Name = "mtbxFindProduct";
            this.mtbxFindProduct.PasswordChar = '\0';
            this.mtbxFindProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxFindProduct.SelectedText = "";
            this.mtbxFindProduct.Size = new System.Drawing.Size(179, 23);
            this.mtbxFindProduct.TabIndex = 14;
            this.mtbxFindProduct.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(606, 73);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(35, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Find";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.human_icon_png_1901;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 596);
            this.Controls.Add(this.mbtnFind);
            this.Controls.Add(this.mtbxFindProduct);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.mtbxProductType);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtbxStock);
            this.Controls.Add(this.mtbxNameProduct);
            this.Controls.Add(this.mtbxPrice);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTextBox mtbxNameProduct;
        private MetroFramework.Controls.MetroTextBox mtbxStock;
        private MetroFramework.Controls.MetroTextBox mtbxPrice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TreeView trvListProType;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtbxProductType;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroButton mbtnFind;
        private MetroFramework.Controls.MetroTextBox mtbxFindProduct;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TreeView trvListProductType;
    }
}