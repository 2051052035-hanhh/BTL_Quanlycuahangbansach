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
    public partial class frmTacGias : Form
    {
        public static string _connectString = @"Data Source=NGUYENTHANH\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        int _option = 0, pos = 0;
        public frmTacGias()
        {
            InitializeComponent();
        }
        void Load_TG()
        {
            try
            {
                DataTable dtTB = SqlHelper.ExecuteQuery(
                    "select * from TACGIA", CommandType.Text);
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
                        item.Text = row["MATG"].ToString();
                        item.SubItems.Add(row["TENTG"].ToString());

                     

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
            txtMaTG.ReadOnly = true;
            txtTenTG.ReadOnly = false;
           


            cmdSave.Visible = true;
            cmdCancel.Visible = true;

            lView.Enabled = false;

            grpFunction.Enabled = false;

            _option = 2;
        }
        void SetAdd(bool edit)
        {
            txtMaTG.Text = "";
            txtMaTG.ReadOnly = !edit;

            txtTenTG.ReadOnly = !edit;
           

            txtTenTG.Text = "";
           


            cmdSave.Visible = edit;
            cmdCancel.Visible = edit;

            lView.Enabled = !edit;

            grpFunction.Enabled = !edit;

            _option = edit ? 1 : 0;
        }

        private void lView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lView.SelectedItems.Count == 0)
                return;

            ListViewItem item = lView.SelectedItems[0];
            pos = item.Index;
            txtMaTG.Text = item.SubItems[0].Text;
            txtTenTG.Text = item.SubItems[1].Text;

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            try
            {
                SqlHelper.ExecuteNonQuery(
                    "sp_ins_tacgia",
                    CommandType.StoredProcedure,
                    "@option", _option,
                    "@MATG", txtMaTG.Text.Trim(),
                    "@TENTG", txtTenTG.Text.Trim()

                ); ; ;
                Load_TG();
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
            if (txtMaTG.Text == "")
                return;

            SetEdit();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "")
                return;

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tác giả này không?",
                "Xóa tác giả",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlHelper.ExecuteNonQuery(
                    "sp_del_tacgia",
                    CommandType.StoredProcedure,
                    "@MATG", txtMaTG.Text);

                MessageBox.Show("Đã xóa tác giả!");
                if (pos == lView.Items.Count - 1)
                    pos = 0;
                Load_TG();
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTacGias_Activated(object sender, EventArgs e)
        {
            lView_SelectedIndexChanged(lView, EventArgs.Empty);
        }

        private void frmTacGias_Load(object sender, EventArgs e)
        {
            Load_TG();
            SetAdd(false);
        }
    }
}
