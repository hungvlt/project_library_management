using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class UserControlDanhMucSach : UserControl
  {
    private string connectionString = "Server=Hung-Macbook\\SQLEXPRESS;Database=QLThuVien;Integrated Security=True;";
    private List<Book> books = new List<Book>();
    private Book currentBook = null;

    public UserControlDanhMucSach()
    {
      InitializeComponent();
      InitializeDataGridView();
    }

    private void UserControlDanhMucSach_Load(object sender, EventArgs e)
    {
      LoadBooksFromDatabase();
    }

    private void InitializeDataGridView()
    {
      // Thiết lập DataGridView
      dataGridView1.Size = new Size(805, 570);
      dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      // Tạo cột hình ảnh
      DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
      {
        HeaderText = "Hình ảnh",
        Name = "HinhAnh",
        Width = 120
      };
      dataGridView1.Columns.Add(imageColumn);

      // Thêm các cột khác
      dataGridView1.Columns.Add("ID", "ID");
      dataGridView1.Columns.Add("Tên sách", "Tên sách");
      dataGridView1.Columns.Add("Tác giả", "Tác giả");
      dataGridView1.Columns.Add("Giá", "Giá");
      dataGridView1.Columns.Add("NXB", "Nhà xuất bản");
      dataGridView1.Columns.Add("SL", "Số lượng");
      dataGridView1.Columns.Add("Thể loại", "Thể loại");

      // Đặt kích thước cột
      dataGridView1.Columns["ID"].Width = 50;
      dataGridView1.Columns["Tên sách"].Width = 150;
      dataGridView1.Columns["Tác giả"].Width = 100;
      dataGridView1.Columns["Giá"].Width = 80;
      dataGridView1.Columns["NXB"].Width = 100;
      dataGridView1.Columns["SL"].Width = 70;
      dataGridView1.Columns["Thể loại"].Width = 100;

      // Đặt chiều cao cho mỗi hàng
      dataGridView1.RowTemplate.Height = 150; // Chiều cao hàng
    }

    private void LoadBooksFromDatabase()
    {
      dataGridView1.Rows.Clear(); // Xóa tất cả các hàng đã có
      books.Clear(); // Xóa danh sách sách

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        connection.Open();
        string query = "SELECT * FROM DanhMucSach"; // Tên bảng
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
          // Thêm hàng vào DataGridView
          Book book = new Book
          {
            BookID = reader["BookID"].ToString(),
            TenSach = reader["TenSach"].ToString(),
            TacGia = reader["TacGia"].ToString(),
            Gia = reader["Gia"].ToString(),
            NhaXuatBan = reader["NhaXuatBan"].ToString(),
            SoLuong = reader["SoLuong"].ToString(),
            TheLoai = reader["TheLoai"].ToString(),
            HinhAnh = reader["HinhAnh"] as string
          };

          books.Add(book);
          AddBookToGrid(book);
        }
      }
    }

    private void AddBookToGrid(Book book)
    {
      int rowIndex = dataGridView1.Rows.Add();
      DataGridViewRow row = dataGridView1.Rows[rowIndex];

      row.Cells["ID"].Value = book.BookID;
      row.Cells["Tên sách"].Value = book.TenSach;
      row.Cells["Tác giả"].Value = book.TacGia;
      row.Cells["Giá"].Value = book.Gia;
      row.Cells["NXB"].Value = book.NhaXuatBan;
      row.Cells["SL"].Value = book.SoLuong;
      row.Cells["Thể loại"].Value = book.TheLoai;

      // Thêm hình ảnh vào cột hình ảnh
      if (!string.IsNullOrEmpty(book.HinhAnh) && File.Exists(book.HinhAnh))
      {
        row.Cells["HinhAnh"].Value = Image.FromFile(book.HinhAnh);
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      SaveBookToDatabase();
      LoadBooksFromDatabase();
    }

    private void SaveBookToDatabase()
    {
      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        connection.Open();
        string query = "INSERT INTO DanhMucSach (BookID, TenSach, TacGia, TheLoai, NhaXuatBan, Gia, SoLuong, HinhAnh) VALUES (@BookID, @TenSach, @TacGia, @TheLoai, @NhaXuatBan, @Gia, @SoLuong, @HinhAnh)";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@BookID", int.Parse(txtBookID.Text)); // Nhập mã sách
          command.Parameters.AddWithValue("@TenSach", txtProductName.Text);
          //command.Parameters.AddWithValue("@TacGia", txtAuthor.Text);
          command.Parameters.AddWithValue("@TheLoai", cmbCategory.SelectedItem?.ToString());
          command.Parameters.AddWithValue("@NhaXuatBan", txtPublisher.Text);
          command.Parameters.AddWithValue("@Gia", decimal.Parse(txtPrice.Text));
          command.Parameters.AddWithValue("@SoLuong", (int)numQuantity.Value);
          command.Parameters.AddWithValue("@HinhAnh", SaveImageAndGetPath());

          command.ExecuteNonQuery();
        }
      }
      ClearInputFields();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (currentBook != null)
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
      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        connection.Open();
        string query = "UPDATE DanhMucSach SET TenSach = @TenSach, TacGia = @TacGia, TheLoai = @TheLoai, NhaXuatBan = @NhaXuatBan, Gia = @Gia, SoLuong = @SoLuong, HinhAnh = @HinhAnh WHERE BookID = @BookID";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@BookID", currentBook.BookID);
          command.Parameters.AddWithValue("@TenSach", txtProductName.Text);
          //command.Parameters.AddWithValue("@TacGia", txtAuthor.Text);
          command.Parameters.AddWithValue("@TheLoai", cmbCategory.SelectedItem?.ToString());
          command.Parameters.AddWithValue("@NhaXuatBan", txtPublisher.Text);
          command.Parameters.AddWithValue("@Gia", decimal.Parse(txtPrice.Text));
          command.Parameters.AddWithValue("@SoLuong", (int)numQuantity.Value);
          command.Parameters.AddWithValue("@HinhAnh", SaveImageAndGetPath());

          command.ExecuteNonQuery();
        }
      }
      ClearInputFields();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (currentBook != null)
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
      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        connection.Open();
        string query = "DELETE FROM DanhMucSach WHERE BookID = @BookID";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@BookID", currentBook.BookID);
          command.ExecuteNonQuery();
        }
      }
      ClearInputFields();
      currentBook = null; // Reset current book
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
        PictureBox.Image = Image.FromFile(openFileDialog.FileName);
      }
    }

    private void ClearInputFields()
    {
      txtBookID.Clear();
      txtProductName.Clear();
      //txtAuthor.Clear();
      txtPublisher.Clear();
      txtPrice.Clear();
      numQuantity.Value = 0;
      cmbCategory.SelectedIndex = -1;
      PictureBox.Image = null;
      currentBook = null; // Reset current book
    }

    private string SaveImageAndGetPath()
    {
      if (PictureBox.Image != null)
      {
        string path = Path.Combine(Environment.CurrentDirectory, "Images");
        if (!Directory.Exists(path))
        {
          Directory.CreateDirectory(path);
        }

        string fileName = Path.Combine(path, Guid.NewGuid().ToString() + ".png");
        PictureBox.Image.Save(fileName);
        return fileName;
      }
      return null;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        currentBook = books[e.RowIndex];
        txtBookID.Text = currentBook.BookID;
        txtProductName.Text = currentBook.TenSach;
        //txtAuthor.Text = currentBook.TacGia;
        txtPublisher.Text = currentBook.NhaXuatBan;
        txtPrice.Text = currentBook.Gia;
        numQuantity.Value = Convert.ToDecimal(currentBook.SoLuong);
        cmbCategory.SelectedItem = currentBook.TheLoai;

        if (!string.IsNullOrEmpty(currentBook.HinhAnh) && File.Exists(currentBook.HinhAnh))
        {
          PictureBox.Image = Image.FromFile(currentBook.HinhAnh);
        }
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower();
      var filteredBooks = books.Where(b => b.TenSach.ToLower().Contains(searchText)).ToList();
      dataGridView1.Rows.Clear();
      foreach (var book in filteredBooks)
      {
        AddBookToGrid(book);
      }
    }
  }

  public class Book
  {
    public string BookID { get; set; }
    public string TenSach { get; set; }
    public string TacGia { get; set; }
    public string Gia { get; set; }
    public string NhaXuatBan { get; set; }
    public string SoLuong { get; set; }
    public string TheLoai { get; set; }
    public string HinhAnh { get; set; }
  }
}