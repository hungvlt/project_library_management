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

      dgvQuanLySach.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
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

      danhSachTacGia.Insert(0, new TacGia { MaTacGia = "ALL", TenTacGia = "Tất cả" });

      cmbAuthor.DataSource = danhSachTacGia;
      cmbAuthor.DisplayMember = "TenTacGia";
      cmbAuthor.ValueMember = "MaTacGia";

      cmbLocTheoTacGia.DataSource = danhSachTacGia.ToList();
      cmbLocTheoTacGia.DisplayMember = "TenTacGia";
      cmbLocTheoTacGia.ValueMember = "MaTacGia";

      cmbLocTheoTacGia.SelectedIndex = 0;
    }

    private void LoadCategoriesIntoComboBox()
    {
      // Xóa tất cả các mục hiện có trước khi thêm
      cmbTheLoai.Items.Clear();
      cmbLocTheoTheLoai.Items.Clear();

      // Thêm "Tất cả" vào danh sách thể loại
      cmbLocTheoTheLoai.Items.Add("Tất cả");

      // Thêm các thể loại khác
      var categories = new object[]
      {
        "Khoa học", "Văn học", "Công nghệ", "Tiểu thuyết", "Tự truyện",
        "Lịch sử", "Kinh doanh", "Giáo dục", "Hư cấu", "Triết học",
        "Tâm lý học", "Ngữ văn", "Khoa học xã hội", "Thể thao",
        "Du lịch", "Nấu ăn", "Nhạc", "Sân khấu", "Thiếu nhi",
        "Kinh điển", "Sách điện tử"
      };

      // Thêm các thể loại vào cmbTheLoai
      cmbTheLoai.Items.AddRange(categories);

      // Thêm các thể loại vào cmbLocTheoTheLoai
      cmbLocTheoTheLoai.Items.AddRange(categories);

      // Đặt giá trị mặc định cho cmbLocTheoTheLoai
      cmbLocTheoTheLoai.SelectedIndex = 0; // Chọn "Tất cả"
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
      var tacGia = danhSachTacGia.FirstOrDefault(a => a.MaTacGia == sach.MaTacGia);
      row.Cells["Tác giả"].Value = tacGia != null ? tacGia.TenTacGia : string.Empty;
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
        CalculateTotalBooks();
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (sachHienTai != null && ValidateInput(false))
      {
        UpdateBookInDatabase();
        LoadBooksFromDatabase();
        CalculateTotalBooks();
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
        if (IsBookBeingBorrowed(sachHienTai.MaSach))
        {
          MessageBox.Show("Không thể xóa sách này vì nó đang được mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          try
          {
            using (var context = new QLThuVienContextDB())
            {
              var sachToDelete = context.DanhMucSaches.Find(sachHienTai.MaSach);
              if (sachToDelete != null)
              {
                context.DanhMucSaches.Remove(sachToDelete);
                context.SaveChanges();
              }
              else
              {
                MessageBox.Show("Sách không tồn tại trong cơ sở dữ liệu.");
              }
            }

            LoadData();
            ClearInputFields();
            sachHienTai = null;
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một sách để xóa.");
      }
    }

    private bool IsBookBeingBorrowed(int maSach)
    {
      using (var context = new QLThuVienContextDB())
      {
        return context.MuonSaches.Any(ms => ms.MaSach == maSach && ms.TrangThai == "Đang mượn");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
      SetWatermark();
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
      txtTimKiemTheoTen.Clear();
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
      if (isChangingText) return;

      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      if (!string.IsNullOrEmpty(searchText) && searchText != "tên sách hoặc tên tác giả")
      {
        filteredBooks = danhMucSach.Where(b =>
            b.TenSach.ToLower().Contains(searchText) ||
            danhSachTacGia.Any(a => a.TenTacGia.ToLower().Contains(searchText) && a.MaTacGia == b.MaTacGia)).ToList();
      }
      else
      {
        filteredBooks = danhMucSach.ToList();
      }

      dgvQuanLySach.Rows.Clear();
      foreach (var sach in filteredBooks)
      {
        AddBookToGrid(sach);
      }
    }

    private void dgvQuanLySach_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        if (dgvQuanLySach.Rows[e.RowIndex].Cells["ID"].Value == null ||
            dgvQuanLySach.Rows[e.RowIndex].Cells["ID"].Value == DBNull.Value)
        {
          ClearInputFields();
          sachHienTai = null;
          return;
        }

        if (txtTimKiemTheoTen.Text.Length > 0 && filteredBooks.Count > 0)
        {
          if (e.RowIndex < filteredBooks.Count)
          {
            sachHienTai = filteredBooks[e.RowIndex];
            LoadBookDetails(sachHienTai);
          }
        }
        else if (danhMucSach.Count > 0)
        {
          if (e.RowIndex < danhMucSach.Count)
          {
            sachHienTai = danhMucSach[e.RowIndex];
            LoadBookDetails(sachHienTai);
          }
        }
      }
    }

    private void LoadBookDetails(DanhMucSach sach)
    {
      if (sach == null) return;

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
      int totalBooks = danhMucSach.Count();
      lblTongSach.Text = totalBooks.ToString();
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
        var currentBookId = sachHienTai != null ? sachHienTai.MaSach : (int?)null;

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

        if (context.DanhMucSaches.Any(s => s.TenSach == txtTenSach.Text && s.MaTacGia == cmbAuthor.SelectedValue.ToString()))
        {
          MessageBox.Show("Tên sách đã tồn tại với tác giả này. Vui lòng nhập tên khác.");
          return;
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
        context.SaveChanges();
        MessageBox.Show("Thêm sách thành công!");
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
          var currentBookId = sachHienTai.MaSach;

          if (context.DanhMucSaches.Any(s => s.TenSach == txtTenSach.Text
                                              && s.MaTacGia == cmbAuthor.SelectedValue.ToString()
                                              && s.MaSach != currentBookId))
          {
            MessageBox.Show("Tên sách đã tồn tại với tác giả này. Vui lòng nhập tên khác.");
            txtTenSach.Focus();
            return;
          }

          sach.TenSach = txtTenSach.Text;
          sach.MaTacGia = cmbAuthor.SelectedValue.ToString();
          sach.NhaXuatBan = txtNhaXuatBan.Text;
          sach.Gia = (int)decimal.Parse(txtGia.Text);
          sach.SoLuong = (int)numSoLuong.Value;
          sach.TheLoai = cmbTheLoai.SelectedItem.ToString();
          sach.HinhAnh = SaveImageAndGetPath();
          sach.MoTa = txtMoTa.Text;
          sach.NgayXuatBan = dtpNgayXuatBan.Value;

          context.SaveChanges();
          MessageBox.Show("Sửa sách thành công!");
        }
      }
      ClearInputFields();
      CalculateTotalBooks();
      OnDataChanged?.Invoke();
    }

    //private void DeleteBookFromDatabase()
    //{
    //  using (var context = new QLThuVienContextDB())
    //  {
    //    var sach = context.DanhMucSaches.Find(sachHienTai.MaSach);
    //    if (sach != null)
    //    {
    //      context.DanhMucSaches.Remove(sach);
    //      context.SaveChanges();
    //    }
    //    else
    //    {
    //      MessageBox.Show("Mã sách không tồn tại trong cơ sở dữ liệu. Không thể xóa.");
    //    }
    //  }
    //  ClearInputFields();
    //  sachHienTai = null;
    //  CalculateTotalBooks();
    //  OnDataChanged?.Invoke();
    //}

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
      if (isChangingText) return;

      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tên sách hoặc tên tác giả")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "Tên sách hoặc tên tác giả";
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

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Tên sách hoặc tên tác giả")
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

    private void cmbLocTheoTheLoai_SelectedIndexChanged(object sender, EventArgs e)
    {
      FilterBooks();
    }

    private void cmbLocTheoTacGia_SelectedIndexChanged(object sender, EventArgs e)
    {
      FilterBooks();
    }

    private void FilterBooks()
    {
      string selectedCategory = cmbLocTheoTheLoai.SelectedItem?.ToString();
      string selectedAuthor = cmbLocTheoTacGia.SelectedValue?.ToString();

      var filteredBooks = danhMucSach.AsEnumerable();

      // Lọc theo thể loại
      if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Tất cả")
      {
        filteredBooks = filteredBooks.Where(b => b.TheLoai == selectedCategory);
      }

      // Lọc theo tác giả
      if (!string.IsNullOrEmpty(selectedAuthor) && selectedAuthor != "ALL")
      {
        filteredBooks = filteredBooks.Where(b => b.MaTacGia == selectedAuthor);
      }

      // Cập nhật DataGridView
      dgvQuanLySach.Rows.Clear();
      foreach (var sach in filteredBooks)
      {
        AddBookToGrid(sach);
      }

      lblTongSach.Text = filteredBooks.Count().ToString();
    }
  }
}