using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace demoCRUDCategory.Products
{
    public partial class ProductList : Form
    {
        //Kết nối db
        private static string connectionString = "server = localhost; user id = root; password = ; database = d01k13csharp";
        private MySqlConnection connection = new MySqlConnection(connectionString);
        private string sql;
        private string search = "";
        
        public ProductList()
        {
            InitializeComponent();
        }

        //Lấy dữ liệu product từ db
        private void ProductList_Load(object sender, EventArgs e)
        {
            //Query
            sql = "SELECT products.id, products.name, products.price, products.quantity, products.description, categories.name AS category_name FROM products INNER JOIN categories ON products.category_id = categories.id WHERE products.name LIKE '%" + search + "%' ";
            //Chạy query
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            //Tạo dataTable và đổ dữ liệu lấy đc từ query vào
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //Đổ dữ liệu từ dataTable sang DataGridView
            ProductGridView.DataSource = dataTable;
        }

        private void GetCategory()
        {
            //Query
            sql = "SELECT * FROM categories";
            //Chạy query
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            //Tạo dataTable
            DataTable dataTable = new DataTable();
            //Đổ dữ liệu từ adapter vào dataTable
            adapter.Fill(dataTable);
            //Đổ dữ liệu từ dataTable vào comboBox
            cbProductCategory.DataSource = dataTable;
            //Hiển thị tên của các categories vào comboBox
            cbProductCategory.DisplayMember = "name";
            //Đổ id của category vào value của các item
            cbProductCategory.ValueMember = "id";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            tbProductName.Enabled = true;
            tbProductPrice.Enabled = true;
            tbProductQuantity.Enabled = true;
            tbProductDescription.Enabled = true;
            cbProductCategory.Enabled = true;
            btnSaveProduct.Enabled = true;
            btnAddProduct.Enabled = false;
            
            //Lấy dữ liệu từ category và đổ vào comboBox
            GetCategory();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu trong form
            string ProName = tbProductName.Text;
            string ProPrice = tbProductPrice.Text;
            string ProQuantity = tbProductQuantity.Text;
            string ProDescript = tbProductDescription.Text;
            string ProCat = cbProductCategory.SelectedValue.ToString();
            //Query
            sql = "INSERT INTO products(name, price, quantity, description, category_id) VALUES ('" + ProName + "', '" + ProPrice + "', '" + ProQuantity + "', '" + ProDescript + "', '" + ProCat + "')";
            //Mở kết nối
            connection.Open();
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Thêm thành công");
            //Load lại list
            ProductList_Load(null, null);
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            tbProductDescription.Enabled = false;
            cbProductCategory.Enabled = false;
            btnSaveProduct.Enabled = false;
            btnAddProduct.Enabled = true;
        }

        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dữ liệu của bản ghi đang được click
            string ProId = ProductGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string ProName = ProductGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
            string ProPrice = ProductGridView.Rows[e.RowIndex].Cells["price"].Value.ToString();
            string ProQuantity = ProductGridView.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            string ProDescript = ProductGridView.Rows[e.RowIndex].Cells["description"].Value.ToString();
            string ProCat = ProductGridView.Rows[e.RowIndex].Cells["category_name"].Value.ToString();
            //Đổ dữ liệu vào ô input
            tbProductId.Text = ProId;
            tbProductName.Text = ProName;
            tbProductPrice.Text = ProPrice;
            tbProductQuantity.Text = ProQuantity;
            tbProductDescription.Text = ProDescript;
            //Đổ dữ liệu của category vào comboBox
            GetCategory();
            cbProductCategory.SelectedIndex = cbProductCategory.FindString(ProCat);
            //Bật button update lên
            btnUpdateProduct.Enabled = true;
            tbProductName.Enabled = true;
            tbProductPrice.Enabled = true;
            tbProductQuantity.Enabled = true;
            tbProductDescription.Enabled = true;
            cbProductCategory.Enabled = true;
            btnDeleteProduct.Enabled = true;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ các ô input và comboBox
            string ProId = tbProductId.Text;
            string ProName = tbProductName.Text;
            string ProPrice = tbProductPrice.Text;
            string ProQuantity = tbProductQuantity.Text;
            string ProDescript = tbProductDescription.Text;
            string ProCat = cbProductCategory.SelectedValue.ToString();
            //Query
            sql = "UPDATE products SET name = '" + ProName + "', price = '" + ProPrice +
                  "', quantity = '" + ProQuantity + "', description = '" + ProDescript + "', category_id = '" + ProCat + "' WHERE id = '" + ProId + "'";
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Mở kết nối
            connection.Open();
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Sửa thành công");
            //Load lại DataGridView
            ProductList_Load(null, null);
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            tbProductDescription.Enabled = false;
            cbProductCategory.Enabled = false;
            btnUpdateProduct.Enabled = false;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //Lấy id cần xóa
            string ProId = tbProductId.Text;
            //Query
            sql = "DELETE FROM products WHERE id = '" + ProId + "'";
            //Mở kết nối
            connection.Open();
            //Tạo command
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Chạy query
            command.ExecuteNonQuery();
            //Đóng kết nối
            connection.Close();
            //Hiển thị thông báo
            MessageBox.Show("Xóa thành công");
            //Load lại DataGridView
            ProductList_Load(null, null);
            tbProductName.Enabled = false;
            tbProductPrice.Enabled = false;
            tbProductQuantity.Enabled = false;
            tbProductDescription.Enabled = false;
            cbProductCategory.Enabled = false;
            btnDeleteProduct.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Lấy dư liệu ở ô search
            search = tbSearch.Text;
            ProductList_Load(null, null);
        }
    }
}