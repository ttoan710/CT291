using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form_Home : Form
    {
        private Image image1;
        private Image image2;

        
        public static int mau = function.mau;
        public Form_Home()
        {
            
            InitializeComponent();

            // Lấy đường dẫn thư mục khởi động của ứng dụng
            string startupPath = Application.StartupPath;

            // Kết hợp đường dẫn thư mục khởi động với tên tệp tin hình ảnh
            string image1Path = Path.Combine(startupPath+ @"\img\sun1.jpg");
            string image2Path = Path.Combine(startupPath+ @"\img\moon.jpg");

            // Kiểm tra xem tệp tin hình ảnh có tồn tại không
            if (File.Exists(image1Path) && File.Exists(image2Path))
            {
                // Tải hình ảnh 1 và hình ảnh 2 từ tệp tin
                image1 = Image.FromFile(image1Path);
                image2 = Image.FromFile(image2Path);

                // Thiết lập hình ảnh mặc định cho button
                btn_color.BackgroundImage = image1;
            }
            else
            {
                //MessageBox.Show(image1Path);
            }
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            function.mau = 1;
            Form_Login form_Login = new Form_Login();
            this.Hide();
            form_Login.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin form_Update = new Form_Update_ThongTin();
            this.Hide();
            form_Update.ShowDialog();
        }

        private void update_diem_Click(object sender, EventArgs e)
        {
            Form_Update_Diem form_Update_Diem = new Form_Update_Diem("");
            this.Hide();
            form_Update_Diem.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print form_Print = new Form_Print("");
            this.Hide();
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
            ChinhMauGiaoDien(mau);
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Phan_Hoi ph = new Form_Phan_Hoi("");
            this.Hide();
            ph.Show();
        }

        
        public void btn_color_Click(object sender, EventArgs e)
        {

            if (mau == 1)
            {
                function.mau = 0;
                mau = 0;
                ChinhMauGiaoDien(mau);
                btn_color.BackgroundImage = image2;
            }
            else if (mau == 0)
            {
                function.mau = 1;
                mau = 1;
                ChinhMauGiaoDien(mau);
                btn_color.BackgroundImage = image1;
            }
        }
        private void ChinhMauGiaoDien(int mauHienTai)
        {
            if (mauHienTai == 1)
            {
                this.label7.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox1.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox2.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_day);
                //this.btn_color.Text = "Giao Diện Sáng";
            }
            else if (mauHienTai == 0)
            {
                //this.btn_color.Text = "Giao Diện Tối";

                this.label7.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox1.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox2.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_night);

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Lich_Giang_Day d = new Form_Lich_Giang_Day("");
            this.Hide();
            d.ShowDialog();
        }
    }
}
