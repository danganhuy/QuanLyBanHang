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
    public partial class HDX : Form
    {
        public HDX()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietHDB ctHDB = new ChiTietHDB();
            ctHDB.ShowDialog();
        }
    }
}
