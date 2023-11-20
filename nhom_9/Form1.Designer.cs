namespace nhom_9
{
    partial class frm_dat_lich
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btn_tao_moi = new Button();
            splitContainer2 = new SplitContainer();
            button2 = new Button();
            button1 = new Button();
            dtp_thoigian = new DateTimePicker();
            label2 = new Label();
            rad_hoanthanh = new RadioButton();
            btn_luu_lich = new Button();
            label4 = new Label();
            txt_noidung = new TextBox();
            label1 = new Label();
            txt_tieude = new TextBox();
            btn_timkiem = new Button();
            label3 = new Label();
            txt_timkiem = new TextBox();
            dgv_danhsach = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Cyan;
            splitContainer1.Panel1.Controls.Add(btn_tao_moi);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(828, 526);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.TabIndex = 0;
            // 
            // btn_tao_moi
            // 
            btn_tao_moi.Location = new Point(12, 18);
            btn_tao_moi.Name = "btn_tao_moi";
            btn_tao_moi.Size = new Size(94, 29);
            btn_tao_moi.TabIndex = 0;
            btn_tao_moi.Text = "Tạo mới";
            btn_tao_moi.UseVisualStyleBackColor = true;
            btn_tao_moi.Click += btn_tao_moi_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(255, 255, 128);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(button1);
            splitContainer2.Panel1.Controls.Add(dtp_thoigian);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(rad_hoanthanh);
            splitContainer2.Panel1.Controls.Add(btn_luu_lich);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(txt_noidung);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(txt_tieude);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(192, 255, 192);
            splitContainer2.Panel2.Controls.Add(btn_timkiem);
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Panel2.Controls.Add(txt_timkiem);
            splitContainer2.Panel2.Controls.Add(dgv_danhsach);
            splitContainer2.Size = new Size(612, 526);
            splitContainer2.SplitterDistance = 257;
            splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(499, 161);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_sua_Click; 
            // 
            // button1
            // 
            button1.Location = new Point(499, 102);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_xoa_Click;
            // 
            // dtp_thoigian
            // 
            dtp_thoigian.CustomFormat = "HH:mm  dd/MM/yyyy";
            dtp_thoigian.Format = DateTimePickerFormat.Custom;
            dtp_thoigian.Location = new Point(87, 219);
            dtp_thoigian.Name = "dtp_thoigian";
            dtp_thoigian.Size = new Size(397, 27);
            dtp_thoigian.TabIndex = 10;
            dtp_thoigian.Value = new DateTime(2023, 11, 12, 20, 13, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 219);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 9;
            label2.Text = "Thời gian:";
            // 
            // rad_hoanthanh
            // 
            rad_hoanthanh.AutoSize = true;
            rad_hoanthanh.Location = new Point(499, 14);
            rad_hoanthanh.Name = "rad_hoanthanh";
            rad_hoanthanh.Size = new Size(107, 24);
            rad_hoanthanh.TabIndex = 7;
            rad_hoanthanh.TabStop = true;
            rad_hoanthanh.Text = "Hoàn thành";
            rad_hoanthanh.UseVisualStyleBackColor = true;
            // 
            // btn_luu_lich
            // 
            btn_luu_lich.Location = new Point(499, 220);
            btn_luu_lich.Name = "btn_luu_lich";
            btn_luu_lich.Size = new Size(94, 29);
            btn_luu_lich.TabIndex = 6;
            btn_luu_lich.Text = "Lưu lịch";
            btn_luu_lich.UseVisualStyleBackColor = true;
            btn_luu_lich.Click += btn_luu_lich_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Nội dung :";
            // 
            // txt_noidung
            // 
            txt_noidung.Location = new Point(87, 55);
            txt_noidung.Multiline = true;
            txt_noidung.Name = "txt_noidung";
            txt_noidung.Size = new Size(397, 135);
            txt_noidung.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Tiêu đề :";
            // 
            // txt_tieude
            // 
            txt_tieude.Location = new Point(87, 11);
            txt_tieude.Name = "txt_tieude";
            txt_tieude.Size = new Size(397, 27);
            txt_tieude.TabIndex = 0;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(499, 18);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 3;
            btn_timkiem.Text = "SREACH";
            btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(87, 18);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(397, 27);
            txt_timkiem.TabIndex = 1;
            // 
            // dgv_danhsach
            // 
            dgv_danhsach.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv_danhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhsach.GridColor = SystemColors.ActiveBorder;
            dgv_danhsach.Location = new Point(12, 51);
            dgv_danhsach.Name = "dgv_danhsach";
            dgv_danhsach.RowHeadersWidth = 51;
            dgv_danhsach.Size = new Size(575, 171);
            dgv_danhsach.TabIndex = 0;
            dgv_danhsach.CellContentClick += dgv_danhsach_CellContentClick;
            // 
            // frm_dat_lich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(828, 526);
            Controls.Add(splitContainer1);
            Name = "frm_dat_lich";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt lịch";
            Load += frm_dat_lich_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_danhsach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox txt_noidung;
        private Label label1;
        private Button btn_luu_lich;
        private Label label4;
        private TextBox txt_tieude;
        private DataGridView dgv_danhsach;
        private Label label2;
        private RadioButton rad_hoanthanh;
        private Button btn_tao_moi;
        private Button btn_timkiem;
        private Label label3;
        private TextBox txt_timkiem;
        private DateTimePicker dtp_thoigian;
        private Button button2;
        private Button button1;
    }
}