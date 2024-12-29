using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLThuVien_2.Models
{
  public partial class QLThuVienContextDB_1 : DbContext
  {
    public QLThuVienContextDB_1()
        : base("name=QLThuVienContextDB_1")
    {
    }

    public virtual DbSet<DanhMucSach> DanhMucSaches { get; set; }
    public virtual DbSet<DocGia> DocGias { get; set; }
    public virtual DbSet<MuonSach> MuonSaches { get; set; }
    public virtual DbSet<NhanVien> NhanViens { get; set; }
    public virtual DbSet<TacGia> TacGias { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
    }
  }
}
