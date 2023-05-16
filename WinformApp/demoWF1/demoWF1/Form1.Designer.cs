namespace demoWF1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.btn_display_a = new System.Windows.Forms.Button();
            this.txt_a1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(135, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(247, 102);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(532, 38);
            this.txt_a.TabIndex = 1;
            // 
            // btn_display_a
            // 
            this.btn_display_a.Location = new System.Drawing.Point(355, 276);
            this.btn_display_a.Name = "btn_display_a";
            this.btn_display_a.Size = new System.Drawing.Size(250, 75);
            this.btn_display_a.TabIndex = 2;
            this.btn_display_a.Text = "Hiển thị a + 1\r\n";
            this.btn_display_a.UseVisualStyleBackColor = true;
            this.btn_display_a.Click += new System.EventHandler(this.btn_display_a_Click);
            // 
            // txt_a1
            // 
            this.txt_a1.Enabled = false;
            this.txt_a1.Location = new System.Drawing.Point(247, 174);
            this.txt_a1.Name = "txt_a1";
            this.txt_a1.Size = new System.Drawing.Size(529, 38);
            this.txt_a1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 808);
            this.Controls.Add(this.txt_a1);
            this.Controls.Add(this.btn_display_a);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Winform 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_a1;

        private System.Windows.Forms.Button btn_display_a;

        private System.Windows.Forms.TextBox txt_a;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}