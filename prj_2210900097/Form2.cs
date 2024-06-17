using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace prj_2210900097
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private SqlConnection ConnectDB()
        {
            string sqlCon = "Data Source = MSI\\TRANDANGDUONG; Initial Catalog = TranDangDuong_2210900097; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            sqlConnection.Open();
            return sqlConnection;
        }
        private void LoadDataGridView()
        {
            SqlConnection con = ConnectDB();
            DataTable dt = new DataTable();
            string show = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(show, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
