namespace Plane_Ticket
{
    partial class frmTinhTrangVe
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
            this.dtgvTinhTrangVe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTinhTrangVe
            // 
            this.dtgvTinhTrangVe.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTinhTrangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTinhTrangVe.Location = new System.Drawing.Point(12, 108);
            this.dtgvTinhTrangVe.Name = "dtgvTinhTrangVe";
            this.dtgvTinhTrangVe.RowTemplate.Height = 24;
            this.dtgvTinhTrangVe.Size = new System.Drawing.Size(520, 330);
            this.dtgvTinhTrangVe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chuyến bay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 32);
            this.label8.TabIndex = 40;
            this.label8.Text = "TÌNH TRẠNG VÉ";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(148, 64);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(150, 24);
            this.cboMaChuyenBay.TabIndex = 1;
            this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            // 
            // frmTinhTrangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.cboMaChuyenBay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvTinhTrangVe);
            this.Name = "frmTinhTrangVe";
            this.Text = "frmTinhTrangVe";
            this.Shown += new System.EventHandler(this.frmTinhTrangVe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTinhTrangVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
    }
}