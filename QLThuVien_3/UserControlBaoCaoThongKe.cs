using System;
using System.Linq;
using System.Windows.Forms;
using QLThuVien_3.Models;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System.Drawing;

namespace QLThuVien_3
{
  public partial class UserControlBaoCaoThongKe : UserControl
  {
    private UserControlDanhMucSach userControlDanhMucSach;

    public UserControlBaoCaoThongKe()
    {
      InitializeComponent();
      userControlDanhMucSach = new UserControlDanhMucSach();
      userControlDanhMucSach.OnDataChanged += UpdateStatistics;

      // Gán sự kiện Load cho UserControl
      this.Load += UserControlBaoCaoThongKe_Load;
    }

    private void UserControlBaoCaoThongKe_Load(object sender, EventArgs e)
    {
      LoadStatistics();
      LoadReportData();
    }

    private void LoadReportData()
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
                           TenTacGia = tacGia.TenTacGia,
                           TenNhanVien = nhanVien.TenNhanVien,
                           NgayMuon = muonSach.NgayMuon,
                           NgayTra = muonSach.NgayTra,
                           TrangThai = muonSach.TrangThai
                         };

        dgvBaoCaoThongKe.DataSource = reportData.ToList(); // Cập nhật DataGridView

        // Thiết lập tiêu đề cho các cột
        dgvBaoCaoThongKe.Columns["STT"].HeaderText = "Số Thứ Tự";
        dgvBaoCaoThongKe.Columns["MaDocGia"].HeaderText = "Mã Độc Giả";
        dgvBaoCaoThongKe.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
        dgvBaoCaoThongKe.Columns["MaSach"].HeaderText = "Mã Sách";
        dgvBaoCaoThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
        dgvBaoCaoThongKe.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
        dgvBaoCaoThongKe.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
        dgvBaoCaoThongKe.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
        dgvBaoCaoThongKe.Columns["NgayTra"].HeaderText = "Ngày Trả";
        dgvBaoCaoThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";

        foreach (DataGridViewColumn column in dgvBaoCaoThongKe.Columns)
        {
          column.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }

        dgvBaoCaoThongKe.RowTemplate.Height = 35;
      }
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

        // Tổng số lượng sách
        var totalQuantity = context.DanhMucSaches.Sum(s => s.SoLuong ?? 0);
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
      }
    }

    private void UpdateStatistics()
    {
      LoadStatistics(); // Cập nhật lại khi có thay đổi dữ liệu
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoMa.Text.Trim(); // Lấy giá trị tìm kiếm

      using (var context = new QLThuVienContextDB())
      {
        var reportData = from muonSach in context.MuonSaches
                         join docGia in context.DocGias on muonSach.MaDocGia equals docGia.MaDocGia
                         join sach in context.DanhMucSaches on muonSach.MaSach equals sach.MaSach
                         join tacGia in context.TacGias on sach.MaTacGia equals tacGia.MaTacGia
                         join nhanVien in context.NhanViens on muonSach.MaNhanVien equals nhanVien.MaNhanVien
                         where docGia.TenDocGia.Contains(searchText) // Tìm kiếm theo tên độc giả
                         select new
                         {
                           STT = muonSach.MaMuon,
                           MaDocGia = muonSach.MaDocGia,
                           TenDocGia = docGia.TenDocGia,
                           MaSach = muonSach.MaSach,
                           TenSach = sach.TenSach,
                           TenTacGia = tacGia.TenTacGia,
                           TenNhanVien = nhanVien.TenNhanVien,
                           NgayMuon = muonSach.NgayMuon,
                           NgayTra = muonSach.NgayTra,
                           TrangThai = muonSach.TrangThai
                         };

        dgvBaoCaoThongKe.DataSource = reportData.ToList(); // Cập nhật DataGridView

        // Thiết lập tiêu đề cho các cột
        dgvBaoCaoThongKe.Columns["STT"].HeaderText = "Số Thứ Tự";
        dgvBaoCaoThongKe.Columns["MaDocGia"].HeaderText = "Mã Độc Giả";
        dgvBaoCaoThongKe.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
        dgvBaoCaoThongKe.Columns["MaSach"].HeaderText = "Mã Sách";
        dgvBaoCaoThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
        dgvBaoCaoThongKe.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
        dgvBaoCaoThongKe.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
        dgvBaoCaoThongKe.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
        dgvBaoCaoThongKe.Columns["NgayTra"].HeaderText = "Ngày Trả";
        dgvBaoCaoThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";

      }
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      string filePath = Path.Combine(desktopPath, "BaoCaoThongKe.xlsx");

      using (ExcelPackage excelPackage = new ExcelPackage())
      {
        var worksheet = excelPackage.Workbook.Worksheets.Add("Báo Cáo Thống Kê");

        // Thiết lập tiêu đề cột và định dạng
        for (int i = 0; i < dgvBaoCaoThongKe.Columns.Count; i++)
        {
          worksheet.Cells[1, i + 1].Value = dgvBaoCaoThongKe.Columns[i].HeaderText;
          worksheet.Cells[1, i + 1].Style.Font.Bold = true; // Đặt tiêu đề in đậm
          worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
          worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray); // Màu nền cho tiêu đề
        }

        // Xuất dữ liệu từ DataGridView
        for (int i = 0; i < dgvBaoCaoThongKe.Rows.Count; i++)
        {
          for (int j = 0; j < dgvBaoCaoThongKe.Columns.Count; j++)
          {
            worksheet.Cells[i + 2, j + 1].Value = dgvBaoCaoThongKe.Rows[i].Cells[j].Value;
          }
        }

        // Tạo bảng
        var tableRange = worksheet.Cells[1, 1, dgvBaoCaoThongKe.Rows.Count + 1, dgvBaoCaoThongKe.Columns.Count];
        var table = worksheet.Tables.Add(tableRange, "Table_BaoCao");
        table.TableStyle = TableStyles.Medium9; // Chọn kiểu bảng

        // Căn chỉnh kích thước cột theo nội dung
        worksheet.Cells.AutoFitColumns();

        // Thiết lập đường viền cho bảng
        using (var borderRange = tableRange)
        {
          borderRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
          borderRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
          borderRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
          borderRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;

          // Đường viền dày cho bảng
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
  }
}

