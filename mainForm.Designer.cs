
namespace QLKS
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.Date = new System.Windows.Forms.StatusBarPanel();
            this.stBar = new System.Windows.Forms.StatusBar();
            this.NhanVien = new System.Windows.Forms.StatusBarPanel();
            this.mnCaNhan = new System.Windows.Forms.MenuItem();
            this.mnHoSoNV = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnkhach = new System.Windows.Forms.MenuItem();
            this.mnSach = new System.Windows.Forms.MenuItem();
            this.mnCauHinh = new System.Windows.Forms.MenuItem();
            this.mntheloai = new System.Windows.Forms.MenuItem();
            this.mnTacGia = new System.Windows.Forms.MenuItem();
            this.mnhoadon = new System.Windows.Forms.MenuItem();
            this.mnSearchSach = new System.Windows.Forms.MenuItem();
            this.mnTimKiem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnExit = new System.Windows.Forms.MenuItem();
            this.mnThongKe = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.Date.MinWidth = 200;
            this.Date.Name = "Date";
            this.Date.Text = "Date";
            this.Date.Width = 775;
            // 
            // stBar
            // 
            this.stBar.Location = new System.Drawing.Point(0, 658);
            this.stBar.Margin = new System.Windows.Forms.Padding(4);
            this.stBar.Name = "stBar";
            this.stBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.NhanVien,
            this.Date});
            this.stBar.ShowPanels = true;
            this.stBar.Size = new System.Drawing.Size(996, 30);
            this.stBar.TabIndex = 2;
            this.stBar.Text = "TTTTTTTTT";
            // 
            // NhanVien
            // 
            this.NhanVien.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.NhanVien.MinWidth = 200;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Text = "Nhân viên:";
            this.NhanVien.Width = 200;
            // 
            // mnCaNhan
            // 
            this.mnCaNhan.Index = 3;
            this.mnCaNhan.Text = "Thay đổi mật khẩu";
            this.mnCaNhan.Click += new System.EventHandler(this.mnCaNhan_Click);
            // 
            // mnHoSoNV
            // 
            this.mnHoSoNV.Index = 2;
            this.mnHoSoNV.Text = "Hồ sơ nhân viên";
            this.mnHoSoNV.Click += new System.EventHandler(this.mnHoSoNV_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "-";
            // 
            // mnkhach
            // 
            this.mnkhach.Index = 3;
            this.mnkhach.Text = "Khách hàng";
            this.mnkhach.Click += new System.EventHandler(this.mnkhach_Click);
            // 
            // mnSach
            // 
            this.mnSach.Index = 1;
            this.mnSach.Text = "Sách";
            this.mnSach.Click += new System.EventHandler(this.mnSach_Click);
            // 
            // mnCauHinh
            // 
            this.mnCauHinh.Index = 2;
            this.mnCauHinh.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.mnSach,
            this.mnHoSoNV,
            this.mnkhach,
            this.mntheloai,
            this.mnTacGia,
            this.mnhoadon});
            this.mnCauHinh.Text = "Quản lý";
            // 
            // mntheloai
            // 
            this.mntheloai.Index = 4;
            this.mntheloai.Text = "Thể loại";
            this.mntheloai.Click += new System.EventHandler(this.mntheloai_Click);
            // 
            // mnTacGia
            // 
            this.mnTacGia.Index = 5;
            this.mnTacGia.Text = "Tác giả";
            this.mnTacGia.Click += new System.EventHandler(this.mnTacGia_Click);
            // 
            // mnhoadon
            // 
            this.mnhoadon.Index = 6;
            this.mnhoadon.Text = "Hóa đơn";
            this.mnhoadon.Click += new System.EventHandler(this.mnhoadon_Click);
            // 
            // mnSearchSach
            // 
            this.mnSearchSach.Index = 0;
            this.mnSearchSach.Text = "Sách";
            this.mnSearchSach.Click += new System.EventHandler(this.mnSearchSach_Click);
            // 
            // mnTimKiem
            // 
            this.mnTimKiem.Index = 1;
            this.mnTimKiem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnSearchSach,
            this.menuItem1,
            this.menuItem2});
            this.mnTimKiem.Text = "Tìm kiếm";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "Hóa đơn";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Nhân viên";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // mnExit
            // 
            this.mnExit.Index = 4;
            this.mnExit.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
            this.mnExit.Text = "Đăng xuất";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnThongKe
            // 
            this.mnThongKe.Index = 0;
            this.mnThongKe.Text = "Thống kê ";
            this.mnThongKe.Click += new System.EventHandler(this.mnThongKe_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnThongKe,
            this.mnTimKiem,
            this.mnCauHinh,
            this.mnCaNhan,
            this.mnExit});
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 688);
            this.Controls.Add(this.stBar);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Menu = this.mainMenu1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CỬA HÀNG BÁN SÁCH ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBarPanel Date;
        private System.Windows.Forms.StatusBar stBar;
        private System.Windows.Forms.StatusBarPanel NhanVien;
        private System.Windows.Forms.MenuItem mnCaNhan;
        private System.Windows.Forms.MenuItem mnHoSoNV;
        private System.Windows.Forms.MenuItem menuItem5;
        public System.Windows.Forms.MenuItem mnkhach;
        public System.Windows.Forms.MenuItem mnSach;
        private System.Windows.Forms.MenuItem mnCauHinh;
        private System.Windows.Forms.MenuItem mnSearchSach;
        private System.Windows.Forms.MenuItem mnTimKiem;
        private System.Windows.Forms.MenuItem mnExit;
        private System.Windows.Forms.MenuItem mnThongKe;
        public System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mntheloai;
        private System.Windows.Forms.MenuItem mnTacGia;
        private System.Windows.Forms.MenuItem mnhoadon;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

