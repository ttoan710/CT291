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
        String teachername;
        public Form_Update_ThongTin(string teachername)
        {
            InitializeComponent();
            this.teachername = teachername;
        }


        private void Form_Update_ThongTin_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, "SELECT distinct hs.MaHocSinh,hs.HoTen, hs.NgaySinh, hs.GioiTinh, hs.MatKhau " +
                "FROM HocSinh hs, Lop l,GiaoVien gv " +
                "Where hs.MaLop = l.MaLop " +
                "AND gv.MaLop = L.MaLop AND gv.MaGiaoVien = '"+teachername+"'", conn);
            
            ham.HienThiDLComb(cb_ma_lop, "SELECT l.TenLop, l.MaLop FROM Lop l, GiaoVien gv " +
                "WHERE l.Malop = gv.MaLop " +
                "And gv.MaGiaoVien = '"+teachername+"'", conn, "TenLop", "MaLop");
            
            LoadGioiTinhToComboBox();
            txt_ma_hs.Enabled = false;

            // Gắn môn của GV vào label
            string temon = "SELECT l.TenLop FROM GiaoVien gv, Lop l Where gv.MaLop = l.MaLop And gv.MaGiaoVien ='"+teachername+"'";
            SqlCommand comd = new SqlCommand(temon, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                string tenLop = reader["TenLop"].ToString();
                label1.Text += tenLop;
            }
            reader.Close();

            // Chỉnh màu
            int mau = function.mau;
            if (mau == 1)
            {
                this.groupBox2.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(function._backcolor_day);
                this.groupBox4.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_day);
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromName(function._dataGridViewcolor_day);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_day);
                
            }
            else
            {
                this.groupBox2.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox3.BackColor = System.Drawing.Color.FromName(function._backcolor_night);
                this.groupBox4.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_night);
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromName(function._dataGridViewcolor_night);
                this.BackColor = System.Drawing.Color.FromName(function._backgroundcolor_night);

            }
        }
      
        // Tạo combobox giới tính
        private void LoadGioiTinhToComboBox()
        {
            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Items.Add("Nam");
            cb_sex.Items.Add("Nữ");

        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            string malonnhat = "SELECT MAX (SUBSTRING(MaHocSinh,3,3)) FROM HocSinh";
            SqlCommand comd = new SqlCommand(malonnhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            // Tăng mã học sinh
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
            // Kết thúc kiểm tra
 
            string sql_them = "INSERT INTO HocSinh VALUES ('" + ma + "', N'" + ten + "', '" + date_ngay_sinh.Value.ToString("yyyy-MM-dd") + "', N'" + gioitinh + "', '" + malop + "', '" + matkhau + "')";
            ham.capnhat(sql_them, conn);
            ham.HienThiDLDG(dataGridView1, "SELECT distinct hs.MaHocSinh,hs.HoTen, hs.NgaySinh, hs.GioiTinh, hs.MatKhau " +
                           "FROM HocSinh hs, Lop l,GiaoVien gv " +
                           "Where hs.MaLop = l.MaLop " +
                           "AND gv.MaLop = L.MaLop AND gv.MaGiaoVien = '" + teachername + "'", conn);
            MessageBox.Show("Cập nhật dữ liệu thành công");
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
            ham.HienThiDLDG(dataGridView1, "SELECT distinct hs.MaHocSinh,hs.HoTen, hs.NgaySinh, hs.GioiTinh, hs.MatKhau " +
                           "FROM HocSinh hs, Lop l,GiaoVien gv " +
                           "Where hs.MaLop = l.MaLop " +
                           "AND gv.MaLop = L.MaLop AND gv.MaGiaoVien = '" + teachername + "'", conn); btn_them.Enabled = true;
            MessageBox.Show("Sửa dữ liệu thành công");
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_ma_hs.Text;
            // Kiểm tra xem học sinh đã tồn tại trong cơ sở dữ liệu  DIEM chưa
            string checkQuery = $"SELECT COUNT(*) FROM Diem WHERE MaHocSinh = '{ma}'";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            int existingCount = (int)checkCmd.ExecuteScalar();
            if (existingCount > 0)
            {
                MessageBox.Show("Học sinh đang có điểm, không thể xóa. Vui lòng xóa điểm trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Kết thúc kiểm tra


            string sql_xoa = "DELETE FROM HocSinh WHERE MaHocSinh ='" + ma + "'";
            ham.capnhat(sql_xoa, conn);
            ham.HienThiDLDG(dataGridView1, "SELECT distinct hs.MaHocSinh,hs.HoTen, hs.NgaySinh, hs.GioiTinh, hs.MatKhau " +
                           "FROM HocSinh hs, Lop l,GiaoVien gv " +
                           "Where hs.MaLop = l.MaLop " +
                           "AND gv.MaLop = L.MaLop AND gv.MaGiaoVien = '" + teachername + "'", conn);
            clearALL();
            btn_them.Enabled = true;
            MessageBox.Show("Xóa dữ liệu thành công");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy tên lớp gắn vào combobox lớp khi ấn
            string temon = "SELECT l.TenLop FROM GiaoVien gv, Lop l Where gv.MaLop = l.MaLop And gv.MaGiaoVien ='" + teachername + "'";
            SqlCommand comd = new SqlCommand(temon, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                string tenLop = reader["TenLop"].ToString();
                cb_ma_lop.Text = tenLop;
            }
            reader.Close();
           

            string date = date_ngay_sinh.Text;           
            txt_ma_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_sex.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();         
            txt_mat_khau.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        // Hàm làm mới
        private void clearALL()
        {
            cb_ma_lop.Text = "";
            txt_ma_hs.Text = "";
            txt_ten_hs.Text = "";
            txt_mat_khau.Text = "";
            cb_sex.Text = "";
            date_ngay_sinh.Value = new DateTime(2000, 1, 1);

        }

        // text tìm
        private void txt_tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                string tuKhoa = txt_tim.Text;
                string sql_tim = "SELECT distinct hs.MaHocSinh,hs.HoTen, hs.NgaySinh, hs.GioiTinh, l.TenLop, hs.MatKhau " +
                    "FROM HocSinh hs, Lop l,GiaoVien gv " +
                    "Where hs.MaLop = l.MaLop " +
                    "AND gv.MaLop = L.MaLop " +
                    "AND gv.MaGiaoVien = '" + teachername + "'" +
                    " AND (hs.MaHocSinh LIKE '%" + tuKhoa + "%' OR hs.HoTen LIKE '%" + tuKhoa + "%' OR hs.GioiTinh LIKE '%" + tuKhoa + "%' OR hs.NgaySinh LIKE '%" + tuKhoa + "%' ) ";
                ham.HienThiDLDG(dataGridView1, sql_tim, conn);
            }
        }

        // Nút log_out
        private void out_Click(object sender, EventArgs e)
        {        
                Form_Home1 fh = new Form_Home1(teachername);
                this.Hide();
                fh.ShowDialog();           
        }      
    }
}
