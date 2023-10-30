using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLHS

{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.update_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.update_diem = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(202, 689);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.update_thongtin,
            this.update_diem});
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update.Margin = new System.Windows.Forms.Padding(10, 100, 10, 10);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(10);
            this.update.Size = new System.Drawing.Size(171, 50);
            this.update.Text = "Cập Nhật";
            // 
            // update_thongtin
            // 
            this.update_thongtin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update_thongtin.Name = "update_thongtin";
            this.update_thongtin.Padding = new System.Windows.Forms.Padding(10);
            this.update_thongtin.Size = new System.Drawing.Size(340, 50);
            this.update_thongtin.Text = "Thông Tin Học Sinh";
            this.update_thongtin.Click += new System.EventHandler(this.update_thongtin_Click);
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
            this.print.Margin = new System.Windows.Forms.Padding(10);
            this.print.Name = "print";
            this.print.Padding = new System.Windows.Forms.Padding(10);
            this.print.Size = new System.Drawing.Size(308, 50);
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
            this.logout.Size = new System.Drawing.Size(308, 50);
            this.logout.Text = "Thoát";
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1219, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Home";
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem update;
        private ToolStripMenuItem update_thongtin;
        private ToolStripMenuItem update_diem;
        private ToolStripMenuItem print;
        private ToolStripMenuItem logout;
        private PictureBox pictureBox1;
    }
}