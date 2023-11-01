using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form_Student : Form
    {
        private string username;
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
        public Form_Student(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLComb(cb_hk, "SELECT MaHocKy, TenHocKy FROM HocKy", conn, "TenHocKy", "MaHocKy");
            string query = $"SELECT HoTen, NgaySinh, GioiTinh FROM HocSinh WHERE MaHocSinh = '{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string studentName = reader["Hoten"].ToString();
                DateTime studentDOB = Convert.ToDateTime(reader["NgaySinh"]);
                string studentSex = reader["GioiTinh"].ToString();

                lb_hs.Text = studentName;
                lb_ngaysinh.Text = studentDOB.ToString("dd/MM/yyyy");
                lb_gioitinh.Text = studentSex;
                lb_mahs.Text = username;
            }

            reader.Close();


        }

        private void btn_hk_Click(object sender, EventArgs e)
        { 
            string hk1 = "HK001";
            string hk2 = "HK002";
            string hk = cb_hk.SelectedValue.ToString();
            if (hk == hk1) {
                ham.HienThiDLDG(dataGridView1, "SELECT SUBSTRING(Diem.MaDiem, LEN(Diem.MaDiem) - 1, 2) AS TT,       MonHoc.TenMonHoc,      Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,    Diem.MaHocKy,      AVG((DiemMieng + Diem15Phut + Diem1Tiet + DiemThi) / 4) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc WHERE Diem.MaHocKy = '" + hk1 + "' GROUP BY Diem.MaDiem, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, Diem.MaHocKy;", conn);
            }
            else if (hk == hk2)
            {
                ham.HienThiDLDG(dataGridView1, "SELECT SUBSTRING(Diem.MaDiem, LEN(Diem.MaDiem) - 1, 2) AS TT,       MonHoc.TenMonHoc,      Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,    Diem.MaHocKy,      AVG((DiemMieng + Diem15Phut + Diem1Tiet + DiemThi) / 4) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc WHERE Diem.MaHocKy = '" + hk2 + "' GROUP BY Diem.MaDiem, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, Diem.MaHocKy;", conn);
            }
            string sql = "SELECT AVG(DiemTrungBinh) AS DiemTrungBinhTong, CASE  WHEN AVG(DiemTrungBinh) >= 9 THEN N'Xuất săc'          WHEN AVG(DiemTrungBinh) >= 8 AND AVG(DiemTrungBinh) <9  THEN N'Giỏi'  WHEN AVG(DiemTrungBinh) >= 7 AND AVG(DiemTrungBinh) <8  THEN N'Khá'   WHEN AVG(DiemTrungBinh) >= 5 AND AVG(DiemTrungBinh) <7  THEN N'Trung bình'           ELSE N'Yếu'      END AS XepLoai FROM (   SELECT (DiemMieng + Diem15Phut + Diem1Tiet + DiemThi) / 4 AS DiemTrungBinh   FROM Diem) AS DiemTrungBinhCacMon;";
            ham.HienThiDLDG(dataGridView_xl, sql,conn);
        }
        private void btn_gui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi thành công");
            tb_gui.Text = "";
        }
        private void dataGridView_xl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

