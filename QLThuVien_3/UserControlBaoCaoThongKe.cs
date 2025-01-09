using System;
using System.Linq;
using System.Windows.Forms;
using QLThuVien_3.Models;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System.Drawing;
using System.Windows.Input;

namespace QLThuVien_3
{
  public partial class UserControlBaoCaoThongKe : UserControl
  {
    private UserControlDanhMucSach userControlDanhMucSach;
    private bool isChangingText = false;

    public UserControlBaoCaoThongKe()
    {
      InitializeComponent();
      userControlDanhMucSach = new UserControlDanhMucSach();
      userControlDanhMucSach.OnDataChanged += UpdateStatistics;
    }

    private void UserControlBaoCaoThongKe_Load(object sender, EventArgs e)
    {
      LoadStatistics();
      LoadReportData();
      LoadStatusToComboBox();
      SetWatermark();
    }

    private void LoadStatusToComboBox()
    {
      cmbTrangThai.Items.Add("Tất cả");
      cmbTrangThai.Items.Add("Đã trả");
      cmbTrangThai.Items.Add("Đang mượn");
      cmbTrangThai.SelectedIndex = 0;
    }

    private void LoadReportData(string selectedStatus = "Tất cả")
    {
      using (var context = new QLThuVienContextDB())
      {
        var reportData = from muonSach in context.MuonSaches
                         join docGia in context.DocGias on muonSach.MaDocGia equals docGia.MaDocGia
                         join sach in context.DanhMucSaches on muonSach.MaSach equals sach.MaSach
                         join tacGia in context.TacGias on sach.MaTacGia equals tacGia.MaTacGia
                         join nhanVien in context.NhanViens on muonSach.MaNhanVien equals nhanVien.MaNhanVien
                         select new
                         {
                           STT = muonSach.MaMuon,
                           MaDocGia = muonSach.MaDocGia,
                           TenDocGia = docGia.TenDocGia,
                           MaSach = muonSach.MaSach,
                           TenSach = sach.TenSach,
                           SoLuongMuon = muonSach.SoLuongMuon,
                           TenTacGia = tacGia.TenTacGia,
                           TenNhanVien = nhanVien.TenNhanVien,
                           NgayMuon = muonSach.NgayMuon,
                           NgayTra = muonSach.NgayTra,
                           NgayTraThucTe = muonSach.NgayTraThucTe,
                           TrangThai = muonSach.TrangThai
                         };

        if (selectedStatus != "Tất cả")
        {
          reportData = reportData.Where(r => r.TrangThai == selectedStatus);
        }

        dgvBaoCaoThongKe.DataSource = reportData.ToList();
        txtSoDong.Text = dgvBaoCaoThongKe.Rows.Count + " dòng";
        SetDataGridViewColumnHeaders();
      }
    }

    private void SetDataGridViewColumnHeaders()
    {
      dgvBaoCaoThongKe.Columns["STT"].HeaderText = "Số Thứ Tự";
      dgvBaoCaoThongKe.Columns["MaDocGia"].HeaderText = "Mã Độc Giả";
      dgvBaoCaoThongKe.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
      dgvBaoCaoThongKe.Columns["MaSach"].HeaderText = "Mã Sách";
      dgvBaoCaoThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
      dgvBaoCaoThongKe.Columns["SoLuongMuon"].HeaderText = "Số Lượng Mượn";
      dgvBaoCaoThongKe.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
      dgvBaoCaoThongKe.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
      dgvBaoCaoThongKe.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
      dgvBaoCaoThongKe.Columns["NgayTra"].HeaderText = "Ngày Trả";
      dgvBaoCaoThongKe.Columns["NgayTraThucTe"].HeaderText = "Ngày Trả Thực Tế";
      dgvBaoCaoThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";

      foreach (DataGridViewColumn column in dgvBaoCaoThongKe.Columns)
      {
        column.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
      }

      dgvBaoCaoThongKe.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
      dgvBaoCaoThongKe.RowTemplate.Height = 35;
    }

    private void LoadStatistics()
    {
      using (var context = new QLThuVienContextDB())
      {
        // Tổng đầu sách
        var totalBooks = context.DanhMucSaches.Count();
        txtTongDauSach.Text = totalBooks.ToString();

        // Tổng tác giả
        var totalAuthors = context.TacGias.Count();
        txtTongTacGia.Text = totalAuthors.ToString();

        // Tổng độc giả
        var totalReaders = context.DocGias.Count();
        txtTongDocGia.Text = totalReaders.ToString();

        // Tổng nhân viên
        var totalStaff = context.NhanViens.Count();
        txtTongNhanVien.Text = totalStaff.ToString();

        // Tổng số lượng sách (tính từ danh mục sách) 
        var totalQuantity = context.DanhMucSaches.Sum(s => (int?)s.SoLuong) ?? 0;

        // Thêm số lượng sách mượn từ phiếu mượn đang có trạng thái "Đang mượn"
        var totalQuantityBorrowed = context.MuonSaches
            .Where(l => l.TrangThai == "Đang mượn")
            .Sum(l => l.SoLuongMuon);

        totalQuantity += totalQuantityBorrowed;
        txtTongSoLuongSach.Text = totalQuantity.ToString();

        // Tổng phiếu mượn
        var totalLoans = context.MuonSaches.Count();
        txtTongPhieuMuon.Text = totalLoans.ToString();

        // Phiếu đang mượn
        var totalCurrentLoans = context.MuonSaches.Count(l => l.TrangThai == "Đang mượn");
        txtPhieuDangMuon.Text = totalCurrentLoans.ToString();

        // Phiếu đã trả
        var totalReturnedLoans = context.MuonSaches.Count(l => l.TrangThai == "Đã trả");
        txtPhieuDaTra.Text = totalReturnedLoans.ToString();

        // Tính tổng sách còn lại (cập nhật theo sách đã mượn)
        var totalBooksLeft = context.DanhMucSaches.Sum(s => (int?)s.SoLuong) ?? 0;
        txtTongSachHienCon.Text = totalBooksLeft.ToString();
      }
    }

    private void UpdateStatistics()
    {
      LoadStatistics();
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show("Bạn có chắc chắn muốn xuất dữ liệu ra file Excel?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result != DialogResult.Yes) return;

      string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      string filePath = Path.Combine(desktopPath, "BaoCaoThongKe.xlsx");

      using (ExcelPackage excelPackage = new ExcelPackage())
      {
        var worksheet = excelPackage.Workbook.Worksheets.Add("Báo Cáo Thống Kê");

        // Thiết lập tiêu đề cột và định dạng
        for (int i = 0; i < dgvBaoCaoThongKe.Columns.Count; i++)
        {
          worksheet.Cells[1, i + 1].Value = dgvBaoCaoThongKe.Columns[i].HeaderText;
          worksheet.Cells[1, i + 1].Style.Font.Bold = true;
          worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
          worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
        }

        // Xuất dữ liệu từ DataGridView
        for (int i = 0; i < dgvBaoCaoThongKe.Rows.Count; i++)
        {
          for (int j = 0; j < dgvBaoCaoThongKe.Columns.Count; j++)
          {
            var cellValue = dgvBaoCaoThongKe.Rows[i].Cells[j].Value;

            // Gán giá trị cho ô
            worksheet.Cells[i + 2, j + 1].Value = cellValue;

            if (dgvBaoCaoThongKe.Columns[j].Name == "NgayMuon" ||
                dgvBaoCaoThongKe.Columns[j].Name == "NgayTra" ||
                dgvBaoCaoThongKe.Columns[j].Name == "NgayTraThucTe")
            {
              // Chuyển đổi giá trị sang DateTime nếu có thể
              if (cellValue is DateTime dateValue)
              {
                worksheet.Cells[i + 2, j + 1].Value = dateValue;
                worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "MM/dd/yyyy";
              }
            }
          }
        }

        // Tạo bảng
        var tableRange = worksheet.Cells[1, 1, dgvBaoCaoThongKe.Rows.Count + 1, dgvBaoCaoThongKe.Columns.Count];
        var table = worksheet.Tables.Add(tableRange, "Table_BaoCao");
        table.TableStyle = TableStyles.Medium9;

        worksheet.Cells.AutoFitColumns();

        // Thiết lập đường viền cho bảng
        using (var borderRange = tableRange)
        {
          borderRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
          borderRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
          borderRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
          borderRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;

          borderRange.Style.Border.Top.Color.SetColor(System.Drawing.Color.Black);
          borderRange.Style.Border.Bottom.Color.SetColor(System.Drawing.Color.Black);
          borderRange.Style.Border.Left.Color.SetColor(System.Drawing.Color.Black);
          borderRange.Style.Border.Right.Color.SetColor(System.Drawing.Color.Black);
        }

        // Lưu file
        FileInfo excelFile = new FileInfo(filePath);
        excelPackage.SaveAs(excelFile);
      }

      MessageBox.Show("Đã xuất thành công vào Desktop!");
    }

    private void dgvBaoCaoThongKe_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
      {
        dgvBaoCaoThongKe.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
      else
      {
        dgvBaoCaoThongKe.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
      }
    }

    private void SetWatermark()
    {
      if (isChangingText) return;

      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Mã nhân viên/Mã phiếu")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "Mã nhân viên/Mã phiếu";
        txtTimKiemTheoTen.ForeColor = Color.Gray;
        txtTimKiemTheoTen.BackColor = Color.LightGray;
        isChangingText = false;
      }
      else
      {
        txtTimKiemTheoTen.ForeColor = Color.Black;
        txtTimKiemTheoTen.BackColor = Color.White;
      }
    }

    private void txtTimKiemTheoTen_Enter(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Mã nhân viên/Mã phiếu")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "";
        txtTimKiemTheoTen.ForeColor = Color.Black;
        txtTimKiemTheoTen.BackColor = Color.White;
        isChangingText = false;
      }
    }

    private void txtTimKiemTheoTen_Leave(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text))
      {
        SetWatermark();
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.Trim();

      using (var context = new QLThuVienContextDB())
      {
        if (!string.IsNullOrEmpty(searchText) && searchText != "Mã nhân viên/Mã phiếu")
        {
          var reportData = from muonSach in context.MuonSaches
                           join docGia in context.DocGias on muonSach.MaDocGia equals docGia.MaDocGia
                           join sach in context.DanhMucSaches on muonSach.MaSach equals sach.MaSach
                           join tacGia in context.TacGias on sach.MaTacGia equals tacGia.MaTacGia
                           join nhanVien in context.NhanViens on muonSach.MaNhanVien equals nhanVien.MaNhanVien
                           where nhanVien.MaNhanVien.Contains(searchText) || muonSach.MaMuon.Contains(searchText)
                           select new
                           {
                             STT = muonSach.MaMuon,
                             MaDocGia = muonSach.MaDocGia,
                             TenDocGia = docGia.TenDocGia,
                             MaSach = muonSach.MaSach,
                             TenSach = sach.TenSach,
                             SoLuongMuon = muonSach.SoLuongMuon,
                             TenTacGia = tacGia.TenTacGia,
                             TenNhanVien = nhanVien.TenNhanVien,
                             NgayMuon = muonSach.NgayMuon,
                             NgayTra = muonSach.NgayTra,
                             NgayTraThucTe = muonSach.NgayTraThucTe,
                             TrangThai = muonSach.TrangThai
                           };

          dgvBaoCaoThongKe.DataSource = reportData.ToList();
          txtSoDong.Text = $"{dgvBaoCaoThongKe.Rows.Count} dòng";
          SetDataGridViewColumnHeaders();
        }
        else
        {
          LoadReportData();
        }
      }
    }

    private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
    {
      string selectedStatus = cmbTrangThai.SelectedItem.ToString();
      LoadReportData(selectedStatus);
    }

    private void txtMaDocGia_TextChanged(object sender, EventArgs e)
    {
      string maDocGia = txtMaDocGia.Text.Trim();
      string selectedStatus = cmbTrangThai.SelectedItem != null ? cmbTrangThai.SelectedItem.ToString() : "Tất cả";

      using (var context = new QLThuVienContextDB())
      {
        if (!string.IsNullOrEmpty(maDocGia))
        {
          var totalLoans = context.MuonSaches.Count(ms => ms.MaDocGia == maDocGia);

          var totalQuantity = context.MuonSaches
              .Where(ms => ms.MaDocGia == maDocGia && ms.TrangThai == "Đang mượn")
              .Select(ms => ms.SoLuongMuon)
              .DefaultIfEmpty(0)
              .Sum();

          var totalBooks = context.MuonSaches
              .Where(ms => ms.MaDocGia == maDocGia)
              .Select(ms => ms.SoLuongMuon)
              .DefaultIfEmpty(0)
              .Sum();

          txtSoLuongPhieuMuonVaSach.Text = $"Phiếu mượn: {totalLoans} | Sách mượn: {totalBooks} | Sách đang mượn: {totalQuantity}";

          var reportData = from muonSach in context.MuonSaches
                           join docGia in context.DocGias on muonSach.MaDocGia equals docGia.MaDocGia
                           join sach in context.DanhMucSaches on muonSach.MaSach equals sach.MaSach
                           join tacGia in context.TacGias on sach.MaTacGia equals tacGia.MaTacGia
                           join nhanVien in context.NhanViens on muonSach.MaNhanVien equals nhanVien.MaNhanVien
                           where muonSach.MaDocGia == maDocGia
                           && (selectedStatus == "Tất cả" || muonSach.TrangThai == selectedStatus)
                           select new
                           {
                             STT = muonSach.MaMuon,
                             MaDocGia = muonSach.MaDocGia,
                             TenDocGia = docGia.TenDocGia,
                             MaSach = muonSach.MaSach,
                             TenSach = sach.TenSach,
                             SoLuongMuon = muonSach.SoLuongMuon,
                             TenTacGia = tacGia.TenTacGia,
                             TenNhanVien = nhanVien.TenNhanVien,
                             NgayMuon = muonSach.NgayMuon,
                             NgayTra = muonSach.NgayTra,
                             NgayTraThucTe = muonSach.NgayTraThucTe,
                             TrangThai = muonSach.TrangThai
                           };

          dgvBaoCaoThongKe.DataSource = reportData.ToList();
          txtSoDong.Text = $"{dgvBaoCaoThongKe.Rows.Count} dòng";
        }
        else
        {
          txtSoLuongPhieuMuonVaSach.Text = "";
          dgvBaoCaoThongKe.DataSource = null;
          txtSoDong.Text = "";
        }
      }
    }

    private void txtSoDong_TextChanged(object sender, EventArgs e)
    {
    }
  }
}