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
    }
}
