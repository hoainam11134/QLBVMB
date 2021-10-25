namespace Plane_Ticket
{
    partial class frmBanVe
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
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHangVe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.txtSanBayDi = new System.Windows.Forms.TextBox();
            this.txtSanBayDen = new System.Windows.Forms.TextBox();
            this.txtThoiGianKhoiHanh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThoiGIanBay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnMuaVe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxDSVe = new System.Windows.Forms.GroupBox();
            this.dtgvVe = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxTTVe = new System.Windows.Forms.GroupBox();
            this.btnChiTietGheTrong = new System.Windows.Forms.Button();
            this.txtSoGheTrong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxThaoTac.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxDSVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).BeginInit();
            this.gbxTTVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(151, 302);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(221, 27);
            this.txtTenKhachHang.TabIndex = 2;
            this.txtTenKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhachHang_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(151, 342);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.MaxLength = 15;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(221, 27);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(152, 261);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.MaxLength = 12;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(221, 27);
            this.txtCMND.TabIndex = 1;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(5, 390);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "Tên hạng vé";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 347);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tên Khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Thời gian khởi hành";
            // 
            // cboHangVe
            // 
            this.cboHangVe.FormattingEnabled = true;
            this.cboHangVe.Location = new System.Drawing.Point(152, 383);
            this.cboHangVe.Margin = new System.Windows.Forms.Padding(4);
            this.cboHangVe.Name = "cboHangVe";
            this.cboHangVe.Size = new System.Drawing.Size(221, 27);
            this.cboHangVe.TabIndex = 4;
            this.cboHangVe.SelectedValueChanged += new System.EventHandler(this.cboHangVe_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Sân Bay Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sân Bay Đi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Mã chuyến bay";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(153, 17);
            this.cboMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(221, 27);
            this.cboMaChuyenBay.TabIndex = 0;
            this.cboMaChuyenBay.TextUpdate += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            // 
            // txtSanBayDi
            // 
            this.txtSanBayDi.Location = new System.Drawing.Point(152, 97);
            this.txtSanBayDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanBayDi.Name = "txtSanBayDi";
            this.txtSanBayDi.ReadOnly = true;
            this.txtSanBayDi.Size = new System.Drawing.Size(221, 27);
            this.txtSanBayDi.TabIndex = 69;
            this.txtSanBayDi.TabStop = false;
            // 
            // txtSanBayDen
            // 
            this.txtSanBayDen.Location = new System.Drawing.Point(152, 134);
            this.txtSanBayDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanBayDen.Name = "txtSanBayDen";
            this.txtSanBayDen.ReadOnly = true;
            this.txtSanBayDen.Size = new System.Drawing.Size(221, 27);
            this.txtSanBayDen.TabIndex = 69;
            this.txtSanBayDen.TabStop = false;
            // 
            // txtThoiGianKhoiHanh
            // 
            this.txtThoiGianKhoiHanh.Location = new System.Drawing.Point(152, 177);
            this.txtThoiGianKhoiHanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianKhoiHanh.Name = "txtThoiGianKhoiHanh";
            this.txtThoiGianKhoiHanh.ReadOnly = true;
            this.txtThoiGianKhoiHanh.Size = new System.Drawing.Size(221, 27);
            this.txtThoiGianKhoiHanh.TabIndex = 69;
            this.txtThoiGianKhoiHanh.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(7, 473);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 63;
            this.label11.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(149, 468);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.Size = new System.Drawing.Size(179, 27);
            this.txtGiaTien.TabIndex = 68;
            this.txtGiaTien.TabStop = false;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(5, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 59;
            this.label12.Text = "Thời gian bay";
            // 
            // txtThoiGIanBay
            // 
            this.txtThoiGIanBay.Location = new System.Drawing.Point(152, 218);
            this.txtThoiGIanBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGIanBay.Name = "txtThoiGIanBay";
            this.txtThoiGIanBay.ReadOnly = true;
            this.txtThoiGIanBay.Size = new System.Drawing.Size(221, 27);
            this.txtThoiGIanBay.TabIndex = 69;
            this.txtThoiGIanBay.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(7, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 19);
            this.label13.TabIndex = 54;
            this.label13.Text = "Mã tuyến bay";
            // 
            // txtMaTuyenBay
            // 
            this.txtMaTuyenBay.Location = new System.Drawing.Point(152, 57);
            this.txtMaTuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTuyenBay.Name = "txtMaTuyenBay";
            this.txtMaTuyenBay.ReadOnly = true;
            this.txtMaTuyenBay.Size = new System.Drawing.Size(221, 27);
            this.txtMaTuyenBay.TabIndex = 69;
            this.txtMaTuyenBay.TabStop = false;
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnTraCuu);
            this.gbxThaoTac.Controls.Add(this.btnMuaVe);
            this.gbxThaoTac.Controls.Add(this.btnDatVe);
            this.gbxThaoTac.Controls.Add(this.label16);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Controls.Add(this.label2);
            this.gbxThaoTac.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxThaoTac.Location = new System.Drawing.Point(11, 590);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 149);
            this.gbxThaoTac.TabIndex = 1;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
            this.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Location = new System.Drawing.Point(264, 22);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(55, 50);
            this.btnTraCuu.TabIndex = 64;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnMuaVe
            // 
            this.btnMuaVe.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnMua;
            this.btnMuaVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuaVe.FlatAppearance.BorderSize = 0;
            this.btnMuaVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaVe.Location = new System.Drawing.Point(41, 22);
            this.btnMuaVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuaVe.Name = "btnMuaVe";
            this.btnMuaVe.Size = new System.Drawing.Size(55, 50);
            this.btnMuaVe.TabIndex = 5;
            this.btnMuaVe.UseVisualStyleBackColor = true;
            this.btnMuaVe.Click += new System.EventHandler(this.btnMuaVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnDat1;
            this.btnDatVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatVe.FlatAppearance.BorderSize = 0;
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatVe.Location = new System.Drawing.Point(149, 22);
            this.btnDatVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(55, 50);
            this.btnDatVe.TabIndex = 6;
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(209, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 19);
            this.label16.TabIndex = 63;
            this.label16.Text = "Tra cứu chuyến bay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "Đặt vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mua vé";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 58);
            this.panel1.TabIndex = 75;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(457, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(375, 49);
            this.label17.TabIndex = 39;
            this.label17.Text = "BÁN VÉ MÁY BAY";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel1;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1404, 2);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 50);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbxDSVe
            // 
            this.gbxDSVe.Controls.Add(this.dtgvVe);
            this.gbxDSVe.Controls.Add(this.label18);
            this.gbxDSVe.Controls.Add(this.txtTimKiem);
            this.gbxDSVe.Controls.Add(this.btnTimKiem);
            this.gbxDSVe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxDSVe.Location = new System.Drawing.Point(397, 63);
            this.gbxDSVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDSVe.Name = "gbxDSVe";
            this.gbxDSVe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDSVe.Size = new System.Drawing.Size(1043, 699);
            this.gbxDSVe.TabIndex = 2;
            this.gbxDSVe.TabStop = false;
            this.gbxDSVe.Text = "Danh sách vé";
            // 
            // dtgvVe
            // 
            this.dtgvVe.BackgroundColor = System.Drawing.Color.White;
            this.dtgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVe.Location = new System.Drawing.Point(5, 63);
            this.dtgvVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvVe.Name = "dtgvVe";
            this.dtgvVe.RowTemplate.Height = 24;
            this.dtgvVe.Size = new System.Drawing.Size(1003, 609);
            this.dtgvVe.TabIndex = 9;
            this.dtgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVe_CellClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(667, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 15;
            this.label18.Text = "Tìm kiếm ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(784, 22);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(165, 27);
            this.txtTimKiem.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(959, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(33, 30);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // gbxTTVe
            // 
            this.gbxTTVe.Controls.Add(this.btnChiTietGheTrong);
            this.gbxTTVe.Controls.Add(this.txtThoiGIanBay);
            this.gbxTTVe.Controls.Add(this.cboMaChuyenBay);
            this.gbxTTVe.Controls.Add(this.label1);
            this.gbxTTVe.Controls.Add(this.label13);
            this.gbxTTVe.Controls.Add(this.label6);
            this.gbxTTVe.Controls.Add(this.txtGiaTien);
            this.gbxTTVe.Controls.Add(this.txtTenKhachHang);
            this.gbxTTVe.Controls.Add(this.txtSoGheTrong);
            this.gbxTTVe.Controls.Add(this.txtSDT);
            this.gbxTTVe.Controls.Add(this.txtSanBayDen);
            this.gbxTTVe.Controls.Add(this.label14);
            this.gbxTTVe.Controls.Add(this.label11);
            this.gbxTTVe.Controls.Add(this.label3);
            this.gbxTTVe.Controls.Add(this.label4);
            this.gbxTTVe.Controls.Add(this.txtCMND);
            this.gbxTTVe.Controls.Add(this.label10);
            this.gbxTTVe.Controls.Add(this.txtThoiGianKhoiHanh);
            this.gbxTTVe.Controls.Add(this.label15);
            this.gbxTTVe.Controls.Add(this.cboHangVe);
            this.gbxTTVe.Controls.Add(this.label9);
            this.gbxTTVe.Controls.Add(this.label12);
            this.gbxTTVe.Controls.Add(this.txtMaTuyenBay);
            this.gbxTTVe.Controls.Add(this.txtSanBayDi);
            this.gbxTTVe.Controls.Add(this.label8);
            this.gbxTTVe.Controls.Add(this.label7);
            this.gbxTTVe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxTTVe.Location = new System.Drawing.Point(12, 64);
            this.gbxTTVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTTVe.Name = "gbxTTVe";
            this.gbxTTVe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTTVe.Size = new System.Drawing.Size(380, 522);
            this.gbxTTVe.TabIndex = 0;
            this.gbxTTVe.TabStop = false;
            this.gbxTTVe.Text = "Thông tin vé";
            // 
            // btnChiTietGheTrong
            // 
            this.btnChiTietGheTrong.Location = new System.Drawing.Point(285, 425);
            this.btnChiTietGheTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTietGheTrong.Name = "btnChiTietGheTrong";
            this.btnChiTietGheTrong.Size = new System.Drawing.Size(88, 28);
            this.btnChiTietGheTrong.TabIndex = 70;
            this.btnChiTietGheTrong.Text = "Chi tiết";
            this.btnChiTietGheTrong.UseVisualStyleBackColor = true;
            this.btnChiTietGheTrong.Click += new System.EventHandler(this.btnChiTietGheTrong_Click);
            // 
            // txtSoGheTrong
            // 
            this.txtSoGheTrong.Location = new System.Drawing.Point(152, 426);
            this.txtSoGheTrong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoGheTrong.Name = "txtSoGheTrong";
            this.txtSoGheTrong.ReadOnly = true;
            this.txtSoGheTrong.Size = new System.Drawing.Size(127, 27);
            this.txtSoGheTrong.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 471);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 19);
            this.label14.TabIndex = 63;
            this.label14.Text = "VNĐ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(8, 431);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 19);
            this.label15.TabIndex = 63;
            this.label15.Text = "Số ghế trống";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBanVe
            // 
            this.AcceptButton = this.btnMuaVe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1455, 788);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDSVe);
            this.Controls.Add(this.gbxTTVe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bán vé chuyến bay";
            this.Shown += new System.EventHandler(this.frmBanVe_Shown);
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSVe.ResumeLayout(false);
            this.gbxDSVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).EndInit();
            this.gbxTTVe.ResumeLayout(false);
            this.gbxTTVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHangVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.TextBox txtSanBayDi;
        private System.Windows.Forms.TextBox txtSanBayDen;
        private System.Windows.Forms.TextBox txtThoiGianKhoiHanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThoiGIanBay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnMuaVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSVe;
        private System.Windows.Forms.DataGridView dtgvVe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnChiTietGheTrong;
        private System.Windows.Forms.TextBox txtSoGheTrong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}