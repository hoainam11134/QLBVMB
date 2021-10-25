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
    public partial class frmBaoCaoNam : Form
    {
       
        DTO_DoanhThuNam dtoDTNam;
        BUS_DoanhThuNam busDTNam;


        public frmBaoCaoNam()
        {
            InitializeComponent();
            busDTNam = new BUS_DoanhThuNam();
            KhoiTaoGiaoDienDTTNam();
        }

        private void TaoBangDTTNam()
        {
            DataTable dtDTNam = busDTNam.Get();
            dtgvDTNam.DataSource = dtDTNam;
            dtgvDTNam.Sort(dtgvDTNam.Columns[0], ListSortDirection.Descending);
            dtgvDTNam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDTNam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void KhoiTaoGiaoDienDTTNam()
        {
            BUS_DoanhThuNam busDTTNam = new BUS_DoanhThuNam();
            DataTable dtDTTNam = new DataTable();
            dtDTTNam = busDTTNam.Get();
            TaoBangDTTNam();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaoDienDTTNam();
        }

       
    }
}
