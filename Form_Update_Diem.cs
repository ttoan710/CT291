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
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                Form_Home1 fh = new Form_Home1(this.teachername);
                this.Hide();
                fh.ShowDialog();
            }else
            {
                Form_Home fh = new Form_Home();
                this.Hide();
                fh.ShowDialog();
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print fp = new Form_Print("");
            this.Hide();
            fp.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin tt = new Form_Update_ThongTin();
            this.Hide();
            tt.ShowDialog();
        }






        private void Form_Update_Diem_Load(object sender, EventArgs e)
        {

            ham.connect(conn);
            txt_ma_diem.Enabled = false;
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                ham.HienThiDLDG(dataGridView1, "SELECT       d.MaDiem AS Mã,      MIN(hs.HoTen) AS HoTen,      MIN(mh.TenMonHoc) AS TenMonHoc,      MIN(hk.TenHocKy) AS TenHocKy,      MIN(d.DiemMieng) AS DiemMieng,      MIN(d.Diem15Phut) AS Diem15Phut,      MIN(d.Diem1Tiet) AS Diem1Tiet,      MIN(d.DiemThi) AS DiemThi  FROM       Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv  WHERE       d.MaHocSinh = hs.MaHocSinh       AND d.MaHocKy = hk.MaHocKy       AND mh.MaMonHoc = d.MaMon  \tAND mh.MaMonHoc = gv.MaMon  \tAND gv.MaGiaoVien = '" + teachername + "' GROUP BY       d.MaDiem", conn);

            }
            else
            {
                ham.HienThiDLDG(dataGridView1, "Select d.MaDiem as Mã,hs.HoTen, mh.TenMonHoc, hk.TenHocKy,d.DiemMieng ,d.Diem15Phut,d.Diem1Tiet,d.DiemThi from Diem d,HocSinh hs,HocKy hk,MonHoc mh where d.MaHocSinh = hs.MaHocSinh and d.MaHocKy = hk.MaHocKy and mh.MaMonHoc = d.MaMon;  ", conn);
            }
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                ham.HienThiDLComb(cb_hoc_ky, "SELECT MAHOCKY, TENHOCKY FROM HOCKY", conn, "TENHOCKY", "MAHOCKY");
                ham.HienThiDLComb(cb_mahs, "SELECT MaHocSinh, HoTen FROM HocSinh", conn, "HoTen", "MaHocSinh");
                ham.HienThiDLComb(cb_mon, "SELECT mh.MaMonHoc, mh.TenMonHoc FROM MonHoc mh,GiaoVien gv where gv.MaMon = mh.MaMonHoc and gv.MaGiaoVien = '"+teachername+"'", conn, "TenMonHoc", "MaMonHoc");
            } else
            {
                ham.HienThiDLComb(cb_hoc_ky, "SELECT MAHOCKY, TENHOCKY FROM HOCKY", conn, "TENHOCKY", "MAHOCKY");
                ham.HienThiDLComb(cb_mahs, "SELECT MaHocSinh, HoTen FROM HocSinh", conn, "HoTen", "MaHocSinh");
                ham.HienThiDLComb(cb_mon, "SELECT MaMonHoc, TenMonHoc FROM MonHoc", conn, "TenMonHoc", "MaMonHoc");
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
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

                // Tiếp tục xử lý khi giá trị điểm hợp lệ nếu được mở từ Form_Home1
               
                
                string diemQuery = $"SELECT MaHocSinh FROM Diem WHERE MaHocSinh = '{maHocSinh}' AND MaMon = '{maMon}' AND MaHocKy = '{maHocKy}'";
                SqlCommand diemCmd = new SqlCommand(diemQuery, conn);
                SqlDataReader diemReader = diemCmd.ExecuteReader();
                    
                if (diemReader.Read())
                {
                    diemReader.Close(); // Đóng DataReader trước khi thực hiện truy vấn UPDATE

                    string updateQuery = $"UPDATE Diem SET DiemMieng = (CASE WHEN DiemMieng = 0 THEN {diemMiengValue} WHEN DiemMieng <> 0 AND {diemMiengValue} = 0 THEN DiemMieng ELSE (DiemMieng + {diemMiengValue}) / 2 END), Diem15Phut = (CASE WHEN Diem15Phut = 0 THEN {diem15Value} WHEN Diem15Phut <> 0 AND {diem15Value} = 0 THEN Diem15Phut ELSE (Diem15Phut + {diem15Value}) / 2 END), Diem1Tiet = (CASE WHEN Diem1Tiet = 0 THEN {diem1tValue} WHEN Diem1Tiet <> 0 AND {diem1tValue} = 0 THEN Diem1Tiet ELSE (Diem1Tiet + {diem1tValue}) / 2 END), DiemThi = (CASE WHEN DiemThi = 0 THEN {diemThiValue} WHEN DiemThi <> 0 AND {diemThiValue} = 0 THEN DiemThi ELSE (DiemThi + {diemThiValue}) / 2 END) WHERE MaHocSinh = '{maHocSinh}' AND MaMon = '{maMon}' AND MaHocKy = '{maHocKy}'";
                    ham.capnhat(updateQuery, conn);
                    if (Form_Home1.IsFormOpenedFromHome1)
                    {
                        ham.HienThiDLDG(dataGridView1, "SELECT       d.MaDiem AS Mã,      MIN(hs.HoTen) AS HoTen,      MIN(mh.TenMonHoc) AS TenMonHoc,      MIN(hk.TenHocKy) AS TenHocKy,      MIN(d.DiemMieng) AS DiemMieng,      MIN(d.Diem15Phut) AS Diem15Phut,      MIN(d.Diem1Tiet) AS Diem1Tiet,      MIN(d.DiemThi) AS DiemThi  FROM       Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv  WHERE       d.MaHocSinh = hs.MaHocSinh       AND d.MaHocKy = hk.MaHocKy       AND mh.MaMonHoc = d.MaMon  \tAND mh.MaMonHoc = gv.MaMon  \tAND gv.MaGiaoVien = '" + teachername + "' GROUP BY       d.MaDiem", conn);

                    }
                    else
                    {
                        ham.HienThiDLDG(dataGridView1, "Select d.MaDiem as Mã,hs.HoTen, mh.TenMonHoc, hk.TenHocKy,d.DiemMieng ,d.Diem15Phut,d.Diem1Tiet,d.DiemThi from Diem d,HocSinh hs,HocKy hk,MonHoc mh where d.MaHocSinh = hs.MaHocSinh and d.MaHocKy = hk.MaHocKy and mh.MaMonHoc = d.MaMon;  ", conn);
                    }
                    clearALL();
                
            }
                else
                {
                    diemReader.Close(); // Đóng DataReader trước khi thực hiện truy vấn INSERT

                    string insertQuery = $"INSERT INTO Diem (MaDiem, MaHocSinh, MaMon, MaHocKy, DiemMieng, Diem15Phut, Diem1Tiet, DiemThi) VALUES ('{maDiem}', '{maHocSinh}', '{maMon}', '{maHocKy}', '{diemmieng}', '{diem15}', '{diem1t}', '{diemthi}')";
                    ham.capnhat(insertQuery, conn);
                    if (Form_Home1.IsFormOpenedFromHome1)
                    {
                        ham.HienThiDLDG(dataGridView1, "SELECT       d.MaDiem AS Mã,      MIN(hs.HoTen) AS HoTen,      MIN(mh.TenMonHoc) AS TenMonHoc,      MIN(hk.TenHocKy) AS TenHocKy,      MIN(d.DiemMieng) AS DiemMieng,      MIN(d.Diem15Phut) AS Diem15Phut,      MIN(d.Diem1Tiet) AS Diem1Tiet,      MIN(d.DiemThi) AS DiemThi  FROM       Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv  WHERE       d.MaHocSinh = hs.MaHocSinh       AND d.MaHocKy = hk.MaHocKy       AND mh.MaMonHoc = d.MaMon  \tAND mh.MaMonHoc = gv.MaMon  \tAND gv.MaGiaoVien = '" + teachername + "' GROUP BY       d.MaDiem", conn);

                    }
                    else
                    {
                        ham.HienThiDLDG(dataGridView1, "Select d.MaDiem as Mã,hs.HoTen, mh.TenMonHoc, hk.TenHocKy,d.DiemMieng ,d.Diem15Phut,d.Diem1Tiet,d.DiemThi from Diem d,HocSinh hs,HocKy hk,MonHoc mh where d.MaHocSinh = hs.MaHocSinh and d.MaHocKy = hk.MaHocKy and mh.MaMonHoc = d.MaMon;  ", conn);
                    }
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

        }

        private void txt_tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tuKhoa = txt_tim.Text;
                string sql_tim = "SELECT d.MaDiem AS Mã, d.MaHocSinh, hs.HoTen, mh.TenMonHoc, hk.TenHocKy, d.DiemMieng, d.Diem15Phut, d.Diem1Tiet, d.DiemThi FROM Diem d, HocSinh hs, HocKy hk, GiaoVien gv, MonHoc mh WHERE d.MaHocSinh = hs.MaHocSinh AND d.MaHocKy = hk.MaHocKy AND mh.MaMonHoc = d.MaMon AND gv.MaMon = d.MaMon AND d.MaMon = gv.MaMon AND gv.MaGiaoVien = '" + teachername + "' AND (hs.MaHocSinh LIKE '%" + tuKhoa + "%' OR hs.HoTen LIKE '%" + tuKhoa + "%')";
                if (Form_Home1.IsFormOpenedFromHome1)
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT       d.MaDiem AS Mã,      MIN(hs.HoTen) AS HoTen,      MIN(mh.TenMonHoc) AS TenMonHoc,      MIN(hk.TenHocKy) AS TenHocKy,      MIN(d.DiemMieng) AS DiemMieng,      MIN(d.Diem15Phut) AS Diem15Phut,      MIN(d.Diem1Tiet) AS Diem1Tiet,      MIN(d.DiemThi) AS DiemThi  FROM       Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv  WHERE       d.MaHocSinh = hs.MaHocSinh       AND d.MaHocKy = hk.MaHocKy       AND mh.MaMonHoc = d.MaMon  \tAND mh.MaMonHoc = gv.MaMon  \tAND gv.MaGiaoVien = '" + teachername + "' GROUP BY       d.MaDiem", conn);

                }
                else
                {
                    ham.HienThiDLDG(dataGridView1, "Select d.MaDiem as Mã,hs.HoTen, mh.TenMonHoc, hk.TenHocKy,d.DiemMieng ,d.Diem15Phut,d.Diem1Tiet,d.DiemThi from Diem d,HocSinh hs,HocKy hk,MonHoc mh where d.MaHocSinh = hs.MaHocSinh and d.MaHocKy = hk.MaHocKy and mh.MaMonHoc = d.MaMon;  ", conn);
                }
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

                // Tiếp tục xử lý khi giá trị điểm hợp lệ
                string query = $"UPDATE Diem SET MaHocSinh = '{maHocSinh}', MaMon = '{maMon}', MaHocKy = '{maHocKy}', DiemMieng = '{diemmieng}', Diem15Phut = '{diem15}', Diem1Tiet = '{diem1t}', DiemThi = '{diemthi}' WHERE MaDiem = '{maDiem}'";
                ham.capnhat(query, conn);
                if (Form_Home1.IsFormOpenedFromHome1)
                {
                    ham.HienThiDLDG(dataGridView1, "SELECT       d.MaDiem AS Mã,      MIN(hs.HoTen) AS HoTen,      MIN(mh.TenMonHoc) AS TenMonHoc,      MIN(hk.TenHocKy) AS TenHocKy,      MIN(d.DiemMieng) AS DiemMieng,      MIN(d.Diem15Phut) AS Diem15Phut,      MIN(d.Diem1Tiet) AS Diem1Tiet,      MIN(d.DiemThi) AS DiemThi  FROM       Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv  WHERE       d.MaHocSinh = hs.MaHocSinh       AND d.MaHocKy = hk.MaHocKy       AND mh.MaMonHoc = d.MaMon  \tAND mh.MaMonHoc = gv.MaMon  \tAND gv.MaGiaoVien = '" + teachername + "' GROUP BY       d.MaDiem", conn);

                }
                else
                {
                    ham.HienThiDLDG(dataGridView1, "Select d.MaDiem as Mã,hs.HoTen, mh.TenMonHoc, hk.TenHocKy,d.DiemMieng ,d.Diem15Phut,d.Diem1Tiet,d.DiemThi from Diem d,HocSinh hs,HocKy hk,MonHoc mh where d.MaHocSinh = hs.MaHocSinh and d.MaHocKy = hk.MaHocKy and mh.MaMonHoc = d.MaMon;  ", conn);
                }

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
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maDiem = txt_ma_diem.Text;
            string query = "DELETE From Diem Where MaDiem = '" + maDiem + "'";
            ham.capnhat(query, conn);
            if (Form_Home1.IsFormOpenedFromHome1)
            {
                ham.HienThiDLDG(dataGridView1, "SELECT       d.MaDiem AS Mã,      MIN(hs.HoTen) AS HoTen,      MIN(mh.TenMonHoc) AS TenMonHoc,      MIN(hk.TenHocKy) AS TenHocKy,      MIN(d.DiemMieng) AS DiemMieng,      MIN(d.Diem15Phut) AS Diem15Phut,      MIN(d.Diem1Tiet) AS Diem1Tiet,      MIN(d.DiemThi) AS DiemThi  FROM       Diem d, HocSinh hs, HocKy hk, MonHoc mh, GiaoVien gv  WHERE       d.MaHocSinh = hs.MaHocSinh       AND d.MaHocKy = hk.MaHocKy       AND mh.MaMonHoc = d.MaMon  \tAND mh.MaMonHoc = gv.MaMon  \tAND gv.MaGiaoVien = '" + teachername + "' GROUP BY       d.MaDiem", conn);

            }
            else
            {
                ham.HienThiDLDG(dataGridView1, "Select d.MaDiem as Mã,hs.HoTen, mh.TenMonHoc, hk.TenHocKy,d.DiemMieng ,d.Diem15Phut,d.Diem1Tiet,d.DiemThi from Diem d,HocSinh hs,HocKy hk,MonHoc mh where d.MaHocSinh = hs.MaHocSinh and d.MaHocKy = hk.MaHocKy and mh.MaMonHoc = d.MaMon;  ", conn);
            }
            clearALL();
        }
        public void clearALL()
        {
           
            cb_mahs.SelectedValue = "";
            cb_mon.SelectedValue = "";
            cb_hoc_ky.SelectedValue = "";
            txt_thi.Text = "";
            txt_15p.Text = "";
            txt_1t.Text = "";
            txt_mieng.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1) // Kiểm tra chỉ xử lý khi click vào dòng có dữ liệu
            {
                txt_ma_diem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                // cb_mahs.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                // cb_mon.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                // cb_hoc_ky.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                // txt_mieng.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                // txt_15p.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                //txt_1t.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                // txt_thi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else // Xử lý khi click vào ô trống
            {
                string ma_lon_nhat = "SELECT MAX(SUBSTRING(MaDiem, 3, 3)) FROM DIEM";
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
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

        private void cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

