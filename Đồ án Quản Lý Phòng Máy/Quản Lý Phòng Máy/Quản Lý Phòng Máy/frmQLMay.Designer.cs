namespace Quản_Lý_Phòng_Máy
{
    partial class frm_QuanLyMay
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
            this.lbl_QuanLyMay = new System.Windows.Forms.Label();
            this.grp_QuanLyMay = new System.Windows.Forms.GroupBox();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.radTrangThai = new System.Windows.Forms.RadioButton();
            this.radTenMay = new System.Windows.Forms.RadioButton();
            this.radMaMay = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbnThem = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.cbHeDieuHanh = new System.Windows.Forms.ComboBox();
            this.lbl_HDH = new System.Windows.Forms.Label();
            this.cbPSU = new System.Windows.Forms.ComboBox();
            this.lbl_PSU = new System.Windows.Forms.Label();
            this.cbVGA = new System.Windows.Forms.ComboBox();
            this.lbl_VGA = new System.Windows.Forms.Label();
            this.cbOCung = new System.Windows.Forms.ComboBox();
            this.lbl_OCung = new System.Windows.Forms.Label();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.cbMainBoard = new System.Windows.Forms.ComboBox();
            this.lbl_MainBoard = new System.Windows.Forms.Label();
            this.cbCPU = new System.Windows.Forms.ComboBox();
            this.lbl_CPU = new System.Windows.Forms.Label();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.lbl_Case = new System.Windows.Forms.Label();
            this.cbBanPhim = new System.Windows.Forms.ComboBox();
            this.lbl_BanPhim = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Chuot = new System.Windows.Forms.Label();
            this.cbManHinh = new System.Windows.Forms.ComboBox();
            this.lbl_ManHinh = new System.Windows.Forms.Label();
            this.txtNhapTenMay = new System.Windows.Forms.TextBox();
            this.lbl_TenMay = new System.Windows.Forms.Label();
            this.txtNhapMaMay = new System.Windows.Forms.TextBox();
            this.lbl_MaMay = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeDieuHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_QuanLyMay.SuspendLayout();
            this.grp_TimKiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QuanLyMay
            // 
            this.lbl_QuanLyMay.AutoSize = true;
            this.lbl_QuanLyMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyMay.Location = new System.Drawing.Point(12, 9);
            this.lbl_QuanLyMay.Name = "lbl_QuanLyMay";
            this.lbl_QuanLyMay.Size = new System.Drawing.Size(339, 61);
            this.lbl_QuanLyMay.TabIndex = 0;
            this.lbl_QuanLyMay.Text = "Quản Lý Máy";
            // 
            // grp_QuanLyMay
            // 
            this.grp_QuanLyMay.Controls.Add(this.grp_TimKiem);
            this.grp_QuanLyMay.Controls.Add(this.btnXoa);
            this.grp_QuanLyMay.Controls.Add(this.btnSua);
            this.grp_QuanLyMay.Controls.Add(this.tbnThem);
            this.grp_QuanLyMay.Controls.Add(this.cbTrangThai);
            this.grp_QuanLyMay.Controls.Add(this.lbl_TrangThai);
            this.grp_QuanLyMay.Controls.Add(this.groupBox2);
            this.grp_QuanLyMay.Controls.Add(this.txtNhapTenMay);
            this.grp_QuanLyMay.Controls.Add(this.lbl_TenMay);
            this.grp_QuanLyMay.Controls.Add(this.txtNhapMaMay);
            this.grp_QuanLyMay.Controls.Add(this.lbl_MaMay);
            this.grp_QuanLyMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_QuanLyMay.Location = new System.Drawing.Point(1, 92);
            this.grp_QuanLyMay.Name = "grp_QuanLyMay";
            this.grp_QuanLyMay.Size = new System.Drawing.Size(899, 444);
            this.grp_QuanLyMay.TabIndex = 1;
            this.grp_QuanLyMay.TabStop = false;
            this.grp_QuanLyMay.Text = "Quản Lý Máy";
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.radTrangThai);
            this.grp_TimKiem.Controls.Add(this.radTenMay);
            this.grp_TimKiem.Controls.Add(this.radMaMay);
            this.grp_TimKiem.Controls.Add(this.textBox1);
            this.grp_TimKiem.Location = new System.Drawing.Point(22, 358);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(700, 65);
            this.grp_TimKiem.TabIndex = 24;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // radTrangThai
            // 
            this.radTrangThai.AutoSize = true;
            this.radTrangThai.Location = new System.Drawing.Point(537, 29);
            this.radTrangThai.Name = "radTrangThai";
            this.radTrangThai.Size = new System.Drawing.Size(87, 17);
            this.radTrangThai.TabIndex = 3;
            this.radTrangThai.TabStop = true;
            this.radTrangThai.Text = "Trạng Thái";
            this.radTrangThai.UseVisualStyleBackColor = true;
            // 
            // radTenMay
            // 
            this.radTenMay.AutoSize = true;
            this.radTenMay.Location = new System.Drawing.Point(398, 29);
            this.radTenMay.Name = "radTenMay";
            this.radTenMay.Size = new System.Drawing.Size(74, 17);
            this.radTenMay.TabIndex = 2;
            this.radTenMay.TabStop = true;
            this.radTenMay.Text = "Tên Máy";
            this.radTenMay.UseVisualStyleBackColor = true;
            // 
            // radMaMay
            // 
            this.radMaMay.AutoSize = true;
            this.radMaMay.Location = new System.Drawing.Point(252, 29);
            this.radMaMay.Name = "radMaMay";
            this.radMaMay.Size = new System.Drawing.Size(69, 17);
            this.radMaMay.TabIndex = 1;
            this.radMaMay.TabStop = true;
            this.radMaMay.Text = "Mã Máy";
            this.radMaMay.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(767, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 34);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(767, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // tbnThem
            // 
            this.tbnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnThem.Location = new System.Drawing.Point(767, 92);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(97, 34);
            this.tbnThem.TabIndex = 21;
            this.tbnThem.Text = "Thêm";
            this.tbnThem.UseVisualStyleBackColor = false;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Mới",
            "Cũ"});
            this.cbTrangThai.Location = new System.Drawing.Point(624, 33);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(112, 21);
            this.cbTrangThai.TabIndex = 20;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Location = new System.Drawing.Point(541, 37);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(77, 13);
            this.lbl_TrangThai.TabIndex = 5;
            this.lbl_TrangThai.Text = "Trạng Thái: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.lbl_GhiChu);
            this.groupBox2.Controls.Add(this.cbHeDieuHanh);
            this.groupBox2.Controls.Add(this.lbl_HDH);
            this.groupBox2.Controls.Add(this.cbPSU);
            this.groupBox2.Controls.Add(this.lbl_PSU);
            this.groupBox2.Controls.Add(this.cbVGA);
            this.groupBox2.Controls.Add(this.lbl_VGA);
            this.groupBox2.Controls.Add(this.cbOCung);
            this.groupBox2.Controls.Add(this.lbl_OCung);
            this.groupBox2.Controls.Add(this.cbRAM);
            this.groupBox2.Controls.Add(this.lbl_RAM);
            this.groupBox2.Controls.Add(this.cbMainBoard);
            this.groupBox2.Controls.Add(this.lbl_MainBoard);
            this.groupBox2.Controls.Add(this.cbCPU);
            this.groupBox2.Controls.Add(this.lbl_CPU);
            this.groupBox2.Controls.Add(this.cbCase);
            this.groupBox2.Controls.Add(this.lbl_Case);
            this.groupBox2.Controls.Add(this.cbBanPhim);
            this.groupBox2.Controls.Add(this.lbl_BanPhim);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lbl_Chuot);
            this.groupBox2.Controls.Add(this.cbManHinh);
            this.groupBox2.Controls.Add(this.lbl_ManHinh);
            this.groupBox2.Location = new System.Drawing.Point(22, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 273);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Máy";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(476, 233);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(182, 20);
            this.txtGhiChu.TabIndex = 25;
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Location = new System.Drawing.Point(395, 236);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(56, 13);
            this.lbl_GhiChu.TabIndex = 24;
            this.lbl_GhiChu.Text = "Ghi Chú:";
            // 
            // cbHeDieuHanh
            // 
            this.cbHeDieuHanh.FormattingEnabled = true;
            this.cbHeDieuHanh.Location = new System.Drawing.Point(108, 233);
            this.cbHeDieuHanh.Name = "cbHeDieuHanh";
            this.cbHeDieuHanh.Size = new System.Drawing.Size(181, 21);
            this.cbHeDieuHanh.TabIndex = 21;
            // 
            // lbl_HDH
            // 
            this.lbl_HDH.AutoSize = true;
            this.lbl_HDH.Location = new System.Drawing.Point(7, 236);
            this.lbl_HDH.Name = "lbl_HDH";
            this.lbl_HDH.Size = new System.Drawing.Size(95, 13);
            this.lbl_HDH.TabIndex = 20;
            this.lbl_HDH.Text = "Hệ Điều Hành: ";
            // 
            // cbPSU
            // 
            this.cbPSU.FormattingEnabled = true;
            this.cbPSU.Location = new System.Drawing.Point(476, 190);
            this.cbPSU.Name = "cbPSU";
            this.cbPSU.Size = new System.Drawing.Size(182, 21);
            this.cbPSU.TabIndex = 19;
            // 
            // lbl_PSU
            // 
            this.lbl_PSU.AutoSize = true;
            this.lbl_PSU.Location = new System.Drawing.Point(396, 193);
            this.lbl_PSU.Name = "lbl_PSU";
            this.lbl_PSU.Size = new System.Drawing.Size(40, 13);
            this.lbl_PSU.TabIndex = 18;
            this.lbl_PSU.Text = "PSU: ";
            // 
            // cbVGA
            // 
            this.cbVGA.FormattingEnabled = true;
            this.cbVGA.Location = new System.Drawing.Point(476, 152);
            this.cbVGA.Name = "cbVGA";
            this.cbVGA.Size = new System.Drawing.Size(182, 21);
            this.cbVGA.TabIndex = 17;
            // 
            // lbl_VGA
            // 
            this.lbl_VGA.AutoSize = true;
            this.lbl_VGA.Location = new System.Drawing.Point(396, 155);
            this.lbl_VGA.Name = "lbl_VGA";
            this.lbl_VGA.Size = new System.Drawing.Size(40, 13);
            this.lbl_VGA.TabIndex = 16;
            this.lbl_VGA.Text = "VGA: ";
            // 
            // cbOCung
            // 
            this.cbOCung.FormattingEnabled = true;
            this.cbOCung.Location = new System.Drawing.Point(476, 112);
            this.cbOCung.Name = "cbOCung";
            this.cbOCung.Size = new System.Drawing.Size(182, 21);
            this.cbOCung.TabIndex = 15;
            // 
            // lbl_OCung
            // 
            this.lbl_OCung.AutoSize = true;
            this.lbl_OCung.Location = new System.Drawing.Point(396, 115);
            this.lbl_OCung.Name = "lbl_OCung";
            this.lbl_OCung.Size = new System.Drawing.Size(57, 13);
            this.lbl_OCung.TabIndex = 14;
            this.lbl_OCung.Text = "Ổ Cứng: ";
            // 
            // cbRAM
            // 
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Location = new System.Drawing.Point(476, 71);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(182, 21);
            this.cbRAM.TabIndex = 13;
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.Location = new System.Drawing.Point(396, 74);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(42, 13);
            this.lbl_RAM.TabIndex = 12;
            this.lbl_RAM.Text = "RAM: ";
            // 
            // cbMainBoard
            // 
            this.cbMainBoard.FormattingEnabled = true;
            this.cbMainBoard.Location = new System.Drawing.Point(476, 31);
            this.cbMainBoard.Name = "cbMainBoard";
            this.cbMainBoard.Size = new System.Drawing.Size(182, 21);
            this.cbMainBoard.TabIndex = 11;
            // 
            // lbl_MainBoard
            // 
            this.lbl_MainBoard.AutoSize = true;
            this.lbl_MainBoard.Location = new System.Drawing.Point(396, 34);
            this.lbl_MainBoard.Name = "lbl_MainBoard";
            this.lbl_MainBoard.Size = new System.Drawing.Size(75, 13);
            this.lbl_MainBoard.TabIndex = 10;
            this.lbl_MainBoard.Text = "MainBoard: ";
            // 
            // cbCPU
            // 
            this.cbCPU.FormattingEnabled = true;
            this.cbCPU.Location = new System.Drawing.Point(108, 190);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(181, 21);
            this.cbCPU.TabIndex = 9;
            // 
            // lbl_CPU
            // 
            this.lbl_CPU.AutoSize = true;
            this.lbl_CPU.Location = new System.Drawing.Point(7, 193);
            this.lbl_CPU.Name = "lbl_CPU";
            this.lbl_CPU.Size = new System.Drawing.Size(40, 13);
            this.lbl_CPU.TabIndex = 8;
            this.lbl_CPU.Text = "CPU: ";
            // 
            // cbCase
            // 
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(108, 152);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(181, 21);
            this.cbCase.TabIndex = 7;
            // 
            // lbl_Case
            // 
            this.lbl_Case.AutoSize = true;
            this.lbl_Case.Location = new System.Drawing.Point(7, 155);
            this.lbl_Case.Name = "lbl_Case";
            this.lbl_Case.Size = new System.Drawing.Size(43, 13);
            this.lbl_Case.TabIndex = 6;
            this.lbl_Case.Text = "Case: ";
            // 
            // cbBanPhim
            // 
            this.cbBanPhim.FormattingEnabled = true;
            this.cbBanPhim.Location = new System.Drawing.Point(108, 112);
            this.cbBanPhim.Name = "cbBanPhim";
            this.cbBanPhim.Size = new System.Drawing.Size(181, 21);
            this.cbBanPhim.TabIndex = 5;
            // 
            // lbl_BanPhim
            // 
            this.lbl_BanPhim.AutoSize = true;
            this.lbl_BanPhim.Location = new System.Drawing.Point(7, 115);
            this.lbl_BanPhim.Name = "lbl_BanPhim";
            this.lbl_BanPhim.Size = new System.Drawing.Size(70, 13);
            this.lbl_BanPhim.TabIndex = 4;
            this.lbl_BanPhim.Text = "Bàn Phím: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lbl_Chuot
            // 
            this.lbl_Chuot.AutoSize = true;
            this.lbl_Chuot.Location = new System.Drawing.Point(7, 74);
            this.lbl_Chuot.Name = "lbl_Chuot";
            this.lbl_Chuot.Size = new System.Drawing.Size(48, 13);
            this.lbl_Chuot.TabIndex = 2;
            this.lbl_Chuot.Text = "Chuột: ";
            // 
            // cbManHinh
            // 
            this.cbManHinh.FormattingEnabled = true;
            this.cbManHinh.Location = new System.Drawing.Point(108, 31);
            this.cbManHinh.Name = "cbManHinh";
            this.cbManHinh.Size = new System.Drawing.Size(181, 21);
            this.cbManHinh.TabIndex = 1;
            // 
            // lbl_ManHinh
            // 
            this.lbl_ManHinh.AutoSize = true;
            this.lbl_ManHinh.Location = new System.Drawing.Point(7, 34);
            this.lbl_ManHinh.Name = "lbl_ManHinh";
            this.lbl_ManHinh.Size = new System.Drawing.Size(69, 13);
            this.lbl_ManHinh.TabIndex = 0;
            this.lbl_ManHinh.Text = "Màn Hình: ";
            // 
            // txtNhapTenMay
            // 
            this.txtNhapTenMay.Location = new System.Drawing.Point(352, 34);
            this.txtNhapTenMay.Name = "txtNhapTenMay";
            this.txtNhapTenMay.Size = new System.Drawing.Size(143, 20);
            this.txtNhapTenMay.TabIndex = 3;
            // 
            // lbl_TenMay
            // 
            this.lbl_TenMay.AutoSize = true;
            this.lbl_TenMay.Location = new System.Drawing.Point(271, 37);
            this.lbl_TenMay.Name = "lbl_TenMay";
            this.lbl_TenMay.Size = new System.Drawing.Size(64, 13);
            this.lbl_TenMay.TabIndex = 2;
            this.lbl_TenMay.Text = "Tên Máy: ";
            // 
            // txtNhapMaMay
            // 
            this.txtNhapMaMay.Location = new System.Drawing.Point(87, 34);
            this.txtNhapMaMay.Name = "txtNhapMaMay";
            this.txtNhapMaMay.Size = new System.Drawing.Size(143, 20);
            this.txtNhapMaMay.TabIndex = 1;
            // 
            // lbl_MaMay
            // 
            this.lbl_MaMay.AutoSize = true;
            this.lbl_MaMay.Location = new System.Drawing.Point(22, 37);
            this.lbl_MaMay.Name = "lbl_MaMay";
            this.lbl_MaMay.Size = new System.Drawing.Size(59, 13);
            this.lbl_MaMay.TabIndex = 0;
            this.lbl_MaMay.Text = "Mã Máy: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMay,
            this.TenMay,
            this.ManHinh,
            this.Chuot,
            this.BanPhim,
            this.Case,
            this.CPU,
            this.MainBoard,
            this.RAM,
            this.OCung,
            this.VGA,
            this.SPU,
            this.HeDieuHanh,
            this.TrangThai,
            this.GhiChu});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 205);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaMay
            // 
            this.MaMay.HeaderText = "Mã Máy";
            this.MaMay.Name = "MaMay";
            this.MaMay.ReadOnly = true;
            this.MaMay.Width = 70;
            // 
            // TenMay
            // 
            this.TenMay.HeaderText = "Tên Máy";
            this.TenMay.Name = "TenMay";
            this.TenMay.ReadOnly = true;
            this.TenMay.Width = 74;
            // 
            // ManHinh
            // 
            this.ManHinh.HeaderText = "Màn Hình";
            this.ManHinh.Name = "ManHinh";
            this.ManHinh.ReadOnly = true;
            this.ManHinh.Width = 78;
            // 
            // Chuot
            // 
            this.Chuot.HeaderText = "Chuột";
            this.Chuot.Name = "Chuot";
            this.Chuot.ReadOnly = true;
            this.Chuot.Width = 60;
            // 
            // BanPhim
            // 
            this.BanPhim.HeaderText = "Bàn Phím";
            this.BanPhim.Name = "BanPhim";
            this.BanPhim.ReadOnly = true;
            this.BanPhim.Width = 79;
            // 
            // Case
            // 
            this.Case.HeaderText = "Case";
            this.Case.Name = "Case";
            this.Case.ReadOnly = true;
            this.Case.Width = 56;
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            this.CPU.Width = 54;
            // 
            // MainBoard
            // 
            this.MainBoard.HeaderText = "MainBoard";
            this.MainBoard.Name = "MainBoard";
            this.MainBoard.ReadOnly = true;
            this.MainBoard.Width = 83;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 56;
            // 
            // OCung
            // 
            this.OCung.HeaderText = "Ổ Cứng";
            this.OCung.Name = "OCung";
            this.OCung.ReadOnly = true;
            this.OCung.Width = 68;
            // 
            // VGA
            // 
            this.VGA.HeaderText = "VGA";
            this.VGA.Name = "VGA";
            this.VGA.ReadOnly = true;
            this.VGA.Width = 54;
            // 
            // SPU
            // 
            this.SPU.HeaderText = "SPU";
            this.SPU.Name = "SPU";
            this.SPU.ReadOnly = true;
            this.SPU.Width = 54;
            // 
            // HeDieuHanh
            // 
            this.HeDieuHanh.HeaderText = "Hệ Điều Hành";
            this.HeDieuHanh.Name = "HeDieuHanh";
            this.HeDieuHanh.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 84;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 70;
            // 
            // frm_QuanLyMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 739);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_QuanLyMay);
            this.Controls.Add(this.grp_QuanLyMay);
            this.Name = "frm_QuanLyMay";
            this.Text = "frm_QuanLyMay";
            this.grp_QuanLyMay.ResumeLayout(false);
            this.grp_QuanLyMay.PerformLayout();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QuanLyMay;
        private System.Windows.Forms.GroupBox grp_QuanLyMay;
        private System.Windows.Forms.TextBox txtNhapTenMay;
        private System.Windows.Forms.Label lbl_TenMay;
        private System.Windows.Forms.TextBox txtNhapMaMay;
        private System.Windows.Forms.Label lbl_MaMay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.Label lbl_Case;
        private System.Windows.Forms.ComboBox cbBanPhim;
        private System.Windows.Forms.Label lbl_BanPhim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Chuot;
        private System.Windows.Forms.ComboBox cbManHinh;
        private System.Windows.Forms.Label lbl_ManHinh;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.Label lbl_CPU;
        private System.Windows.Forms.ComboBox cbPSU;
        private System.Windows.Forms.Label lbl_PSU;
        private System.Windows.Forms.ComboBox cbVGA;
        private System.Windows.Forms.Label lbl_VGA;
        private System.Windows.Forms.ComboBox cbOCung;
        private System.Windows.Forms.Label lbl_OCung;
        private System.Windows.Forms.ComboBox cbRAM;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.ComboBox cbMainBoard;
        private System.Windows.Forms.Label lbl_MainBoard;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button tbnThem;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.ComboBox cbHeDieuHanh;
        private System.Windows.Forms.Label lbl_HDH;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.RadioButton radTenMay;
        private System.Windows.Forms.RadioButton radMaMay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.RadioButton radTrangThai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn VGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeDieuHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}