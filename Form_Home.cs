using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //private void button1_MouseEnter(object sender, EventArgs e)
        //{
        //    button1.BackColor = Color.Red;
        //    button1.Size = new Size((int)(button1.Size.Width * 1.1), (int)(button1.Size.Height * 1.1)); // Tăng kích thước của nút
        //    button1.Scale(new SizeF(1.1f, 1.1f)); // Tăng tỷ lệ của nút
        //}

        //private void button1_MouseLeave(object sender, EventArgs e)
        //{
        //    button1.BackColor = SystemColors.Control;
        //    button1.Size = new Size((int)(button1.Size.Width / 1.1), (int)(button1.Size.Height / 1.1)); // Thu nhỏ kích thước của nút
        //    button1.Scale(new SizeF(1f / 1.1f, 1f / 1.1f)); // Thu nhỏ tỷ lệ của nút
        //}

        private void Form_Home_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add(DateTime.Now.ToShortDateString());
            listBox1.Items.Add(DateTime.Now.ToShortTimeString());
            String note = "Ode.Edu vừa mới cập nhật, vui lòng chờ hệ thống trong ít phút ..";
            groupBox5.Text = note;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
