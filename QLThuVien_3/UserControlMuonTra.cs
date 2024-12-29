using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class UserControlMuonTra : UserControl
  {
    private List<MuonSach> danhSachMuonSach = new List<MuonSach>();
    private List<MuonSach> danhSachMuonSachHienTai = new List<MuonSach>();
    private MuonSach muonSachHienTai = null;
    private bool isChangingText = false;

    public UserControlMuonTra()
    {
      InitializeComponent();
      InitializeDataGridView();
      LoadData();
      LoadComboBoxes();
      ClearInputFields();
      SetReadOnlyFields();
    }

    private void InitializeDataGridView()
    {
      dgvQuanLyMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      dgvQuanLyMuonTra.Columns.Add("MaMuon", "Mã phiếu mượn");
      dgvQuanLyMuonTra.Columns.Add("MaDocGia", "Mã độc giả");
      dgvQuanLyMuonTra.Columns.Add("TenDocGia", "Tên độc giả");
      dgvQuanLyMuonTra.Columns.Add("MaSach", "Mã sách");
      dgvQuanLyMuonTra.Columns.Add("TenSach", "Tên sách");
      dgvQuanLyMuonTra.Columns.Add("MaNhanVien", "Mã nhân viên");
      dgvQuanLyMuonTra.Columns.Add("TenNhanVien", "Tên nhân viên");
      dgvQuanLyMuonTra.Columns.Add("NgayMuon", "Ngày mượn");
      dgvQuanLyMuonTra.Columns.Add("NgayTra", "Ngày trả");
      dgvQuanLyMuonTra.Columns.Add("NgayTraThucTe", "Ngày trả thực tế");
      dgvQuanLyMuonTra.Columns.Add("TrangThai", "Trạng thái");

      foreach (DataGridViewColumn column in dgvQuanLyMuonTra.Columns)
      {
        column.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
      }

      dgvQuanLyMuonTra.RowTemplate.Height = 35;
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB())
        {
          danhSachMuonSach = context.MuonSaches
              .Include(ms => ms.DocGia)
              .Include(ms => ms.DanhMucSach)
              .Include(ms => ms.NhanVien)
              .ToList();
        }
        danhSachMuonSachHienTai = danhSachMuonSach;
        HienThiDanhSachMuonSach();
        UpdateTotalReceipts();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void HienThiDanhSachMuonSach()
    {
      dgvQuanLyMuonTra.Rows.Clear();
      foreach (var muonSach in danhSachMuonSachHienTai)
      {
        AddMuonSachToGrid(muonSach);
      }
    }

    private void AddMuonSachToGrid(MuonSach muonSach)
    {
      int rowIndex = dgvQuanLyMuonTra.Rows.Add();
      DataGridViewRow row = dgvQuanLyMuonTra.Rows[rowIndex];

      row.Cells["MaMuon"].Value = muonSach.MaMuon;
      row.Cells["MaDocGia"].Value = muonSach.MaDocGia;
      row.Cells["TenDocGia"].Value = muonSach.DocGia?.TenDocGia;
      row.Cells["MaSach"].Value = muonSach.MaSach;
      row.Cells["TenSach"].Value = muonSach.DanhMucSach?.TenSach;
      row.Cells["MaNhanVien"].Value = muonSach.MaNhanVien;
      row.Cells["TenNhanVien"].Value = muonSach.NhanVien?.TenNhanVien;
      row.Cells["NgayMuon"].Value = muonSach.NgayMuon.ToShortDateString();
      row.Cells["NgayTra"].Value = muonSach.NgayTra?.ToShortDateString();
      row.Cells["NgayTraThucTe"].Value = muonSach.NgayTraThucTe?.ToShortDateString();
      row.Cells["TrangThai"].Value = muonSach.TrangThai;
    }

    private void LoadComboBoxes()
    {
      using (var context = new QLThuVienContextDB())
      {
        cmbMaDocGia.DataSource = context.DocGias.ToList();
        cmbMaDocGia.DisplayMember = "MaDocGia";
        cmbMaDocGia.ValueMember = "MaDocGia";

        cmbMaSach.DataSource = context.DanhMucSaches.ToList();
        cmbMaSach.DisplayMember = "MaSach";
        cmbMaSach.ValueMember = "MaSach";

        cmbMaNhanVien.DataSource = context.NhanViens.ToList();
        cmbMaNhanVien.DisplayMember = "MaNhanVien";
        cmbMaNhanVien.ValueMember = "MaNhanVien";
      }
    }

    private void SetReadOnlyFields()
    {
      txtMaMuon.ReadOnly = true;
      txtTenDocGia.ReadOnly = true;
      txtTenSach.ReadOnly = true;
      txtTenNhanVien.ReadOnly = true;
      txtTrangThai.ReadOnly = true;
    }

    private bool ValidateInput()
    {
      List<string> errors = new List<string>();

      if (cmbMaDocGia.SelectedValue == null)
      {
        errors.Add("Vui lòng chọn mã độc giả.");
      }

      if (cmbMaSach.SelectedValue == null)
      {
        errors.Add("Vui lòng chọn mã sách.");
      }

      if (cmbMaNhanVien.SelectedValue == null)
      {
        errors.Add("Vui lòng chọn mã nhân viên.");
      }

      if (errors.Count > 0)
      {
        MessageBox.Show(string.Join(Environment.NewLine, errors), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      return true;
    }

    private string GenerateMaMuon()
    {
      using (var context = new QLThuVienContextDB())
      {
        // Lấy mã mượn lớn nhất hiện tại
        var lastMaMuon = context.MuonSaches
            .OrderByDescending(ms => ms.MaMuon)
            .Select(ms => ms.MaMuon)
            .FirstOrDefault();

        // Tạo mã mới
        int newMaMuonNumber = 1; // Mặc định bắt đầu từ 1
        if (lastMaMuon != null)
        {
          // Lấy phần số từ mã mượn cuối
          string numberPart = lastMaMuon.Substring(2); // Lấy phần xxx
          newMaMuonNumber = int.Parse(numberPart) + 1; // Tăng lên 1
        }

        // Đảm bảo mã mới không vượt quá 999
        if (newMaMuonNumber > 999)
        {
          throw new Exception("Đã đạt giới hạn số phiếu mượn.");
        }

        return "MM" + newMaMuonNumber.ToString("D3"); // Định dạng thành 3 chữ số
      }
    }

    private void btnMuon_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        string maMuon = GenerateMaMuon();
        string maDocGia = cmbMaDocGia.SelectedValue.ToString();
        int? maSach = cmbMaSach.SelectedValue != null ? (int?)cmbMaSach.SelectedValue : null;

        using (var context = new QLThuVienContextDB())
        {
          var phieuDangMuon = context.MuonSaches
              .FirstOrDefault(ms => ms.MaDocGia == maDocGia && ms.MaSach == maSach && ms.TrangThai == "Đang mượn");

          if (phieuDangMuon != null)
          {
            MessageBox.Show("Không thể mượn sách này vì độc giả đã có phiếu mượn sách tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }
        }

        muonSachHienTai = new MuonSach
        {
          MaMuon = maMuon,
          MaDocGia = maDocGia,
          MaSach = maSach,
          MaNhanVien = cmbMaNhanVien.SelectedValue.ToString(),
          NgayMuon = DateTime.Now,
          NgayTra = DateTime.Now.AddDays(14),
          TrangThai = "Đang mượn"
        };

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            context.MuonSaches.Add(muonSachHienTai);
            context.SaveChanges();
          }

          MessageBox.Show("Thêm phiếu mượn thành công! Mã mượn: " + maMuon);
          LoadData();
          ClearInputFields();
          UpdateTotalReceipts(); // Đảm bảo gọi phương thức này
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm phiếu mượn: " + ex.Message);
        }
      }
    }

    private void btnTra_Click(object sender, EventArgs e)
    {
      if (muonSachHienTai != null)
      {
        muonSachHienTai.NgayTraThucTe = DateTime.Now;
        muonSachHienTai.TrangThai = muonSachHienTai.NgayTraThucTe > muonSachHienTai.NgayTra ? "Trả muộn" : "Đã trả";

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            var phieuMuon = context.MuonSaches.Find(muonSachHienTai.MaMuon);
            if (phieuMuon == null)
            {
              MessageBox.Show("Phiếu mượn không tồn tại.");
              return;
            }

            if (phieuMuon.TrangThai != "Đang mượn")
            {
              MessageBox.Show("Phiếu này không thể trả vì chưa được mượn.");
              return;
            }

            phieuMuon.NgayTraThucTe = muonSachHienTai.NgayTraThucTe;
            phieuMuon.TrangThai = muonSachHienTai.TrangThai;

            var sach = context.DanhMucSaches.Find(muonSachHienTai.MaSach);
            if (sach == null)
            {
              MessageBox.Show("Sách không tồn tại.");
              return;
            }
            sach.SoLuong += 1;

            context.SaveChanges();
          }

          MessageBox.Show("Trả sách thành công!");
          LoadData();
          ClearInputFields();
          UpdateTotalReceipts();
        }
        catch (DbUpdateException ex)
        {
          MessageBox.Show("Lỗi cập nhật cơ sở dữ liệu: " + ex.InnerException?.Message);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi cập nhật phiếu trả: " + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một phiếu để trả.");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (muonSachHienTai != null)
      {
        if (muonSachHienTai.TrangThai != "Đã trả")
        {
          MessageBox.Show("Không thể xóa phiếu mượn vì sách vẫn đang được mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          try
          {
            using (var context = new QLThuVienContextDB())
            {
              var sachToDelete = context.MuonSaches.Find(muonSachHienTai.MaMuon);
              if (sachToDelete != null)
              {
                context.MuonSaches.Remove(sachToDelete);
                context.SaveChanges();
              }
              else
              {
                MessageBox.Show("Phiếu mượn không tồn tại trong cơ sở dữ liệu.");
              }
            }

            LoadData();
            ClearInputFields();
            muonSachHienTai = null;
            UpdateTotalReceipts(); // Cập nhật lại tổng số phiếu
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một phiếu để xóa.");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
      LoadData();
    }

    private void ClearInputFields()
    {
      txtMaMuon.Clear();
      cmbMaDocGia.SelectedIndex = -1;
      cmbMaSach.SelectedIndex = -1;
      cmbMaNhanVien.SelectedIndex = -1;
      txtTrangThai.Clear();
      txtTenDocGia.Clear();
      txtTenSach.Clear();
      txtTenNhanVien.Clear();
    }

    private void UpdateTotalReceipts()
    {
      lblTongPhieu.Text = $"Tổng phiếu: {danhSachMuonSach.Count}";
    }

    private void cmbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbMaDocGia.SelectedValue != null)
      {
        var docGia = (DocGia)cmbMaDocGia.SelectedItem;
        txtTenDocGia.Text = docGia?.TenDocGia;
      }
    }

    private void cmbMaSach_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbMaSach.SelectedValue != null)
      {
        var sach = (DanhMucSach)cmbMaSach.SelectedItem;
        txtTenSach.Text = sach?.TenSach;
      }
    }

    private void cmbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbMaNhanVien.SelectedValue != null)
      {
        var nhanVien = (NhanVien)cmbMaNhanVien.SelectedItem;
        txtTenNhanVien.Text = nhanVien?.TenNhanVien;
      }
    }

    private void dgvQuanLyMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < danhSachMuonSachHienTai.Count)
      {
        muonSachHienTai = danhSachMuonSachHienTai[e.RowIndex];
        if (muonSachHienTai != null)
        {
          txtMaMuon.Text = muonSachHienTai.MaMuon;
          cmbMaDocGia.SelectedValue = muonSachHienTai.MaDocGia;
          cmbMaSach.SelectedValue = muonSachHienTai.MaSach;
          cmbMaNhanVien.SelectedValue = muonSachHienTai.MaNhanVien;
          dtpNgayMuon.Value = muonSachHienTai.NgayMuon;
          dtpNgayTra.Value = muonSachHienTai.NgayTra ?? DateTime.Now;
          txtTrangThai.Text = muonSachHienTai.TrangThai;

          txtTenDocGia.Text = muonSachHienTai.DocGia?.TenDocGia;
          txtTenNhanVien.Text = muonSachHienTai.NhanVien?.TenNhanVien;
          txtTenSach.Text = muonSachHienTai.DanhMucSach?.TenSach;
        }
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      // Ngăn chặn thay đổi văn bản
      if (isChangingText) return;

      // Lấy giá trị tìm kiếm
      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      // Kiểm tra xem người dùng có nhập vào không
      if (string.IsNullOrEmpty(searchText) || searchText == "tìm kiếm theo tên")
      {
        // Nếu không nhập gì, hiển thị lại danh sách đầy đủ
        danhSachMuonSachHienTai = danhSachMuonSach; // Đặt lại danh sách hiện tại
      }
      else
      {
        // Lọc danh sách theo tên độc giả
        danhSachMuonSachHienTai = danhSachMuonSach
            .Where(muonSach => muonSach.DocGia?.TenDocGia.ToLower().Contains(searchText) == true)
            .ToList();
      }

      // Cập nhật giao diện
      HienThiDanhSachMuonSach();
    }

    private void dgvQuanLyMuonTra_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
      {
        dgvQuanLyMuonTra.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
      else
      {
        dgvQuanLyMuonTra.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
      }
    }

    private void txtTimKiemTheoTen_Leave(object sender, EventArgs e)
    {
      // Kiểm tra và hiển thị watermark nếu TextBox trống
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text))
      {
        SetWatermark();
      }
    }

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Tìm kiếm theo tên")
      {
        isChangingText = true; // Đánh dấu là đang thay đổi văn bản
        txtTimKiemTheoTen.Text = ""; // Xóa watermark
        txtTimKiemTheoTen.ForeColor = Color.Black; // Đặt lại màu chữ
        txtTimKiemTheoTen.BackColor = Color.White; // Đặt lại màu nền
        isChangingText = false; // Đánh dấu kết thúc thay đổi
      }
    }

    private void SetWatermark()
    {
      if (isChangingText) return; // Ngăn chặn việc gọi lại do thay đổi văn bản

      // Kiểm tra và thiết lập watermark
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tìm kiếm theo tên")
      {
        isChangingText = true; // Đánh dấu là đang thay đổi văn bản
        txtTimKiemTheoTen.Text = "Tìm kiếm theo tên"; // Thiết lập watermark
        txtTimKiemTheoTen.ForeColor = Color.Gray; // Đặt màu chữ
        txtTimKiemTheoTen.BackColor = Color.LightGray; // Đặt màu nền
        isChangingText = false; // Đánh dấu kết thúc thay đổi
      }
      else
      {
        txtTimKiemTheoTen.ForeColor = Color.Black; // Đặt lại màu chữ
        txtTimKiemTheoTen.BackColor = Color.White; // Đặt lại màu nền
      }
    }

    private void UserControlMuonTra_Load(object sender, EventArgs e)
    {
      SetWatermark();
    }
  }
}