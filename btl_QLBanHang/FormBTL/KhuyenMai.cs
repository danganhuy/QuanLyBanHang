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

namespace btl_QLBanHang
{
    public partial class KhuyenMai : Form
    {
        ConnectData connectData = new ConnectData();
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKM.Text = dgvKhuyenMai.CurrentRow.Cells[0].Value.ToString();
            txtGiamgia.Text = dgvKhuyenMai.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dgvKhuyenMai.CurrentRow.Cells[2].Value.ToString();


        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadForm();
            dgvKhuyenMai.Columns[0].HeaderText = "Mã KM";
            dgvKhuyenMai.Columns[1].HeaderText = "Giảm giá";
            dgvKhuyenMai.Columns[2].HeaderText = "Ghi Chú";
        }
        public void LoadForm()
        {
            DataTable dataTable = connectData.ReadData("select * from tblKhuyenMai");
            dgvKhuyenMai.DataSource = dataTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DataTable dataTable = connectData.ReadData("Select * from tblKhuyenMai where MaKM='" + txtMaKM.Text + "'");
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Da ton tai ma nay");
            }
            else
            {
                string sqlInsert = "insert into tblKhuyenMai values('" + txtMaKM.Text + "','" + float.Parse(txtGiamgia.Text) + "',N'" + txtGhiChu.Text + "')";
                connectData.ChangeData(sqlInsert);
                LoadForm();
                MessageBox.Show("Them moi thanh conggggggg");

            }

        }
    }
}
