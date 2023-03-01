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
    public partial class frmKhach : Form
    {
        public static string _connectString = @"Data Source=NGUYENTHANH\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        int _option = 0, pos = 0;
        public frmKhach()
        {
            InitializeComponent();
        }
		void Load_TB()
		{
			try
			{
				DataTable dtTB = SqlHelper.ExecuteQuery(
					"select * from KHACHHANG", CommandType.Text);
				/*DataTable dtTB = SqlHelper.ExecuteQuery(
					"pr_list_ThietBi",
					CommandType.StoredProcedure,
					"@option", "3");*/
				lView.Items.Clear();
				if (dtTB.Rows.Count > 0)
				{
					foreach (DataRow row in dtTB.Rows)
					{
						ListViewItem item = new ListViewItem();
						item.Text = row["MAKHACH"].ToString();
						item.SubItems.Add(row["HOTEN"].ToString());
				
						item.SubItems.Add(row["DIENTHOAI"].ToString());

						lView.Items.Add(item);
					}
					lView.Items[pos].Selected = true;
					lView_SelectedIndexChanged(lView.Items[pos], EventArgs.Empty);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void SetEdit()
		{
			txtMak.ReadOnly = true;
			txtTenK.ReadOnly = false;
			txtSDT.ReadOnly = false;
			

			cmdSave.Visible = true;
			cmdCancel.Visible = true;

			lView.Enabled = false;

			grpFunction.Enabled = false;

			_option = 2;
		}
		void SetAdd(bool edit)
		{
			txtMak.Text = "";
			txtMak.ReadOnly = !edit;

			txtTenK.ReadOnly = !edit;
			txtSDT.ReadOnly = !edit;
		
			txtTenK.Text = "";
			txtSDT.Text = "";
			

			cmdSave.Visible = edit;
			cmdCancel.Visible = edit;

			lView.Enabled = !edit;

			grpFunction.Enabled = !edit;

			_option = edit ? 1 : 0;
		}
		private void frmPhong_Load(object sender, EventArgs e)
		{
			Load_TB();
			SetAdd(false);
		}
		private void lView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lView.SelectedItems.Count == 0)
				return;

			ListViewItem item = lView.SelectedItems[0];
			pos = item.Index;
			txtMak.Text = item.SubItems[0].Text;
			txtTenK.Text = item.SubItems[1].Text;
		
			txtSDT.Text = item.SubItems[2].Text;
		}

		private void cmdExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			if (txtMak.Text == "")
				return;

			DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?",
				"Xóa khách hàng",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				SqlHelper.ExecuteNonQuery(
					"sp_del_khach",
					CommandType.StoredProcedure,
					"@MAKHACH", txtMak.Text);

				MessageBox.Show("Đã xóa khách!");
				if (pos == lView.Items.Count - 1)
					pos = 0;
				Load_TB();
			}
		}

		private void cmdAdd_Click(object sender, EventArgs e)
		{
			SetAdd(true);
		}

		private void cmdEdit_Click(object sender, EventArgs e)
		{
			if (txtMak.Text == "")
				return;

			SetEdit();
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			SetAdd(false);
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			
			try
			{
				SqlHelper.ExecuteNonQuery(
					"sp_ins_khach",
					CommandType.StoredProcedure,
					"@option", _option,
					"@MAKHACH", txtMak.Text.Trim(),
					"@HOTEN", txtTenK.Text.Trim(),
					"@SDT", txtSDT.Text.Trim()
				); ;
				Load_TB();
				SetAdd(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void frmPhong_Activated(object sender, EventArgs e)
		{
			lView_SelectedIndexChanged(lView, EventArgs.Empty);
		}
	}
}
