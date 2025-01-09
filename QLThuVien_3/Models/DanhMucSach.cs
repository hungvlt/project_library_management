namespace QLThuVien_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucSach")]
    public partial class DanhMucSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucSach()
        {
            MuonSaches = new HashSet<MuonSach>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSach { get; set; }

        [StringLength(100)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string MaTacGia { get; set; }

        [StringLength(100)]
        public string NhaXuatBan { get; set; }

        public decimal? Gia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(200)]
        public string HinhAnh { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayXuatBan { get; set; }

        [StringLength(50)]
        public string TheLoai { get; set; }

        public virtual TacGia TacGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuonSach> MuonSaches { get; set; }
    }
}
