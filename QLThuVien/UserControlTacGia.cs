using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class UserControlTacGia : UserControl
  {
    private string connectionString = "Server=Hung-Macbook\\SQLEXPRESS;Database=QLThuVien;Integrated Security=True;";
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
        danhSachTacGia.Clear();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();
          string query = "SELECT * FROM TacGia"; // Chắc chắn rằng tên bảng đúng
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
              TacGia tacGia = new TacGia
              {
                MaTacGia = reader["MaTacGia"].ToString(),
                TenTacGia = reader["TenTacGia"].ToString(),
                QuocTich = reader["QuocTich"].ToString(),
                DiaChi = reader["DiaChi"].ToString(),
                Gender = reader["Gender"].ToString(),
                DOB = reader["DOB"] != DBNull.Value ? DateTime.Parse(reader["DOB"].ToString()) : DateTime.MinValue,
                SoDienThoai = reader["SoDienThoai"].ToString()
              };
              danhSachTacGia.Add(tacGia);
            }
          }
        }
        HienThiDanhSachTacGia();
        lblTongTacGia.Text = danhSachTacGia.Count.ToString(); // Cập nhật số lượng tác giả
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
          Gender = cmbGender.SelectedItem.ToString(),
          DOB = dtpDOB.Value,
          SoDienThoai = txtSoDienThoai.Text
        };

        try
        {
          // Kiểm tra nếu mã tác giả đã tồn tại trong cơ sở dữ liệu
          using (SqlConnection connection = new SqlConnection(connectionString))
          {
            connection.Open();
            string checkQuery = "SELECT COUNT(*) FROM TacGia WHERE MaTacGia = @MaTacGia";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
              checkCommand.Parameters.AddWithValue("@MaTacGia", tacGiaHienTai.MaTacGia);
              int count = (int)checkCommand.ExecuteScalar();
              if (count > 0)
              {
                MessageBox.Show("Mã tác giả đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập mã khác.");
                return;
              }
            }

            // Thêm vào cơ sở dữ liệu
            string query = "INSERT INTO TacGia (MaTacGia, TenTacGia, QuocTich, DiaChi, Gender, DOB, SoDienThoai) VALUES (@MaTacGia, @TenTacGia, @QuocTich, @DiaChi, @Gender, @DOB, @SoDienThoai)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
              command.Parameters.AddWithValue("@MaTacGia", tacGiaHienTai.MaTacGia);
              command.Parameters.AddWithValue("@TenTacGia", tacGiaHienTai.TenTacGia);
              command.Parameters.AddWithValue("@QuocTich", tacGiaHienTai.QuocTich);
              command.Parameters.AddWithValue("@DiaChi", tacGiaHienTai.DiaChi);
              command.Parameters.AddWithValue("@Gender", tacGiaHienTai.Gender);
              command.Parameters.AddWithValue("@DOB", tacGiaHienTai.DOB);
              command.Parameters.AddWithValue("@SoDienThoai", tacGiaHienTai.SoDienThoai);
              command.ExecuteNonQuery();
            }
          }

          danhSachTacGia.Add(tacGiaHienTai);
          HienThiDanhSachTacGia();
          lblTongTacGia.Text = danhSachTacGia.Count.ToString(); // Cập nhật số lượng tác giả
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
          !long.TryParse(txtSoDienThoai.Text, out _) || // Kiểm tra số điện thoại có phải là số
          string.IsNullOrWhiteSpace(txtQuocTich.Text) ||
          string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
          cmbGender.SelectedItem == null) // Kiểm tra giới tính đã được chọn
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.");
        return false;
      }

      // Kiểm tra ngày sinh không lớn hơn ngày hiện tại
      if (dtpDOB.Value > DateTime.Now)
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
        tacGiaHienTai.Gender = cmbGender.SelectedItem?.ToString();
        tacGiaHienTai.DOB = dtpDOB.Value;
        tacGiaHienTai.SoDienThoai = txtSoDienThoai.Text;

        try
        {
          using (SqlConnection connection = new SqlConnection(connectionString))
          {
            connection.Open();
            string query = "UPDATE TacGia SET TenTacGia = @TenTacGia, QuocTich = @QuocTich, DiaChi = @DiaChi, Gender = @Gender, DOB = @DOB, SoDienThoai = @SoDienThoai WHERE MaTacGia = @MaTacGia";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
              command.Parameters.AddWithValue("@MaTacGia", tacGiaHienTai.MaTacGia);
              command.Parameters.AddWithValue("@TenTacGia", tacGiaHienTai.TenTacGia);
              command.Parameters.AddWithValue("@QuocTich", tacGiaHienTai.QuocTich);
              command.Parameters.AddWithValue("@DiaChi", tacGiaHienTai.DiaChi);
              command.Parameters.AddWithValue("@Gender", tacGiaHienTai.Gender);
              command.Parameters.AddWithValue("@DOB", tacGiaHienTai.DOB);
              command.Parameters.AddWithValue("@SoDienThoai", tacGiaHienTai.SoDienThoai);
              command.ExecuteNonQuery();
            }
          }

          // Cập nhật lại danh sách và hiển thị trên DataGridView
          HienThiDanhSachTacGia();
          lblTongTacGia.Text = danhSachTacGia.Count.ToString(); // Cập nhật số lượng tác giả
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
          using (SqlConnection connection = new SqlConnection(connectionString))
          {
            connection.Open();
            string query = "DELETE FROM TacGia WHERE MaTacGia = @MaTacGia";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
              command.Parameters.AddWithValue("@MaTacGia", tacGiaHienTai.MaTacGia);
              command.ExecuteNonQuery();
            }
          }

          danhSachTacGia.Remove(tacGiaHienTai);
          HienThiDanhSachTacGia();
          lblTongTacGia.Text = danhSachTacGia.Count.ToString(); // Cập nhật số lượng tác giả
          ClearInputFields();
          tacGiaHienTai = null; // Đặt lại cho null
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
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = danhSachTacGia;
    }

    private void ClearInputFields()
    {
      txtMaTacGia.Clear();
      txtTenTacGia.Clear();
      txtQuocTich.Clear();
      txtDiaChi.Clear();
      cmbGender.SelectedIndex = -1;
      dtpDOB.Value = DateTime.Now;
      txtSoDienThoai.Clear();
      txtMaTacGia.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearInputFields();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        tacGiaHienTai = (TacGia)dataGridView1.Rows[e.RowIndex].DataBoundItem;

        txtMaTacGia.Text = tacGiaHienTai.MaTacGia;
        txtTenTacGia.Text = tacGiaHienTai.TenTacGia;
        txtQuocTich.Text = tacGiaHienTai.QuocTich;
        txtDiaChi.Text = tacGiaHienTai.DiaChi;
        cmbGender.SelectedItem = tacGiaHienTai.Gender;
        dtpDOB.Value = tacGiaHienTai.DOB;
        txtSoDienThoai.Text = tacGiaHienTai.SoDienThoai;
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower(); // Lấy văn bản tìm kiếm và chuyển về chữ thường
      var filteredList = danhSachTacGia
          .Where(tg => tg.TenTacGia.ToLower().Contains(searchText)) // Lọc danh sách
          .ToList();

      // Cập nhật DataGridView với danh sách đã lọc
      dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu
      dataGridView1.DataSource = filteredList; // Thiết lập nguồn dữ liệu mới
    }
  }

  public class TacGia
  {
    public string MaTacGia { get; set; } // Mã tác giả
    public string TenTacGia { get; set; } // Tên tác giả
    public string QuocTich { get; set; } // Quốc tịch
    public string DiaChi { get; set; } // Địa chỉ
    public string Gender { get; set; } // Giới tính
    public DateTime DOB { get; set; } // Ngày sinh
    public string SoDienThoai { get; set; } // Số điện thoại
  }
}