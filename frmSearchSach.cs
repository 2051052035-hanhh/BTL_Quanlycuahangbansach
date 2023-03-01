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
    public partial class frmSearchSach : Form
    {

        DataTable dtP;
        DataView dv;
        public frmSearchSach()
        {
            InitializeComponent();
            dtP = SqlHelper.ExecuteQuery("select * from SACH", CommandType.Text);

            dv = dtP.DefaultView;
            Load_LoaiP();
        }

		void Load_LoaiP()
		{
			try
			{
				DataTable dtLoaiP = SqlHelper.ExecuteQuery(
					"sp_List_sach",
					CommandType.StoredProcedure);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void cmdTim_Click(object sender, EventArgs e)
		{
			string strSQL = "";

			if (txtMaS.Text != "")
				strSQL = "MASACH='" + txtMaS.Text.Trim() + "'";
            if (txtTenS.Text != "")
                strSQL = "TENSACH='" + txtTenS.Text.Trim() + "'";
            if (txtGia.Text != "")
                strSQL = "GIA='" + txtGia.Text.Trim() + "'";
            if (txtNXB.Text != "")
                strSQL = "NXB='" + txtNXB.Text.Trim() + "'";

            int n = strSQL.IndexOf("and");
			if (n == 1)
				strSQL = strSQL.Substring(n + 4);
			dv.RowFilter = strSQL;
			dtGrid.DataSource = dv;
		}

		private void cmdThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void txtMaP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
