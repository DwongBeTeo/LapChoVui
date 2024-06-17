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
namespace DanhMucNhanVien
{
    public partial class NhanVien : Form
    {
        public NhanVien()
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
            dgvNhanVien.DataSource = dt;
        }
        private void LoadDataToComboBox()
        {
            SqlConnection con = ConnectDB();
            string load = "select * from Khoa";
            SqlDataAdapter da = new SqlDataAdapter(load, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "TENKHOA";
            comboBox2.ValueMember = "MAKHOA";
            comboBox2.SelectedIndex = -1;
        }
        private void lbMaPhong_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
