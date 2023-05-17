using QLBH.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_QLBanHang.FormBTL
{
    public partial class ChiTietNV : Form
    {
        ConnectData connectData = new ConnectData();
        public ChiTietNV()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            DataTable dataTable = connectData.ReadData("Select * from tblChiTietNV");
            dgvChiTietNV.DataSource = dataTable;
        }

        private void ChiTietNV_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvChiTietNV.Columns[0].HeaderText = "MaNV";
            dgvChiTietNV.Columns[1].HeaderText = "Chức vụ";
            dgvChiTietNV.Columns[2].HeaderText = "Lương cơ bản";
            dgvChiTietNV.Columns[3].HeaderText = "Hệ số";
            dgvChiTietNV.Columns[4].HeaderText = "Thưởng";
        }
        void Resetform()
        {
            txtMaNV.Text = "";
            txtChucvu.Text = "";
            txtLCB.Text = "";
            txtHSL.Text = "";
            txtThuong.Text = "";

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            connectData.ChangeData("update tblChiTietNV  set ChucVu=N'" + txtChucvu.Text +
                           "',LuongCB= N'" + txtLCB.Text
                           + "',HeSo='" + (txtHSL.Text)
                           + "',Thuong=N'" + (txtThuong.Text)

                           + "' from tblChiTietNV inner join tblNV on tblChiTietNV.MaNV=tblNV.MaNV where tblChiTietNV.MaNV='" + txtMaNV.Text + "'");
            MessageBox.Show("Sửa thành công");
            Resetform();
            LoadData();
        }

        private void dgvChiTietNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvChiTietNV.CurrentRow.Cells[0].Value.ToString();
            txtChucvu.Text = dgvChiTietNV.CurrentRow.Cells[1].Value.ToString();
            txtLCB.Text = dgvChiTietNV.CurrentRow.Cells[2].Value.ToString();
            txtHSL.Text = dgvChiTietNV.CurrentRow.Cells[3].Value.ToString();
            txtThuong.Text = dgvChiTietNV.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
