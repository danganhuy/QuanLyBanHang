namespace btl_QLBanHang.FormBTL.SanPham
{
    partial class TimKiemSP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.tb_MaSP = new System.Windows.Forms.TextBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.tb_TenSP = new System.Windows.Forms.TextBox();
            this.tb_KM_Min = new System.Windows.Forms.TextBox();
            this.tb_SL_Min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SL_Max = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_KM_Max = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_DGN_Max = new System.Windows.Forms.TextBox();
            this.tb_DGN_Min = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_DGB_Max = new System.Windows.Forms.TextBox();
            this.tb_DGB_Min = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_ChatLieu = new System.Windows.Forms.ComboBox();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.errTim = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errTim)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SP:";
            // 
            // bt_Huy
            // 
            this.bt_Huy.Location = new System.Drawing.Point(262, 189);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(120, 32);
            this.bt_Huy.TabIndex = 0;
            this.bt_Huy.Text = "Hủy Tìm Kiếm";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // tb_MaSP
            // 
            this.tb_MaSP.Location = new System.Drawing.Point(86, 27);
            this.tb_MaSP.Name = "tb_MaSP";
            this.tb_MaSP.Size = new System.Drawing.Size(100, 22);
            this.tb_MaSP.TabIndex = 3;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_TimKiem.Location = new System.Drawing.Point(156, 189);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(100, 32);
            this.bt_TimKiem.TabIndex = 1;
            this.bt_TimKiem.Text = "Tìm Kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // tb_TenSP
            // 
            this.tb_TenSP.Location = new System.Drawing.Point(281, 27);
            this.tb_TenSP.Name = "tb_TenSP";
            this.tb_TenSP.Size = new System.Drawing.Size(200, 22);
            this.tb_TenSP.TabIndex = 5;
            // 
            // tb_KM_Min
            // 
            this.tb_KM_Min.Location = new System.Drawing.Point(355, 57);
            this.tb_KM_Min.Name = "tb_KM_Min";
            this.tb_KM_Min.Size = new System.Drawing.Size(30, 22);
            this.tb_KM_Min.TabIndex = 9;
            this.tb_KM_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // tb_SL_Min
            // 
            this.tb_SL_Min.Location = new System.Drawing.Point(99, 57);
            this.tb_SL_Min.Name = "tb_SL_Min";
            this.tb_SL_Min.Size = new System.Drawing.Size(60, 22);
            this.tb_SL_Min.TabIndex = 7;
            this.tb_SL_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khuyến mãi:";
            // 
            // tb_SL_Max
            // 
            this.tb_SL_Max.Location = new System.Drawing.Point(181, 57);
            this.tb_SL_Max.Name = "tb_SL_Max";
            this.tb_SL_Max.Size = new System.Drawing.Size(60, 22);
            this.tb_SL_Max.TabIndex = 10;
            this.tb_SL_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(164, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // tb_KM_Max
            // 
            this.tb_KM_Max.Location = new System.Drawing.Point(408, 57);
            this.tb_KM_Max.Name = "tb_KM_Max";
            this.tb_KM_Max.Size = new System.Drawing.Size(30, 22);
            this.tb_KM_Max.TabIndex = 13;
            this.tb_KM_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(388, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(251, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "-";
            // 
            // tb_DGN_Max
            // 
            this.tb_DGN_Max.Location = new System.Drawing.Point(272, 87);
            this.tb_DGN_Max.Name = "tb_DGN_Max";
            this.tb_DGN_Max.Size = new System.Drawing.Size(120, 22);
            this.tb_DGN_Max.TabIndex = 21;
            this.tb_DGN_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // tb_DGN_Min
            // 
            this.tb_DGN_Min.Location = new System.Drawing.Point(125, 87);
            this.tb_DGN_Min.Name = "tb_DGN_Min";
            this.tb_DGN_Min.Size = new System.Drawing.Size(120, 22);
            this.tb_DGN_Min.TabIndex = 18;
            this.tb_DGN_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đơn giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(251, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "-";
            // 
            // tb_DGB_Max
            // 
            this.tb_DGB_Max.Location = new System.Drawing.Point(271, 117);
            this.tb_DGB_Max.Name = "tb_DGB_Max";
            this.tb_DGB_Max.Size = new System.Drawing.Size(120, 22);
            this.tb_DGB_Max.TabIndex = 25;
            this.tb_DGB_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // tb_DGB_Min
            // 
            this.tb_DGB_Min.Location = new System.Drawing.Point(125, 117);
            this.tb_DGB_Min.Name = "tb_DGB_Min";
            this.tb_DGB_Min.Size = new System.Drawing.Size(120, 22);
            this.tb_DGB_Min.TabIndex = 24;
            this.tb_DGB_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Đơn giá Bán:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Chất liệu:";
            // 
            // cb_ChatLieu
            // 
            this.cb_ChatLieu.FormattingEnabled = true;
            this.cb_ChatLieu.Location = new System.Drawing.Point(97, 147);
            this.cb_ChatLieu.Name = "cb_ChatLieu";
            this.cb_ChatLieu.Size = new System.Drawing.Size(125, 24);
            this.cb_ChatLieu.TabIndex = 28;
            // 
            // cb_NCC
            // 
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Location = new System.Drawing.Point(356, 147);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(125, 24);
            this.cb_NCC.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Nhà cung cấp:";
            // 
            // errTim
            // 
            this.errTim.ContainerControl = this;
            // 
            // TimKiemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(516, 241);
            this.Controls.Add(this.cb_NCC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_ChatLieu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_DGB_Max);
            this.Controls.Add(this.tb_DGB_Min);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_DGN_Max);
            this.Controls.Add(this.tb_DGN_Min);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_KM_Max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_SL_Max);
            this.Controls.Add(this.tb_KM_Min);
            this.Controls.Add(this.tb_SL_Min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_TenSP);
            this.Controls.Add(this.tb_MaSP);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Huy);
            this.Name = "TimKiemSP";
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.TimKiemSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.TextBox tb_MaSP;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox tb_TenSP;
        private System.Windows.Forms.TextBox tb_KM_Min;
        private System.Windows.Forms.TextBox tb_SL_Min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SL_Max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_KM_Max;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_DGN_Max;
        private System.Windows.Forms.TextBox tb_DGN_Min;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_DGB_Max;
        private System.Windows.Forms.TextBox tb_DGB_Min;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_ChatLieu;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errTim;
    }
}