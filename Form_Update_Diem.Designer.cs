using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLHS
{
    partial class Form_Update_Diem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ma_hs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_gv = new System.Windows.Forms.ComboBox();
            this.cb_hoc_ky = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.update_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.update_diem = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_loai_diem = new System.Windows.Forms.ComboBox();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.txt_ma_diem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập Nhật Điểm Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(175, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(157, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Học Sinh";
            // 
            // txt_ma_hs
            // 
            this.txt_ma_hs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ma_hs.Location = new System.Drawing.Point(257, 39);
            this.txt_ma_hs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_ma_hs.Name = "txt_ma_hs";
            this.txt_ma_hs.Size = new System.Drawing.Size(155, 21);
            this.txt_ma_hs.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(175, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Học Kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(522, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại Điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(531, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm Số";
            // 
            // cb_gv
            // 
            this.cb_gv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_gv.FormattingEnabled = true;
            this.cb_gv.Location = new System.Drawing.Point(621, 36);
            this.cb_gv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cb_gv.Name = "cb_gv";
            this.cb_gv.Size = new System.Drawing.Size(155, 23);
            this.cb_gv.TabIndex = 4;
            // 
            // cb_hoc_ky
            // 
            this.cb_hoc_ky.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_hoc_ky.FormattingEnabled = true;
            this.cb_hoc_ky.Location = new System.Drawing.Point(257, 93);
            this.cb_hoc_ky.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cb_hoc_ky.Name = "cb_hoc_ky";
            this.cb_hoc_ky.Size = new System.Drawing.Size(155, 23);
            this.cb_hoc_ky.TabIndex = 5;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(405, 131);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(69, 23);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(221, 131);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(69, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(553, 131);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(69, 23);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(740, 131);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(69, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Đặt Lại";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(157, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(558, 172);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(637, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_diem
            // 
            this.txt_diem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diem.Location = new System.Drawing.Point(621, 96);
            this.txt_diem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(155, 21);
            this.txt_diem.TabIndex = 2;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.update_thongtin,
            this.update_diem});
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update.Margin = new System.Windows.Forms.Padding(10);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(10);
            this.update.Size = new System.Drawing.Size(122, 43);
            this.update.Text = "Cập Nhật";
            // 
            // update_thongtin
            // 
            this.update_thongtin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update_thongtin.Name = "update_thongtin";
            this.update_thongtin.Padding = new System.Windows.Forms.Padding(10);
            this.update_thongtin.Size = new System.Drawing.Size(230, 42);
            this.update_thongtin.Text = "Thông Tin Học Sinh";
            this.update_thongtin.Click += new System.EventHandler(this.update_thongtin_Click);
            // 
            // update_diem
            // 
            this.update_diem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update_diem.Name = "update_diem";
            this.update_diem.Padding = new System.Windows.Forms.Padding(10);
            this.update_diem.Size = new System.Drawing.Size(230, 42);
            this.update_diem.Text = "Điểm ";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.HighlightText;
            this.print.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.print.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.print.Margin = new System.Windows.Forms.Padding(10);
            this.print.Name = "print";
            this.print.Padding = new System.Windows.Forms.Padding(10);
            this.print.Size = new System.Drawing.Size(122, 43);
            this.print.Text = "In Bảng Điểm";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.HighlightText;
            this.logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logout.Margin = new System.Windows.Forms.Padding(10, 300, 10, 10);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(10);
            this.logout.Size = new System.Drawing.Size(122, 43);
            this.logout.Text = "Thoát";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.update,
            this.print,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(149, 399);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(522, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giáo viên";
            // 
            // cb_loai_diem
            // 
            this.cb_loai_diem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_loai_diem.FormattingEnabled = true;
            this.cb_loai_diem.Location = new System.Drawing.Point(621, 64);
            this.cb_loai_diem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cb_loai_diem.Name = "cb_loai_diem";
            this.cb_loai_diem.Size = new System.Drawing.Size(155, 23);
            this.cb_loai_diem.TabIndex = 4;
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(257, 65);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(155, 21);
            this.cb_mon.TabIndex = 9;
            // 
            // txt_ma_diem
            // 
            this.txt_ma_diem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ma_diem.Location = new System.Drawing.Point(221, 8);
            this.txt_ma_diem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_ma_diem.Name = "txt_ma_diem";
            this.txt_ma_diem.Size = new System.Drawing.Size(155, 21);
            this.txt_ma_diem.TabIndex = 2;
            // 
            // Form_Update_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(864, 399);
            this.Controls.Add(this.cb_mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.cb_hoc_ky);
            this.Controls.Add(this.cb_loai_diem);
            this.Controls.Add(this.cb_gv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ma_diem);
            this.Controls.Add(this.txt_ma_hs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_diem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form_Update_Diem";
            this.Text = "Bảng Điểm";
            this.Load += new System.EventHandler(this.Form_Update_Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_ma_hs;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cb_gv;
        private ComboBox cb_hoc_ky;
        private Button btn_sua;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_clear;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txt_diem;
        private ToolStripMenuItem update;
        private ToolStripMenuItem update_thongtin;
        private ToolStripMenuItem update_diem;
        private ToolStripMenuItem print;
        private ToolStripMenuItem logout;
        private MenuStrip menuStrip1;
        private Label label2;
        private ComboBox cb_loai_diem;
        private ComboBox cb_mon;
        private TextBox txt_ma_diem;
    }
}