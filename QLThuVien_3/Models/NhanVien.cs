namespace QLThuVien_3.Models
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("NhanVien")]
  public partial class NhanVien
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NhanVien()
    {
      MuonSaches = new HashSet<MuonSach>();
    }

    [Key]
    [StringLength(50)]
    public string MaNhanVien { get; set; }

    [Required]
    [StringLength(100)]
    public string TenNhanVien { get; set; }

    [Required]
    [StringLength(255)]
    public string DiaChi { get; set; }

    [Required]
    [StringLength(15)]
    public string SoDienThoai { get; set; }

    [Column(TypeName = "date")]
    public DateTime NgaySinh { get; set; }

    [Required]
    [StringLength(10)]
    public string GioiTinh { get; set; }

    [Required]
    [StringLength(50)]
    public string Quyen { get; set; }

    [StringLength(100)]
    public string Email { get; set; }

    [StringLength(50)]
    public string TenDangNhap { get; set; }

    [Required]
    [StringLength(255)]
    public string MatKhau { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<MuonSach> MuonSaches { get; set; }
  }
}
