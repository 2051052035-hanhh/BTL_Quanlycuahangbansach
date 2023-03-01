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
    public partial class frmHoaDon : Form
    {
        public static string _connectString = @"Data Source=NGUYENTHANH\SQLEXPRESS;Initial Catalog=QLS;Integrated Security=True";
        int _option = 0, pos = 0;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        void Load_NV()
        {
            try
            {
                DataTable dtTB = SqlHelper.ExecuteQuery(
                    "sp_list_hoadon",
                    CommandType.StoredProcedure);
                lView.Items.Clear();
                if (dtTB.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTB.Rows)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = row["SHD"].ToString();
                        item.SubItems.Add(row["MANHANVIEN"].ToString());
                        item.SubItems.Add(row["MAKHACH"].ToString());
                       
                        item.SubItems.Add(DateTime.Parse(row["NGAYLAP"].ToString()).ToString("d"));
                        item.SubItems.Add(row["TONGTIEN"].ToString());
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
            txtSHD.ReadOnly = true;
            txtMaNV.ReadOnly = false;
            txtMak.ReadOnly = false;
            txtTongTien.ReadOnly = false;
           
            
            
           

            dTPicker_NLap.Enabled = true;
           

            cmdSave.Visible = true;
            cmdCancel.Visible = true;

            lView.Enabled = false;

            grpFunction.Enabled = false;

            _option = 2;
        }
        void SetAdd(bool edit)
        {
            txtSHD.Text = "";
            txtMaNV.Text = "";
            txtMak.Text = "";
           
            txtTongTien.Text = "";
         
            dTPicker_NLap.Value = DateTime.Now;


            
            txtMaNV.ReadOnly = !edit;
            txtMak.ReadOnly = !edit;
            txtTongTien.ReadOnly = !edit;
           
            dTPicker_NLap.Enabled = edit;
            

            

            cmdSave.Visible = edit;
            cmdCancel.Visible = edit;

            lView.Enabled = !edit;

            grpFunction.Enabled = !edit;

            _option = edit ? 1 : 0;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Load_NV();
            SetAdd(false);
        }

        private void lView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lView.SelectedItems.Count == 0)
                return;

            ListViewItem item = lView.SelectedItems[0];
            pos = item.Index;
            txtSHD.Text = item.SubItems[0].Text;
            txtMaNV.Text = item.SubItems[1].Text;
            txtMak.Text = item.SubItems[2].Text;
            dTPicker_NLap.Text = item.SubItems[3].Text;
            txtTongTien.Text = item.SubItems[4].Text;   
            
           
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtSHD.Text.Trim() == "")
                return;
           
                try
                {
                SqlHelper.ExecuteNonQuery(
                    "sp_ins_hoadon",
                    CommandType.StoredProcedure,
                    "@option", _option,
                    "@SHD", txtSHD.Text.Trim(),
                    "@MANV", txtMaNV.Text.Trim(),
                    "@MAK", txtMak.Text.Trim(),
                    "@NGAYLAP", dTPicker_NLap.Value,

                    "@TONGTIEN", txtTongTien.Text.Trim()

                    ); ;
                    Load_NV();
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
            if (txtSHD.Text == "")
                return;

            SetEdit();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDon_Activated(object sender, EventArgs e)
        {
            lView_SelectedIndexChanged(lView, System.EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
