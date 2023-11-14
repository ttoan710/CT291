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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLHS
{
    public partial class Form_Update_Diem : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();
       string teachername;
       
        public Form_Update_Diem(string teachernamne)
        {
            InitializeComponent();
            this.teachername = teachernamne;
        }

        private void logout_Click(object sender, EventArgs e)
        {
           
                Form_Home1 fh = new Form_Home1(this.teachername);
                this.Hide();
                fh.ShowDialog();   
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print fp = new Form_Print("");
            this.Hide();
            fp.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin tt = new Form_Update_ThongTin(teachername);
            this.Hide();
            tt.ShowDialog();
        }

        private void Form_Update_Diem_Load(object sender, EventArgs e)
        {
            cb_mon.Enabled = false;
            ham.connect(conn);
            txt_ma_diem.Enabled = false;
            cb_lop.Enabled = false;
            ham.HienThiDLDG(dataGridView1, "SELECT d.MaDiem AS Mã, MIN(hs.HoTen) AS HoTen, MIN(l.TenLop) AS Lop, MIN(hk.TenHocKy) AS TenHocKy, MIN(d.DiemMieng) AS DiemMieng, MIN(d.Diem15Phut) AS Diem15Phut, MIN(d.Diem1Tiet) AS Diem1Tiet, MIN(d.DiemThi) AS DiemThi  " +
                               "FROM  Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv,Lop l  " +
                               "WHERE l.MaLop = hs.MaLop " +
                               "AND  d.MaHocSinh = hs.MaHocSinh " +
                               "AND d.MaHocKy = hk.MaHocKy " +
                               "AND mh.MaMonHoc = d.MaMon " +
                               "AND  mh.MaMonHoc = gv.MaMon " +
                               "AND gv.MaGiaoVien = '" + teachername + "' " +
                               "GROUP BY  d.MaDiem", conn);

            ham.HienThiDLComb(cb_hoc_ky, "SELECT MAHOCKY, TENHOCKY FROM HOCKY", conn, "TENHOCKY", "MAHOCKY");

            ham.HienThiDLComb(cb_mahs, "SELECT MaHocSinh, HoTen FROM HocSinh", conn, "HoTen", "MaHocSinh");

            ham.HienThiDLComb(cb_lop, "SELECT l.TenLop, l.MaLop FROM Lop l", conn, "TenLop", "MaLop");

            ham.HienThiDLComb(cb_mon, "SELECT mh.MaMonHoc, mh.TenMonHoc " +
                "FROM MonHoc mh,GiaoVien gv " +
                "where gv.MaMon = mh.MaMonHoc " +
                "and gv.MaGiaoVien = '"+teachername+"'", conn, "TenMonHoc", "MaMonHoc");
            
            // Gán tên môn học vào label
            string temon = "SELECT mh.TenMonHoc FROM GiaoVien gv, MonHoc mh Where gv.MaMon = mh.MaMonHoc And gv.MaGiaoVien ='" + teachername + "'";
            SqlCommand comd = new SqlCommand(temon, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                string tenMonHoc = reader["TenMonHoc"].ToString();
                label1.Text += tenMonHoc;
            }
            reader.Close();
        
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

        


        private void btn_them_Click(object sender, EventArgs e)
        {
           // Tăng mã điểm
            string ma_lon_nhat = "select Max (SUBSTRING(MaDiem,3,3)) from DIEM";
            SqlCommand comd = new SqlCommand(ma_lon_nhat, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int max = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (max < 10)
                {
                    txt_ma_diem.Text = "MD00" + max;
                }
                else
                {
                    txt_ma_diem.Text = "MD0" + max;
                }
                txt_ma_diem.Enabled = false;
            }
            reader.Close();

            string maDiem = txt_ma_diem.Text;
            string maHocSinh = cb_mahs.SelectedValue.ToString();
            string maMon = cb_mon.SelectedValue.ToString();
            string maHocKy = cb_hoc_ky.SelectedValue.ToString();
            string diemmieng = txt_mieng.Text;
            string diem15 = txt_15p.Text;
            string diem1t = txt_1t.Text;
            string diemthi = txt_thi.Text;




            float diemMiengValue, diem15Value, diem1tValue, diemThiValue;

            // kiểm tra nhập vào
            try
            {
                if (!float.TryParse(diemmieng, out diemMiengValue))
                {
                    throw new FormatException("Vui lòng nhập giá trị số cho điểm miệng.");
                }

                if (!float.TryParse(diem15, out diem15Value))
                {
                    throw new FormatException("Vui lòng nhập giá trị số cho điểm 15 phút.");
                }

                if (!float.TryParse(diem1t, out diem1tValue))
                {
                    throw new FormatException("Vui lòng nhập giá trị số cho điểm 1 tiết.");
                }

                if (!float.TryParse(diemthi, out diemThiValue))
                {
                    throw new FormatException("Vui lòng nhập giá trị số cho điểm thi.");
                }

                if (diemMiengValue < 0 || diemMiengValue > 10 ||
                    diem15Value < 0 || diem15Value > 10 ||
                    diem1tValue < 0 || diem1tValue > 10 ||
                    diemThiValue < 0 || diemThiValue > 10)
                {
                    throw new Exception("Giá trị điểm nằm ngoài khoảng từ 0 đến 10.");
                }
               // Kết thúc kiểm tra
               
                
                string diemQuery = $"SELECT MaHocSinh FROM Diem WHERE MaHocSinh = '{maHocSinh}' AND MaMon = '{maMon}' AND MaHocKy = '{maHocKy}'";
                SqlCommand diemCmd = new SqlCommand(diemQuery, conn);
                SqlDataReader diemReader = diemCmd.ExecuteReader();
                    
                if (diemReader.Read())
                {
                    diemReader.Close(); // Đóng DataReader trước khi thực hiện truy vấn UPDATE

                    string updateQuery = $"UPDATE Diem SET DiemMieng = (CASE WHEN DiemMieng = 0 THEN {diemMiengValue} WHEN DiemMieng <> 0 AND {diemMiengValue} = 0 THEN DiemMieng ELSE (DiemMieng + {diemMiengValue}) / 2 END), Diem15Phut = (CASE WHEN Diem15Phut = 0 THEN {diem15Value} WHEN Diem15Phut <> 0 AND {diem15Value} = 0 THEN Diem15Phut ELSE (Diem15Phut + {diem15Value}) / 2 END), Diem1Tiet = (CASE WHEN Diem1Tiet = 0 THEN {diem1tValue} WHEN Diem1Tiet <> 0 AND {diem1tValue} = 0 THEN Diem1Tiet ELSE (Diem1Tiet + {diem1tValue}) / 2 END), DiemThi = (CASE WHEN DiemThi = 0 THEN {diemThiValue} WHEN DiemThi <> 0 AND {diemThiValue} = 0 THEN DiemThi ELSE (DiemThi + {diemThiValue}) / 2 END) WHERE MaHocSinh = '{maHocSinh}' AND MaMon = '{maMon}' AND MaHocKy = '{maHocKy}'";
                    ham.capnhat(updateQuery, conn);

                    ham.HienThiDLDG(dataGridView1, "SELECT d.MaDiem AS Mã, MIN(hs.HoTen) AS HoTen, MIN(l.TenLop) AS Lop, MIN(hk.TenHocKy) AS TenHocKy, MIN(d.DiemMieng) AS DiemMieng, MIN(d.Diem15Phut) AS Diem15Phut, MIN(d.Diem1Tiet) AS Diem1Tiet, MIN(d.DiemThi) AS DiemThi  " +
                                "FROM  Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv,Lop l  " +
                                "WHERE l.MaLop = hs.MaLop " +
                                "AND  d.MaHocSinh = hs.MaHocSinh " +
                                "AND d.MaHocKy = hk.MaHocKy " +
                                "AND mh.MaMonHoc = d.MaMon " +
                                "AND  mh.MaMonHoc = gv.MaMon " +
                                "AND gv.MaGiaoVien = '" + teachername + "' " +
                                "GROUP BY  d.MaDiem", conn);

                }
                else
                {
                    diemReader.Close(); // Đóng DataReader trước khi thực hiện truy vấn INSERT

                    string insertQuery = $"INSERT INTO Diem (MaDiem, MaHocSinh, MaMon, MaHocKy, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) VALUES ('{maDiem}', '{maHocSinh}', '{maMon}', '{maHocKy}', '{diemmieng}', '{diem15}', '{diem1t}', '{diemthi}')";
                    ham.capnhat(insertQuery, conn);

                    ham.HienThiDLDG(dataGridView1, "SELECT d.MaDiem AS Mã, MIN(hs.HoTen) AS HoTen, MIN(l.TenLop) AS Lop, MIN(hk.TenHocKy) AS TenHocKy, MIN(d.DiemMieng) AS DiemMieng, MIN(d.Diem15Phut) AS Diem15Phut, MIN(d.Diem1Tiet) AS Diem1Tiet, MIN(d.DiemThi) AS DiemThi  " +
                                "FROM  Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv,Lop l  " +
                                "WHERE l.MaLop = hs.MaLop " +
                                "AND  d.MaHocSinh = hs.MaHocSinh " +
                                "AND d.MaHocKy = hk.MaHocKy " +
                                "AND mh.MaMonHoc = d.MaMon " +
                                "AND  mh.MaMonHoc = gv.MaMon " +
                                "AND gv.MaGiaoVien = '" + teachername + "' " +
                                "GROUP BY  d.MaDiem", conn); 
                    clearALL();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Cập nhật dữ liệu thành công");
        }

        private void txt_tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tuKhoa = txt_tim.Text;               
                ham.HienThiDLDG(dataGridView1, "SELECT d.MaDiem AS Mã, MIN(hs.HoTen) AS HoTen, MIN(l.TenLop) AS Lop, MIN(hk.TenHocKy) AS TenHocKy, MIN(d.DiemMieng) AS DiemMieng, MIN(d.Diem15Phut) AS Diem15Phut, MIN(d.Diem1Tiet) AS Diem1Tiet, MIN(d.DiemThi) AS DiemThi  " +
                               "FROM  Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv,Lop l  " +
                               "WHERE l.MaLop = hs.MaLop " +
                               "AND  d.MaHocSinh = hs.MaHocSinh " +
                               "AND d.MaHocKy = hk.MaHocKy " +
                               "AND mh.MaMonHoc = d.MaMon " +
                               "AND  mh.MaMonHoc = gv.MaMon " +
                               "AND gv.MaGiaoVien = '" + teachername + "' " +
                                "AND (hs.MaHocSinh LIKE '%" + tuKhoa + "%' OR hs.HoTen LIKE '%" + tuKhoa + "%' OR hk.TenHocKy LIKE '%" + tuKhoa + "%' OR l.TenLop LIKE '%" + tuKhoa + "%') " +
                               "GROUP BY  d.MaDiem", conn);
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maDiem = txt_ma_diem.Text;
            string maHocSinh = cb_mahs.SelectedValue.ToString();
            string maMon = cb_mon.SelectedValue.ToString();
            string maHocKy = cb_hoc_ky.SelectedValue.ToString();
            string diemmieng = txt_mieng.Text;
            string diem15 = txt_15p.Text;
            string diem1t = txt_1t.Text;
            string diemthi = txt_thi.Text;

            // Kiểm tra nhập vào đúng không
            try
            {
                float diemMiengValue, diem15Value, diem1tValue, diemThiValue;

                if (!float.TryParse(diemmieng, out diemMiengValue) ||
                    !float.TryParse(diem15, out diem15Value) ||
                    !float.TryParse(diem1t, out diem1tValue) ||
                    !float.TryParse(diemthi, out diemThiValue))
                {
                    throw new FormatException("Nhập điểm sai, Vui lòng nhập lại.");
                }

                if (diemMiengValue < 0 || diemMiengValue > 10 ||
                    diem15Value < 0 || diem15Value > 10 ||
                    diem1tValue < 0 || diem1tValue > 10 ||
                    diemThiValue < 0 || diemThiValue > 10)
                {
                    throw new Exception("Giá trị điểm nằm ngoài khoảng từ 0 đến 10.");
                }
                // Kết thúc kiểm tra


                // Tiếp tục xử lý khi giá trị điểm hợp lệ
                string query = $"UPDATE Diem SET MaHocSinh = '{maHocSinh}', MaMon = '{maMon}', MaHocKy = '{maHocKy}', DiemMieng = '{diemmieng}', Diem15Phut = '{diem15}', Diem1Tiet = '{diem1t}', DiemThi = '{diemthi}' WHERE MaDiem = '{maDiem}'";
                ham.capnhat(query, conn);

                ham.HienThiDLDG(dataGridView1, "SELECT d.MaDiem AS Mã, MIN(hs.HoTen) AS HoTen, MIN(l.TenLop) AS Lop, MIN(hk.TenHocKy) AS TenHocKy, MIN(d.DiemMieng) AS DiemMieng, MIN(d.Diem15Phut) AS Diem15Phut, MIN(d.Diem1Tiet) AS Diem1Tiet, MIN(d.DiemThi) AS DiemThi  " +
                            "FROM  Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv,Lop l  " +
                            "WHERE l.MaLop = hs.MaLop " +
                            "AND  d.MaHocSinh = hs.MaHocSinh " +
                            "AND d.MaHocKy = hk.MaHocKy " +
                            "AND mh.MaMonHoc = d.MaMon " +
                            "AND  mh.MaMonHoc = gv.MaMon " +
                            "AND gv.MaGiaoVien = '" + teachername + "' " +
                            "GROUP BY  d.MaDiem", conn);
                clearALL();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Sửa dữ liệu thành công");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maDiem = txt_ma_diem.Text;
            string query = "DELETE From Diem Where MaDiem = '" + maDiem + "'";
            ham.capnhat(query, conn);

            ham.HienThiDLDG(dataGridView1, "SELECT d.MaDiem AS Mã, MIN(hs.HoTen) AS HoTen, MIN(l.TenLop) AS Lop, MIN(hk.TenHocKy) AS TenHocKy, MIN(d.DiemMieng) AS DiemMieng, MIN(d.Diem15Phut) AS Diem15Phut, MIN(d.Diem1Tiet) AS Diem1Tiet, MIN(d.DiemThi) AS DiemThi  " +
                        "FROM  Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv,Lop l  " +
                        "WHERE l.MaLop = hs.MaLop " +
                        "AND  d.MaHocSinh = hs.MaHocSinh " +
                        "AND d.MaHocKy = hk.MaHocKy " +
                        "AND mh.MaMonHoc = d.MaMon " +
                        "AND  mh.MaMonHoc = gv.MaMon " +
                        "AND gv.MaGiaoVien = '" + teachername + "' " +
                        "GROUP BY  d.MaDiem", conn);
            clearALL();
            MessageBox.Show("Xóa dữ liệu thành công");
        }
        public void clearALL()
        {
           // hàm làm mới
            cb_mahs.SelectedValue = "";
            cb_mon.SelectedValue = "";
            cb_hoc_ky.SelectedValue = "";
            txt_thi.Text = "0";
            txt_15p.Text = "0";
            txt_1t.Text = "0";
            txt_mieng.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy tên môn gắn vào combobox khi click vào dataGridView vì dataGridView không hiện cột tên môn
            string temon = "SELECT mh.TenMonHoc FROM GiaoVien gv, MonHoc mh Where gv.MaMon = mh.MaMonHoc And gv.MaGiaoVien ='" + teachername + "'";
            SqlCommand comd = new SqlCommand(temon, conn);
            SqlDataReader reader = comd.ExecuteReader();

            if (reader.Read())
            {
                string tenMonHoc = reader["TenMonHoc"].ToString();
                cb_mon.Text = tenMonHoc;
            }
            reader.Close();

            
                 txt_ma_diem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cb_mahs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_lop.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cb_hoc_ky.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_mieng.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_15p.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_1t.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_thi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

          
        }

        // Hàm đặt lại
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearALL();
        }


    }
}

