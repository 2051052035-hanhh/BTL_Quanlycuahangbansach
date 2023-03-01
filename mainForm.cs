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
    public partial class mainForm : Form
    {
		public static string msNV = "", tenNV = "";
		public Form father;
		public mainForm(Form father)
		{
			this.father = father;
			InitializeComponent();
		}

		private void mainForm_Load(object sender, EventArgs e)
		{

        }

     

		private void mnkhach_Click(object sender, System.EventArgs e)
		{
			frmKhach f = new frmKhach();
			f.MdiParent = this;
			f.Show();
		}

		private void mnHoSoNV_Click(object sender, System.EventArgs e)
		{
			frmNV f = new frmNV();
			f.MdiParent = this;
			f.Show();
		}

		private void mnSach_Click(object sender, System.EventArgs e)
		{
			frmsach f = new frmsach();
			f.MdiParent = this;
			f.Show();
		}

	

		private void mnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public void enableFormMain(string masoNV)
		{
			msNV = masoNV;
            DataTable dtNV = SqlHelper.ExecuteQuery(
                "select top 1 MANHANVIEN from NHANVIEN order by MANHANVIEN",
                CommandType.Text);
            if (dtNV.Rows[0]["MANHANVIEN"].ToString() != msNV)
				mnCauHinh.Visible = false;
			dtNV = SqlHelper.ExecuteQuery(
				"select HOTEN from NHANVIEN where MANHANVIEN='" + msNV + "'",
				CommandType.Text);
			tenNV = dtNV.Rows[0]["HOTEN"].ToString();
			stBar.Panels[0].Text = "Nhân viên : " + tenNV;
			stBar.Panels[1].Text = "Hôm nay : " + DateTime.Now.ToShortDateString();
		}

		

	

		private void mnCascade_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void mnTileH_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void mnTileV_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void mnThanhToan_Click(object sender, EventArgs e)
		{
			frmThanhToanPhong f = new frmThanhToanPhong();
			f.MdiParent = this;
			f.Show();
		}

		private void mnSearchKH_Click(object sender, EventArgs e)
		{
			frmSearchNV f = new frmSearchNV();
			f.MdiParent = this;
			f.Show();
		}

		private void mnSearchSach_Click(object sender, EventArgs e)
		{
			frmSearchSach f = new frmSearchSach();
			f.MdiParent = this;
			f.Show();
		}

		private void mnCaNhan_Click(object sender, EventArgs e)
		{
			frmChangeProfile f = new frmChangeProfile();
			f.MdiParent = this;
			f.Show();
		}

		

        private void mntheloai_Click(object sender, EventArgs e)
        {
            TheLoai f = new TheLoai();
            f.MdiParent = this;
            f.Show();
        }

        private void mnTacGia_Click(object sender, EventArgs e)
        {
            frmTacGias f = new frmTacGias();
            f.MdiParent = this;
            f.Show();
        }

        private void mnhoadon_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            frmSearchHoaDon f = new frmSearchHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            frmSearchNV f = new frmSearchNV();
            f.MdiParent = this;
            f.Show();
        }

        private void mnThongKe_Click(object sender, EventArgs e)
        {
            frmThongke f = new frmThongke();
            f.MdiParent = this;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			father.Show();
		}

    }
}
