using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLHS
{
    partial class Form_Update_ThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Update_ThongTin));
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.update_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.update_diem = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.cb_ma_lop = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.date_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma_hs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ten_hs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.update_thongtin,
            this.update_diem});
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Margin = new System.Windows.Forms.Padding(10);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(10);
            this.update.Size = new System.Drawing.Size(196, 50);
            this.update.Text = "Cập Nhật";
            // 
            // update_thongtin
            // 
            this.update_thongtin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update_thongtin.Name = "update_thongtin";
            this.update_thongtin.Padding = new System.Windows.Forms.Padding(10);
            this.update_thongtin.Size = new System.Drawing.Size(340, 50);
            this.update_thongtin.Text = "Thông Tin Học Sinh";
            // 
            // update_diem
            // 
            this.update_diem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update_diem.Name = "update_diem";
            this.update_diem.Padding = new System.Windows.Forms.Padding(10);
            this.update_diem.Size = new System.Drawing.Size(340, 50);
            this.update_diem.Text = "Điểm ";
            this.update_diem.Click += new System.EventHandler(this.update_diem_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.HighlightText;
            this.print.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.print.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.print.Image = ((System.Drawing.Image)(resources.GetObject("print.Image")));
            this.print.Margin = new System.Windows.Forms.Padding(10);
            this.print.Name = "print";
            this.print.Padding = new System.Windows.Forms.Padding(10);
            this.print.Size = new System.Drawing.Size(196, 50);
            this.print.Text = "In Bảng Điểm";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.HighlightText;
            this.logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Margin = new System.Windows.Forms.Padding(10, 300, 10, 10);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(10);
            this.logout.Size = new System.Drawing.Size(196, 50);
            this.logout.Text = "Thoát";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.update,
            this.print,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(225, 637);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(851, 279);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(237, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(869, 304);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cb_sex);
            this.groupBox2.Controls.Add(this.cb_ma_lop);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.date_ngay_sinh);
            this.groupBox2.Controls.Add(this.txt_tim);
            this.groupBox2.Controls.Add(this.txt_mat_khau);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ma_hs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_ten_hs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 315);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Location = new System.Drawing.Point(580, 131);
            this.cb_sex.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(226, 28);
            this.cb_sex.TabIndex = 23;
            this.cb_sex.Text = "Chọn giới tính";
            // 
            // cb_ma_lop
            // 
            this.cb_ma_lop.FormattingEnabled = true;
            this.cb_ma_lop.Location = new System.Drawing.Point(580, 171);
            this.cb_ma_lop.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ma_lop.Name = "cb_ma_lop";
            this.cb_ma_lop.Size = new System.Drawing.Size(230, 28);
            this.cb_ma_lop.TabIndex = 24;
            this.cb_ma_lop.Text = "Chọn Lớp";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(283, 257);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 34);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_them.Location = new System.Drawing.Point(44, 257);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(104, 34);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(164, 257);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 34);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // date_ngay_sinh
            // 
            this.date_ngay_sinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_ngay_sinh.Location = new System.Drawing.Point(156, 207);
            this.date_ngay_sinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_ngay_sinh.Name = "date_ngay_sinh";
            this.date_ngay_sinh.Size = new System.Drawing.Size(230, 28);
            this.date_ngay_sinh.TabIndex = 22;
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tim.Location = new System.Drawing.Point(663, 24);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(194, 28);
            this.txt_tim.TabIndex = 12;
            this.txt_tim.Click += new System.EventHandler(this.txt_tim_TextChanged);
            this.txt_tim.TextChanged += new System.EventHandler(this.txt_tim_TextChanged);
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_mat_khau.Location = new System.Drawing.Point(580, 217);
            this.txt_mat_khau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.Size = new System.Drawing.Size(230, 28);
            this.txt_mat_khau.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(472, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mật Khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(473, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(473, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(38, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày Sinh";
            // 
            // txt_ma_hs
            // 
            this.txt_ma_hs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ma_hs.Location = new System.Drawing.Point(156, 127);
            this.txt_ma_hs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma_hs.Name = "txt_ma_hs";
            this.txt_ma_hs.Size = new System.Drawing.Size(230, 28);
            this.txt_ma_hs.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã Học Sinh";
            // 
            // txt_ten_hs
            // 
            this.txt_ten_hs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ten_hs.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_ten_hs.Location = new System.Drawing.Point(156, 171);
            this.txt_ten_hs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten_hs.Name = "txt_ten_hs";
            this.txt_ten_hs.Size = new System.Drawing.Size(230, 28);
            this.txt_ten_hs.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(38, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(196, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cập Nhật Thông Tin Học Sinh";
            // 
            // Form_Update_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1118, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Update_ThongTin";
            this.Text = "Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form_Update_ThongTin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem update;
        private ToolStripMenuItem update_thongtin;
        private ToolStripMenuItem update_diem;
        private ToolStripMenuItem print;
        private ToolStripMenuItem logout;
        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private ComboBox cb_sex;
        private ComboBox cb_ma_lop;
        private Button btn_xoa;
        private Button btn_them;
        private Button btn_sua;
        private DateTimePicker date_ngay_sinh;
        private TextBox txt_tim;
        private TextBox txt_mat_khau;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_ma_hs;
        private Label label4;
        private TextBox txt_ten_hs;
        private Label label3;
        private Label label1;
    }
}