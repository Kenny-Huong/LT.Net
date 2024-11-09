using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NguyenVanHuong_DHTI15A5HN_05112024.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NguyenVanHuong_DHTI15A5HN_05112024.Context
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

        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<HopDongMatHang> HopDongMatHang { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MatHang> MatHang { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P9QQDV1;Initial Catalog=QuanLyBanHang_2024_v3;Integrated Security=True ;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasKey(e => e.SoHieuHd)
                    .HasName("PK__HopDong__FB4ECC013694C69C");

                entity.Property(e => e.SoHieuHd).IsUnicode(false);

                entity.Property(e => e.MaKh).IsUnicode(false);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HopDong)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HopDong__MaKH__4F7CD00D");
            });

            modelBuilder.Entity<HopDongMatHang>(entity =>
            {
                entity.HasKey(e => new { e.SoHieuHd, e.MaMh })
                    .HasName("PK__HopDong___793C91FCC39169B8");

                entity.Property(e => e.SoHieuHd).IsUnicode(false);

                entity.Property(e => e.MaMh).IsUnicode(false);

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.HopDongMatHang)
                    .HasForeignKey(d => d.MaMh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HopDong_Ma__MaMH__5165187F");

                entity.HasOne(d => d.SoHieuHdNavigation)
                    .WithMany(p => p.HopDongMatHang)
                    .HasForeignKey(d => d.SoHieuHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HopDong_M__SoHie__5070F446");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1EE072AAFF");

                entity.Property(e => e.MaKh).IsUnicode(false);
            });

            modelBuilder.Entity<MatHang>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__MatHang__2725DFD9283EC11E");

                entity.Property(e => e.MaMh).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
