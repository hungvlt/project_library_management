using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class UserControlTacGia : UserControl
  {
    private List<TacGia> danhSachTacGia = new List<TacGia>();
    private List<TacGia> filteredAuthors = new List<TacGia>();
    private TacGia tacGiaHienTai = null;
    private bool isChangingText = false;

    public UserControlTacGia()
    {
      InitializeComponent();
      InitializeDataGridView();
    }

    private void UserControlTacGia_Load(object sender, EventArgs e)
    {
      LoadAuthorsFromDatabase();
      SetWatermark();
    }

    private void InitializeDataGridView()
    {
      dgvQuanLyTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      dgvQuanLyTacGia.Columns.Add("MaTacGia", "Mã tác giả");
      dgvQuanLyTacGia.Columns.Add("TenTacGia", "Tên tác giả");
      dgvQuanLyTacGia.Columns.Add("QuocTich", "Quốc tịch");
      dgvQuanLyTacGia.Columns.Add("DiaChi", "Địa chỉ");
      dgvQuanLyTacGia.Columns.Add("GioiTinh", "Giới tính");
      dgvQuanLyTacGia.Columns.Add("NgaySinh", "Ngày sinh");
      dgvQuanLyTacGia.Columns.Add("SoDienThoai", "Số điện thoại");
      dgvQuanLyTacGia.Columns.Add("Email", "Email");

      foreach (DataGridViewColumn column in dgvQuanLyTacGia.Columns)
      {
        column.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
      }

      dgvQuanLyTacGia.RowTemplate.Height = 35;
    }

    private void LoadAuthorsFromDatabase()
    {
      try
      {
        using (var context = new QLThuVienContextDB())
        {
          danhSachTacGia = context.TacGias.AsNoTracking().ToList();
        }
        filteredAuthors = danhSachTacGia; // Khởi tạo danh sách đã lọc với danh sách gốc
        DisplayAuthors(filteredAuthors); // Hiển thị danh sách tác giả ban đầu
        CalculateTotalAuthors();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu tác giả: " + ex.Message);
      }
    }

    private void DisplayAuthors(List<TacGia> authors)
    {
      dgvQuanLyTacGia.Rows.Clear();
      foreach (var tacGia in authors)
      {
        AddAuthorToGrid(tacGia);
      }
    }

    private void AddAuthorToGrid(TacGia tacGia)
    {
      int rowIndex = dgvQuanLyTacGia.Rows.Add();
      DataGridViewRow row = dgvQuanLyTacGia.Rows[rowIndex];

      row.Cells["MaTacGia"].Value = tacGia.MaTacGia;
      row.Cells["TenTacGia"].Value = tacGia.TenTacGia;
      row.Cells["QuocTich"].Value = tacGia.QuocTich;
      row.Cells["DiaChi"].Value = tacGia.DiaChi;
      row.Cells["GioiTinh"].Value = tacGia.GioiTinh;
      row.Cells["NgaySinh"].Value = tacGia.NgaySinh?.ToShortDateString() ?? "Chưa xác định";
      row.Cells["SoDienThoai"].Value = tacGia.SoDienThoai;
      row.Cells["Email"].Value = tacGia.Email;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        var result = MessageBox.Show("Bạn có chắc chắn muốn thêm tác giả này không?", "Xác nhận", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
          // Sinh mã tác giả mới
          string newMaTacGia = GenerateAuthorCode();
          txtMaTacGia.Text = newMaTacGia; // Cập nhật mã tác giả vào trường (readonly)

          // Ghi tác giả vào cơ sở dữ liệu và kiểm tra kết quả
          bool isSuccess = SaveAuthorToDatabase();
          if (isSuccess)
          {
            // Hiển thị thông báo thành công
            MessageBox.Show($"Tác giả mới đã được thêm với mã tác giả: {newMaTacGia}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAuthorsFromDatabase(); // Tải lại danh sách tác giả
          }
        }
      }
    }

    private bool SaveAuthorToDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        // Kiểm tra số điện thoại
        if (context.TacGias.Any(a => a.SoDienThoai == txtSoDienThoai.Text))
        {
          MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.");
          txtSoDienThoai.Focus();
          return false; // Không thêm tác giả
        }

        // Kiểm tra email
        if (context.TacGias.Any(a => a.Email == txtEmail.Text))
        {
          MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
          txtEmail.Focus();
          return false; // Không thêm tác giả
        }

        var tacGia = new TacGia
        {
          MaTacGia = txtMaTacGia.Text,
          TenTacGia = txtTenTacGia.Text,
          QuocTich = txtQuocTich.Text,
          DiaChi = txtDiaChi.Text,
          GioiTinh = cmbGioiTinh.SelectedItem.ToString(),
          NgaySinh = dtpNgaySinh.Value,
          SoDienThoai = txtSoDienThoai.Text,
          Email = txtEmail.Text
        };

        context.TacGias.Add(tacGia);
        context.SaveChanges();
      }
      ClearInputFields();
      return true; // Thêm tác giả thành công
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      if (tacGiaHienTai != null)
      {
        if (ValidateInput())
        {
          var result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin tác giả này không?", "Xác nhận", MessageBoxButtons.YesNo);
          if (result == DialogResult.Yes)
          {
            UpdateAuthorInDatabase();
            LoadAuthorsFromDatabase();
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn tác giả để chỉnh sửa.");
      }
    }

    private void UpdateAuthorInDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        var tacGia = context.TacGias.Find(tacGiaHienTai.MaTacGia);
        if (tacGia != null)
        {
          // Kiểm tra trùng số điện thoại
          if (txtSoDienThoai.Text != tacGia.SoDienThoai &&
              context.TacGias.Any(a => a.SoDienThoai == txtSoDienThoai.Text))
          {
            MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.");
            txtSoDienThoai.Focus();
            return;
          }

          // Kiểm tra trùng email
          if (txtEmail.Text != tacGia.Email &&
              context.TacGias.Any(a => a.Email == txtEmail.Text))
          {
            MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
            txtEmail.Focus();
            return;
          }

          // Cập nhật thông tin tác giả
          tacGia.TenTacGia = txtTenTacGia.Text;
          tacGia.QuocTich = txtQuocTich.Text;
          tacGia.DiaChi = txtDiaChi.Text;
          tacGia.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
          tacGia.NgaySinh = dtpNgaySinh.Value;
          tacGia.SoDienThoai = txtSoDienThoai.Text;
          tacGia.Email = txtEmail.Text;

          context.SaveChanges();
        }
      }
      ClearInputFields();
    }

    private bool ValidateInput()
    {
      // Kiểm tra tên tác giả
      if (string.IsNullOrWhiteSpace(txtTenTacGia.Text) ||
          !Regex.IsMatch(txtTenTacGia.Text, @"^[\p{L}\d\s]+$"))
      {
        MessageBox.Show("Tên tác giả chỉ chứa chữ cái tiếng Việt, số và khoảng trắng.");
        txtTenTacGia.Focus();
        return false;
      }

      // Kiểm tra quốc tịch
      if (string.IsNullOrWhiteSpace(txtQuocTich.Text) ||
          !Regex.IsMatch(txtQuocTich.Text, @"^[\p{L}\s]+$"))
      {
        MessageBox.Show("Quốc tịch chỉ chứa chữ cái tiếng Việt và khoảng trắng.");
        txtQuocTich.Focus();
        return false;
      }

      // Kiểm tra địa chỉ (cho phép dấu ',' và '.')
      if (string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
          !Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}\d\s,.]+$"))
      {
        MessageBox.Show("Địa chỉ chỉ chứa chữ cái tiếng Việt, số, khoảng trắng, dấu ',' và dấu '.'.");
        txtDiaChi.Focus();
        return false;
      }

      // Kiểm tra ngày sinh (14 tuổi trở lên)
      if (dtpNgaySinh.Value > DateTime.Now.AddYears(-14))
      {
        MessageBox.Show("Tác giả phải từ 14 tuổi trở lên.");
        dtpNgaySinh.Focus();
        return false;
      }

      // Kiểm tra số điện thoại
      if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          !Regex.IsMatch(txtSoDienThoai.Text, @"^0\d{9}$"))
      {
        MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0, có độ dài 10 và chỉ chứa chữ số.");
        txtSoDienThoai.Focus();
        return false;
      }

      // Kiểm tra email
      if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
          !Regex.IsMatch(txtEmail.Text, @"^[\w\.-]+@gmail\.com$"))
      {
        MessageBox.Show("Email phải kết thúc bằng @gmail.com và chỉ chứa chữ cái, số.");
        txtEmail.Focus();
        return false;
      }

      return true;
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (tacGiaHienTai != null)
      {
        var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này không?", "Xác nhận", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
          DeleteAuthorFromDatabase();
          LoadAuthorsFromDatabase();
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn tác giả để xóa.");
      }
    }

    private void DeleteAuthorFromDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        var tacGia = context.TacGias.Find(tacGiaHienTai.MaTacGia);
        if (tacGia != null)
        {
          // Kiểm tra có bản ghi liên quan trong DanhMucSach
          if (context.DanhMucSaches.Any(dms => dms.MaTacGia == tacGia.MaTacGia))
          {
            MessageBox.Show("Không thể xóa tác giả này vì còn tồn tại sách liên quan. Vui lòng xóa các sách liên quan trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Dừng lại nếu có liên kết
          }

          context.TacGias.Remove(tacGia);
          context.SaveChanges();
          MessageBox.Show("Tác giả đã được xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      ClearInputFields();
      tacGiaHienTai = null;
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
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
      txtEmail.Clear();
      tacGiaHienTai = null;
      txtTenTacGia.Focus();
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      // Ngăn chặn thay đổi văn bản trong quá trình xử lý
      if (isChangingText) return;

      // Lấy giá trị tìm kiếm và chuẩn hóa
      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      // Nếu người dùng không nhập gì hoặc nhập watermark, hiển thị lại danh sách gốc
      if (string.IsNullOrEmpty(searchText) || searchText == "tìm kiếm theo tên")
      {
        filteredAuthors = danhSachTacGia; // Đặt lại danh sách đã lọc
      }
      else
      {
        // Lọc danh sách tác giả theo tên
        filteredAuthors = danhSachTacGia
            .Where(tacGia => tacGia.TenTacGia.ToLower().Contains(searchText))
            .ToList();
      }

      // Cập nhật giao diện với danh sách đã lọc
      DisplayAuthors(filteredAuthors);
    }

    private void dgvQuanLyTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < (filteredAuthors.Count > 0 ? filteredAuthors.Count : danhSachTacGia.Count))
      {
        tacGiaHienTai = filteredAuthors.Count > 0 ? filteredAuthors[e.RowIndex] : danhSachTacGia[e.RowIndex];

        if (tacGiaHienTai != null)
        {
          txtMaTacGia.Text = tacGiaHienTai.MaTacGia;
          txtTenTacGia.Text = tacGiaHienTai.TenTacGia;
          txtQuocTich.Text = tacGiaHienTai.QuocTich;
          txtDiaChi.Text = tacGiaHienTai.DiaChi;
          cmbGioiTinh.SelectedItem = tacGiaHienTai.GioiTinh;
          dtpNgaySinh.Value = tacGiaHienTai.NgaySinh ?? DateTime.Now;
          txtSoDienThoai.Text = tacGiaHienTai.SoDienThoai;
          txtEmail.Text = tacGiaHienTai.Email;
        }
      }
    }

    private void CalculateTotalAuthors()
    {
      lblTongTacGia.Text = $"Tổng tác giả: {danhSachTacGia.Count}";
    }

    private void dgvQuanLyTacGia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
      {
        dgvQuanLyTacGia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
      else
      {
        dgvQuanLyTacGia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
      }
    }

    private string GenerateAuthorCode()
    {
      using (var context = new QLThuVienContextDB())
      {
        // Tìm mã tác giả lớn nhất hiện có
        var maxMaTacGia = context.TacGias
            .Where(a => a.MaTacGia.StartsWith("TG"))
            .Select(a => a.MaTacGia)
            .DefaultIfEmpty("TG000") // Nếu không có tác giả nào thì mặc định là TG000
            .Max();

        // Trích xuất số từ mã tác giả lớn nhất
        int maxId = int.Parse(maxMaTacGia.Substring(2)); // Bỏ 'TG' và chuyển sang số
        int newId = maxId + 1; // Tăng ID lên 1

        return $"TG{newId.ToString("D3")}"; // Định dạng mã dưới dạng TGxxx
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
  }
}