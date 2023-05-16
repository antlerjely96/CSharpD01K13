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
    }
}