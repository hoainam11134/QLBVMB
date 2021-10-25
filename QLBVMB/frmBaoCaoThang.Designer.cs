namespace Plane_Ticket
{
    partial class frmBaoCaoThang
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
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDTThang = new System.Windows.Forms.DataGridView();
            this.dsDoanhThuThang = new Plane_Ticket.dsDoanhThuThang();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.Location = new System.Drawing.Point(882, 63);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(136, 44);
            this.btnXemBaoCao.TabIndex = 9;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 58);
            this.panel1.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(564, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 49);
            this.label7.TabIndex = 39;
            this.label7.Text = "BÁO CÁO THÁNG";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel1;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1392, 7);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 50);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(701, 70);
            this.dtpThangNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(115, 22);
            this.dtpThangNam.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 123;
            this.label1.Text = "Tháng / năm";
            // 
            // dtgvDTThang
            // 
            this.dtgvDTThang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDTThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDTThang.Location = new System.Drawing.Point(12, 124);
            this.dtgvDTThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDTThang.Name = "dtgvDTThang";
            this.dtgvDTThang.RowTemplate.Height = 24;
            this.dtgvDTThang.Size = new System.Drawing.Size(1435, 528);
            this.dtgvDTThang.TabIndex = 124;
            // 
            // dsDoanhThuThang
            // 
            this.dsDoanhThuThang.DataSetName = "dsDoanhThuThang";
            this.dsDoanhThuThang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(1097, 63);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(136, 44);
            this.btnReport.TabIndex = 125;
            this.btnReport.Text = "Xuất báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 678);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dtgvDTThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXemBaoCao);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBaoCaoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tháng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoanhThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXemBaoCao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoThang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDTThang;
        private dsDoanhThuThang dsDoanhThuThang;
        private System.Windows.Forms.Button btnReport;
    }
}