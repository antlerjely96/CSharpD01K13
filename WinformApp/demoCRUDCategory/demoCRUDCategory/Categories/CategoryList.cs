using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace demoCRUDCategory.Categories
{
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            //Kết nối đến MySQL
            string connectionString = "server=localhost;user id=root;password=;database=d01k13csharp";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //Viết query
            string sql = "SELECT * FROM categories";
            //Tạo Adapter để lấy dữ liệu (truyền vào 2 tham số sql, connection)
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            //Tạo dataSet để chứa dữ liệu được lấy về
            DataSet dataSet = new DataSet();
            //Đổ dữ liệu vào lấy được vào dataSet
            dataAdapter.Fill(dataSet, "categories");
            //Đổ Dataset vào DataGridView (phần hiển thị dữ liệu)
            ListCategory.DataSource = dataSet.Tables["categories"].DefaultView;
        }

        private void btn_add_new_cat_Click(object sender, EventArgs e)
        {
            //Cho ô input nhập tên và nút save có thể tác động
            tb_cat_name.Enabled = true;
            btn_save_new_cat.Enabled = true;
        }

        private void btn_save_new_cat_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ ô nhập tên
            string category_name = tb_cat_name.Text;
            //Kết nối đến MySQL
            string connectionString = "server=localhost;user id=root;password=;database=d01k13csharp";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //Mở kết nối
            connection.Open();
            //Viết query
            string sql = "INSERT INTO categories(name) VALUES (" + "'" + category_name + "'" + ")";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Load lại datagridview (load lại danh sách)
            CategoryList_Load(null, null);
        }

        private void ListCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy id, name của row đang được chọn
            string category_id = ListCategory.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string category_name = ListCategory.Rows[e.RowIndex].Cells["name"].Value.ToString();
            //Hiển thị id, name của category vào ô input
            tb_cat_id.Text = category_id;
            tb_cat_name.Text = category_name;
        }

        private void btn_edit_cat_Click(object sender, EventArgs e)
        {
            //Cho ô input nhập tên và nút update có thể tác động
            tb_cat_name.Enabled = true;
            btn_update_cat.Enabled = true;
        }

        private void btn_update_cat_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu trong ô input
            string cat_id = tb_cat_id.Text;
            string cat_name = tb_cat_name.Text;
            //Kết nối đến MySQL
            string connectionString = "server=localhost;user id=root;password=;database=d01k13csharp";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //Mở kết nối
            connection.Open();
            //Viết query
            string sql = "UPDATE categories SET name = '" + cat_name + "' WHERE id = '" + cat_id + "'";
            //Tạo đối tượng command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Load lại danh sách
            CategoryList_Load(null, null);
        }

        private void btn_delete_cat_Click(object sender, EventArgs e)
        {
            //Lấy id của bản ghi cần xóa từ ô input
            string cat_id = tb_cat_id.Text;
            //Kết nối đến MySQL
            string connectionString = "server=localhost;user id=root;password=;database=d01k13csharp";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //Mở kết nối
            connection.Open();
            //Viết query
            string sql = "DELETE FROM categories WHERE id = '" + cat_id + "'";
            //Tạo đối tượng command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Load lại danh sách
            CategoryList_Load(null, null);
        }
    }
}