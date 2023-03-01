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
    public partial class frmsach : Form
    {
        public static string _connectString = @"Data Source=NGUYENTHANH\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        int _option = 0, pos = 0;
        public frmsach()
        {
            InitializeComponent();
        }

        void Load_LoaiS()
        {
            try
            {
                DataTable dtTB = SqlHelper.ExecuteQuery(
                    "sp_list_sach",
                    CommandType.StoredProcedure);
                lView.Items.Clear();
                if (dtTB.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTB.Rows)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = row["MASACH"].ToString();
                        item.SubItems.Add(row["MATL"].ToString());

                        item.SubItems.Add(row["MATG"].ToString());

                        item.SubItems.Add(row["TENSACH"].ToString());
                        item.SubItems.Add(row["NAMXB"].ToString());
                        item.SubItems.Add(row["NXB"].ToString());
                        item.SubItems.Add(row["GIA"].ToString());
                        lView.Items.Add(item);
                    }
                    lView.Items[pos].Selected = true;
                    lView_SelectedIndexChanged(lView.Items[pos], System.EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SetEdit()
        {
            txtMaS.ReadOnly = true;
            txtMaTG.ReadOnly = false;
            txtMaTL.ReadOnly = false;
            txtTenS.ReadOnly = false;
            txtNXB.ReadOnly = false;
            txtGia.ReadOnly = false;


            txtNamXB.ReadOnly = false;



            cmdSave.Visible = true;
            cmdCancel.Visible = true;

            lView.Enabled = false;

            grpFunction.Enabled = false;

            _option = 2;
        }
        void SetAdd(bool edit)
        {
            txtMaS.Text = "";
            txtMaS.ReadOnly = !edit;
            txtMaTG.Text = "";
            txtMaTL.Text = "";
            txtGia.Text = "";
            txtNamXB.Text = "";
            txtTenS.Text = "";
            txtNXB.Text = "";
            txtGia.Text = "";

            txtMaTG.ReadOnly = !edit;
            txtMaTL.ReadOnly = !edit;
            txtGia.ReadOnly = !edit;
            txtNamXB.ReadOnly = !edit;
            txtTenS.ReadOnly = !edit;
            txtNXB.ReadOnly = !edit;




            cmdSave.Visible = edit;
            cmdCancel.Visible = edit;

            lView.Enabled = !edit;

            grpFunction.Enabled = !edit;

            _option = edit ? 1 : 0;
        }
        private void frmPhong_Load(object sender, System.EventArgs e)
        {
            Load_LoaiS();

            SetAdd(false);
        }

        private void lView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lView.SelectedItems.Count == 0)
                return;

            ListViewItem item = lView.SelectedItems[0];
            pos = item.Index;
            txtMaS.Text = item.SubItems[0].Text;
            txtMaTL.Text = item.SubItems[1].Text;
            txtMaTG.Text = item.SubItems[2].Text;
            txtTenS.Text = item.SubItems[3].Text;
            txtNamXB.Text = item.SubItems[4].Text;
            txtNXB.Text = item.SubItems[5].Text;
            txtGia.Text = item.SubItems[6].Text;



        }

        private void cmdExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cmdDelete_Click(object sender, System.EventArgs e)
        {
            if (txtMaS.Text == "")
                return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sách này không?",
                "Xóa sách",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlHelper.ExecuteNonQuery(
                    "sp_del_Sach",
                    CommandType.StoredProcedure,
                    "@MASACH", txtMaS.Text);

                MessageBox.Show("Đã xóa sách!");
                if (pos == lView.Items.Count - 1)
                    pos = 0;
                Load_LoaiS();
            }
        }

        private void cmdAdd_Click(object sender, System.EventArgs e)
        {
            SetAdd(true);
        }

        private void cmdEdit_Click(object sender, System.EventArgs e)
        {
            if (txtMaS.Text == "")
                return;

            SetEdit();
        }

        private void cmdCancel_Click(object sender, System.EventArgs e)
        {
            SetAdd(false);
        }

        private void cmdSave_Click(object sender, System.EventArgs e)
        {
            if (txtMaS.Text.Trim() == "")
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(
                    "sp_ins_sach",
                    CommandType.StoredProcedure,
                    "@option", _option,
                    "@MASACH", txtMaS.Text.Trim(),
                    "MATG", txtMaTG.Text.Trim(),
                    "MATL", txtMaTL.Text.Trim(),
                    "TENSACH", txtTenS.Text.Trim(),
                    "NAMXB", txtNamXB.Text.Trim(),
                    "NXB", txtNXB.Text.Trim(),
                    "GIA", txtGia.Text.Trim()
                    ); ;
                Load_LoaiS();
                SetAdd(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grpFunction_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaS_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPhong_Activated(object sender, System.EventArgs e)
        {
            lView_SelectedIndexChanged(lView, System.EventArgs.Empty);
        }
    }
}
