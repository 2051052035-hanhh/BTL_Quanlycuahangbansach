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
    public partial class frmSearchHoaDon : Form
    {
        DataTable dtKH;
        DataView dv;
        public frmSearchHoaDon()
        {
            InitializeComponent();
            dtKH = SqlHelper.ExecuteQuery("select * FROM PHIEUHOADON",
                                            CommandType.Text);

            dv = dtKH.DefaultView;
            Load_HoaDon();
        }
        void Load_HoaDon()
        {
            try
            {
                DataTable dtLoaiP = SqlHelper.ExecuteQuery(
                    "sp_List_hoadon",
                    CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmSearchHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void cmdTim_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            if (txtSHD.Text != "")
                strSQL = "SHD like '%" + txtSHD.Text.Trim() + "%'";
            if (txtNV.Text != "")
                strSQL = "MANHANVIEN like '%" + txtNV.Text.Trim() + "%'";
            if (txtMaK.Text != "")
                strSQL = "MAKHACH like '%" + txtMaK.Text.Trim() + "%'";



            int n = strSQL.IndexOf("and");
            if (n == 1)
                strSQL = strSQL.Substring(n + 3);
            dv.RowFilter = strSQL;
            dtGrid.DataSource = dv;
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
