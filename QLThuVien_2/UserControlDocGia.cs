using QLThuVien_2.Models; // Đảm bảo bạn đã có lớp DocGia trong Models
using System;
using System.Collections.Generic;
using System.Data.Entity; // Đảm bảo bạn đã cài đặt Entity Framework
using System.Linq;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class UserControlDocGia : UserControl
  {
    private List<DocGia> danhSachDocGia = new List<DocGia>();
    private DocGia docGiaHienTai = null;

    public UserControlDocGia()
    {
      InitializeComponent();
      LoadData();
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB_1())
        {
          danhSachDocGia = context.DocGias.ToList(); // Tải danh sách độc giả từ cơ sở dữ liệu
        }

        HienThiDanhSachDocGia();
        lblTongDocGia.Text = danhSachDocGia.Count.ToString(); // Cập nhật số lượng độc giả
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void HienThiDanhSachDocGia()
    {
      dgvQuanLyDocGia.DataSource = null; // Đặt lại nguồn dữ liệu
      dgvQuanLyDocGia.DataSource = danhSachDocGia; // Cập nhật DataGridView với danh sách mới
    }

    private void ClearInputFields()
    {
      txtMaDocGia.Clear();
      txtTenDocGia.Clear();
      txtSoDienThoai.Clear();
      txtDiaChi.Clear();
      rdoNam.Checked = false;
      rdoNu.Checked = false;
      txtMaDocGia.Focus();
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower();
      var filteredList = danhSachDocGia
          .Where(docGia => docGia.TenDocGia.ToLower().Contains(searchText))
          .ToList();

      dgvQuanLyDocGia.DataSource = null; // Đặt lại nguồn dữ liệu
      dgvQuanLyDocGia.DataSource = filteredList; // Cập nhật với danh sách đã lọc
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        docGiaHienTai = new DocGia
        {
          MaDocGia = txtMaDocGia.Text,
          TenDocGia = txtTenDocGia.Text,
          SoDienThoai = txtSoDienThoai.Text,
          GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
          DiaChi = txtDiaChi.Text
        };

        try
        {
          using (var context = new QLThuVienContextDB_1())
          {
            // Kiểm tra mã độc giả đã tồn tại
            if (context.DocGias.Any(dg => dg.MaDocGia == docGiaHienTai.MaDocGia))
            {
              MessageBox.Show("Mã độc giả đã tồn tại. Vui lòng nhập mã khác.");
              return;
            }

            // Thêm vào cơ sở dữ liệu
            context.DocGias.Add(docGiaHienTai);
            context.SaveChanges();
          }

          LoadData();
          ClearInputFields();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm độc giả: " + ex.Message);
        }
      }
    }

    private bool ValidateInput()
    {
      // Kiểm tra tất cả các trường nhập liệu
      if (string.IsNullOrWhiteSpace(txtMaDocGia.Text) ||
          string.IsNullOrWhiteSpace(txtTenDocGia.Text) ||
          string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          txtSoDienThoai.Text.Length != 10 ||
          !long.TryParse(txtSoDienThoai.Text, out _)) // Kiểm tra định dạng số điện thoại
      {
        MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp lệ.");
        return false;
      }

      return true;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (docGiaHienTai != null)
      {
        docGiaHienTai.TenDocGia = txtTenDocGia.Text;
        docGiaHienTai.SoDienThoai = txtSoDienThoai.Text;
        docGiaHienTai.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
        docGiaHienTai.DiaChi = txtDiaChi.Text;

        if (ValidateInput())
        {
          try
          {
            using (var context = new QLThuVienContextDB_1())
            {
              context.Entry(docGiaHienTai).State = EntityState.Modified; // Đánh dấu đối tượng là đã thay đổi
              context.SaveChanges();
            }

            LoadData();
            ClearInputFields();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi cập nhật độc giả: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một hàng để sửa.");
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (docGiaHienTai != null)
      {
        if (MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          try
          {
            using (var context = new QLThuVienContextDB_1())
            {
              context.DocGias.Remove(docGiaHienTai);
              context.SaveChanges();
            }

            LoadData();
            ClearInputFields();
            docGiaHienTai = null;
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi xóa độc giả: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một hàng để xóa.");
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearInputFields();
    }

    private void dgvQuanLyDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        docGiaHienTai = (DocGia)dgvQuanLyDocGia.Rows[e.RowIndex].DataBoundItem;

        txtMaDocGia.Text = docGiaHienTai.MaDocGia;
        txtTenDocGia.Text = docGiaHienTai.TenDocGia;
        txtSoDienThoai.Text = docGiaHienTai.SoDienThoai;
        txtDiaChi.Text = docGiaHienTai.DiaChi;
        rdoNam.Checked = docGiaHienTai.GioiTinh == "Nam";
        rdoNu.Checked = docGiaHienTai.GioiTinh == "Nữ";
      }
    }
  }
}