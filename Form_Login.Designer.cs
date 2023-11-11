using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace QLHS
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(136, 364);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 364);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_login.Location = new System.Drawing.Point(110, 502);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(194, 44);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.UseWaitCursor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(98, 136);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.label1.Size = new System.Drawing.Size(214, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            this.label1.UseWaitCursor = true;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_password.Location = new System.Drawing.Point(98, 410);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(229, 32);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(124, 571);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quên mật khẩu";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username.Location = new System.Drawing.Point(94, 304);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(229, 32);
            this.txt_username.TabIndex = 0;
            this.txt_username.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(132, 260);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            this.label2.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(98, 448);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox1.Size = new System.Drawing.Size(140, 26);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.UseWaitCursor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 742);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Login";
            this.Text = "Đăng Nhập";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Button btn_login;
        public PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_password;
        private Label label4;
        private TextBox txt_username;
        private Label label2;
        private CheckBox checkBox1;
    }
}