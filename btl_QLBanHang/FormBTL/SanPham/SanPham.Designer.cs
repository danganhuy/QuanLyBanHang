namespace btl_QLBanHang
{
    partial class SanPham
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
            this.cb_ChatLieu = new System.Windows.Forms.ComboBox();
            this.bt_Anh = new System.Windows.Forms.Button();
            this.rb__XL = new System.Windows.Forms.RadioButton();
            this.rb_L = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.rb_S = new System.Windows.Forms.RadioButton();
            this.tb_SLuong = new System.Windows.Forms.TextBox();
            this.tb_DGB = new System.Windows.Forms.TextBox();
            this.tb_DGN = new System.Windows.Forms.TextBox();
            this.tb_MaSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.tb_TenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_ThongTinSP = new System.Windows.Forms.GroupBox();
            this.cb_KM = new System.Windows.Forms.ComboBox();
            this.panel_Size = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.bt_Moi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.tb_MoTa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picSanpham = new System.Windows.Forms.PictureBox();
            this.error_ThongTin = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_excel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.gb_ThongTinSP.SuspendLayout();
            this.panel_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ChatLieu
            // 
            this.cb_ChatLieu.FormattingEnabled = true;
            this.cb_ChatLieu.Location = new System.Drawing.Point(97, 120);
            this.cb_ChatLieu.Name = "cb_ChatLieu";
            this.cb_ChatLieu.Size = new System.Drawing.Size(139, 24);
            this.cb_ChatLieu.TabIndex = 23;
            // 
            // bt_Anh
            // 
            this.bt_Anh.Location = new System.Drawing.Point(771, 191);
            this.bt_Anh.Name = "bt_Anh";
            this.bt_Anh.Size = new System.Drawing.Size(103, 34);
            this.bt_Anh.TabIndex = 22;
            this.bt_Anh.Text = "Chọn ảnh";
            this.bt_Anh.UseVisualStyleBackColor = true;
            this.bt_Anh.Click += new System.EventHandler(this.bt_Anh_Click);
            // 
            // rb__XL
            // 
            this.rb__XL.AutoSize = true;
            this.rb__XL.Location = new System.Drawing.Point(132, 3);
            this.rb__XL.Name = "rb__XL";
            this.rb__XL.Size = new System.Drawing.Size(43, 20);
            this.rb__XL.TabIndex = 21;
            this.rb__XL.TabStop = true;
            this.rb__XL.Text = "XL";
            this.rb__XL.UseVisualStyleBackColor = true;
            // 
            // rb_L
            // 
            this.rb_L.AutoSize = true;
            this.rb_L.Location = new System.Drawing.Point(92, 3);
            this.rb_L.Name = "rb_L";
            this.rb_L.Size = new System.Drawing.Size(35, 20);
            this.rb_L.TabIndex = 20;
            this.rb_L.TabStop = true;
            this.rb_L.Text = "L";
            this.rb_L.UseVisualStyleBackColor = true;
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(52, 3);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(39, 20);
            this.rb_M.TabIndex = 19;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "M";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // rb_S
            // 
            this.rb_S.AutoSize = true;
            this.rb_S.Location = new System.Drawing.Point(12, 3);
            this.rb_S.Name = "rb_S";
            this.rb_S.Size = new System.Drawing.Size(37, 20);
            this.rb_S.TabIndex = 17;
            this.rb_S.TabStop = true;
            this.rb_S.Text = "S";
            this.rb_S.UseVisualStyleBackColor = true;
            // 
            // tb_SLuong
            // 
            this.tb_SLuong.Location = new System.Drawing.Point(349, 30);
            this.tb_SLuong.Name = "tb_SLuong";
            this.tb_SLuong.Size = new System.Drawing.Size(70, 22);
            this.tb_SLuong.TabIndex = 15;
            // 
            // tb_DGB
            // 
            this.tb_DGB.Location = new System.Drawing.Point(360, 90);
            this.tb_DGB.Name = "tb_DGB";
            this.tb_DGB.Size = new System.Drawing.Size(120, 22);
            this.tb_DGB.TabIndex = 14;
            // 
            // tb_DGN
            // 
            this.tb_DGN.Location = new System.Drawing.Point(125, 90);
            this.tb_DGN.Name = "tb_DGN";
            this.tb_DGN.Size = new System.Drawing.Size(120, 22);
            this.tb_DGN.TabIndex = 13;
            // 
            // tb_MaSP
            // 
            this.tb_MaSP.Location = new System.Drawing.Point(125, 30);
            this.tb_MaSP.Name = "tb_MaSP";
            this.tb_MaSP.Size = new System.Drawing.Size(120, 22);
            this.tb_MaSP.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Chất liệu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSanpham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 286);
            this.panel1.TabIndex = 9;
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanpham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1182, 286);
            this.dgvSanpham.TabIndex = 1;
            this.dgvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellClick);
            // 
            // tb_TenSP
            // 
            this.tb_TenSP.Location = new System.Drawing.Point(135, 60);
            this.tb_TenSP.Name = "tb_TenSP";
            this.tb_TenSP.Size = new System.Drawing.Size(565, 22);
            this.tb_TenSP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kích cỡ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // gb_ThongTinSP
            // 
            this.gb_ThongTinSP.Controls.Add(this.bt_excel);
            this.gb_ThongTinSP.Controls.Add(this.cb_KM);
            this.gb_ThongTinSP.Controls.Add(this.panel_Size);
            this.gb_ThongTinSP.Controls.Add(this.label11);
            this.gb_ThongTinSP.Controls.Add(this.label3);
            this.gb_ThongTinSP.Controls.Add(this.cb_NCC);
            this.gb_ThongTinSP.Controls.Add(this.bt_Moi);
            this.gb_ThongTinSP.Controls.Add(this.label10);
            this.gb_ThongTinSP.Controls.Add(this.bt_Xoa);
            this.gb_ThongTinSP.Controls.Add(this.bt_Sua);
            this.gb_ThongTinSP.Controls.Add(this.bt_TimKiem);
            this.gb_ThongTinSP.Controls.Add(this.bt_Them);
            this.gb_ThongTinSP.Controls.Add(this.bt_Huy);
            this.gb_ThongTinSP.Controls.Add(this.tb_MoTa);
            this.gb_ThongTinSP.Controls.Add(this.label8);
            this.gb_ThongTinSP.Controls.Add(this.bt_Anh);
            this.gb_ThongTinSP.Controls.Add(this.cb_ChatLieu);
            this.gb_ThongTinSP.Controls.Add(this.picSanpham);
            this.gb_ThongTinSP.Controls.Add(this.tb_SLuong);
            this.gb_ThongTinSP.Controls.Add(this.tb_DGB);
            this.gb_ThongTinSP.Controls.Add(this.tb_DGN);
            this.gb_ThongTinSP.Controls.Add(this.tb_TenSP);
            this.gb_ThongTinSP.Controls.Add(this.tb_MaSP);
            this.gb_ThongTinSP.Controls.Add(this.label9);
            this.gb_ThongTinSP.Controls.Add(this.label7);
            this.gb_ThongTinSP.Controls.Add(this.label6);
            this.gb_ThongTinSP.Controls.Add(this.label5);
            this.gb_ThongTinSP.Controls.Add(this.label4);
            this.gb_ThongTinSP.Controls.Add(this.label2);
            this.gb_ThongTinSP.Controls.Add(this.label1);
            this.gb_ThongTinSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_ThongTinSP.Location = new System.Drawing.Point(0, 0);
            this.gb_ThongTinSP.Name = "gb_ThongTinSP";
            this.gb_ThongTinSP.Size = new System.Drawing.Size(1182, 267);
            this.gb_ThongTinSP.TabIndex = 8;
            this.gb_ThongTinSP.TabStop = false;
            this.gb_ThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // cb_KM
            // 
            this.cb_KM.FormattingEnabled = true;
            this.cb_KM.Location = new System.Drawing.Point(585, 90);
            this.cb_KM.Name = "cb_KM";
            this.cb_KM.Size = new System.Drawing.Size(58, 24);
            this.cb_KM.TabIndex = 39;
            // 
            // panel_Size
            // 
            this.panel_Size.Controls.Add(this.rb_L);
            this.panel_Size.Controls.Add(this.rb_M);
            this.panel_Size.Controls.Add(this.rb__XL);
            this.panel_Size.Controls.Add(this.rb_S);
            this.panel_Size.Location = new System.Drawing.Point(321, 118);
            this.panel_Size.Name = "panel_Size";
            this.panel_Size.Size = new System.Drawing.Size(191, 26);
            this.panel_Size.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(641, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Khuyến mãi:";
            // 
            // cb_NCC
            // 
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Location = new System.Drawing.Point(550, 30);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(150, 24);
            this.cb_NCC.TabIndex = 34;
            // 
            // bt_Moi
            // 
            this.bt_Moi.Location = new System.Drawing.Point(516, 233);
            this.bt_Moi.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Moi.Name = "bt_Moi";
            this.bt_Moi.Size = new System.Drawing.Size(80, 32);
            this.bt_Moi.TabIndex = 33;
            this.bt_Moi.Text = "Làm mới";
            this.bt_Moi.UseVisualStyleBackColor = true;
            this.bt_Moi.Click += new System.EventHandler(this.bt_Moi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nhà cung cấp:";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(417, 233);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(80, 32);
            this.bt_Xoa.TabIndex = 30;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(321, 233);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(80, 32);
            this.bt_Sua.TabIndex = 29;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Location = new System.Drawing.Point(225, 233);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(80, 32);
            this.bt_TimKiem.TabIndex = 28;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(129, 233);
            this.bt_Them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(80, 32);
            this.bt_Them.TabIndex = 27;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(33, 233);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(80, 32);
            this.bt_Huy.TabIndex = 26;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(33, 171);
            this.tb_MoTa.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MoTa.Multiline = true;
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(667, 58);
            this.tb_MoTa.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mô tả sản phẩm:";
            // 
            // picSanpham
            // 
            this.picSanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picSanpham.Location = new System.Drawing.Point(737, 21);
            this.picSanpham.Name = "picSanpham";
            this.picSanpham.Size = new System.Drawing.Size(167, 164);
            this.picSanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSanpham.TabIndex = 0;
            this.picSanpham.TabStop = false;
            // 
            // error_ThongTin
            // 
            this.error_ThongTin.ContainerControl = this;
            // 
            // bt_excel
            // 
            this.bt_excel.Location = new System.Drawing.Point(620, 233);
            this.bt_excel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(80, 32);
            this.bt_excel.TabIndex = 40;
            this.bt_excel.Text = "In ra excel";
            this.bt_excel.UseVisualStyleBackColor = true;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_ThongTinSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "SanPham";
            this.Text = "Sản phẩm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.gb_ThongTinSP.ResumeLayout(false);
            this.gb_ThongTinSP.PerformLayout();
            this.panel_Size.ResumeLayout(false);
            this.panel_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_ChatLieu;
        private System.Windows.Forms.Button bt_Anh;
        private System.Windows.Forms.RadioButton rb__XL;
        private System.Windows.Forms.RadioButton rb_L;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.RadioButton rb_S;
        private System.Windows.Forms.TextBox tb_SLuong;
        private System.Windows.Forms.TextBox tb_DGB;
        private System.Windows.Forms.TextBox tb_DGN;
        private System.Windows.Forms.TextBox tb_MaSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_TenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSanpham;
        private System.Windows.Forms.GroupBox gb_ThongTinSP;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox tb_MoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider error_ThongTin;
        private System.Windows.Forms.Button bt_Moi;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_Size;
        private System.Windows.Forms.ComboBox cb_KM;
        private System.Windows.Forms.Button bt_excel;
    }
}