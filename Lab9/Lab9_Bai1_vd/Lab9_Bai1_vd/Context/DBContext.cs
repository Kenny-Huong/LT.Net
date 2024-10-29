using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lab9_Bai1_vd.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab9_Bai1_vd.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBanHang> TblBanHang { get; set; }
        public virtual DbSet<TblChiTietBanHang> TblChiTietBanHang { get; set; }
        public virtual DbSet<TblKhachHang> TblKhachHang { get; set; }
        public virtual DbSet<TblMatHang> TblMatHang { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P9QQDV1;Initial Catalog=qlBanHang;Integrated Security=True ;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBanHang>(entity =>
            {
                entity.HasKey(e => e.SoHieuHd)
                    .HasName("PK__tblBanHa__FB4ECC014E0652EA");

                entity.Property(e => e.SoHieuHd).ValueGeneratedNever();

                entity.Property(e => e.MaKh).IsUnicode(false);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TblBanHang)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__tblBanHang__MaKH__4D94879B");
            });

            modelBuilder.Entity<TblChiTietBanHang>(entity =>
            {
                entity.HasKey(e => new { e.SoHieuHd, e.MaMh })
                    .HasName("PK__tblChiTi__793C91FCE6765C9E");

                entity.Property(e => e.MaMh).IsUnicode(false);

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.TblChiTietBanHang)
                    .HasForeignKey(d => d.MaMh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblChiTiet__MaMH__5165187F");

                entity.HasOne(d => d.SoHieuHdNavigation)
                    .WithMany(p => p.TblChiTietBanHang)
                    .HasForeignKey(d => d.SoHieuHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblChiTie__SoHie__5070F446");
            });

            modelBuilder.Entity<TblKhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__tblKhach__2725CF1EE50DCF02");

                entity.Property(e => e.MaKh).IsUnicode(false);

                entity.Property(e => e.Diachi).IsUnicode(false);

                entity.Property(e => e.DienThoai).IsUnicode(false);

                entity.Property(e => e.Gioitinh).IsUnicode(false);

                entity.Property(e => e.Hoten).IsUnicode(false);
            });

            modelBuilder.Entity<TblMatHang>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__tblMatHa__2725DFD94C7B47DE");

                entity.Property(e => e.MaMh).IsUnicode(false);

                entity.Property(e => e.Dvt).IsUnicode(false);

                entity.Property(e => e.TenMh).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
