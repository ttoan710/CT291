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

        private void HocKyToComboBox()
        {
            cb_hk.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hk.Items.Add("Hoc Kỳ 1");
            cb_hk.Items.Add("Học Kỳ 2");
            cb_hk.Items.Add("Tất cả");

        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            HocKyToComboBox();
            txt_ma.Visible = false;
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
            
            string hk1 = "Hoc Kỳ 1";
            string hk2 = "Học Kỳ 2";
            string hk = cb_hk.Text;
            if (hk == hk1) {
                ham.HienThiDLDG(dataGridView1, "SELECT        MonHoc.TenMonHoc,  HocKy.TenHocKy,    Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,         ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc,HocKy WHERE Diem.MaHocKy = HocKy.MaHocKy AND Diem.MaHocKy = 'HK001' AND Diem.MaHocSinh = '"+username+"' GROUP BY Diem.MaDiem,HocKy.TenHocKy, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi;", conn);
                string sql = "SELECT ROUND(AVG(DiemTrungBinh), 2) AS DiemTrungBinhTong,    CASE       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 9 THEN N'Xuất sắc'      WHEN ROUND(AVG(DiemTrungBinh), 2) >= 8 AND ROUND(AVG(DiemTrungBinh), 2) < 9 THEN N'Giỏi'       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 7 AND ROUND(AVG(DiemTrungBinh), 2) < 8 THEN N'Khá'      WHEN ROUND(AVG(DiemTrungBinh), 2) >= 5 AND ROUND(AVG(DiemTrungBinh), 2) < 7 THEN N'Trung bình'       ELSE N'Yếu'   END AS XepLoai FROM (    SELECT (DiemMieng + Diem15Phut + Diem1Tiet * 2 + DiemThi * 3) / 7 AS DiemTrungBinh   FROM Diem   WHERE Diem.MaHocKy = 'HK001') AS DiemTrungBinhCacMon ,Diem Where MaHocSinh = '"+username+"';";
                ham.HienThiDLDG(dataGridView_xl, sql, conn);
            }
            else if (hk == hk2)
            {

                ham.HienThiDLDG(dataGridView1, "   SELECT        MonHoc.TenMonHoc,  HocKy.TenHocKy,    Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,         ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc,HocKy WHERE Diem.MaHocKy = HocKy.MaHocKy AND Diem.MaHocKy = 'HK001'  AND Diem.MaHocSinh = 'HS001' GROUP BY Diem.MaDiem,HocKy.TenHocKy, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi\r\n   UNION ALL    SELECT        MonHoc.TenMonHoc,  HocKy.TenHocKy,    Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,         ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc,HocKy WHERE Diem.MaHocKy = HocKy.MaHocKy AND Diem.MaHocKy = 'HK002'  AND Diem.MaHocSinh = 'HS001' GROUP BY Diem.MaDiem,HocKy.TenHocKy, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi;\r\n", conn);
                string sql = "SELECT ROUND(AVG(DiemTrungBinh), 2) AS DiemTrungBinhTong,    CASE       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 9 THEN N'Xuất sắc'      WHEN ROUND(AVG(DiemTrungBinh), 2) >= 8 AND ROUND(AVG(DiemTrungBinh), 2) < 9 THEN N'Giỏi'       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 7 AND ROUND(AVG(DiemTrungBinh), 2) < 8 THEN N'Khá'      WHEN ROUND(AVG(DiemTrungBinh), 2) >= 5 AND ROUND(AVG(DiemTrungBinh), 2) < 7 THEN N'Trung bình'       ELSE N'Yếu'   END AS XepLoai FROM (    SELECT (DiemMieng + Diem15Phut + Diem1Tiet * 2 + DiemThi * 3) / 7 AS DiemTrungBinh   FROM Diem   WHERE Diem.MaHocKy = 'HK002') AS DiemTrungBinhCacMon ,Diem Where MaHocSinh = '" + username+"';";
                ham.HienThiDLDG(dataGridView_xl, sql, conn);

            }
            else
            {

                ham.HienThiDLDG(dataGridView1, "SELECT       MonHoc.TenMonHoc,    HocKy.TenHocKy,   Diem.DiemMieng,      Diem.Diem15Phut,       Diem.Diem1Tiet,      Diem.DiemThi,        ROUND( AVG((DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7),2) AS DiemTrungBinh FROM Diem INNER JOIN MonHoc ON Diem.MaMon = MonHoc.MaMonHoc,HocKy  WHERE Diem.MaHocKy = HocKy.MaHocKy AND  Diem.MaHocKy = 'HK001' OR  Diem.MaHocKy = 'HK002' AND Diem.MaHocSinh = '"+username+"' GROUP BY Diem.MaDiem, MonHoc.TenMonHoc, Diem.DiemMieng, Diem.Diem15Phut, Diem.Diem1Tiet, Diem.DiemThi, HocKy.TenHocKy ORDER BY  HocKy.TenHocKy;", conn);
                string sql = "SELECT ROUND(AVG(DiemTrungBinh), 2) AS DiemTrungBinhTong,\r\n  CASE       WHEN ROUND(AVG(DiemTrungBinh), 2) >= 9 THEN N'Xuất sắc'      \r\n  WHEN ROUND(AVG(DiemTrungBinh), 2) >= 8 AND ROUND(AVG(DiemTrungBinh), 2) < 9 THEN N'Giỏi'       \r\n  WHEN ROUND(AVG(DiemTrungBinh), 2) >= 7 AND ROUND(AVG(DiemTrungBinh), 2) < 8 THEN N'Khá'      \r\n  WHEN ROUND(AVG(DiemTrungBinh), 2) >= 5 AND ROUND(AVG(DiemTrungBinh), 2) < 7 THEN N'Trung bình'       \r\n  ELSE N'Yếu'   END AS XepLoai \r\nFROM (\r\n    SELECT ROUND(AVG((DiemMieng + Diem15Phut + Diem1Tiet * 2 + DiemThi * 3) / 7), 2) AS DiemTrungBinh\r\n    FROM Diem\r\n    WHERE Diem.MaHocSinh = 'HS001'\r\n    AND Diem.MaHocKy = 'HK002'\r\n\tAND Diem.MaHocSinh = 'HS001'\r\n    GROUP BY Diem.MaMon\r\n) AS SubjectAverage;";
                ham.HienThiDLDG(dataGridView_xl, sql, conn);
            }
            
            // string sql = "SELECT AVG(DiemTrungBinh) AS DiemTrungBinhTong, CASE  WHEN AVG(DiemTrungBinh) >= 9 THEN N'Xuất săc'          WHEN AVG(DiemTrungBinh) >= 8 AND AVG(DiemTrungBinh) <9  THEN N'Giỏi'  WHEN AVG(DiemTrungBinh) >= 7 AND AVG(DiemTrungBinh) <8  THEN N'Khá'   WHEN AVG(DiemTrungBinh) >= 5 AND AVG(DiemTrungBinh) <7  THEN N'Trung bình'           ELSE N'Yếu'      END AS XepLoai FROM (   SELECT (DiemMieng + Diem15Phut + Diem1Tiet*2 + DiemThi*3) / 7 AS DiemTrungBinh   FROM Diem) AS DiemTrungBinhCacMon;";
        }
       
        private void btn_gui_Click(object sender, EventArgs e)
        {
            string ma_lon_nhat = "select Max (SUBSTRING(MaPhanHoi,3,3)) from PhanHoi";
            SqlCommand comd = new SqlCommand(ma_lon_nhat, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                int max = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    txt_ma.Text = "PH00" + max;
                }
                else
                {
                    txt_ma.Text = "PH0" + max;
                }
               txt_ma.Enabled = false;
            }
            reader.Close();
            string maPhanHoi = txt_ma.Text;
            string phanHoi = tb_gui.Text;
            string sql_gui = "INSERT INTO PHANHOI (MaPhanHoi, MaHocSinh, PhanHoi) VALUES ('" + maPhanHoi + "', '" + username + "', N'" + phanHoi + "')";
            ham.capnhat(sql_gui, conn);
            MessageBox.Show("Đã gửi thành công");
            tb_gui.Text = "";
        }
    }
    }

