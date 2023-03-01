using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmSearchNV : Form
    {
        DataTable dtKH;
        DataView dv;
        public frmSearchNV()
        {
            InitializeComponent();
            dtKH = SqlHelper.ExecuteQuery("select * FROM NHANVIEN",
                                            CommandType.Text);

            dv = dtKH.DefaultView;
        }
		private void cmdTim_Click(object sender, System.EventArgs e)
		{
			string strSQL = "";
            if (txtMaNV.Text != "")
                strSQL = "MANHANVIEN like '%" + txtMaNV.Text.Trim() + "%'";
            if (txtTenNV.Text != "")
				strSQL = "HoTen like '%" + txtTenNV.Text.Trim() + "%'";
			if (txtGioiTinh.Text != "")
				strSQL = strSQL + " and ='" + txtGioiTinh.Text.Trim() + "'";
            if (txtDiaChi.Text != "")
                strSQL = "DiaChi like '%" + txtDiaChi.Text.Trim() + "'";

            int n = strSQL.IndexOf("and");
			if (n == 1)
				strSQL = strSQL.Substring(n + 4);
			dv.RowFilter = strSQL;
			dtGrid.DataSource = dv;
		}

		private void cmdThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
