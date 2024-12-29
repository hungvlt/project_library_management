using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class UserControlDanhMucSach : UserControl
  {
    private List<DanhMucSach> danhMucSach = new List<DanhMucSach>();
    private List<TacGia> danhSachTacGia = new List<TacGia>();
    private DanhMucSach sachHienTai = null;
    private List<DanhMucSach> filteredBooks = new List<DanhMucSach>();
    public event Action OnDataChanged;
    private bool isChangingText = false;

    public UserControlDanhMucSach()
    {
      InitializeComponent();
      InitializeDataGridView();
      txtMaSach.ReadOnly = true;
    }

    private void UserControlDanhMucSach_Load(object sender, EventArgs e)
    {
      LoadData();
      SetWatermark();
    }

    private void InitializeDataGridView()
    {
      dgvQuanLySach.Size = new Size(805, 570);
      dgvQuanLySach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      dgvQuanLySach.Columns.Add("ID", "ID");
      dgvQuanLySach.Columns.Add("Tên sách", "Tên sách");
      dgvQuanLySach.Columns.Add("Tác giả", "Tác giả");
      dgvQuanLySach.Columns.Add("Thể loại", "Thể loại");
      dgvQuanLySach.Columns.Add("Giá", "Giá");
      dgvQuanLySach.Columns.Add("NXB", "Nhà xuất bản");
      dgvQuanLySach.Columns.Add("SL", "Số lượng");
      dgvQuanLySach.Columns.Add("Mô tả", "Mô tả");
      dgvQuanLySach.Columns.Add("Ngày xuất bản", "Ngày xuất bản");

      foreach (DataGridViewColumn column in dgvQuanLySach.Columns)
      {
        column.HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
      }

      dgvQuanLySach.RowTemplate.Height = 35;
    }

    private void LoadData()
    {
      LoadAuthorsIntoComboBox();
      LoadCategoriesIntoComboBox();
      LoadBooksFromDatabase();
    }

    private void LoadAuthorsIntoComboBox()
    {
      using (var context = new QLThuVienContextDB())
      {
        danhSachTacGia = context.TacGias.ToList();
      }
      cmbAuthor.DataSource = danhSachTacGia;
      cmbAuthor.DisplayMember = "TenTacGia";
      cmbAuthor.ValueMember = "MaTacGia";
    }

    private void LoadCategoriesIntoComboBox()
    {
      cmbTheLoai.Items.AddRange(new object[]
      {
                "Khoa học", "Văn học", "Công nghệ", "Tiểu thuyết", "Tự truyện",
                "Lịch sử", "Kinh doanh", "Giáo dục", "Hư cấu", "Triết học",
                "Tâm lý học", "Ngữ văn", "Khoa học xã hội", "Thể thao",
                "Du lịch", "Nấu ăn", "Nhạc", "Sân khấu", "Thiếu nhi",
                "Kinh điển", "Sách điện tử"
      });
    }

    private void LoadBooksFromDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        danhMucSach = context.DanhMucSaches.ToList();
        txtMaSach.Text = (danhMucSach.Any() ? danhMucSach.Max(s => s.MaSach) + 1 : 1).ToString();
      }

      dgvQuanLySach.Rows.Clear();
      foreach (var sach in danhMucSach)
      {
        AddBookToGrid(sach);
      }
      CalculateTotalBooks();
    }

    private void AddBookToGrid(DanhMucSach sach)
    {
      int rowIndex = dgvQuanLySach.Rows.Add();
      DataGridViewRow row = dgvQuanLySach.Rows[rowIndex];

      row.Cells["ID"].Value = sach.MaSach;
      row.Cells["Tên sách"].Value = sach.TenSach;

      // Gán tên tác giả, chắc chắn rằng tacGia không null
      var tacGia = danhSachTacGia.FirstOrDefault(a => a.MaTacGia == sach.MaTacGia);
      row.Cells["Tác giả"].Value = tacGia != null ? tacGia.TenTacGia : string.Empty;

      // Các giá trị khác
      row.Cells["Giá"].Value = sach.Gia;
      row.Cells["Thể loại"].Value = sach.TheLoai;
      row.Cells["NXB"].Value = sach.NhaXuatBan;
      row.Cells["SL"].Value = sach.SoLuong;
      row.Cells["Mô tả"].Value = sach.MoTa;
      row.Cells["Ngày xuất bản"].Value = sach.NgayXuatBan?.ToShortDateString() ?? "Chưa xác định";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (ValidateInput(false))
      {
        SaveBookToDatabase();
        LoadBooksFromDatabase();
        MessageBox.Show("Thêm sách thành công!");
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (sachHienTai != null && ValidateInput(false))
      {
        UpdateBookInDatabase();
        LoadBooksFromDatabase();
        MessageBox.Show("Sửa sách thành công!");
      }
      else
      {
        MessageBox.Show("Vui lòng chọn sách để chỉnh sửa.");
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (sachHienTai != null)
      {
        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
          DeleteBookFromDatabase();
          LoadBooksFromDatabase();
          MessageBox.Show("Xóa sách thành công!");
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn sách để xóa.");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
    }

    private void btnTaiAnh_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          picAnhSach.Image = Image.FromFile(openFileDialog.FileName);
        }
      }
    }

    private void ClearInputFields()
    {
      txtMaSach.Clear();
      txtTenSach.Clear();
      cmbAuthor.SelectedIndex = -1;
      cmbTheLoai.SelectedIndex = -1;
      txtNhaXuatBan.Clear();
      txtGia.Clear();
      numSoLuong.Value = 0;
      txtMoTa.Clear();
      dtpNgayXuatBan.Value = DateTime.Now;
      picAnhSach.Image = null;
      sachHienTai = null;
      txtTenSach.Focus();
    }

    private string SaveImageAndGetPath()
    {
      if (picAnhSach.Image != null)
      {
        string path = Path.Combine(Environment.CurrentDirectory, "Images");
        Directory.CreateDirectory(path);
        string fileName = Path.Combine(path, Guid.NewGuid() + ".png");
        picAnhSach.Image.Save(fileName);
        return fileName;
      }
      return null;
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      // Ngăn chặn thay đổi văn bản
      if (isChangingText) return;

      // Nếu người dùng nhập ký tự, không hiển thị watermark
      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      // Cập nhật danh sách sách chỉ nếu người dùng không nhập watermark
      if (searchText != "tìm kiếm theo tên")
      {
        filteredBooks = danhMucSach.Where(b => b.TenSach.ToLower().Contains(searchText)).ToList();
        dgvQuanLySach.Rows.Clear();
        foreach (var sach in filteredBooks)
        {
          AddBookToGrid(sach);
        }
      }
    }

    private void dgvQuanLySach_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < (txtTimKiemTheoTen.Text.Length > 0 ? filteredBooks.Count : danhMucSach.Count))
      {
        sachHienTai = txtTimKiemTheoTen.Text.Length > 0 ? filteredBooks[e.RowIndex] : danhMucSach[e.RowIndex];
        LoadBookDetails(sachHienTai);
      }
    }

    private void LoadBookDetails(DanhMucSach sach)
    {
      txtMaSach.Text = sach.MaSach.ToString();
      txtTenSach.Text = sach.TenSach;
      cmbAuthor.SelectedValue = sach.MaTacGia;
      cmbTheLoai.SelectedItem = sach.TheLoai;
      txtNhaXuatBan.Text = sach.NhaXuatBan;
      txtGia.Text = sach.Gia.ToString();
      numSoLuong.Value = sach.SoLuong ?? 0;
      txtMoTa.Text = sach.MoTa;
      dtpNgayXuatBan.Value = sach.NgayXuatBan ?? DateTime.Now;

      if (string.IsNullOrEmpty(sach.HinhAnh))
      {
        picAnhSach.Image = null;
      }
      else
      {
        LoadBookImageToPictureBox(sach.HinhAnh, picAnhSach);
      }
    }

    private void CalculateTotalBooks()
    {
      int totalBooks = danhMucSach.Count;
      int totalQuantity = danhMucSach.Sum(s => s.SoLuong ?? 0);
      lblTongSach.Text = $"Tổng sách: {totalBooks} | Tổng số lượng: {totalQuantity}";
    }

    private bool ValidateInput(bool checkMaSach = true)
    {
      if (!ValidateTenSach()) return false;
      if (cmbAuthor.SelectedIndex == -1) return ShowError("Vui lòng chọn tác giả.", cmbAuthor);
      if (!ValidateNhaXuatBan()) return false;
      if (!ValidateGia()) return false;
      if (numSoLuong.Value <= 0 || numSoLuong.Value >= 100) return ShowError("Số lượng của sách phải là số dương và nhỏ hơn 100.", numSoLuong);
      if (cmbTheLoai.SelectedIndex == -1) return ShowError("Vui lòng chọn thể loại.", cmbTheLoai);
      if (dtpNgayXuatBan.Value > DateTime.Now) return ShowError("Ngày xuất bản phải nhỏ hơn hoặc bằng ngày hiện tại.", dtpNgayXuatBan);

      if (checkMaSach && !IsMaSachValid()) return false;

      return true;
    }

    private bool ValidateTenSach()
    {
      if (string.IsNullOrWhiteSpace(txtTenSach.Text) || !Regex.IsMatch(txtTenSach.Text, @"^[\p{L}\d\s]+$"))
      {
        return ShowError("Tên sách chỉ chứa chữ cái tiếng Việt, số và khoảng trắng.", txtTenSach);
      }
      return true;
    }

    private bool ValidateNhaXuatBan()
    {
      if (string.IsNullOrWhiteSpace(txtNhaXuatBan.Text) || !Regex.IsMatch(txtNhaXuatBan.Text, @"^[\p{L}\s]+$"))
      {
        return ShowError("Nhà xuất bản chỉ chứa chữ cái tiếng Việt và khoảng trắng.", txtNhaXuatBan);
      }
      return true;
    }

    private bool ValidateGia()
    {
      if (string.IsNullOrWhiteSpace(txtGia.Text) || !decimal.TryParse(txtGia.Text, out decimal gia) || gia <= 0 || gia >= 200000)
      {
        return ShowError("Giá trị của giá sách phải là số dương và nhỏ hơn 200.000.", txtGia);
      }
      return true;
    }

    private bool IsMaSachValid()
    {
      if (string.IsNullOrWhiteSpace(txtMaSach.Text))
      {
        return true;
      }

      using (var context = new QLThuVienContextDB())
      {
        // Lấy mã sách hiện tại
        var currentBookId = sachHienTai != null ? sachHienTai.MaSach : (int?)null;

        // Kiểm tra nếu sách đã tồn tại với cùng tên sách và tác giả, ngoại trừ sách hiện tại
        if (context.DanhMucSaches.Any(s => s.TenSach == txtTenSach.Text
                                            && s.MaTacGia == cmbAuthor.SelectedValue.ToString()
                                            && s.MaSach != currentBookId))
        {
          return ShowError("Tên sách đã tồn tại với tác giả này. Vui lòng nhập tên khác.", txtTenSach);
        }
      }
      return true;
    }

    private bool ShowError(string message, Control control)
    {
      MessageBox.Show(message);
      control.Focus();
      return false;
    }

    private void SaveBookToDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        int maSach = danhMucSach.Any() ? danhMucSach.Max(s => s.MaSach) + 1 : 1;

        if (!decimal.TryParse(txtGia.Text, out decimal gia))
        {
          MessageBox.Show("Giá không hợp lệ.");
          return;
        }

        // Kiểm tra trùng tên sách với tác giả
        if (context.DanhMucSaches.Any(s => s.TenSach == txtTenSach.Text && s.MaTacGia == cmbAuthor.SelectedValue.ToString()))
        {
          MessageBox.Show("Tên sách đã tồn tại với tác giả này. Vui lòng nhập tên khác.");
          return; // Ngừng thực hiện nếu có lỗi
        }

        var sach = new DanhMucSach
        {
          MaSach = maSach,
          TenSach = txtTenSach.Text,
          MaTacGia = cmbAuthor.SelectedValue.ToString(),
          NhaXuatBan = txtNhaXuatBan.Text,
          Gia = (int)gia,
          SoLuong = (int)numSoLuong.Value,
          TheLoai = cmbTheLoai.SelectedItem.ToString(),
          HinhAnh = picAnhSach.Image != null ? SaveImageAndGetPath() : null,
          MoTa = txtMoTa.Text,
          NgayXuatBan = dtpNgayXuatBan.Value
        };

        context.DanhMucSaches.Add(sach);
        context.SaveChanges(); // Lưu sách vào cơ sở dữ liệu

        MessageBox.Show("Thêm sách thành công!"); // Xuất thông báo chỉ khi thêm thành công
      }
      ClearInputFields();
      CalculateTotalBooks();
      OnDataChanged?.Invoke();
    }

    private void UpdateBookInDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        var sach = context.DanhMucSaches.Find(sachHienTai.MaSach);
        if (sach != null)
        {
          // Lấy mã sách hiện tại
          var currentBookId = sachHienTai.MaSach;

          // Kiểm tra trùng tên sách với tác giả
          if (context.DanhMucSaches.Any(s => s.TenSach == txtTenSach.Text
                                              && s.MaTacGia == cmbAuthor.SelectedValue.ToString()
                                              && s.MaSach != currentBookId))
          {
            MessageBox.Show("Tên sách đã tồn tại với tác giả này. Vui lòng nhập tên khác.");
            txtTenSach.Focus();
            return; // Ngừng thực hiện nếu có lỗi
          }

          // Nếu không có lỗi, thực hiện cập nhật
          sach.TenSach = txtTenSach.Text;
          sach.MaTacGia = cmbAuthor.SelectedValue.ToString();
          sach.NhaXuatBan = txtNhaXuatBan.Text;
          sach.Gia = (int)decimal.Parse(txtGia.Text);
          sach.SoLuong = (int)numSoLuong.Value;
          sach.TheLoai = cmbTheLoai.SelectedItem.ToString();
          sach.HinhAnh = SaveImageAndGetPath();
          sach.MoTa = txtMoTa.Text;
          sach.NgayXuatBan = dtpNgayXuatBan.Value;

          context.SaveChanges(); // Chỉ gọi SaveChanges() nếu không có lỗi

          MessageBox.Show("Sửa sách thành công!"); // Xuất thông báo chỉ khi sửa thành công
        }
      }
      ClearInputFields();
      CalculateTotalBooks();
      OnDataChanged?.Invoke();
    }

    private void DeleteBookFromDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        var sach = context.DanhMucSaches.Find(sachHienTai.MaSach);
        if (sach != null)
        {
          context.DanhMucSaches.Remove(sach);
          context.SaveChanges();
        }
        else
        {
          MessageBox.Show("Mã sách không tồn tại trong cơ sở dữ liệu. Không thể xóa.");
        }
      }
      ClearInputFields();
      sachHienTai = null;
      CalculateTotalBooks();
      OnDataChanged?.Invoke();
    }

    private void dgvQuanLySach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      dgvQuanLySach.Rows[e.RowIndex].DefaultCellStyle.BackColor = e.RowIndex % 2 == 0 ? Color.LightGray : Color.White;
    }

    private void LoadBookImageToPictureBox(string imagePath, PictureBox pictureBox)
    {
      if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath) && IsImageFile(imagePath))
      {
        try
        {
          pictureBox.Image = ResizeImage(imagePath, pictureBox.Width, pictureBox.Height);
        }
        catch (Exception ex)
        {
          MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}");
        }
      }
    }

    private bool IsImageFile(string filePath)
    {
      string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
      return validExtensions.Contains(Path.GetExtension(filePath).ToLower());
    }

    private Image ResizeImage(string filePath, int maxWidth, int maxHeight)
    {
      using (var originalImage = Image.FromFile(filePath))
      {
        var ratioX = (double)maxWidth / originalImage.Width;
        var ratioY = (double)maxHeight / originalImage.Height;
        var ratio = Math.Min(ratioX, ratioY);

        var newWidth = (int)(originalImage.Width * ratio);
        var newHeight = (int)(originalImage.Height * ratio);
        var newImage = new Bitmap(newWidth, newHeight);

        using (var graphics = Graphics.FromImage(newImage))
        {
          graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
        }
        return newImage;
      }
    }

    private void SetWatermark()
    {
      // Ngăn chặn việc gọi lại do thay đổi văn bản
      if (isChangingText) return;

      // Kiểm tra và thiết lập watermark
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tìm kiếm theo tên")
      {
        isChangingText = true; // Đánh dấu là đang thay đổi văn bản
        txtTimKiemTheoTen.Text = "Tìm kiếm theo tên";
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
  }
}