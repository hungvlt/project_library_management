namespace QLThuVien_2.Models
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("MuonSach")]
  public partial class MuonSach
  {
    [Key]
    [StringLength(50)]
    public string MaMuon { get; set; }

    [StringLength(50)]
    public string MaDocGia { get; set; }

    public int? MaSach { get; set; }

    [StringLength(50)]
    public string MaTacGia { get; set; }

    [StringLength(50)]
    public string MaNhanVien { get; set; }

    [Column(TypeName = "date")]
    public DateTime NgayMuon { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayTra { get; set; }

    [StringLength(50)]
    public string TrangThai { get; set; }

    public virtual DanhMucSach DanhMucSach { get; set; }

    public virtual DocGia DocGia { get; set; }

    public virtual NhanVien NhanVien { get; set; }

    public virtual TacGia TacGia { get; set; }
  }
}
