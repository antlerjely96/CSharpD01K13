using System.ComponentModel;

namespace demoCRUDCategory
{
    partial class TabControlDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCategory);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1429, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCategory
            // 
            this.tabCategory.Location = new System.Drawing.Point(10, 48);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(1409, 658);
            this.tabCategory.TabIndex = 0;
            this.tabCategory.Text = "Categories";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabProduct
            // 
            this.tabProduct.Location = new System.Drawing.Point(10, 48);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(1409, 658);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Products";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // TabControlDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 776);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabControlDemo";
            this.Text = "TabControlDemo";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabProduct;

        #endregion
    }
}