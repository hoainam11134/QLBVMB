using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace Plane_Ticket
{
    public partial class frmBaoCaoThang : Form
    {
        DTO_DoanhThuThang dtoDTThang;
        BUS_DoanhThuThang busDTThang;


        public frmBaoCaoThang()
        {
            InitializeComponent();
            busDTThang = new BUS_DoanhThuThang();
            KhoiTaoGiaoDienDTThang();
        }
       
        private void TaoBangDTThang()
        {
            DataTable dtDTThang = busDTThang.GetToDisplay();
            dtgvDTThang.DataSource = dtDTThang;
            dtgvDTThang.Sort(dtgvDTThang.Columns[0], ListSortDirection.Descending);
            dtgvDTThang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDTThang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void KhoiTaoGiaoDienDTThang()
        {
            BUS_DoanhThuThang busDTThang = new BUS_DoanhThuThang();
            DataTable dtDTThang = new DataTable();
            dtDTThang = busDTThang.Get();      
            TaoBangDTThang();
        }
        
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            KhoiTaoGiaoDienDTThang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
