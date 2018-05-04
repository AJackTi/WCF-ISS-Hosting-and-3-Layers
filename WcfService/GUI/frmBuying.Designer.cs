namespace GUI
{
    partial class frmBuying
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPresent = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvListProductType = new System.Windows.Forms.TreeView();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.mbtnBuying = new MetroFramework.Controls.MetroButton();
            this.mbtnPurchare = new MetroFramework.Controls.MetroButton();
            this.mbtnFeedback = new MetroFramework.Controls.MetroButton();
            this.mbtnExit = new MetroFramework.Controls.MetroButton();
            this.mbtnLogout = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtbxNameProduct = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.mtbxStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mtbxFindProduct = new MetroFramework.Controls.MetroTextBox();
            this.mbtnFind = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnMyCart = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbxProductType = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(959, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "I\'m";
            // 
            // btnPresent
            // 
            this.btnPresent.Enabled = false;
            this.btnPresent.Location = new System.Drawing.Point(992, 29);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(109, 23);
            this.btnPresent.TabIndex = 1;
            this.btnPresent.Text = "Customer\'s Name";
            this.btnPresent.UseSelectable = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 153);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvListProductType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvListProducts);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 391);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvListProductType
            // 
            this.trvListProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvListProductType.Location = new System.Drawing.Point(0, 0);
            this.trvListProductType.Name = "trvListProductType";
            this.trvListProductType.Size = new System.Drawing.Size(257, 391);
            this.trvListProductType.TabIndex = 0;
            this.trvListProductType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvListProductType_AfterSelect);
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.Size = new System.Drawing.Size(836, 391);
            this.dgvListProducts.TabIndex = 0;
            this.dgvListProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProducts_CellClick);
            this.dgvListProducts.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvListProducts_RowStateChanged);
            // 
            // mbtnBuying
            // 
            this.mbtnBuying.Location = new System.Drawing.Point(4, 560);
            this.mbtnBuying.Name = "mbtnBuying";
            this.mbtnBuying.Size = new System.Drawing.Size(121, 23);
            this.mbtnBuying.TabIndex = 7;
            this.mbtnBuying.Text = "Add to Cart";
            this.mbtnBuying.UseSelectable = true;
            // 
            // mbtnPurchare
            // 
            this.mbtnPurchare.Location = new System.Drawing.Point(248, 561);
            this.mbtnPurchare.Name = "mbtnPurchare";
            this.mbtnPurchare.Size = new System.Drawing.Size(121, 23);
            this.mbtnPurchare.TabIndex = 8;
            this.mbtnPurchare.Text = "Purchase";
            this.mbtnPurchare.UseSelectable = true;
            // 
            // mbtnFeedback
            // 
            this.mbtnFeedback.Location = new System.Drawing.Point(492, 561);
            this.mbtnFeedback.Name = "mbtnFeedback";
            this.mbtnFeedback.Size = new System.Drawing.Size(121, 23);
            this.mbtnFeedback.TabIndex = 9;
            this.mbtnFeedback.Text = "Feed Back";
            this.mbtnFeedback.UseSelectable = true;
            // 
            // mbtnExit
            // 
            this.mbtnExit.Location = new System.Drawing.Point(980, 560);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(121, 23);
            this.mbtnExit.TabIndex = 11;
            this.mbtnExit.Text = "Exit";
            this.mbtnExit.UseSelectable = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // mbtnLogout
            // 
            this.mbtnLogout.Location = new System.Drawing.Point(736, 560);
            this.mbtnLogout.Name = "mbtnLogout";
            this.mbtnLogout.Size = new System.Drawing.Size(121, 23);
            this.mbtnLogout.TabIndex = 10;
            this.mbtnLogout.Text = "Log out";
            this.mbtnLogout.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(13, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Name Product";
            // 
            // mtbxNameProduct
            // 
            this.mtbxNameProduct.Lines = new string[0];
            this.mtbxNameProduct.Location = new System.Drawing.Point(125, 79);
            this.mtbxNameProduct.MaxLength = 32767;
            this.mtbxNameProduct.Name = "mtbxNameProduct";
            this.mtbxNameProduct.PasswordChar = '\0';
            this.mtbxNameProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxNameProduct.SelectedText = "";
            this.mtbxNameProduct.Size = new System.Drawing.Size(147, 23);
            this.mtbxNameProduct.TabIndex = 1;
            this.mtbxNameProduct.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(316, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Price";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(316, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Stock";
            // 
            // mtbxPrice
            // 
            this.mtbxPrice.Lines = new string[0];
            this.mtbxPrice.Location = new System.Drawing.Point(360, 29);
            this.mtbxPrice.MaxLength = 32767;
            this.mtbxPrice.Name = "mtbxPrice";
            this.mtbxPrice.PasswordChar = '\0';
            this.mtbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxPrice.SelectedText = "";
            this.mtbxPrice.Size = new System.Drawing.Size(156, 23);
            this.mtbxPrice.TabIndex = 2;
            this.mtbxPrice.UseSelectable = true;
            // 
            // mtbxStock
            // 
            this.mtbxStock.Lines = new string[0];
            this.mtbxStock.Location = new System.Drawing.Point(362, 80);
            this.mtbxStock.MaxLength = 32767;
            this.mtbxStock.Name = "mtbxStock";
            this.mtbxStock.PasswordChar = '\0';
            this.mtbxStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxStock.SelectedText = "";
            this.mtbxStock.Size = new System.Drawing.Size(154, 23);
            this.mtbxStock.TabIndex = 3;
            this.mtbxStock.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(539, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(612, 28);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(54, 20);
            this.nudQuantity.TabIndex = 4;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(539, 84);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Find";
            // 
            // mtbxFindProduct
            // 
            this.mtbxFindProduct.Lines = new string[0];
            this.mtbxFindProduct.Location = new System.Drawing.Point(612, 80);
            this.mtbxFindProduct.MaxLength = 32767;
            this.mtbxFindProduct.Name = "mtbxFindProduct";
            this.mtbxFindProduct.PasswordChar = '\0';
            this.mtbxFindProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxFindProduct.SelectedText = "";
            this.mtbxFindProduct.Size = new System.Drawing.Size(156, 23);
            this.mtbxFindProduct.TabIndex = 5;
            this.mtbxFindProduct.UseSelectable = true;
            // 
            // mbtnFind
            // 
            this.mbtnFind.Location = new System.Drawing.Point(782, 80);
            this.mbtnFind.Name = "mbtnFind";
            this.mbtnFind.Size = new System.Drawing.Size(75, 23);
            this.mbtnFind.TabIndex = 6;
            this.mbtnFind.Text = "Find";
            this.mbtnFind.UseSelectable = true;
            this.mbtnFind.Click += new System.EventHandler(this.mbtnFind_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(265, 127);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(836, 23);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "List Products";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(4, 127);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(257, 23);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "List Product Type";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMyCart
            // 
            this.btnMyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCart.Image = global::GUI.Properties.Resources.shopping_cart;
            this.btnMyCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyCart.Location = new System.Drawing.Point(959, 63);
            this.btnMyCart.Name = "btnMyCart";
            this.btnMyCart.Size = new System.Drawing.Size(101, 46);
            this.btnMyCart.TabIndex = 15;
            this.btnMyCart.Text = "My Cart";
            this.btnMyCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyCart.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(13, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Product Type";
            // 
            // mtbxProductType
            // 
            this.mtbxProductType.Lines = new string[0];
            this.mtbxProductType.Location = new System.Drawing.Point(125, 28);
            this.mtbxProductType.MaxLength = 32767;
            this.mtbxProductType.Name = "mtbxProductType";
            this.mtbxProductType.PasswordChar = '\0';
            this.mtbxProductType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxProductType.SelectedText = "";
            this.mtbxProductType.Size = new System.Drawing.Size(147, 23);
            this.mtbxProductType.TabIndex = 17;
            this.mtbxProductType.UseSelectable = true;
            // 
            // frmBuying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 596);
            this.Controls.Add(this.mtbxProductType);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnMyCart);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mbtnFind);
            this.Controls.Add(this.mtbxFindProduct);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.mtbxStock);
            this.Controls.Add(this.mtbxNameProduct);
            this.Controls.Add(this.mtbxPrice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mbtnLogout);
            this.Controls.Add(this.mbtnExit);
            this.Controls.Add(this.mbtnFeedback);
            this.Controls.Add(this.mbtnPurchare);
            this.Controls.Add(this.mbtnBuying);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmBuying";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuying_FormClosing);
            this.Load += new System.EventHandler(this.frmBuying_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPresent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private MetroFramework.Controls.MetroButton mbtnBuying;
        private MetroFramework.Controls.MetroButton mbtnPurchare;
        private MetroFramework.Controls.MetroButton mbtnFeedback;
        private MetroFramework.Controls.MetroButton mbtnExit;
        private MetroFramework.Controls.MetroButton mbtnLogout;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtbxNameProduct;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtbxPrice;
        private MetroFramework.Controls.MetroTextBox mtbxStock;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox mtbxFindProduct;
        private MetroFramework.Controls.MetroButton mbtnFind;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TreeView trvListProductType;
        private System.Windows.Forms.Button btnMyCart;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbxProductType;
    }
}