namespace Quản_Lý_Phòng_Máy
{
    partial class frm_QuanLyGV
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
            this.lbl_QuanLyGV = new System.Windows.Forms.Label();
            this.grp_ThongTinGV = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.rad_SDT = new System.Windows.Forms.RadioButton();
            this.rad_TenGV = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.dtm_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtN_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.txtNhapTenGV = new System.Windows.Forms.TextBox();
            this.lbl_TenGV = new System.Windows.Forms.Label();
            this.txtNhapMaGV = new System.Windows.Forms.TextBox();
            this.lbl_MaGV = new System.Windows.Forms.Label();
            this.dvw_DSGV = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ThongTinGV.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QuanLyGV
            // 
            this.lbl_QuanLyGV.AutoSize = true;
            this.lbl_QuanLyGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyGV.Location = new System.Drawing.Point(1, 9);
            this.lbl_QuanLyGV.Name = "lbl_QuanLyGV";
            this.lbl_QuanLyGV.Size = new System.Drawing.Size(500, 61);
            this.lbl_QuanLyGV.TabIndex = 0;
            this.lbl_QuanLyGV.Text = "Quản Lý Giảng Viên";
            // 
            // grp_ThongTinGV
            // 
            this.grp_ThongTinGV.Controls.Add(this.btn_Xoa);
            this.grp_ThongTinGV.Controls.Add(this.btn_CapNhat);
            this.grp_ThongTinGV.Controls.Add(this.btn_ThemMoi);
            this.grp_ThongTinGV.Controls.Add(this.grp_TimKiem);
            this.grp_ThongTinGV.Controls.Add(this.txt_Password);
            this.grp_ThongTinGV.Controls.Add(this.lbl_Password);
            this.grp_ThongTinGV.Controls.Add(this.txt_Username);
            this.grp_ThongTinGV.Controls.Add(this.lbl_Username);
            this.grp_ThongTinGV.Controls.Add(this.dtm_NgaySinh);
            this.grp_ThongTinGV.Controls.Add(this.txtN_DiaChi);
            this.grp_ThongTinGV.Controls.Add(this.lbl_DiaChi);
            this.grp_ThongTinGV.Controls.Add(this.lbl_NgaySinh);
            this.grp_ThongTinGV.Controls.Add(this.txt_SDT);
            this.grp_ThongTinGV.Controls.Add(this.lbl_SDT);
            this.grp_ThongTinGV.Controls.Add(this.lbl_GioiTinh);
            this.grp_ThongTinGV.Controls.Add(this.rad_Nu);
            this.grp_ThongTinGV.Controls.Add(this.rad_Nam);
            this.grp_ThongTinGV.Controls.Add(this.txtNhapTenGV);
            this.grp_ThongTinGV.Controls.Add(this.lbl_TenGV);
            this.grp_ThongTinGV.Controls.Add(this.txtNhapMaGV);
            this.grp_ThongTinGV.Controls.Add(this.lbl_MaGV);
            this.grp_ThongTinGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinGV.Location = new System.Drawing.Point(3, 94);
            this.grp_ThongTinGV.Name = "grp_ThongTinGV";
            this.grp_ThongTinGV.Size = new System.Drawing.Size(729, 280);
            this.grp_ThongTinGV.TabIndex = 1;
            this.grp_ThongTinGV.TabStop = false;
            this.grp_ThongTinGV.Text = "Thông Tin Giảng Viên";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Location = new System.Drawing.Point(618, 141);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(101, 37);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Location = new System.Drawing.Point(618, 85);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(101, 37);
            this.btn_CapNhat.TabIndex = 20;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemMoi.Location = new System.Drawing.Point(618, 31);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(101, 37);
            this.btn_ThemMoi.TabIndex = 19;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = false;
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.rad_SDT);
            this.grp_TimKiem.Controls.Add(this.rad_TenGV);
            this.grp_TimKiem.Controls.Add(this.txt_TimKiem);
            this.grp_TimKiem.Location = new System.Drawing.Point(13, 196);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(530, 61);
            this.grp_TimKiem.TabIndex = 18;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // rad_SDT
            // 
            this.rad_SDT.AutoSize = true;
            this.rad_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_SDT.Location = new System.Drawing.Point(408, 28);
            this.rad_SDT.Name = "rad_SDT";
            this.rad_SDT.Size = new System.Drawing.Size(103, 19);
            this.rad_SDT.TabIndex = 2;
            this.rad_SDT.TabStop = true;
            this.rad_SDT.Text = "Số Điện Thoại";
            this.rad_SDT.UseVisualStyleBackColor = true;
            // 
            // rad_TenGV
            // 
            this.rad_TenGV.AutoSize = true;
            this.rad_TenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TenGV.Location = new System.Drawing.Point(275, 28);
            this.rad_TenGV.Name = "rad_TenGV";
            this.rad_TenGV.Size = new System.Drawing.Size(109, 19);
            this.rad_TenGV.TabIndex = 1;
            this.rad_TenGV.TabStop = true;
            this.rad_TenGV.Text = "Tên Giảng Viên";
            this.rad_TenGV.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(7, 28);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(238, 21);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(407, 156);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(136, 21);
            this.txt_Password.TabIndex = 17;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(295, 159);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(63, 15);
            this.lbl_Password.TabIndex = 16;
            this.lbl_Password.Text = "Mật Khẩu:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(407, 113);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(136, 21);
            this.txt_Username.TabIndex = 15;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(295, 116);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(97, 15);
            this.lbl_Username.TabIndex = 14;
            this.lbl_Username.Text = "Tên Đăng Nhập:";
            // 
            // dtm_NgaySinh
            // 
            this.dtm_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_NgaySinh.Location = new System.Drawing.Point(407, 31);
            this.dtm_NgaySinh.Name = "dtm_NgaySinh";
            this.dtm_NgaySinh.Size = new System.Drawing.Size(136, 21);
            this.dtm_NgaySinh.TabIndex = 13;
            // 
            // txtN_DiaChi
            // 
            this.txtN_DiaChi.Location = new System.Drawing.Point(407, 74);
            this.txtN_DiaChi.Name = "txtN_DiaChi";
            this.txtN_DiaChi.Size = new System.Drawing.Size(136, 21);
            this.txtN_DiaChi.TabIndex = 12;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(295, 77);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(50, 15);
            this.lbl_DiaChi.TabIndex = 11;
            this.lbl_DiaChi.Text = "Địa Chỉ:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(295, 34);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(66, 15);
            this.lbl_NgaySinh.TabIndex = 9;
            this.lbl_NgaySinh.Text = "Ngày Sinh:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(122, 157);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(136, 21);
            this.txt_SDT.TabIndex = 8;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(6, 160);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(88, 15);
            this.lbl_SDT.TabIndex = 7;
            this.lbl_SDT.Text = "Số Điện Thoại:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(9, 119);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(59, 15);
            this.lbl_GioiTinh.TabIndex = 6;
            this.lbl_GioiTinh.Text = "Giới Tính:";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Nu.Location = new System.Drawing.Point(183, 117);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(41, 19);
            this.rad_Nu.TabIndex = 5;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Nam.Location = new System.Drawing.Point(122, 117);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(52, 19);
            this.rad_Nam.TabIndex = 4;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // txtNhapTenGV
            // 
            this.txtNhapTenGV.Location = new System.Drawing.Point(122, 74);
            this.txtNhapTenGV.Name = "txtNhapTenGV";
            this.txtNhapTenGV.Size = new System.Drawing.Size(136, 21);
            this.txtNhapTenGV.TabIndex = 3;
            // 
            // lbl_TenGV
            // 
            this.lbl_TenGV.AutoSize = true;
            this.lbl_TenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenGV.Location = new System.Drawing.Point(10, 77);
            this.lbl_TenGV.Name = "lbl_TenGV";
            this.lbl_TenGV.Size = new System.Drawing.Size(94, 15);
            this.lbl_TenGV.TabIndex = 2;
            this.lbl_TenGV.Text = "Tên Giảng Viên:";
            // 
            // txtNhapMaGV
            // 
            this.txtNhapMaGV.Location = new System.Drawing.Point(122, 31);
            this.txtNhapMaGV.Name = "txtNhapMaGV";
            this.txtNhapMaGV.Size = new System.Drawing.Size(136, 21);
            this.txtNhapMaGV.TabIndex = 1;
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaGV.Location = new System.Drawing.Point(10, 34);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(91, 15);
            this.lbl_MaGV.TabIndex = 0;
            this.lbl_MaGV.Text = "Mã Giảng Viên:";
            // 
            // dvw_DSGV
            // 
            this.dvw_DSGV.AllowUserToAddRows = false;
            this.dvw_DSGV.AllowUserToDeleteRows = false;
            this.dvw_DSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvw_DSGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dvw_DSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvw_DSGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.GioiTinh,
            this.SoDienThoai,
            this.DiaChi,
            this.username});
            this.dvw_DSGV.Location = new System.Drawing.Point(3, 380);
            this.dvw_DSGV.Name = "dvw_DSGV";
            this.dvw_DSGV.ReadOnly = true;
            this.dvw_DSGV.Size = new System.Drawing.Size(729, 262);
            this.dvw_DSGV.TabIndex = 2;
            // 
            // MaGV
            // 
            this.MaGV.HeaderText = "Mã Giảng Viên";
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            // 
            // TenGV
            // 
            this.TenGV.HeaderText = "Tên Giảng Viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "Tên Đăng Nhập";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // frm_QuanLyGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 644);
            this.Controls.Add(this.dvw_DSGV);
            this.Controls.Add(this.grp_ThongTinGV);
            this.Controls.Add(this.lbl_QuanLyGV);
            this.Name = "frm_QuanLyGV";
            this.Text = "frm_QuanLyGV";
            this.grp_ThongTinGV.ResumeLayout(false);
            this.grp_ThongTinGV.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvw_DSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QuanLyGV;
        private System.Windows.Forms.GroupBox grp_ThongTinGV;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.TextBox txtNhapTenGV;
        private System.Windows.Forms.Label lbl_TenGV;
        private System.Windows.Forms.TextBox txtNhapMaGV;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.RadioButton rad_SDT;
        private System.Windows.Forms.RadioButton rad_TenGV;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.DateTimePicker dtm_NgaySinh;
        private System.Windows.Forms.TextBox txtN_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.DataGridView dvw_DSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
    }
}