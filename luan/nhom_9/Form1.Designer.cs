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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_tao_moi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoiGianThongBao = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SoLanThongBao = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_thoigian = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_hoanthanh = new System.Windows.Forms.RadioButton();
            this.btn_luu_lich = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tieude = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgv_danhsach = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Cyan;
            this.splitContainer1.Panel1.Controls.Add(this.btn_tao_moi);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1035, 658);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_tao_moi
            // 
            this.btn_tao_moi.Location = new System.Drawing.Point(69, 22);
            this.btn_tao_moi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tao_moi.Name = "btn_tao_moi";
            this.btn_tao_moi.Size = new System.Drawing.Size(118, 36);
            this.btn_tao_moi.TabIndex = 0;
            this.btn_tao_moi.Text = "Tạo mới";
            this.btn_tao_moi.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngBáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(69, 78);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.thôngBáoToolStripMenuItem.Text = "Thông báo ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThoiGianThongBao});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(276, 34);
            this.toolStripMenuItem1.Text = "Thông báo thời gian";
            // 
            // ThoiGianThongBao
            // 
            this.ThoiGianThongBao.Name = "ThoiGianThongBao";
            this.ThoiGianThongBao.Size = new System.Drawing.Size(121, 33);
            this.ThoiGianThongBao.DropDown += new System.EventHandler(this.ThoiGianThongBao_DropDown);
            this.ThoiGianThongBao.SelectedIndexChanged += new System.EventHandler(this.ThoiGianThongBao_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SoLanThongBao});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(276, 34);
            this.toolStripMenuItem2.Text = "Số lần thông báo";
            // 
            // SoLanThongBao
            // 
            this.SoLanThongBao.Name = "SoLanThongBao";
            this.SoLanThongBao.Size = new System.Drawing.Size(121, 33);
            this.SoLanThongBao.DropDown += new System.EventHandler(this.SoLanThongBao_DropDown);
            this.SoLanThongBao.SelectedIndexChanged += new System.EventHandler(this.SoLanThongBao_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.dtp_thoigian);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.rad_hoanthanh);
            this.splitContainer2.Panel1.Controls.Add(this.btn_luu_lich);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txt_noidung);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_tieude);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.Controls.Add(this.btn_timkiem);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.txt_timkiem);
            this.splitContainer2.Panel2.Controls.Add(this.dgv_danhsach);
            this.splitContainer2.Size = new System.Drawing.Size(765, 658);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtp_thoigian
            // 
            this.dtp_thoigian.CustomFormat = "HH:mm  dd/MM/yyyy";
            this.dtp_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thoigian.Location = new System.Drawing.Point(109, 274);
            this.dtp_thoigian.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_thoigian.Name = "dtp_thoigian";
            this.dtp_thoigian.Size = new System.Drawing.Size(495, 31);
            this.dtp_thoigian.TabIndex = 10;
            this.dtp_thoigian.Value = new System.DateTime(2023, 11, 12, 20, 13, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thời gian:";
            // 
            // rad_hoanthanh
            // 
            this.rad_hoanthanh.AutoSize = true;
            this.rad_hoanthanh.Location = new System.Drawing.Point(624, 18);
            this.rad_hoanthanh.Margin = new System.Windows.Forms.Padding(4);
            this.rad_hoanthanh.Name = "rad_hoanthanh";
            this.rad_hoanthanh.Size = new System.Drawing.Size(130, 29);
            this.rad_hoanthanh.TabIndex = 7;
            this.rad_hoanthanh.TabStop = true;
            this.rad_hoanthanh.Text = "Hoàn thành";
            this.rad_hoanthanh.UseVisualStyleBackColor = true;
            // 
            // btn_luu_lich
            // 
            this.btn_luu_lich.Location = new System.Drawing.Point(624, 275);
            this.btn_luu_lich.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu_lich.Name = "btn_luu_lich";
            this.btn_luu_lich.Size = new System.Drawing.Size(118, 36);
            this.btn_luu_lich.TabIndex = 6;
            this.btn_luu_lich.Text = "Lưu lịch";
            this.btn_luu_lich.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung :";
            // 
            // txt_noidung
            // 
            this.txt_noidung.Location = new System.Drawing.Point(109, 69);
            this.txt_noidung.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(495, 168);
            this.txt_noidung.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề :";
            // 
            // txt_tieude
            // 
            this.txt_tieude.Location = new System.Drawing.Point(109, 14);
            this.txt_tieude.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tieude.Name = "txt_tieude";
            this.txt_tieude.Size = new System.Drawing.Size(495, 31);
            this.txt_tieude.TabIndex = 0;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(624, 22);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(118, 36);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "SREACH";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(109, 22);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(495, 31);
            this.txt_timkiem.TabIndex = 1;
            // 
            // dgv_danhsach
            // 
            this.dgv_danhsach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsach.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_danhsach.Location = new System.Drawing.Point(15, 64);
            this.dgv_danhsach.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_danhsach.Name = "dgv_danhsach";
            this.dgv_danhsach.RowHeadersWidth = 51;
            this.dgv_danhsach.Size = new System.Drawing.Size(719, 214);
            this.dgv_danhsach.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frm_dat_lich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 658);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_dat_lich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lịch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsach)).EndInit();
            this.ResumeLayout(false);

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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngBáoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripComboBox ThoiGianThongBao;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripComboBox SoLanThongBao;
        private System.Windows.Forms.Timer timer2;
    }
}