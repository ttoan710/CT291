using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form_Login : Form
    {
        public SqlConnection conn = new SqlConnection();
         function ham = new function();

        public Form_Login()
        {
            InitializeComponent();
            ham.connect(conn);
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
        }


        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string username = txt_username.Text.ToUpper();
            string password = txt_password.Text;

            string role = "";

            

            // Kiểm tra thông tin người dùng với bảng HocSinh
            string studentQuery = $"SELECT MaHocSinh FROM HocSinh WHERE MaHocSinh = '{username}' AND MatKhau = '{password}'";
            SqlCommand studentCmd = new SqlCommand(studentQuery, conn);
            SqlDataReader studentReader = studentCmd.ExecuteReader();

            if (studentReader.Read())
            {
                role = "student";
            }

            studentReader.Close();

            // Kiểm tra thông tin người dùng với bảng GiaoVien
            string teacherQuery = $"SELECT MaGiaoVien FROM GiaoVien WHERE MaGiaoVien = '{username}' AND MatKhau = '{password}'";
            SqlCommand teacherCmd = new SqlCommand(teacherQuery, conn);
            SqlDataReader teacherReader = teacherCmd.ExecuteReader();

            if (teacherReader.Read())
            {
                role = "teacher";
            }

            teacherReader.Close();
           

            // Xử lý logic dựa trên vai trò (role) của người dùng
            if (role == "student")
            {
                // Mở form sinh viên
                Form_Student form_Student = new Form_Student(username);
                this.Hide();
                form_Student.ShowDialog();
                
            }
            else if (role == "teacher")
            {
                // Mở form giáo viên
                Form_Home form_Home = new Form_Home();
                this.Hide();
                form_Home.ShowDialog();
                
            }
            else
            {
                // Thông báo thông tin đăng nhập không hợp lệ
                 MessageBox.Show("Invalid username or password. Please try again.");
            }
            
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ GVCN để được sử lý");
        }
    }
}
