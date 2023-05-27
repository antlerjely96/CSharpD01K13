using System.ComponentModel;

namespace demoCRUDCategory.Products
{
    partial class ProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProductCategory = new System.Windows.Forms.ComboBox();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductGridView.Location = new System.Drawing.Point(47, 205);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowTemplate.Height = 40;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(1524, 354);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product name";
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(278, 607);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(226, 38);
            this.tbProductName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(53, 696);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product price";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Location = new System.Drawing.Point(278, 693);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(226, 38);
            this.tbProductPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(591, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product quantity";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Enabled = false;
            this.tbProductQuantity.Location = new System.Drawing.Point(863, 599);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(226, 38);
            this.tbProductQuantity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1178, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product description";
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Enabled = false;
            this.tbProductDescription.Location = new System.Drawing.Point(1178, 667);
            this.tbProductDescription.Multiline = true;
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(265, 171);
            this.tbProductDescription.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(591, 688);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product category";
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.Enabled = false;
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Location = new System.Drawing.Point(863, 685);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(224, 39);
            this.cbProductCategory.TabIndex = 10;
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(1483, 602);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(139, 38);
            this.tbProductId.TabIndex = 11;
            this.tbProductId.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(62, 780);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(194, 58);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add new";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.Location = new System.Drawing.Point(334, 780);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(194, 58);
            this.btnSaveProduct.TabIndex = 13;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.Location = new System.Drawing.Point(602, 780);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(194, 58);
            this.btnUpdateProduct.TabIndex = 14;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(863, 780);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(194, 58);
            this.btnDeleteProduct.TabIndex = 15;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(602, 77);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(471, 38);
            this.tbSearch.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(374, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1157, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(230, 66);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 1087);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.cbProductCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProductDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProductQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductGridView);
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;

        private System.Windows.Forms.TextBox tbProductId;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProductCategory;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProductDescription;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductName;

        private System.Windows.Forms.DataGridView ProductGridView;

        #endregion
    }
}