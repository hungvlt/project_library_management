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

      cmbLocTheoQuocTich.SelectedIndexChanged += (s, e) => FilterAuthors();
      cmbLocTheoGioiTinh.SelectedIndexChanged += (s, e) => FilterAuthors();
    }

    private void UserControlTacGia_Load(object sender, EventArgs e)
    {
      LoadAuthorsFromDatabase();
      LoadCountryList();
      LoadGenderList();
      SetWatermark();
      cmbQuocTich.SelectedIndex = -1;
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

      dgvQuanLyTacGia.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
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
        filteredAuthors = danhSachTacGia;
        DisplayAuthors(filteredAuthors);
        CalculateTotalAuthors();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu tác giả: " + ex.Message);
      }
    }

    private void LoadCountryList()
    {
      var countries = new List<string>
    {
        "Brazil", "Chile", "Colombia", "Israel", "Mỹ", "Nigeria", "Nhật Bản",
        "Vương Quốc Anh", "Việt Nam", "Pháp", "Đức", "Ý", "Tây Ban Nha",
        "Úc", "Canada", "Ấn Độ", "Trung Quốc", "Hàn Quốc", "Nga",
        "Mexico", "Nam Phi", "Thái Lan", "Singapore", "Philippines",
        "Indonesia", "Malaysia", "Saudi Arabia", "UAE", "New Zealand",
        "Argentina", "Bỉ", "Hà Lan", "Na Uy", "Đan Mạch", "Áo",
        "Thụy Điển", "Hy Lạp", "Séc", "Hungary", "Thụy Sĩ",
        "Bulgaria", "Romania", "Croatia", "Serbia", "Slovakia"
    };

      countries.Sort();
      cmbQuocTich.DataSource = countries;
      cmbQuocTich.SelectedIndex = -1;

      cmbLocTheoQuocTich.Items.Clear();
      cmbLocTheoQuocTich.Items.Add("Tất cả");
      cmbLocTheoQuocTich.Items.AddRange(countries.ToArray());
      cmbLocTheoQuocTich.SelectedIndex = 0;
    }

    private void LoadGenderList()
    {
      cmbGioiTinh.Items.Clear();
      cmbGioiTinh.Items.Add("Nam");
      cmbGioiTinh.Items.Add("Nữ");
      cmbGioiTinh.Items.Add("Khác");

      cmbLocTheoGioiTinh.Items.Clear();
      cmbLocTheoGioiTinh.Items.Add("Tất cả");
      cmbLocTheoGioiTinh.Items.Add("Nam");
      cmbLocTheoGioiTinh.Items.Add("Nữ");
      cmbLocTheoGioiTinh.Items.Add("Khác");
      cmbLocTheoGioiTinh.SelectedIndex = 0;
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
          string newMaTacGia = GenerateAuthorCode();
          txtMaTacGia.Text = newMaTacGia;

          bool isSuccess = SaveAuthorToDatabase();
          if (isSuccess)
          {
            MessageBox.Show($"Tác giả mới đã được thêm với mã tác giả: {newMaTacGia}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAuthorsFromDatabase();
          }
        }
      }
    }

    private bool SaveAuthorToDatabase()
    {
      using (var context = new QLThuVienContextDB())
      {
        if (context.TacGias.Any(a => a.SoDienThoai == txtSoDienThoai.Text))
        {
          MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.");
          txtSoDienThoai.Focus();
          return false;
        }

        if (context.TacGias.Any(a => a.Email == txtEmail.Text))
        {
          MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
          txtEmail.Focus();
          return false;
        }

        var tacGia = new TacGia
        {
          MaTacGia = txtMaTacGia.Text,
          TenTacGia = txtTenTacGia.Text,
          QuocTich = cmbQuocTich.SelectedItem.ToString(),
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
      return true;
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
          if (txtSoDienThoai.Text != tacGia.SoDienThoai &&
              context.TacGias.Any(a => a.SoDienThoai == txtSoDienThoai.Text))
          {
            MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.");
            txtSoDienThoai.Focus();
            return;
          }

          if (txtEmail.Text != tacGia.Email &&
              context.TacGias.Any(a => a.Email == txtEmail.Text))
          {
            MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
            txtEmail.Focus();
            return;
          }

          tacGia.TenTacGia = txtTenTacGia.Text;
          tacGia.QuocTich = cmbQuocTich.SelectedItem.ToString();
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
      if (string.IsNullOrWhiteSpace(txtTenTacGia.Text) ||
          !Regex.IsMatch(txtTenTacGia.Text, @"^[\p{L}\d\s]+$"))
      {
        MessageBox.Show("Tên tác giả chỉ chứa chữ cái tiếng Việt, số và khoảng trắng.");
        txtTenTacGia.Focus();
        return false;
      }

      if (cmbQuocTich.SelectedItem == null)
      {
        MessageBox.Show("Vui lòng chọn quốc tịch.");
        cmbQuocTich.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
          !Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}\d\s,.]+$"))
      {
        MessageBox.Show("Địa chỉ chỉ chứa chữ cái tiếng Việt, số, khoảng trắng, dấu ',' và dấu '.'.");
        txtDiaChi.Focus();
        return false;
      }

      if (cmbGioiTinh.SelectedItem == null)
      {
        MessageBox.Show("Vui lòng chọn giới tính.");
        cmbGioiTinh.Focus();
        return false;
      }

      if (dtpNgaySinh.Value > DateTime.Now.AddYears(-14))
      {
        MessageBox.Show("Tác giả phải từ 14 tuổi trở lên.");
        dtpNgaySinh.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          !Regex.IsMatch(txtSoDienThoai.Text, @"^0\d{9}$"))
      {
        MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0, có độ dài 10 và chỉ chứa chữ số.");
        txtSoDienThoai.Focus();
        return false;
      }

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
          if (context.DanhMucSaches.Any(dms => dms.MaTacGia == tacGia.MaTacGia))
          {
            MessageBox.Show("Không thể xóa tác giả này vì còn tồn tại sách liên quan. Vui lòng xóa các sách liên quan trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
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
      SetWatermark();
    }

    private void ClearInputFields()
    {
      txtMaTacGia.Clear();
      txtTenTacGia.Clear();
      cmbQuocTich.SelectedIndex = -1;
      txtDiaChi.Clear();
      cmbGioiTinh.SelectedItem = null;
      dtpNgaySinh.Value = DateTime.Now;
      txtSoDienThoai.Clear();
      txtEmail.Clear();
      tacGiaHienTai = null;
      txtTimKiemTheoTen.Clear();
      txtTenTacGia.Focus();
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      if (isChangingText) return;

      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      if (string.IsNullOrEmpty(searchText) || searchText == "tìm kiếm theo mã/tên")
      {
        filteredAuthors = danhSachTacGia;
      }
      else
      {
        filteredAuthors = danhSachTacGia
            .Where(tacGia => tacGia.TenTacGia.ToLower().Contains(searchText) ||
                             tacGia.MaTacGia.ToLower().Contains(searchText))
            .ToList();
      }

      DisplayAuthors(filteredAuthors);
    }

    private void dgvQuanLyTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < (filteredAuthors.Count > 0 ? filteredAuthors.Count : danhSachTacGia.Count))
      {
        if (dgvQuanLyTacGia.Rows[e.RowIndex].Cells["MaTacGia"].Value == null ||
            dgvQuanLyTacGia.Rows[e.RowIndex].Cells["MaTacGia"].Value == DBNull.Value)
        {
          ClearInputFields();
          tacGiaHienTai = null;
          return;
        }

        tacGiaHienTai = filteredAuthors.Count > 0 ? filteredAuthors[e.RowIndex] : danhSachTacGia[e.RowIndex];

        if (tacGiaHienTai != null)
        {
          txtMaTacGia.Text = tacGiaHienTai.MaTacGia;
          txtTenTacGia.Text = tacGiaHienTai.TenTacGia;
          cmbQuocTich.SelectedItem = tacGiaHienTai.QuocTich;
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
      lblTongTacGia.Text = danhSachTacGia.Count().ToString();
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
        var maxMaTacGia = context.TacGias
            .Where(a => a.MaTacGia.StartsWith("TG"))
            .Select(a => a.MaTacGia)
            .DefaultIfEmpty("TG000")
            .Max();

        int maxId = int.Parse(maxMaTacGia.Substring(2));
        int newId = maxId + 1;

        return $"TG{newId.ToString("D3")}";
      }
    }

    private void txtTimKiemTheoTen_Leave(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text))
      {
        SetWatermark();
      }
    }

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Tìm kiếm theo mã/tên")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "";
        txtTimKiemTheoTen.ForeColor = Color.Black;
        txtTimKiemTheoTen.BackColor = Color.White;
        isChangingText = false;
      }
    }

    private void SetWatermark()
    {
      if (isChangingText) return;

      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tìm kiếm theo mã/tên")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "Tìm kiếm theo mã/tên";
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

    private void cmbLocTheoQuocTich_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmbLocTheoGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void FilterAuthors()
    {
      string selectedCountry = cmbLocTheoQuocTich.SelectedItem?.ToString();
      string selectedGender = cmbLocTheoGioiTinh.SelectedItem?.ToString();

      filteredAuthors = danhSachTacGia;

      if (!string.IsNullOrEmpty(selectedCountry) && selectedCountry != "Tất cả")
      {
        filteredAuthors = filteredAuthors.Where(a => a.QuocTich == selectedCountry).ToList();
      }

      // Lọc theo giới tính
      if (!string.IsNullOrEmpty(selectedGender) && selectedGender != "Tất cả")
      {
        filteredAuthors = filteredAuthors.Where(a => a.GioiTinh == selectedGender).ToList();
      }

      DisplayAuthors(filteredAuthors);
      lblTongTacGia.Text = filteredAuthors.Count().ToString();
    }
  }
}