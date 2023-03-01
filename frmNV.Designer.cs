
namespace QLKS
{
    partial class frmNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dTPicker_NSinh = new System.Windows.Forms.DateTimePicker();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txtDThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMKhau_R = new System.Windows.Forms.TextBox();
            this.lbMKhau_R = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.dTPicker_NVaoLam = new System.Windows.Forms.DateTimePicker();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.lView = new System.Windows.Forms.ListView();
            this.MNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DCHI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DTHOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYVAOLAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHUCVU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTPicker_NSinh
            // 
            this.dTPicker_NSinh.CustomFormat = "\"dd mm yyyy\"";
            this.dTPicker_NSinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NSinh.Location = new System.Drawing.Point(160, 138);
            this.dTPicker_NSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPicker_NSinh.Name = "dTPicker_NSinh";
            this.dTPicker_NSinh.Size = new System.Drawing.Size(169, 23);
            this.dTPicker_NSinh.TabIndex = 5;
            // 
            // optNam
            // 
            this.optNam.Checked = true;
            this.optNam.Location = new System.Drawing.Point(160, 177);
            this.optNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(85, 30);
            this.optNam.TabIndex = 6;
            this.optNam.TabStop = true;
            this.optNam.Text = "Nam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dTPicker_NSinh);
            this.groupBox1.Controls.Add(this.optNam);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMKhau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDChi);
            this.groupBox1.Controls.Add(this.txtDThoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMKhau_R);
            this.groupBox1.Controls.Add(this.lbMKhau_R);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.optNu);
            this.groupBox1.Controls.Add(this.dTPicker_NVaoLam);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(715, 335);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancel.Location = new System.Drawing.Point(597, 59);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 28);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "Hủy bỏ";
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(597, 20);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 28);
            this.cmdSave.TabIndex = 11;
            this.cmdSave.Text = "Lưu";
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(160, 20);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(169, 23);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(160, 59);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(255, 23);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMKhau
            // 
            this.txtMKhau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKhau.Location = new System.Drawing.Point(160, 98);
            this.txtMKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMKhau.Name = "txtMKhau";
            this.txtMKhau.PasswordChar = '*';
            this.txtMKhau.Size = new System.Drawing.Size(116, 23);
            this.txtMKhau.TabIndex = 3;
            this.txtMKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKhau_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDChi
            // 
            this.txtDChi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDChi.Location = new System.Drawing.Point(160, 217);
            this.txtDChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(255, 23);
            this.txtDChi.TabIndex = 8;
            // 
            // txtDThoai
            // 
            this.txtDThoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDThoai.Location = new System.Drawing.Point(160, 248);
            this.txtDThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDThoai.Name = "txtDThoai";
            this.txtDThoai.Size = new System.Drawing.Size(169, 23);
            this.txtDThoai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày vào làm:";
            // 
            // txtMKhau_R
            // 
            this.txtMKhau_R.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKhau_R.Location = new System.Drawing.Point(448, 98);
            this.txtMKhau_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMKhau_R.Name = "txtMKhau_R";
            this.txtMKhau_R.PasswordChar = '*';
            this.txtMKhau_R.Size = new System.Drawing.Size(116, 23);
            this.txtMKhau_R.TabIndex = 4;
            this.txtMKhau_R.Visible = false;
            // 
            // lbMKhau_R
            // 
            this.lbMKhau_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKhau_R.Location = new System.Drawing.Point(299, 98);
            this.lbMKhau_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMKhau_R.Name = "lbMKhau_R";
            this.lbMKhau_R.Size = new System.Drawing.Size(149, 30);
            this.lbMKhau_R.TabIndex = 8;
            this.lbMKhau_R.Text = "Nhập lại mật khẩu:";
            this.lbMKhau_R.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giới tính:";
            // 
            // optNu
            // 
            this.optNu.Location = new System.Drawing.Point(309, 177);
            this.optNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(75, 30);
            this.optNu.TabIndex = 7;
            this.optNu.Text = "Nữ";
            // 
            // dTPicker_NVaoLam
            // 
            this.dTPicker_NVaoLam.CustomFormat = "\"dd mm yyyy\"";
            this.dTPicker_NVaoLam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPicker_NVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_NVaoLam.Location = new System.Drawing.Point(160, 295);
            this.dTPicker_NVaoLam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPicker_NVaoLam.Name = "dTPicker_NVaoLam";
            this.dTPicker_NVaoLam.Size = new System.Drawing.Size(169, 23);
            this.dTPicker_NVaoLam.TabIndex = 10;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdExit.Location = new System.Drawing.Point(11, 138);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(96, 28);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdDelete.Location = new System.Drawing.Point(11, 98);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(96, 28);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Xóa";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEdit.Location = new System.Drawing.Point(11, 59);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(96, 28);
            this.cmdEdit.TabIndex = 1;
            this.cmdEdit.Text = "Sửa";
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(11, 20);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(96, 28);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.cmdExit);
            this.grpFunction.Controls.Add(this.cmdDelete);
            this.grpFunction.Controls.Add(this.cmdEdit);
            this.grpFunction.Controls.Add(this.cmdAdd);
            this.grpFunction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpFunction.Location = new System.Drawing.Point(741, 15);
            this.grpFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFunction.Size = new System.Drawing.Size(117, 335);
            this.grpFunction.TabIndex = 8;
            this.grpFunction.TabStop = false;
            // 
            // lView
            // 
            this.lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MNV,
            this.TEN,
            this.GTinh,
            this.MK,
            this.NSINH,
            this.DCHI,
            this.DTHOAI,
            this.NGAYVAOLAM,
            this.CHUCVU});
            this.lView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lView.FullRowSelect = true;
            this.lView.GridLines = true;
            this.lView.HideSelection = false;
            this.lView.Location = new System.Drawing.Point(16, 358);
            this.lView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(841, 246);
            this.lView.TabIndex = 7;
            this.lView.UseCompatibleStateImageBehavior = false;
            this.lView.View = System.Windows.Forms.View.Details;
            this.lView.SelectedIndexChanged += new System.EventHandler(this.lView_SelectedIndexChanged);
            // 
            // MNV
            // 
            this.MNV.Text = "Mã nhân viên";
            this.MNV.Width = 50;
            // 
            // TEN
            // 
            this.TEN.Text = "Họ tên";
            this.TEN.Width = 150;
            // 
            // GTinh
            // 
            this.GTinh.Text = "Giới tính";
            // 
            // MK
            // 
            this.MK.Text = "Mật khẩu";
            this.MK.Width = 0;
            // 
            // NSINH
            // 
            this.NSINH.Text = "Ngày sinh";
            this.NSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NSINH.Width = 100;
            // 
            // DCHI
            // 
            this.DCHI.Text = "Địa chỉ";
            this.DCHI.Width = 100;
            // 
            // DTHOAI
            // 
            this.DTHOAI.Text = "Điện thoại";
            this.DTHOAI.Width = 70;
            // 
            // NGAYVAOLAM
            // 
            this.NGAYVAOLAM.Text = "Ngày vào làm";
            this.NGAYVAOLAM.Width = 100;
            // 
            // CHUCVU
            // 
            this.CHUCVU.Text = "Chức vụ";
            this.CHUCVU.Width = 100;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(528, 295);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(169, 23);
            this.txtChucVu.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(379, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 30);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chức vụ";
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFunction);
            this.Controls.Add(this.lView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Activated += new System.EventHandler(this.frmPhong_Activated);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTPicker_NSinh;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txtDThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMKhau_R;
        private System.Windows.Forms.Label lbMKhau_R;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.DateTimePicker dTPicker_NVaoLam;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.ListView lView;
        private System.Windows.Forms.ColumnHeader MNV;
        private System.Windows.Forms.ColumnHeader TEN;
        private System.Windows.Forms.ColumnHeader GTinh;
        private System.Windows.Forms.ColumnHeader MK;
        private System.Windows.Forms.ColumnHeader NSINH;
        private System.Windows.Forms.ColumnHeader DCHI;
        private System.Windows.Forms.ColumnHeader DTHOAI;
        private System.Windows.Forms.ColumnHeader NGAYVAOLAM;
        private System.Windows.Forms.ColumnHeader CHUCVU;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label10;
    }
}