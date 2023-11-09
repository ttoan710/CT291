using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLHS
{
    
    public partial class Form_Home1 : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
        private string teacherName;
        public Form_Home1(string username)
        {
            InitializeComponent();
            this.teacherName = username;
        }
        public static bool IsFormOpenedFromHome1 = false;
        private void logout_Click_1(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            this.Hide();
            form_Login.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin form_Update = new Form_Update_ThongTin();
            Form_Home1.IsFormOpenedFromHome1 = true;
            this.Hide();
            form_Update.ShowDialog();
        }

        private void update_diem_Click(object sender, EventArgs e)
        {
            Form_Update_Diem form_Update_Diem = new Form_Update_Diem(teacherName);
            Form_Home1.IsFormOpenedFromHome1 = true;
            this.Hide();
            form_Update_Diem.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print form_Print = new Form_Print(teacherName);
            Form_Home1.IsFormOpenedFromHome1 = true;
            this.Hide();
            form_Print.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form_Lich_Giang_Day fm = new Form_Lich_Giang_Day();
            Form_Home1.IsFormOpenedFromHome1 = true;
            this.Hide();
            fm.ShowDialog();
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
            ham.connect(conn);
            listBox2.Items.Add(DateTime.Now.ToShortDateString());
            listBox1.Items.Add(DateTime.Now.ToShortTimeString());
            String note = "Ode.Edu vừa mới cập nhật, vui lòng chờ hệ thống trong ít phút ..";
            groupBox5.Text = note;

            // lấy tên giáo viên

            string studentQuery = "SELECT HoTen FROM GiaoVien WHERE MaGiaoVien = '"+teacherName+"'";
            SqlCommand studentCmd = new SqlCommand(studentQuery, conn);
            studentCmd.Parameters.AddWithValue("@MaGiaoVien", teacherName);
           
            SqlDataReader studentReader = studentCmd.ExecuteReader();

            if (studentReader.Read())
            {
                string tenGiaoVien = studentReader.GetString(0);
                lb_chao.Text = "Xin Chào, " + tenGiaoVien;
            }

            studentReader.Close();

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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
