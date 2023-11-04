using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin form_Update = new Form_Update_ThongTin();
            form_Update.ShowDialog();
        }

        private void update_diem_Click(object sender, EventArgs e)
        {
            Form_Update_Diem form_Update_Diem = new Form_Update_Diem(); 
            form_Update_Diem.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print form_Print = new Form_Print();
            form_Print.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void Form_Home_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add(DateTime.Now.ToShortDateString());
            listBox1.Items.Add(DateTime.Now.ToShortTimeString());
            String note = "Ode.Edu vừa mới cập nhật, vui lòng chờ hệ thống trong ít phút ..";
            groupBox5.Text = note;
            // Tạo một đối tượng GraphicsPath để định nghĩa hình dạng elip
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(0, 0, button1.Width, button1.Height);
            //// Đặt Region của PictureBox thành hình dạng elip
            //button1.Region = new Region(path);
            ////
            //path.AddEllipse(0, 0, button2.Width, button2.Height);
            //button2.Region = new Region(path);
            //path.AddEllipse(0, 0, button3.Width, button3.Height);
            //button3.Region = new Region(path);
            //path.AddEllipse(0, 0, button4.Width, button4.Height);
            //button4.Region = new Region(path);
            //path.AddEllipse(0, 0, button5.Width, button5.Height);
            //button5.Region = new Region(path);
            //path.AddEllipse(0, 0, button6.Width, button6.Height);
            //button6.Region = new Region(path);
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Phan_Hoi ph = new Form_Phan_Hoi();
            ph.Show();
        }

        int mau = 1;
        public void btn_color_Click(object sender, EventArgs e)
        {
                
                if (mau == 0)
                {
                string _backcolor = "LightSkyBlue";
                string _backgroundcolor = "GradientInactiveCaption";
                this.label7.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.groupBox1.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.groupBox2.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.BackColor = System.Drawing.Color.FromName(_backgroundcolor);
                this.btn_color.Text = "Giao Diện Sáng";
                mau = 1;
    }
                else
                {
                
                this.btn_color.Text = "Giao Diện Tối";
                string _backcolor = "MediumSlateBlue";
                string _backgroundcolor = "Purple";
                this.label7.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.groupBox1.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.groupBox2.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(_backcolor);
                this.BackColor = System.Drawing.Color.FromName(_backgroundcolor);
                
                mau = 0;
                   
                }
                
            
        }

       
    }
}
