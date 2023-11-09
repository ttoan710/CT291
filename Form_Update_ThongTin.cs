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

       
        private void Form_Update_ThongTin_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, "SELECT distinct hs.MaHocSinh,hs.HoTen, hs.NgaySinh, hs.GioiTinh, l.TenLop, hs.MatKhau FROM HocSinh hs, Lop l Where hs.MaLop = l.MaLop", conn);
            ham.HienThiDLComb(cb_ma_lop, "SELECT TenLop, MALOP FROM Lop", conn, "TenLop", "MALOP");
            LoadGioiTinhToComboBox();

        }
      

        private void LoadGioiTinhToComboBox()
        {
            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Items.Add("Nam");
            cb_sex.Items.Add("Nữ");

        }


        private void btn_them_Click(object sender, EventArgs e)
        {
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
            string gioitinh = cb_sex.Text;
            string ma = txt_ma_hs.Text;
            string ten = txt_ten_hs.Text;
            string malop = cb_ma_lop.SelectedValue.ToString();
            string matkhau = txt_mat_khau.Text;

            // Kiểm tra xem học sinh đã tồn tại trong cơ sở dữ liệu chưa
            string checkQuery = $"SELECT COUNT(*) FROM HocSinh WHERE MaHocSinh = '{ma}' OR HoTen = '{ten}' ";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            int existingCount = (int)checkCmd.ExecuteScalar();

            if (existingCount > 0)
            {
                MessageBox.Show("Học sinh đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
        private void btn_dat_Click(object sender, EventArgs e)
        {
            clearALL();
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

            //string date = date_ngay_sinh.Value.ToString("yyyy-MM-dd");
            string date = date_ngay_sinh.Text;
           
            txt_ma_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_sex.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_ma_lop.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_mat_khau.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void cb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearALL()
        {
            cb_ma_lop.Text = "";
            txt_ma_hs.Text = "";
            txt_ten_hs.Text = "";
            txt_mat_khau.Text = "";
            cb_sex.Text = "";
            date_ngay_sinh.Value = new DateTime(2000, 1, 1);

        }

        private void txt_tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                string tuKhoa = txt_tim.Text;
                string sql_tim = "SELECT DISTINCT hs.MaHocSinh, hs.HoTen, hs.NgaySinh, hs.GioiTinh, l.TenLop, hs.MatKhau FROM HocSinh hs, Lop l WHERE hs.MaLop = l.MaLop AND (hs.MaHocSinh LIKE '%" + tuKhoa + "%' OR hs.HoTen LIKE '%" + tuKhoa + "%' OR l.TenLop LIKE '%" + tuKhoa + "%') ";
                ham.HienThiDLDG(dataGridView1, sql_tim, conn);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
