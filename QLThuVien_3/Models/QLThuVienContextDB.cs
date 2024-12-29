using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLThuVien_3.Models
{
  public partial class QLThuVienContextDB : DbContext
  {
    public QLThuVienContextDB()
        : base("name=QLThuVienContextDB")
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
