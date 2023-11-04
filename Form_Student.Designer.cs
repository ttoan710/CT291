namespace QLHS
{
    partial class Form_Student
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_gui = new System.Windows.Forms.TextBox();
            this.btn_gui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hk = new System.Windows.Forms.Button();
            this.cb_hk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_xl = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_mahs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_hs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_xl)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(56, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 559);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(260, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bảng điểm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-15, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(732, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.tb_gui);
            this.groupBox2.Controls.Add(this.btn_gui);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_hk);
            this.groupBox2.Controls.Add(this.cb_hk);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(815, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 517);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tb_gui
            // 
            this.tb_gui.Location = new System.Drawing.Point(24, 280);
            this.tb_gui.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gui.Multiline = true;
            this.tb_gui.Name = "tb_gui";
            this.tb_gui.Size = new System.Drawing.Size(247, 120);
            this.tb_gui.TabIndex = 18;
            // 
            // btn_gui
            // 
            this.btn_gui.Location = new System.Drawing.Point(24, 419);
            this.btn_gui.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(93, 44);
            this.btn_gui.TabIndex = 17;
            this.btn_gui.Text = "Gửi";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ý kiến học sinh (Nếu có) :";
            // 
            // btn_hk
            // 
            this.btn_hk.Location = new System.Drawing.Point(228, 85);
            this.btn_hk.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hk.Name = "btn_hk";
            this.btn_hk.Size = new System.Drawing.Size(93, 30);
            this.btn_hk.TabIndex = 13;
            this.btn_hk.Text = "Chọn";
            this.btn_hk.UseVisualStyleBackColor = true;
            this.btn_hk.Click += new System.EventHandler(this.btn_hk_Click);
            // 
            // cb_hk
            // 
            this.cb_hk.FormattingEnabled = true;
            this.cb_hk.Location = new System.Drawing.Point(24, 86);
            this.cb_hk.Margin = new System.Windows.Forms.Padding(4);
            this.cb_hk.Name = "cb_hk";
            this.cb_hk.Size = new System.Drawing.Size(180, 30);
            this.cb_hk.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vui lòng chọn học kì để tạo bảng điểm";
            // 
            // dataGridView_xl
            // 
            this.dataGridView_xl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_xl.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_xl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_xl.Location = new System.Drawing.Point(815, 611);
            this.dataGridView_xl.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_xl.Name = "dataGridView_xl";
            this.dataGridView_xl.RowHeadersWidth = 62;
            this.dataGridView_xl.Size = new System.Drawing.Size(349, 102);
            this.dataGridView_xl.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.lb_gioitinh);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lb_mahs);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lb_ngaysinh);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lb_hs);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(56, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 115);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_gioitinh.Location = new System.Drawing.Point(561, 69);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(70, 25);
            this.lb_gioitinh.TabIndex = 1;
            this.lb_gioitinh.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(406, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giới Tính";
            // 
            // lb_mahs
            // 
            this.lb_mahs.AutoSize = true;
            this.lb_mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_mahs.Location = new System.Drawing.Point(561, 34);
            this.lb_mahs.Name = "lb_mahs";
            this.lb_mahs.Size = new System.Drawing.Size(70, 25);
            this.lb_mahs.TabIndex = 3;
            this.lb_mahs.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(406, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Học Sinh";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(194, 69);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(70, 25);
            this.lb_ngaysinh.TabIndex = 5;
            this.lb_ngaysinh.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(63, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // lb_hs
            // 
            this.lb_hs.AutoSize = true;
            this.lb_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_hs.Location = new System.Drawing.Point(194, 34);
            this.lb_hs.Name = "lb_hs";
            this.lb_hs.Size = new System.Drawing.Size(70, 25);
            this.lb_hs.TabIndex = 7;
            this.lb_hs.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Học Sinh ";
            // 
            // Form_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1191, 733);
            this.Controls.Add(this.dataGridView_xl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Student";
            this.Text = "Bảng Điểm Học Sinh";
            this.Load += new System.EventHandler(this.Form_Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_xl)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_xl;
        private System.Windows.Forms.Button btn_hk;
        private System.Windows.Forms.ComboBox cb_hk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_mahs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_hs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_gui;
        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}