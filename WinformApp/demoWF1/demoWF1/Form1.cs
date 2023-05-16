using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoWF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_display_a_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ ô textbox có tên là txt_a
            int a = int.Parse(txt_a.Text);
            //Tính a++
            int b = a + 1;
            //Hiển thị a ra 1 popup
            MessageBox.Show("a + 1 = " + b);
            //Hiển thị a sang 1 ô textbox khác
            txt_a1.Text = b.ToString();
        }
    }
}