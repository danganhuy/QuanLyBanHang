using btl_QLBanHang.FormBTL;
using QLBH.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_QLBanHang
{
    public partial class NhanVien : Form
    {
        ConnectData datb = new ConnectData();
        CommonFunction function = new CommonFunction();
        string fileAnh = "";
        public NhanVien(string userName)
        {
            InitializeComponent();
            DataTable dtNhanVien = datb.ReadData("Select * from tblNhanVien");
            function.FillCombobox(cmbSapxep, dtNhanVien, "MaNV", "TenNV");
            // txtUsername.Text = userName;
        }
        public NhanVien()
        {
            InitializeComponent();
        }
        //đổi mk
        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword();
            form.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = datb.ReadData("select chucvu from tblChiTietNV inner join tblUser on tblChiTietNV.MaNV=tblUser.MaNV where Username=N'" + staticdata.userName + "'");
            if (dataTable.Rows[0].ItemArray[0].ToString() != "QL")
            {
                MessageBox.Show("Ban khong co quyen xoa nhan vien");
            }
            else
            {
                DataTable dtCheck = datb.ReadData("Select * from tblNV where MaNV ='" + txtMaNV.Text + "'");
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã có, mời bạn nhập mã khác");
                    txtMaNV.Focus();
                    return;
                }

                // them moi hang vao database
                string sqlInsert = "Insert into tblNV values('N" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtDiaChi.Text
                   + "',N'" + txtPhone.Text + "','" + fileAnh + "',N'" + txtGioitinh.Text + "','" + dtpNgaysinh.Value.ToShortDateString() + "')";
                try
                {
                    datb.ChangeData(sqlInsert);
                    LoadData();
                    MessageBox.Show("Thêm mới thành công!");
                    ResetValue();
                }
                catch
                {

                    MessageBox.Show("lỗi");
                }
            }

        }
        void LoadData()
        {
            DataTable dtNhanvien = datb.ReadData("Select * from tblNV");
            dgvNhanVien.DataSource = dtNhanvien;


        }
        void ResetValue()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dtpNgaysinh.Value = DateTime.Today;
            txtPhone.Text = "";
            txtDiaChi.Text = "";
            txtGioitinh.Text = "";
            txtMaNV.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();

            dgvNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvNhanVien.Columns[1].HeaderText = "Họ tên";
            dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[4].HeaderText = "Ảnh";
            dgvNhanVien.Columns[5].HeaderText = "Giới tính";
            dgvNhanVien.Columns[6].HeaderText = "Ngày sinh";

            ResetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dataTable = datb.ReadData("select chucvu from tblChiTietNV inner join tblUser on tblChiTietNV.MaNV=tblUser.MaNV where Username=N'" + staticdata.userName + "'");
            if (dataTable.Rows[0].ItemArray[0].ToString() != "QL")
            {
                MessageBox.Show("Ban khong co quyen sua nhan vien");
            }
            else
            {
                datb.ChangeData("update tblNV set TenNV=N'" + txtHoTen.Text +
                            "',DiaChi= N'" + txtDiaChi.Text
                            + "',SoDienThoai='" + txtPhone.Text
                            + "',GioiTinh=N'" + txtGioitinh.Text
                            + "',NgaySinh='" + dtpNgaysinh.Value.ToShortDateString()
                            + "',Anh='" + fileAnh
                            + "'where MaNV='" + txtMaNV.Text + "'");
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phần tử để xóa");
                return;
            }
            DataTable dataTable = datb.ReadData("select chucvu from tblChiTietNV inner join tblUser on tblChiTietNV.MaNV=tblUser.MaNV where Username=N'" + staticdata.userName + "'");
            if (dataTable.Rows[0].ItemArray[0].ToString() != "QL")
            {
                MessageBox.Show("Ban khong co quyen xoa nhan vien");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá nhân viên này không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        datb.ChangeData("Delete tblNV where MaNV='" + txtMaNV.Text + "'");
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                        ResetValue();
                    }
                    catch
                    {
                        //   MessageBox.Show("Bạn không thể xoá vì chúng liên quan đến các bảng khác");
                    }
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dataTable = datb.ReadData("select chucvu from tblChiTietNV inner join tblUser on tblChiTietNV.MaNV=tblUser.MaNV where Username=N'" + staticdata.userName + "'");
            if (dataTable.Rows[0].ItemArray[0].ToString() != "QL")
            {
                MessageBox.Show("Ban khong co quyen xem muc nay");
            }
            else
            {
                ChiTietNV chiTietNV = new ChiTietNV();
                chiTietNV.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = datb.ReadData("Select * from tblNV where MaNV= N'" + txtTimKiem.Text + "'");
            DataTable dataTable1 = datb.ReadData("Select TenNV,DiaChi,SoDienThoai,Anh,GioiTinh,NgaySinh from tblNV where MaNV=N'" + txtTimKiem.Text + "'");

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Khong co nv can tim");

            }
            else
            {
                dgvNhanVien.DataSource = dataTable;
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                fileAnh = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                try
                {
                    picNV.Image = Image.FromFile(Application.StartupPath + "\\Images\\Products\\" + fileAnh);

                }
                catch
                {
                    picNV.Image = null;

                }
                txtGioitinh.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                dtpNgaysinh.Value = (DateTime)dgvNhanVien.CurrentRow.Cells[6].Value;
            }

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                fileAnh = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                try
                {
                    picNV.Image = Image.FromFile(Application.StartupPath + "\\Images\\Products\\" + fileAnh);

                }
                catch
                {
                    picNV.Image = null;

                }
                txtGioitinh.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                dtpNgaysinh.Value = (DateTime)dgvNhanVien.CurrentRow.Cells[6].Value;
            }
            catch
            {
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTimKiem.Text = "";
            ResetValue();
        }
    }
}
