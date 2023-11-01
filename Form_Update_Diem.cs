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

namespace QLHS
{
    public partial class Form_Update_Diem : Form
    {
        public SqlConnection conn = new SqlConnection();
        function ham = new function();

        public Form_Update_Diem()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form_Home fh = new Form_Home();
            fh.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form_Print fp = new Form_Print();
            fp.ShowDialog();
        }

        private void update_thongtin_Click(object sender, EventArgs e)
        {
            Form_Update_ThongTin tt = new Form_Update_ThongTin();
            tt.ShowDialog();
        }






        private void Form_Update_Diem_Load(object sender, EventArgs e)
        {
            ham.connect(conn);
            ham.HienThiDLDG(dataGridView1, "Select * from Diem", conn);
            ham.HienThiDLComb(cb_hoc_ky, "SELECT MAHOCKY, TENHOCKY FROM HOCKY", conn, "TENHOCKY", "MAHOCKY");
            ham.HienThiDLComb(cb_mon, "SELECT MaMonHoc, TenMonHoc FROM MonHoc", conn, "TenMonHoc", "MaMonHoc");
            

           
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
            string maHocSinh = txt_ma_hs.Text;
            string maMon = cb_mon.SelectedValue.ToString();
            string maHocKy = cb_hoc_ky.SelectedValue.ToString();
            string diemmieng = txt_mieng.Text;
            string diem15 = txt_15p.Text;
            string diem1t = txt_1t.Text;
            string diemthi= txt_thi.Text;
            string query = "INSERT INTO Diem VALUES ('" + maDiem + "','" + maHocSinh + "','" + maMon + "','" + maHocKy + "','" + diemmieng + "','" + diem15 + "','" + diem1t + "','" + diemthi + "')";
            ham.capnhat(query, conn);       
            ham.HienThiDLDG(dataGridView1, "Select * from Diem", conn);

            clearALL();
        }

        private void txt_ma_hs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ma_diem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maDiem = txt_ma_diem.Text;
            string maHocSinh = txt_ma_hs.Text;
            string maMon = cb_mon.SelectedValue.ToString();
            string maHocKy = cb_hoc_ky.SelectedValue.ToString();
            string diemmieng = txt_mieng.Text;
            string diem15 = txt_15p.Text;
            string diem1t = txt_1t.Text;
            string diemthi = txt_thi.Text;
            string query = "UPDATE Diem SET MaHocSinh = '" + maHocSinh + "',MaMon = '" + maMon + "',MaHocKy = '" + maHocKy + "',DiemMieng = '" + diemmieng + "',Diem15Phut = '" + diem15 + "',Diem1Tiet = '" + diem1t + "',DiemThi = '" + diemthi + "' Where MADIEM='" + maDiem + "';";
            ham.capnhat(query, conn);
            ham.HienThiDLDG(dataGridView1, "Select * from Diem", conn);
            clearALL();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maDiem = txt_ma_diem.Text;
            string query = "DELETE From Diem Where MaHocSinh = '" + maDiem + "'";
            ham.capnhat(query, conn);
            ham.HienThiDLDG(dataGridView1, "Select * from Diem", conn);
            clearALL();
        }
        public void clearALL()
        {
            txt_ma_diem.Text = "";
            txt_ma_hs.Text = "";
            cb_mon.SelectedValue = "";
            cb_hoc_ky.SelectedValue = "";
            txt_mieng.Text = "";
            txt_15p.Text = "";
            txt_1t.Text = "";
            txt_thi.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma_diem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
            txt_ma_hs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            cb_mon.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
            cb_hoc_ky.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
            txt_mieng.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            txt_15p.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
            txt_1t.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
            txt_thi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); ;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearALL();
        }

       
    }
}
      
