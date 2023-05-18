using System.ComponentModel;

namespace demoCRUDCategory.Categories
{
    partial class CategoryList
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListCategory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cat_name = new System.Windows.Forms.TextBox();
            this.tb_cat_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_new_cat = new System.Windows.Forms.Button();
            this.btn_save_new_cat = new System.Windows.Forms.Button();
            this.btn_edit_cat = new System.Windows.Forms.Button();
            this.btn_update_cat = new System.Windows.Forms.Button();
            this.btn_delete_cat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(183, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 329);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Category";
            // 
            // ListCategory
            // 
            this.ListCategory.AllowUserToAddRows = false;
            this.ListCategory.AllowUserToDeleteRows = false;
            this.ListCategory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListCategory.GridColor = System.Drawing.SystemColors.Window;
            this.ListCategory.Location = new System.Drawing.Point(171, 81);
            this.ListCategory.Name = "ListCategory";
            this.ListCategory.ReadOnly = true;
            this.ListCategory.RowTemplate.Height = 40;
            this.ListCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCategory.Size = new System.Drawing.Size(750, 613);
            this.ListCategory.TabIndex = 1;
            this.ListCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCategory_CellClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 814);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category\'s name";
            // 
            // tb_cat_name
            // 
            this.tb_cat_name.Enabled = false;
            this.tb_cat_name.Location = new System.Drawing.Point(453, 811);
            this.tb_cat_name.Name = "tb_cat_name";
            this.tb_cat_name.Size = new System.Drawing.Size(291, 38);
            this.tb_cat_name.TabIndex = 3;
            // 
            // tb_cat_id
            // 
            this.tb_cat_id.Enabled = false;
            this.tb_cat_id.Location = new System.Drawing.Point(453, 730);
            this.tb_cat_id.Name = "tb_cat_id";
            this.tb_cat_id.Size = new System.Drawing.Size(291, 38);
            this.tb_cat_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(170, 726);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "category\'s id";
            // 
            // btn_add_new_cat
            // 
            this.btn_add_new_cat.Location = new System.Drawing.Point(784, 716);
            this.btn_add_new_cat.Name = "btn_add_new_cat";
            this.btn_add_new_cat.Size = new System.Drawing.Size(152, 64);
            this.btn_add_new_cat.TabIndex = 6;
            this.btn_add_new_cat.Text = "Add new";
            this.btn_add_new_cat.UseVisualStyleBackColor = true;
            this.btn_add_new_cat.Click += new System.EventHandler(this.btn_add_new_cat_Click);
            // 
            // btn_save_new_cat
            // 
            this.btn_save_new_cat.Enabled = false;
            this.btn_save_new_cat.Location = new System.Drawing.Point(784, 797);
            this.btn_save_new_cat.Name = "btn_save_new_cat";
            this.btn_save_new_cat.Size = new System.Drawing.Size(152, 64);
            this.btn_save_new_cat.TabIndex = 7;
            this.btn_save_new_cat.Text = "Save";
            this.btn_save_new_cat.UseVisualStyleBackColor = true;
            this.btn_save_new_cat.Click += new System.EventHandler(this.btn_save_new_cat_Click);
            // 
            // btn_edit_cat
            // 
            this.btn_edit_cat.Location = new System.Drawing.Point(963, 716);
            this.btn_edit_cat.Name = "btn_edit_cat";
            this.btn_edit_cat.Size = new System.Drawing.Size(152, 64);
            this.btn_edit_cat.TabIndex = 8;
            this.btn_edit_cat.Text = "Edit";
            this.btn_edit_cat.UseVisualStyleBackColor = true;
            this.btn_edit_cat.Click += new System.EventHandler(this.btn_edit_cat_Click);
            // 
            // btn_update_cat
            // 
            this.btn_update_cat.Enabled = false;
            this.btn_update_cat.Location = new System.Drawing.Point(963, 797);
            this.btn_update_cat.Name = "btn_update_cat";
            this.btn_update_cat.Size = new System.Drawing.Size(152, 64);
            this.btn_update_cat.TabIndex = 9;
            this.btn_update_cat.Text = "Update";
            this.btn_update_cat.UseVisualStyleBackColor = true;
            this.btn_update_cat.Click += new System.EventHandler(this.btn_update_cat_Click);
            // 
            // btn_delete_cat
            // 
            this.btn_delete_cat.Location = new System.Drawing.Point(1141, 716);
            this.btn_delete_cat.Name = "btn_delete_cat";
            this.btn_delete_cat.Size = new System.Drawing.Size(152, 64);
            this.btn_delete_cat.TabIndex = 10;
            this.btn_delete_cat.Text = "Delete";
            this.btn_delete_cat.UseVisualStyleBackColor = true;
            this.btn_delete_cat.Click += new System.EventHandler(this.btn_delete_cat_Click);
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 917);
            this.Controls.Add(this.btn_delete_cat);
            this.Controls.Add(this.btn_update_cat);
            this.Controls.Add(this.btn_edit_cat);
            this.Controls.Add(this.btn_save_new_cat);
            this.Controls.Add(this.btn_add_new_cat);
            this.Controls.Add(this.tb_cat_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cat_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListCategory);
            this.Controls.Add(this.label1);
            this.Name = "CategoryList";
            this.Text = "CategoryList";
            this.Load += new System.EventHandler(this.CategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_delete_cat;

        private System.Windows.Forms.Button btn_edit_cat;
        private System.Windows.Forms.Button btn_update_cat;

        private System.Windows.Forms.TextBox tb_cat_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_new_cat;
        private System.Windows.Forms.Button btn_save_new_cat;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cat_name;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListCategory;

        #endregion
    }
}