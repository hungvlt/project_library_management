using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLThuVien_2.Models;

namespace QLThuVien_2
{
  public partial class UserControlDanhMucSach : UserControl
  {
    private List<DanhMucSach> danhMucSach = new List<DanhMucSach>();
    private List<TacGia> danhSachTacGia = new List<TacGia>();
    private DanhMucSach sachHienTai = null;

    public UserControlDanhMucSach()
    {
      InitializeComponent();
      InitializeDataGridView();
    }

    private void UserControlDanhMucSach_Load(object sender, EventArgs e)
    {
      LoadBooksFromDatabase();
      LoadAuthorsIntoComboBox();
    }

    private void InitializeDataGridView()
    {
      dgvQuanLySach.Size = new Size(805, 570);
      dgvQuanLySach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
      {
        HeaderText = "Hình ảnh",
        Name = "HinhAnh",
        Width = 120
      };
      dgvQuanLySach.Columns.Add(imageColumn);

      dgvQuanLySach.Columns.Add("ID", "ID");
      dgvQuanLySach.Columns.Add("Tên sách", "Tên sách");
      dgvQuanLySach.Columns.Add("Tác giả", "Tác giả");
      dgvQuanLySach.Columns.Add("Giá", "Giá");
      dgvQuanLySach.Columns.Add("NXB", "Nhà xuất bản");
      dgvQuanLySach.Columns.Add("SL", "Số lượng");
      dgvQuanLySach.Columns.Add("Mô tả", "Mô tả");
      dgvQuanLySach.Columns.Add("Ngày xuất bản", "Ngày xuất bản");

      dgvQuanLySach.RowTemplate.Height = 150;
    }

    private void LoadAuthorsIntoComboBox()
    {
      using (var context = new QLThuVienContextDB_1())
      {
        danhSachTacGia = context.TacGias.ToList(); // Tải danh sách tác giả từ cơ sở dữ liệu
      }

      cmbAuthor.DataSource = danhSachTacGia;
      cmbAuthor.DisplayMember = "TenTacGia"; // Tên hiển thị trong ComboBox
      cmbAuthor.ValueMember = "MaTacGia"; // Giá trị để lưu
    }

    private void LoadBooksFromDatabase()
    {
      using (var context = new QLThuVienContextDB_1())
      {
        danhMucSach = context.DanhMucSaches.ToList(); // Tải danh sách sách từ cơ sở dữ liệu
      }

      dgvQuanLySach.Rows.Clear();
      foreach (var sach in danhMucSach)
      {
        AddBookToGrid(sach);
      }
    }

    private void AddBookToGrid(DanhMucSach sach)
    {
      int rowIndex = dgvQuanLySach.Rows.Add();
      DataGridViewRow row = dgvQuanLySach.Rows[rowIndex];

      row.Cells["ID"].Value = sach.MaSach;
      row.Cells["Tên sách"].Value = sach.TenSach;
      row.Cells["Tác giả"].Value = sach.MaTacGia; // Hiển thị mã tác giả
      row.Cells["Giá"].Value = sach.Gia;
      row.Cells["NXB"].Value = sach.NhaXuatBan;
      row.Cells["SL"].Value = sach.SoLuong;
      row.Cells["Mô tả"].Value = sach.MoTa;
      row.Cells["Ngày xuất bản"].Value = sach.NgayXuatBan.HasValue ? sach.NgayXuatBan.Value.ToShortDateString() : "Chưa xác định"; // Xử lý nullable

      if (!string.IsNullOrEmpty(sach.HinhAnh) && File.Exists(sach.HinhAnh))
      {
        row.Cells["HinhAnh"].Value = Image.FromFile(sach.HinhAnh);
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      SaveBookToDatabase();
      LoadBooksFromDatabase();
    }

    private void SaveBookToDatabase()
    {
      using (var context = new QLThuVienContextDB_1())
      {
        var sach = new DanhMucSach
        {
          MaSach = int.Parse(txtMaSach.Text),
          TenSach = txtTenSach.Text,
          MaTacGia = cmbAuthor.SelectedValue.ToString(),
          NhaXuatBan = txtNhaXuatBan.Text,
          Gia = decimal.Parse(txtGia.Text),
          SoLuong = (int)numSoLuong.Value,
          HinhAnh = SaveImageAndGetPath(),
          MoTa = txtMoTa.Text,
          NgayXuatBan = dtpNgayXuatBan.Value
        };

        context.DanhMucSaches.Add(sach);
        context.SaveChanges();
      }
      ClearInputFields();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (sachHienTai != null)
      {
        UpdateBookInDatabase();
        LoadBooksFromDatabase();
      }
      else
      {
        MessageBox.Show("Vui lòng chọn sách để chỉnh sửa.");
      }
    }

    private void UpdateBookInDatabase()
    {
      using (var context = new QLThuVienContextDB_1())
      {
        var sach = context.DanhMucSaches.Find(sachHienTai.MaSach);
        if (sach != null)
        {
          sach.TenSach = txtTenSach.Text;
          sach.MaTacGia = cmbAuthor.SelectedValue.ToString();
          sach.NhaXuatBan = txtNhaXuatBan.Text;
          sach.Gia = decimal.Parse(txtGia.Text);
          sach.SoLuong = (int)numSoLuong.Value;
          sach.HinhAnh = SaveImageAndGetPath();
          sach.MoTa = txtMoTa.Text;
          sach.NgayXuatBan = dtpNgayXuatBan.Value;

          context.SaveChanges();
        }
      }
      ClearInputFields();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (sachHienTai != null)
      {
        DeleteBookFromDatabase();
        LoadBooksFromDatabase();
      }
      else
      {
        MessageBox.Show("Vui lòng chọn sách để xóa.");
      }
    }

    private void DeleteBookFromDatabase()
    {
      using (var context = new QLThuVienContextDB_1())
      {
        var sach = context.DanhMucSaches.Find(sachHienTai.MaSach);
        if (sach != null)
        {
          context.DanhMucSaches.Remove(sach);
          context.SaveChanges();
        }
      }
      ClearInputFields();
      sachHienTai = null;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearInputFields();
    }

    private void btnUpload_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog
      {
        Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
      };
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        picAnhSach.Image = Image.FromFile(openFileDialog.FileName);
      }
    }

    private void ClearInputFields()
    {
      txtMaSach.Clear();
      txtTenSach.Clear();
      cmbAuthor.SelectedIndex = -1;
      txtNhaXuatBan.Clear();
      txtGia.Clear();
      numSoLuong.Value = 0;
      txtMoTa.Clear();
      dtpNgayXuatBan.Value = DateTime.Now;
      picAnhSach.Image = null;
      sachHienTai = null;
      txtMaSach.Focus();
    }

    private string SaveImageAndGetPath()
    {
      if (picAnhSach.Image != null)
      {
        string path = Path.Combine(Environment.CurrentDirectory, "Images");
        if (!Directory.Exists(path))
        {
          Directory.CreateDirectory(path);
        }

        string fileName = Path.Combine(path, Guid.NewGuid().ToString() + ".png");
        picAnhSach.Image.Save(fileName);
        return fileName;
      }
      return null;
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower();
      var filteredBooks = danhMucSach.Where(b => b.TenSach.ToLower().Contains(searchText)).ToList();
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
        sachHienTai = danhMucSach[e.RowIndex];
        txtMaSach.Text = sachHienTai.MaSach.ToString();
        txtTenSach.Text = sachHienTai.TenSach;
        cmbAuthor.SelectedValue = sachHienTai.MaTacGia;
        txtNhaXuatBan.Text = sachHienTai.NhaXuatBan;
        txtGia.Text = sachHienTai.Gia.ToString();
        numSoLuong.Value = sachHienTai.SoLuong ?? 0; // Xử lý nullable
        txtMoTa.Text = sachHienTai.MoTa;
        dtpNgayXuatBan.Value = sachHienTai.NgayXuatBan ?? DateTime.Now; // Xử lý nullable

        if (!string.IsNullOrEmpty(sachHienTai.HinhAnh) && File.Exists(sachHienTai.HinhAnh))
        {
          picAnhSach.Image = Image.FromFile(sachHienTai.HinhAnh);
        }
      }
    }
  }
}