using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmTheLuuDong : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmTheLuuDong()
        {
            InitializeComponent();
            LoadTheLuuDong();
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            // code nút thêm thẻ lưu động cho danh sách
            try
            {
                TheLuuDong the = new TheLuuDong
                {
                    MaThe = txtMaThe.Text,
                    ChuSoHuu = txtChuSoHuu.Text,
                    TrangThai = chkHoatDong.Checked
                };
                using (PolyCafeDataContext db = new PolyCafeDataContext())
                {
                    db.TheLuuDongs.InsertOnSubmit(the);
                    db.SubmitChanges();
                }
                MessageBox.Show("Thêm thẻ lưu động thành công!");
                LoadTheLuuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frmTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadTheLuuDong();
        }

        private void LoadTheLuuDong()
        {
            var list = db.TheLuuDongs
                .Select(t => new
                {
                    t.MaThe,
                    t.ChuSoHuu,
                    TrangThai = t.TrangThai ? "Hoạt động" : "Không hoạt động"
                })
                .ToList();
            dgvTheLuuDong.DataSource = list;
            dgvTheLuuDong.Columns["MaThe"].HeaderText = "Mã thẻ";
            dgvTheLuuDong.Columns["ChuSoHuu"].HeaderText = "Chủ sở hữu";
            dgvTheLuuDong.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // code nút sửa thẻ lưu động cho danh sách
            try
            {
                string maThe = txtMaThe.Text;
                TheLuuDong the = db.TheLuuDongs.FirstOrDefault(t => t.MaThe == maThe);
                if (the != null)
                {
                    the.ChuSoHuu = txtChuSoHuu.Text;
                    the.TrangThai = chkHoatDong.Checked;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thẻ lưu động thành công!");
                    LoadTheLuuDong();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ lưu động với mã: " + maThe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            chkHoatDong.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // code nút xóa thẻ lưu động cho danh sách
            try
            {
                string maThe = txtMaThe.Text;
                TheLuuDong the = db.TheLuuDongs.FirstOrDefault(t => t.MaThe == maThe);
                if (the != null)
                {
                    db.TheLuuDongs.DeleteOnSubmit(the);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thẻ lưu động thành công!");
                    LoadTheLuuDong();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ lưu động với mã: " + maThe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvTheLuuDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị thông tin thẻ lưu động khi click vào dòng
            if (e.RowIndex >= 0 && e.RowIndex < dgvTheLuuDong.Rows.Count)
            {
                DataGridViewRow row = dgvTheLuuDong.Rows[e.RowIndex];
                txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
                txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();
                chkHoatDong.Checked = row.Cells["TrangThai"].Value.ToString() == "Hoạt động";
            }
        }
    }
}
