using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class UserControlMuonTra : UserControl
  {
    private List<MuonSach> danhSachMuonSach = new List<MuonSach>();
    private List<MuonSach> danhSachMuonSachHienTai = new List<MuonSach>();
    private MuonSach muonSachHienTai = null;
    private bool isChangingText = false;
    private NhanVien _nhanVien;
    private string _vaiTro;

    public UserControlMuonTra(NhanVien nhanVien, string vaiTro)
    {
      InitializeComponent();
      _nhanVien = nhanVien;
      _vaiTro = vaiTro;
      InitializeDataGridView();
      LoadData();
      LoadComboBoxes();
      ClearInputFields();
      SetReadOnlyFields();

      cmbMaNhanVien.SelectedValue = _nhanVien.MaNhanVien;
      cmbMaNhanVien.Enabled = false;
    }

    private void UserControlMuonTra_Load(object sender, EventArgs e)
    {
      SetWatermark();
    }

    private void InitializeDataGridView()
    {
      dgvQuanLyMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      dgvQuanLyMuonTra.Columns.Add("MaMuon", "Mã phiếu mượn");
      dgvQuanLyMuonTra.Columns.Add("MaDocGia", "Mã độc giả");
      dgvQuanLyMuonTra.Columns.Add("TenDocGia", "Tên độc giả");
      dgvQuanLyMuonTra.Columns.Add("MaSach", "Mã sách");
      dgvQuanLyMuonTra.Columns.Add("TenSach", "Tên sách");
      dgvQuanLyMuonTra.Columns.Add("SoLuongMuon", "Số lượng mượn");
      dgvQuanLyMuonTra.Columns.Add("MaNhanVien", "Mã nhân viên");
      dgvQuanLyMuonTra.Columns.Add("TenNhanVien", "Tên nhân viên");
      dgvQuanLyMuonTra.Columns.Add("NgayMuon", "Ngày mượn");
      dgvQuanLyMuonTra.Columns.Add("NgayTra", "Ngày trả");
      dgvQuanLyMuonTra.Columns.Add("NgayTraThucTe", "Ngày trả thực tế");
      dgvQuanLyMuonTra.Columns.Add("TrangThai", "Trạng thái");

      foreach (DataGridViewColumn column in dgvQuanLyMuonTra.Columns)
      {
        column.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
      }

      dgvQuanLyMuonTra.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
      dgvQuanLyMuonTra.RowTemplate.Height = 35;
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB())
        {
          danhSachMuonSach = context.MuonSaches
              .Include(ms => ms.DocGia)
              .Include(ms => ms.DanhMucSach)
              .Include(ms => ms.NhanVien)
              .ToList();
        }
        danhSachMuonSachHienTai = danhSachMuonSach;
        HienThiDanhSachMuonSach();
        UpdateTotalReceipts();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void HienThiDanhSachMuonSach()
    {
      dgvQuanLyMuonTra.Rows.Clear();
      foreach (var muonSach in danhSachMuonSachHienTai)
      {
        AddMuonSachToGrid(muonSach);
      }
    }

    private void AddMuonSachToGrid(MuonSach muonSach)
    {
      int rowIndex = dgvQuanLyMuonTra.Rows.Add();
      DataGridViewRow row = dgvQuanLyMuonTra.Rows[rowIndex];

      row.Cells["MaMuon"].Value = muonSach.MaMuon;
      row.Cells["MaDocGia"].Value = muonSach.MaDocGia;
      row.Cells["TenDocGia"].Value = muonSach.DocGia?.TenDocGia;
      row.Cells["MaSach"].Value = muonSach.MaSach;
      row.Cells["TenSach"].Value = muonSach.DanhMucSach?.TenSach;
      row.Cells["SoLuongMuon"].Value = muonSach.SoLuongMuon;
      row.Cells["MaNhanVien"].Value = muonSach.MaNhanVien;
      row.Cells["TenNhanVien"].Value = muonSach.NhanVien?.TenNhanVien;
      row.Cells["NgayMuon"].Value = muonSach.NgayMuon.ToShortDateString();
      row.Cells["NgayTra"].Value = muonSach.NgayTra?.ToShortDateString();
      row.Cells["NgayTraThucTe"].Value = muonSach.NgayTraThucTe?.ToShortDateString();
      row.Cells["TrangThai"].Value = muonSach.TrangThai;
    }

    private void LoadComboBoxes()
    {
      using (var context = new QLThuVienContextDB())
      {
        cmbMaDocGia.DataSource = context.DocGias.ToList();
        cmbMaDocGia.DisplayMember = "MaDocGia";
        cmbMaDocGia.ValueMember = "MaDocGia";

        cmbMaNhanVien.DataSource = context.NhanViens.ToList();
        cmbMaNhanVien.DisplayMember = "MaNhanVien";
        cmbMaNhanVien.ValueMember = "MaNhanVien";

        cmbLocTheoTrangThai.Items.Add("Tất cả");
        cmbLocTheoTrangThai.Items.Add("Đang mượn");
        cmbLocTheoTrangThai.Items.Add("Đã trả");
        cmbLocTheoTrangThai.SelectedIndex = 0;
      }
    }

    private void SetReadOnlyFields()
    {
      txtMaMuon.ReadOnly = true;
      txtTenDocGia.ReadOnly = true;
      txtTenSach1.ReadOnly = true;
      txtTenNhanVien.ReadOnly = true;
      txtTrangThai.ReadOnly = true;
      txtSoLuongSachConLai.ReadOnly = true;
    }

    private bool ValidateInput()
    {
      List<string> errors = new List<string>();

      if (cmbMaDocGia.SelectedValue == null)
      {
        errors.Add("Vui lòng chọn mã độc giả.");
      }

      if (numMaSach1.Value <= 0)
      {
        errors.Add("Vui lòng chọn mã sách hợp lệ.");
      }

      if (cmbMaNhanVien.SelectedValue == null)
      {
        errors.Add("Vui lòng chọn mã nhân viên.");
      }

      if (errors.Count > 0)
      {
        MessageBox.Show(string.Join(Environment.NewLine, errors), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      return true;
    }

    private string GenerateMaMuon()
    {
      using (var context = new QLThuVienContextDB())
      {
        var lastMaMuon = context.MuonSaches
            .OrderByDescending(ms => ms.MaMuon)
            .Select(ms => ms.MaMuon)
            .FirstOrDefault();

        int newMaMuonNumber = 1;
        if (lastMaMuon != null)
        {
          string numberPart = lastMaMuon.Substring(2);
          newMaMuonNumber = int.Parse(numberPart) + 1;
        }

        if (newMaMuonNumber > 999)
        {
          throw new Exception("Đã đạt giới hạn số phiếu mượn.");
        }

        return "MM" + newMaMuonNumber.ToString("D3");
      }
    }

    private int soLuongMuon;

    private void btnMuon_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        string maMuon = GenerateMaMuon();
        string maDocGia = cmbMaDocGia.SelectedValue.ToString();
        int? maSach = (int?)numMaSach1.Value;
        soLuongMuon = (int)numSoLuongMuon.Value;

        if (soLuongMuon > 4)
        {
          MessageBox.Show("Số lượng sách mượn không được vượt quá 4 cho mỗi mã sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        using (var context = new QLThuVienContextDB())
        {
          var soLuongSachDaMuon = context.MuonSaches
            .Where(ms => ms.MaDocGia == maDocGia && ms.MaSach == maSach && ms.TrangThai == "Đang mượn")
            .Select(ms => (int?)ms.SoLuongMuon)
            .Sum() ?? 0;

          if (soLuongSachDaMuon + soLuongMuon > 4)
          {
            MessageBox.Show("Tổng số lượng sách mượn cho mã sách này không được vượt quá 4.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }

          var phieuDangMuon = context.MuonSaches
              .FirstOrDefault(ms => ms.MaDocGia == maDocGia && ms.MaSach == maSach && ms.TrangThai == "Đang mượn");

          if (phieuDangMuon != null)
          {
            MessageBox.Show("Không thể mượn sách này vì độc giả đã có phiếu mượn sách tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }

          var sach = context.DanhMucSaches.Find(maSach);
          if (sach == null || sach.SoLuong < soLuongMuon)
          {
            MessageBox.Show("Sách không còn sẵn có để mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }

          sach.SoLuong -= soLuongMuon;
          context.SaveChanges();
        }

        var muonSach = new MuonSach
        {
          MaMuon = maMuon,
          MaDocGia = maDocGia,
          MaSach = maSach,
          MaNhanVien = _nhanVien.MaNhanVien,
          NgayMuon = DateTime.Now,
          NgayTra = DateTime.Now.AddDays(14),
          TrangThai = "Đang mượn",
          SoLuongMuon = soLuongMuon
        };

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            context.MuonSaches.Add(muonSach);
            context.SaveChanges();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm phiếu mượn: " + ex.Message);
          return;
        }

        MessageBox.Show("Thêm phiếu mượn thành công! Mã mượn: " + maMuon);
        LoadData();
        ClearInputFields();
        UpdateTotalReceipts();
      }
    }

    private void btnTra_Click(object sender, EventArgs e)
    {
      if (muonSachHienTai != null)
      {
        int soLuongTra = (int)numSoLuongMuon.Value;

        muonSachHienTai.NgayTraThucTe = DateTime.Now;
        muonSachHienTai.TrangThai = muonSachHienTai.NgayTraThucTe > muonSachHienTai.NgayTra ? "Trả muộn" : "Đã trả";

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            var phieuMuon = context.MuonSaches.Find(muonSachHienTai.MaMuon);
            if (phieuMuon == null)
            {
              MessageBox.Show("Phiếu mượn không tồn tại.");
              return;
            }

            if (phieuMuon.TrangThai != "Đang mượn")
            {
              MessageBox.Show("Phiếu này không thể trả vì chưa được mượn.");
              return;
            }

            phieuMuon.NgayTraThucTe = muonSachHienTai.NgayTraThucTe;
            phieuMuon.TrangThai = muonSachHienTai.TrangThai;

            var sach = context.DanhMucSaches.Find(muonSachHienTai.MaSach);
            if (sach == null)
            {
              MessageBox.Show("Sách không tồn tại.");
              return;
            }

            sach.SoLuong += soLuongTra;
            context.SaveChanges();
          }

          MessageBox.Show("Trả sách thành công!");
          LoadData();
          ClearInputFields();
          UpdateTotalReceipts();
        }
        catch (DbUpdateException ex)
        {
          MessageBox.Show("Lỗi cập nhật cơ sở dữ liệu: " + ex.InnerException?.Message);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi cập nhật phiếu trả: " + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một phiếu để trả.");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (muonSachHienTai != null)
      {
        if (muonSachHienTai.TrangThai != "Đã trả")
        {
          MessageBox.Show("Không thể xóa phiếu mượn vì sách vẫn đang được mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          try
          {
            using (var context = new QLThuVienContextDB())
            {
              var sachToDelete = context.MuonSaches.Find(muonSachHienTai.MaMuon);
              if (sachToDelete != null)
              {
                context.MuonSaches.Remove(sachToDelete);
                context.SaveChanges();
              }
              else
              {
                MessageBox.Show("Phiếu mượn không tồn tại trong cơ sở dữ liệu.");
              }
            }

            LoadData();
            ClearInputFields();
            muonSachHienTai = null;
            UpdateTotalReceipts();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một phiếu để xóa.");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
      LoadData();
    }

    private void ClearInputFields()
    {
      txtMaMuon.Clear();
      cmbMaDocGia.SelectedIndex = -1;
      numMaSach1.Value = 0;
      txtTrangThai.Clear();
      txtTenDocGia.Clear();
      txtTenSach1.Clear();
      txtSoLuongSachConLai.Clear();
      numSoLuongMuon.Value = 1;
      txtTimKiemTheoTen.Clear();
    }

    private void UpdateTotalReceipts()
    {
      lblTongPhieu.Text = danhSachMuonSach.Count().ToString();
    }

    //private void cmbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //  if (cmbMaDocGia.SelectedValue != null)
    //  {
    //    var docGia = (DocGia)cmbMaDocGia.SelectedItem;
    //    txtTenDocGia.Text = docGia?.TenDocGia;
    //  }
    //}

    private void cmbMaDocGia_TextChanged(object sender, EventArgs e)
    {
      string maDocGiaInput = cmbMaDocGia.Text.Trim();

      if (!string.IsNullOrEmpty(maDocGiaInput))
      {
        using (var context = new QLThuVienContextDB())
        {
          var docGia = context.DocGias
              .FirstOrDefault(d => d.MaDocGia.Equals(maDocGiaInput, StringComparison.OrdinalIgnoreCase));

          if (docGia != null)
          {
            txtTenDocGia.Text = docGia.TenDocGia;
          }
          else
          {
            txtTenDocGia.Clear();
          }
        }
      }
      else
      {
        txtTenDocGia.Clear();
      }
    }

    private void cmbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbMaNhanVien.SelectedValue != null)
      {
        var nhanVien = (NhanVien)cmbMaNhanVien.SelectedItem;
        txtTenNhanVien.Text = nhanVien?.TenNhanVien;
      }
    }

    private void dgvQuanLyMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < danhSachMuonSachHienTai.Count)
      {
        muonSachHienTai = danhSachMuonSachHienTai[e.RowIndex];
        if (muonSachHienTai != null)
        {
          txtMaMuon.Text = muonSachHienTai.MaMuon;
          cmbMaDocGia.SelectedValue = muonSachHienTai.MaDocGia;

          if (muonSachHienTai.MaSach.HasValue)
          {
            numMaSach1.Value = muonSachHienTai.MaSach.Value;
          }

          cmbMaNhanVien.SelectedValue = muonSachHienTai.MaNhanVien;
          dtpNgayMuon.Value = muonSachHienTai.NgayMuon;
          dtpNgayTra.Value = muonSachHienTai.NgayTra ?? DateTime.Now;
          txtTrangThai.Text = muonSachHienTai.TrangThai;
          txtTenDocGia.Text = muonSachHienTai.DocGia?.TenDocGia;
          txtTenNhanVien.Text = muonSachHienTai.NhanVien?.TenNhanVien;
          txtTenSach1.Text = muonSachHienTai.DanhMucSach?.TenSach;

          var sach = muonSachHienTai.DanhMucSach;
          if (sach != null)
          {
            txtSoLuongSachConLai.Text = sach.SoLuong.ToString();
          }
          numSoLuongMuon.Value = muonSachHienTai.SoLuongMuon;
        }
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      if (isChangingText) return;

      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      if (string.IsNullOrEmpty(searchText) || searchText == "mã phiếu, mã độc giả, mã nhân viên, mã sách")
      {
        danhSachMuonSachHienTai = danhSachMuonSach;
      }
      else
      {
        danhSachMuonSachHienTai = danhSachMuonSach
            .Where(muonSach =>
                muonSach.MaMuon.ToLower().Contains(searchText) ||
                muonSach.MaDocGia.ToLower().Contains(searchText) ||
                muonSach.MaNhanVien.ToLower().Contains(searchText) ||
                (muonSach.DocGia?.TenDocGia.ToLower().Contains(searchText) == true) ||
                (muonSach.NhanVien?.TenNhanVien.ToLower().Contains(searchText) == true) ||
                muonSach.MaSach.ToString().Contains(searchText)
            )
            .ToList();
      }

      HienThiDanhSachMuonSach();
      lblTongPhieu.Text = danhSachMuonSachHienTai.Count().ToString();
    }

    private void dgvQuanLyMuonTra_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
      {
        dgvQuanLyMuonTra.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
      else
      {
        dgvQuanLyMuonTra.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
      }
    }

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Mã phiếu, mã độc giả, mã nhân viên, mã sách")
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

      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Mã phiếu, mã độc giả, mã nhân viên, mã sách")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "Mã phiếu, mã độc giả, mã nhân viên, mã sách";
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

    private void txtTimKiemTheoTen_Leave(object sender, EventArgs e)
    {
      SetWatermark();
    }

    private void numMaSach1_ValueChanged(object sender, EventArgs e)
    {
      int maSach;
      if (int.TryParse(numMaSach1.Value.ToString(), out maSach))
      {
        using (var context = new QLThuVienContextDB())
        {
          var sach = context.DanhMucSaches.FirstOrDefault(s => s.MaSach == maSach);
          if (sach != null)
          {
            txtTenSach1.Text = sach.TenSach;
            txtSoLuongSachConLai.Text = sach.SoLuong.ToString();
          }
          else
          {
            txtTenSach1.Clear();
            txtSoLuongSachConLai.Clear();
          }
        }
      }
      else
      {
        txtTenSach1.Clear();
        txtSoLuongSachConLai.Clear();
      }
    }

    private void cmbLocTheoTrangThai_SelectedIndexChanged(object sender, EventArgs e)
    {
      FilterMuonSachByStatus();
    }

    private void FilterMuonSachByStatus()
    {
      string selectedStatus = cmbLocTheoTrangThai.SelectedItem.ToString();

      if (selectedStatus == "Tất cả")
      {
        danhSachMuonSachHienTai = danhSachMuonSach;
      }
      else
      {
        danhSachMuonSachHienTai = danhSachMuonSach
            .Where(muonSach => muonSach.TrangThai == selectedStatus)
            .ToList();
      }

      HienThiDanhSachMuonSach();
      lblTongPhieu.Text = danhSachMuonSachHienTai.Count().ToString();
    }
  }
}