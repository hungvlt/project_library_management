using QLThuVien_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class UserControlTacGia : UserControl
  {
    private List<TacGia> danhSachTacGia = new List<TacGia>();
    private TacGia tacGiaHienTai = null;

    public UserControlTacGia()
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
          danhSachTacGia = context.TacGias.AsNoTracking().ToList();
        }

        HienThiDanhSachTacGia();
        lblTongTacGia.Text = danhSachTacGia.Count.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        tacGiaHienTai = new TacGia
        {
          MaTacGia = txtMaTacGia.Text,
          TenTacGia = txtTenTacGia.Text,
          QuocTich = txtQuocTich.Text,
          DiaChi = txtDiaChi.Text,
          GioiTinh = cmbGioiTinh.SelectedItem.ToString(),
          NgaySinh = dtpNgaySinh.Value,
          SoDienThoai = txtSoDienThoai.Text
        };

        try
        {
          using (var context = new QLThuVienContextDB_1())
          {
            if (context.TacGias.Any(tg => tg.MaTacGia == tacGiaHienTai.MaTacGia))
            {
              MessageBox.Show("Mã tác giả đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập mã khác.");
              return;
            }

            context.TacGias.Add(tacGiaHienTai);
            context.SaveChanges();
          }

          danhSachTacGia.Add(tacGiaHienTai);
          HienThiDanhSachTacGia();
          lblTongTacGia.Text = danhSachTacGia.Count.ToString();
          ClearInputFields();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm tác giả: " + ex.Message);
        }
      }
    }

    private bool ValidateInput()
    {
      if (string.IsNullOrWhiteSpace(txtMaTacGia.Text) ||
          string.IsNullOrWhiteSpace(txtTenTacGia.Text) ||
          string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          txtSoDienThoai.Text.Length != 10 ||
          !long.TryParse(txtSoDienThoai.Text, out _) ||
          string.IsNullOrWhiteSpace(txtQuocTich.Text) ||
          string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
          cmbGioiTinh.SelectedItem == null)
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.");
        return false;
      }

      if (dtpNgaySinh.Value > DateTime.Now)
      {
        MessageBox.Show("Ngày sinh không hợp lệ.");
        return false;
      }

      return true;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (tacGiaHienTai != null)
      {
        tacGiaHienTai.TenTacGia = txtTenTacGia.Text;
        tacGiaHienTai.QuocTich = txtQuocTich.Text;
        tacGiaHienTai.DiaChi = txtDiaChi.Text;
        tacGiaHienTai.GioiTinh = cmbGioiTinh.SelectedItem?.ToString();
        tacGiaHienTai.NgaySinh = dtpNgaySinh.Value;
        tacGiaHienTai.SoDienThoai = txtSoDienThoai.Text;

        try
        {
          using (var context = new QLThuVienContextDB_1())
          {
            context.Entry(tacGiaHienTai).State = EntityState.Modified;
            context.SaveChanges();
          }

          HienThiDanhSachTacGia();
          lblTongTacGia.Text = danhSachTacGia.Count.ToString();
          ClearInputFields();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi chỉnh sửa tác giả: " + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một tác giả để chỉnh sửa.");
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (tacGiaHienTai != null)
      {
        try
        {
          using (var context = new QLThuVienContextDB_1())
          {
            context.TacGias.Remove(tacGiaHienTai);
            context.SaveChanges();
          }

          danhSachTacGia.Remove(tacGiaHienTai);
          HienThiDanhSachTacGia();
          lblTongTacGia.Text = danhSachTacGia.Count.ToString();
          ClearInputFields();
          tacGiaHienTai = null;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi xóa tác giả: " + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một tác giả để xóa.");
      }
    }

    private void HienThiDanhSachTacGia()
    {
      dgvQuanLyTacGia.DataSource = null;
      dgvQuanLyTacGia.DataSource = danhSachTacGia.ToList(); // Liên kết lại
    }

    private void ClearInputFields()
    {
      txtMaTacGia.Clear();
      txtTenTacGia.Clear();
      txtQuocTich.Clear();
      txtDiaChi.Clear();
      cmbGioiTinh.SelectedItem = null;
      dtpNgaySinh.Value = DateTime.Now;
      txtSoDienThoai.Clear();
      txtMaTacGia.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearInputFields();
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower();
      var filteredList = danhSachTacGia
          .Where(tg => tg.TenTacGia.ToLower().Contains(searchText))
          .ToList();

      dgvQuanLyTacGia.DataSource = null;
      dgvQuanLyTacGia.DataSource = filteredList;
    }

    private void dgvQuanLyTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        tacGiaHienTai = (TacGia)dgvQuanLyTacGia.Rows[e.RowIndex].DataBoundItem;

        txtMaTacGia.Text = tacGiaHienTai.MaTacGia;
        txtTenTacGia.Text = tacGiaHienTai.TenTacGia;
        txtQuocTich.Text = tacGiaHienTai.QuocTich;
        txtDiaChi.Text = tacGiaHienTai.DiaChi;
        cmbGioiTinh.SelectedItem = tacGiaHienTai.GioiTinh;
        dtpNgaySinh.Value = tacGiaHienTai.NgaySinh ?? DateTime.Now;
        txtSoDienThoai.Text = tacGiaHienTai.SoDienThoai;
      }
    }
  }
}