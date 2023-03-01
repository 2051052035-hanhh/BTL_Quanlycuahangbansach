using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmThongke : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NGUYENTHANH\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from phieuHoaDon    ";
            command.ExecuteNonQuery(); //thucthicautruyvan
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);//do du lieu vao 
            dataGridView1.DataSource = table;
        }
        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);//truyen vao chuoi ket noi
            connection.Open();//mo ket noi
            LoadData();//thuc hien ham load du lieu
        }

        private void lbl_masach_Click(object sender, EventArgs e)
        {

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_doanhthu.Text = "";
           
            txt_ngay.Text = "";
            txt_thang.Text = "";
            txt_ngay.Text = "";
            txt_nam.Text = "";
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            string sqlTimkiem = "select * from PHIEUHOADON  where  day(NGAYLAP) like @ngay and month(NGAYLAP) like @thang and year(NGAYLAP) like @year";

            SqlCommand command = new SqlCommand(sqlTimkiem, connection);
          

            command.Parameters.AddWithValue("@ngay", "%" + txt_ngay.Text + "%");
            command.Parameters.AddWithValue("@thang", "%" + txt_thang.Text + "%");
            command.Parameters.AddWithValue("@year", "%" + txt_nam.Text + "%");
            
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            int tien = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells["TONGTIEN"].Value.ToString());
            }
            txt_doanhthu.Text = thanhtien.ToString();

        }
    }
}
