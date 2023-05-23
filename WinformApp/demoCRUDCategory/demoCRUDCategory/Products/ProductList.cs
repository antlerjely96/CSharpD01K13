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
        
        public ProductList()
        {
            InitializeComponent();
        }

        //Lấy dữ liệu product từ db
        private void ProductList_Load(object sender, EventArgs e)
        {
            //Query
            sql = "SELECT products.id, products.name, products.price, products.quantity, products.description, categories.name AS category_name FROM products INNER JOIN categories ON products.category_id = categories.id";
            //Chạy query
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            //Tạo dataTable và đổ dữ liệu lấy đc từ query vào
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //Đổ dữ liệu từ dataTable sang DataGridView
            ProductGridView.DataSource = dataTable;
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
    }
}