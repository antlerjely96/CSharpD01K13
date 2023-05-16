using System.ComponentModel;

namespace demoWF1
{
    partial class demoTongHieuTichThuong
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
            this.lb_a = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.lb_b = new System.Windows.Forms.Label();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.txt_tong = new System.Windows.Forms.Label();
            this.hieu = new System.Windows.Forms.TextBox();
            this.txt_hieu = new System.Windows.Forms.Label();
            this.tich = new System.Windows.Forms.TextBox();
            this.lb_tich = new System.Windows.Forms.Label();
            this.thuong = new System.Windows.Forms.TextBox();
            this.lb_thuong = new System.Windows.Forms.Label();
            this.btn_tong = new System.Windows.Forms.Button();
            this.btn_hieu = new System.Windows.Forms.Button();
            this.btn_tich = new System.Windows.Forms.Button();
            this.btn_thuong = new System.Windows.Forms.Button();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_a
            // 
            this.lb_a.Location = new System.Drawing.Point(111, 91);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(96, 41);
            this.lb_a.TabIndex = 0;
            this.lb_a.Text = "a:";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(251, 88);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(390, 38);
            this.tb_a.TabIndex = 1;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(251, 170);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(390, 38);
            this.tb_b.TabIndex = 3;
            // 
            // lb_b
            // 
            this.lb_b.Location = new System.Drawing.Point(111, 170);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(96, 41);
            this.lb_b.TabIndex = 2;
            this.lb_b.Text = "b:";
            // 
            // tb_tong
            // 
            this.tb_tong.Enabled = false;
            this.tb_tong.Location = new System.Drawing.Point(251, 255);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.Size = new System.Drawing.Size(390, 38);
            this.tb_tong.TabIndex = 5;
            // 
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(111, 255);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(134, 41);
            this.txt_tong.TabIndex = 4;
            this.txt_tong.Text = "a + b = ";
            // 
            // hieu
            // 
            this.hieu.Enabled = false;
            this.hieu.Location = new System.Drawing.Point(251, 339);
            this.hieu.Name = "hieu";
            this.hieu.Size = new System.Drawing.Size(390, 38);
            this.hieu.TabIndex = 7;
            // 
            // txt_hieu
            // 
            this.txt_hieu.Location = new System.Drawing.Point(111, 339);
            this.txt_hieu.Name = "txt_hieu";
            this.txt_hieu.Size = new System.Drawing.Size(96, 41);
            this.txt_hieu.TabIndex = 6;
            this.txt_hieu.Text = "a - b =";
            // 
            // tich
            // 
            this.tich.Enabled = false;
            this.tich.Location = new System.Drawing.Point(251, 437);
            this.tich.Name = "tich";
            this.tich.Size = new System.Drawing.Size(390, 38);
            this.tich.TabIndex = 9;
            // 
            // lb_tich
            // 
            this.lb_tich.Location = new System.Drawing.Point(111, 434);
            this.lb_tich.Name = "lb_tich";
            this.lb_tich.Size = new System.Drawing.Size(96, 41);
            this.lb_tich.TabIndex = 8;
            this.lb_tich.Text = "a * b =";
            // 
            // thuong
            // 
            this.thuong.Enabled = false;
            this.thuong.Location = new System.Drawing.Point(251, 524);
            this.thuong.Name = "thuong";
            this.thuong.Size = new System.Drawing.Size(390, 38);
            this.thuong.TabIndex = 11;
            // 
            // lb_thuong
            // 
            this.lb_thuong.Location = new System.Drawing.Point(111, 521);
            this.lb_thuong.Name = "lb_thuong";
            this.lb_thuong.Size = new System.Drawing.Size(96, 41);
            this.lb_thuong.TabIndex = 10;
            this.lb_thuong.Text = "a / b =";
            // 
            // btn_tong
            // 
            this.btn_tong.Location = new System.Drawing.Point(131, 633);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(171, 51);
            this.btn_tong.TabIndex = 12;
            this.btn_tong.Text = "a + b";
            this.btn_tong.UseVisualStyleBackColor = true;
            this.btn_tong.Click += new System.EventHandler(this.btn_tong_Click);
            // 
            // btn_hieu
            // 
            this.btn_hieu.Location = new System.Drawing.Point(339, 633);
            this.btn_hieu.Name = "btn_hieu";
            this.btn_hieu.Size = new System.Drawing.Size(171, 51);
            this.btn_hieu.TabIndex = 13;
            this.btn_hieu.Text = "a - b";
            this.btn_hieu.UseVisualStyleBackColor = true;
            this.btn_hieu.Click += new System.EventHandler(this.btn_hieu_Click);
            // 
            // btn_tich
            // 
            this.btn_tich.Location = new System.Drawing.Point(551, 633);
            this.btn_tich.Name = "btn_tich";
            this.btn_tich.Size = new System.Drawing.Size(171, 51);
            this.btn_tich.TabIndex = 14;
            this.btn_tich.Text = "a * b";
            this.btn_tich.UseVisualStyleBackColor = true;
            this.btn_tich.Click += new System.EventHandler(this.btn_tich_Click);
            // 
            // btn_thuong
            // 
            this.btn_thuong.Location = new System.Drawing.Point(763, 633);
            this.btn_thuong.Name = "btn_thuong";
            this.btn_thuong.Size = new System.Drawing.Size(171, 51);
            this.btn_thuong.TabIndex = 15;
            this.btn_thuong.Text = "a / b";
            this.btn_thuong.UseVisualStyleBackColor = true;
            this.btn_thuong.Click += new System.EventHandler(this.btn_thuong_Click);
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(973, 633);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(171, 51);
            this.btn_tinh.TabIndex = 16;
            this.btn_tinh.Text = "+, -, *, /";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // demoTongHieuTichThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 979);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.btn_thuong);
            this.Controls.Add(this.btn_tich);
            this.Controls.Add(this.btn_hieu);
            this.Controls.Add(this.btn_tong);
            this.Controls.Add(this.thuong);
            this.Controls.Add(this.lb_thuong);
            this.Controls.Add(this.tich);
            this.Controls.Add(this.lb_tich);
            this.Controls.Add(this.hieu);
            this.Controls.Add(this.txt_hieu);
            this.Controls.Add(this.tb_tong);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.lb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.lb_a);
            this.Name = "demoTongHieuTichThuong";
            this.Text = "demoTongHieuTichThuong";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btn_hieu;
        private System.Windows.Forms.Button btn_tich;
        private System.Windows.Forms.Button btn_thuong;
        private System.Windows.Forms.Button btn_tinh;

        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.TextBox tb_tong;
        private System.Windows.Forms.Label txt_tong;
        private System.Windows.Forms.TextBox hieu;
        private System.Windows.Forms.Label txt_hieu;
        private System.Windows.Forms.TextBox tich;
        private System.Windows.Forms.Label lb_tich;
        private System.Windows.Forms.TextBox thuong;
        private System.Windows.Forms.Label lb_thuong;

        private System.Windows.Forms.Label lb_a;

        #endregion
    }
}