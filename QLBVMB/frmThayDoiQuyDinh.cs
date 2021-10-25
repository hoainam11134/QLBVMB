using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Ticket
{
    public partial class frmThayDoiQuyDinh : Form
    {
        #region Properties
        DTO_ThamSo dtoThamSo;
        BUS_ThamSo busThamSo;
        bool flagCellClick;
        #endregion

        #region Initializes
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
            busThamSo = new BUS_ThamSo();
            flagCellClick = false;
        }
        #endregion

        #region Methods

        private void TaoLai()
        {
            DataTable dtThamSo = busThamSo.Get();
            if (dtThamSo.Rows.Count != 0)
            {
                DataRow row = dtThamSo.Rows[0];
                txtTGBayMin.Text = row[0].ToString();
                txtSoSanBayTGMax.Text = row[1].ToString();
                txtTGDungMin.Text = row[2].ToString();
                txtTGDungMax.Text = row[3].ToString();
                txtTGMinDatVe.Text = row[4].ToString();
                txtTGMinHuyVe.Text = row[5].ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoSanBayTGMax.Text.Trim()!="" && txtTGBayMin.Text.Trim() != "" && txtTGDungMax.Text.Trim() != "" && txtTGDungMin.Text.Trim() != "" && txtTGMinDatVe.Text.Trim() != "" && txtTGMinHuyVe.Text.Trim() != "")
            {
                try
                {
                    dtoThamSo = new DTO_ThamSo(Convert.ToInt32(txtTGBayMin.Text), Convert.ToInt32(txtSoSanBayTGMax.Text), Convert.ToInt32(txtTGDungMin.Text), Convert.ToInt32(txtTGDungMax.Text), Convert.ToInt32(txtTGMinDatVe.Text), Convert.ToInt32(txtTGMinHuyVe.Text));
                    if (busThamSo.Update(dtoThamSo))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLai();
                    flagCellClick = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void KhoiTaoGiaoDien()
        {
            DataTable dtThamSo = busThamSo.Get();
            if (dtThamSo.Rows.Count != 0)
            {
                DataRow row = dtThamSo.Rows[0];
                txtTGBayMin.Text= row[0].ToString();
                txtSoSanBayTGMax.Text = row[1].ToString();
                txtTGDungMin.Text = row[2].ToString();
                txtTGDungMax.Text = row[3].ToString();
                txtTGMinDatVe.Text = row[4].ToString();
                txtTGMinHuyVe.Text = row[5].ToString();
            }
            AcceptButton = btnSua;
            CancelButton = btnThoat;
        }
        #endregion

        private void frmThayDoiQuyDinh_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }

        private void txtTGBayMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoSanBayTGMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTGDungMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTGDungMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTGMinDatVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTGMinHuyVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
