using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLHS
{
    public partial class Form_Update_ThongTin : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
        public Form_Update_ThongTin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form_Home hom = new Form_Home();
            hom.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print p = new Form_Print();
            p.ShowDialog();
        }

        private void update_diem_Click(object sender, EventArgs e)
        {
            Form_Update_Diem d = new Form_Update_Diem();
            d.ShowDialog();
        }
        private void Form_Update_ThongTin_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, "SELECT * FROM HocSinh", conn);
            ham.HienThiDLComb(cb_ma_lop, "SELECT TenLop, MALOP FROM Lop", conn, "TenLop", "MALOP");
            LoadGioiTinhToComboBox();

            string malonnhat = "SELECT MAX (SUBSTRING(MaHocSinh,5,2)) FROM HocSinh";
            SqlCommand comd = new SqlCommand(malonnhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    txt_ma_hs.Text = "HS00" + max;
                }
                else
                {
                    txt_ma_hs.Text = "HS0" + max;
                }
                txt_ma_hs.Enabled = false;
            }
            reader.Close();


        }
        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_tim.Text;
            string sql_tim = "SELECT * FROM HocSinh WHERE MaHocSinh LIKE '%" + tuKhoa + "%' OR HoTen LIKE '%" + tuKhoa + "%'";
            ham.HienThiDLDG(dataGridView1, sql_tim, conn);
        }
        private void LoadGioiTinhToComboBox()
        {
            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Items.Add("Nam");
            cb_sex.Items.Add("Nữ");

        }


        private void btn_them_Click(object sender, EventArgs e)
        {

            // chỉnh sửa cột giới tính .text 
             string gioitinh = cb_sex.Text;
             string ma = txt_ma_hs.Text;
             string ten = txt_ten_hs.Text;
             string malop = cb_ma_lop.SelectedValue.ToString();
             string matkhau = txt_mat_khau.Text;
             string sql_them = "INSERT INTO HocSinh VALUES ('" + ma + "', N'" + ten + "', '" + date_ngay_sinh.Value.ToString("yyyy-MM-dd") + "', N'" + gioitinh + "', '" + malop + "', '" + matkhau + "')";
             ham.capnhat(sql_them, conn);
             ham.HienThiDLDG(dataGridView1, "SELECT * FROM HocSinh", conn);
            

           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string gioitinh = cb_sex.Text;
            string ma = txt_ma_hs.Text;
            string ten = txt_ten_hs.Text;
            string malop = cb_ma_lop.SelectedValue.ToString();
            string matkhau = txt_mat_khau.Text;

            string sql_sua = "UPDATE HocSinh SET HoTen = N'" + ten + "', NgaySinh = '" + date_ngay_sinh.Value.ToString("yyyy-MM-dd") + "', GioiTinh = N'" + gioitinh + "', MaLop = '" + malop + "', MatKhau = '" + matkhau + "' WHERE MaHocSinh = '" + ma + "'";
            ham.capnhat(sql_sua, conn);
            ham.HienThiDLDG(dataGridView1, "SELECT * FROM HocSinh", conn);
            btn_them.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_ma_hs.Text;

            string sql_xoa = "DELETE FROM HocSinh WHERE MaHocSinh ='" + ma + "'";
            ham.capnhat(sql_xoa, conn);
            ham.HienThiDLDG(dataGridView1, "SELECT * FROM HocSinh", conn);
            btn_them.Enabled = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            //
            string date = date_ngay_sinh.Value.ToString("yyyy-MM-dd");

            //string sex =cb_sex.SelectedValue.ToString();
            string lop = cb_ma_lop.SelectedValue.ToString();
            txt_ma_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_sex.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            lop = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_mat_khau.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           
           
            


        }
    }
}
