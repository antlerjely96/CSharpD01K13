using System;
using System.Windows.Forms;

namespace demoWF1
{
    public partial class demoTongHieuTichThuong : Form
    {
        public demoTongHieuTichThuong()
        {
            InitializeComponent();
        }

        private void btn_tong_Click(object sender, EventArgs e)
        {
            //Lấy a
            int a = int.Parse(tb_a.Text);
            //Lấy b
            int b = int.Parse(tb_b.Text);
            //Tính tổng a + b
            int tong = a + b;
            //Hiển thị tổng
            tb_tong.Text = tong.ToString();
        }

        private void btn_hieu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_tich_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_thuong_Click(object sender, EventArgs e)
        {
            
        }
    }
}