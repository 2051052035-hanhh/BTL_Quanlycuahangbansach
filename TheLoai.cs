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
    public partial class TheLoai : Form
    {
        public static string _connectString = @"Data Source=NGUYENTHANH\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        int _option = 0, pos = 0;
      
        public TheLoai()
        {
            InitializeComponent();
        }
        void Load_TheLoai()
        {
            try
            {
                DataTable dtLP = SqlHelper.ExecuteQuery(
                    "sp_List_theloai",
                    CommandType.StoredProcedure);
                lView.Items.Clear();
                if (dtLP.Rows.Count > 0)
                {
                    foreach (DataRow row in dtLP.Rows)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = row["MATL"].ToString();
                        item.SubItems.Add(row["TENTL"].ToString());


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
            txtMaTL.ReadOnly = true;
            txtTenTL.ReadOnly = false;


            cmdSave.Visible = true;
            cmdCancel.Visible = true;


            lView.Enabled = false;

            grpFunction.Enabled = false;

            _option = 2;
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            Load_TheLoai();
            SetAdd(false);
        }

        private void lView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lView.SelectedItems.Count == 0)
                return;

            ListViewItem item = lView.SelectedItems[0];
            pos = item.Index;
            txtMaTL.Text = item.SubItems[0].Text;
            txtTenTL.Text = item.SubItems[1].Text;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text.Trim() == "")
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(
                    "sp_ins_theloai",
                    CommandType.StoredProcedure,
                    "@option", _option,
                    "@MATHELOAI", txtMaTL.Text.Trim(),

                    "TENTHELOAI", txtTenTL.Text.Trim()

                    );
                Load_TheLoai();
                SetAdd(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            SetAdd(false);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            SetAdd(true);
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "")
                return;

            SetEdit();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "")
                return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thể loại này không?",
                "Xóa thể loại sách.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlHelper.ExecuteNonQuery(
                    "sp_del_theloai",
                    CommandType.StoredProcedure,
                    "@MATHELOAI", txtMaTL.Text);

                MessageBox.Show("Đã xóa thể loại!");
                if (pos == lView.Items.Count - 1)
                    pos = 0;
                Load_TheLoai();
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TheLoai_Activated(object sender, EventArgs e)
        {
            lView_SelectedIndexChanged(lView, System.EventArgs.Empty);
        }

        void SetAdd(bool edit)
        {
            txtMaTL.Text = "";

            txtMaTL.ReadOnly = !edit;
            txtTenTL.ReadOnly = !edit;

            txtTenTL.Text = "";


            cmdSave.Visible = edit;
            cmdCancel.Visible = edit;

            lView.Enabled = !edit;

            grpFunction.Enabled = !edit;

            _option = edit ? 1 : 0;
        }
    }
}
