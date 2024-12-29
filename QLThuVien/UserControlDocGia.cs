using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class UserControlDocGia : UserControl
  {
    private string connectionString = "Server=Hung-Macbook\\SQLEXPRESS;Database=QLThuVien;Integrated Security=True;";
    private List<DocGia> danhSachDocGia = new List<DocGia>();
    private DocGia docGiaHienTai = null;

    public UserControlDocGia()
    {
      InitializeComponent();
      InitializeDataGridView(); // Khởi tạo cột cho DataGridView
      LoadData();
    }

    private void InitializeDataGridView()
    {
      dataGridView1.Columns.Clear(); // Xóa các cột cũ
      dataGridView1.Columns.Add("Ma", "Mã");
      dataGridView1.Columns.Add("HoTen", "Họ Tên");
      dataGridView1.Columns.Add("Phone", "Số Điện Thoại");
      dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
      dataGridView1.Columns.Add("DiaChi", "Địa Chỉ");
    }

    private void LoadData()
    {
      try
      {
        danhSachDocGia.Clear();
        dataGridView1.Rows.Clear();
        int count = 0;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();
          string query = "SELECT * FROM DocGia";
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
              DocGia docGia = new DocGia
              {
                Ma = reader["Ma"].ToString(),
                HoTen = reader["HoTen"].ToString(),
                Phone = reader["Phone"].ToString(),
                GioiTinh = reader["GioiTinh"].ToString(),
                DiaChi = reader["DiaChi"].ToString()
              };
              danhSachDocGia.Add(docGia);
              dataGridView1.Rows.Add(docGia.Ma, docGia.HoTen, docGia.Phone, docGia.GioiTinh, docGia.DiaChi);
              count++;
            }
          }
        }
        lblTongDocGia.Text = count.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower();

      // Lọc danh sách theo tên
      var filteredList = danhSachDocGia
          .Where(docGia => docGia.HoTen.ToLower().Contains(searchText))
          .ToList();

      // Cập nhật DataGridView với danh sách đã lọc
      dataGridView1.Rows.Clear();
      foreach (var item in filteredList)
      {
        dataGridView1.Rows.Add(item.Ma, item.HoTen, item.Phone, item.GioiTinh, item.DiaChi);
      }
    }

    private void ClearInputFields()
    {
      txtma.Clear();
      txthoten.Clear();
      txtPhone.Clear();
      txtdiachi.Clear();
      radionam.Checked = false;
      radionu.Checked = false;
      txtma.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearInputFields();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        docGiaHienTai = new DocGia
        {
          Ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
          HoTen = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
          Phone = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
          GioiTinh = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
          DiaChi = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()
        };

        // Hiển thị thông tin vào các trường nhập liệu
        txtma.Text = docGiaHienTai.Ma;
        txthoten.Text = docGiaHienTai.HoTen;
        txtPhone.Text = docGiaHienTai.Phone;
        txtdiachi.Text = docGiaHienTai.DiaChi;
        radionam.Checked = docGiaHienTai.GioiTinh == "Nam";
        radionu.Checked = docGiaHienTai.GioiTinh == "Nữ";
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtma.Text) || string.IsNullOrWhiteSpace(txthoten.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
      {
        MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
        return;
      }

      // Kiểm tra định dạng số điện thoại
      if (txtPhone.Text.Length != 10 || !long.TryParse(txtPhone.Text, out _))
      {
        MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
        return;
      }

      docGiaHienTai = new DocGia
      {
        Ma = txtma.Text,
        HoTen = txthoten.Text,
        Phone = txtPhone.Text,
        GioiTinh = radionam.Checked ? "Nam" : "Nữ",
        DiaChi = txtdiachi.Text
      };

      try
      {
        // Kiểm tra mã độc giả đã tồn tại
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();
          string checkQuery = "SELECT COUNT(*) FROM DocGia WHERE Ma = @Ma";
          using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
          {
            checkCommand.Parameters.AddWithValue("@Ma", docGiaHienTai.Ma);
            int count = (int)checkCommand.ExecuteScalar();
            if (count > 0)
            {
              MessageBox.Show("Mã độc giả đã tồn tại. Vui lòng nhập mã khác.");
              return;
            }
          }

          // Thêm vào cơ sở dữ liệu
          string query = "INSERT INTO DocGia (Ma, HoTen, Phone, GioiTinh, DiaChi) VALUES (@Ma, @HoTen, @Phone, @GioiTinh, @DiaChi)";
          using (SqlCommand command = new SqlCommand(query, connection))
          {
            command.Parameters.AddWithValue("@Ma", docGiaHienTai.Ma);
            command.Parameters.AddWithValue("@HoTen", docGiaHienTai.HoTen);
            command.Parameters.AddWithValue("@Phone", docGiaHienTai.Phone);
            command.Parameters.AddWithValue("@GioiTinh", docGiaHienTai.GioiTinh);
            command.Parameters.AddWithValue("@DiaChi", docGiaHienTai.DiaChi);
            command.ExecuteNonQuery();
          }
        }

        LoadData();
        ClearInputFields();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi thêm độc giả: " + ex.Message);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (dataGridView1.SelectedRows.Count > 0)
      {
        if (MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

          try
          {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              connection.Open();
              string query = "DELETE FROM DocGia WHERE Ma = @Ma";
              using (SqlCommand command = new SqlCommand(query, connection))
              {
                command.Parameters.AddWithValue("@Ma", ma);
                command.ExecuteNonQuery();
              }
            }

            LoadData();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi xóa độc giả: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một hàng để xóa.");
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (docGiaHienTai != null)
      {
        // Cập nhật thông tin từ các trường nhập liệu
        docGiaHienTai.HoTen = txthoten.Text;
        docGiaHienTai.Phone = txtPhone.Text;
        docGiaHienTai.GioiTinh = radionam.Checked ? "Nam" : "Nữ";
        docGiaHienTai.DiaChi = txtdiachi.Text;

        // Kiểm tra định dạng số điện thoại
        if (txtPhone.Text.Length != 10 || !long.TryParse(txtPhone.Text, out _))
        {
          MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
          return;
        }

        try
        {
          using (SqlConnection connection = new SqlConnection(connectionString))
          {
            connection.Open();
            string query = "UPDATE DocGia SET HoTen = @HoTen, Phone = @Phone, GioiTinh = @GioiTinh, DiaChi = @DiaChi WHERE Ma = @Ma";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
              command.Parameters.AddWithValue("@Ma", docGiaHienTai.Ma);
              command.Parameters.AddWithValue("@HoTen", docGiaHienTai.HoTen);
              command.Parameters.AddWithValue("@Phone", docGiaHienTai.Phone);
              command.Parameters.AddWithValue("@GioiTinh", docGiaHienTai.GioiTinh);
              command.Parameters.AddWithValue("@DiaChi", docGiaHienTai.DiaChi);
              command.ExecuteNonQuery();
            }
          }

          // Cập nhật lại danh sách và hiển thị trên DataGridView
          LoadData();
          ClearInputFields();
          MessageBox.Show("Thông tin độc giả đã được cập nhật.");
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi cập nhật độc giả: " + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một hàng để sửa.");
      }
    }
  }

  public class DocGia
  {
    public string Ma { get; set; }
    public string HoTen { get; set; }
    public string Phone { get; set; }
    public string GioiTinh { get; set; }
    public string DiaChi { get; set; }
  }
}