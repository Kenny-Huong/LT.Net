using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lab10_QLThuVien_110824.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.Context
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

        public virtual DbSet<TbAdmin> TbAdmin { get; set; }
        public virtual DbSet<TbChinhSach> TbChinhSach { get; set; }
        public virtual DbSet<TbDiem> TbDiem { get; set; }
        public virtual DbSet<TbGiaoVien> TbGiaoVien { get; set; }
        public virtual DbSet<TbKhoa> TbKhoa { get; set; }
        public virtual DbSet<TbLop> TbLop { get; set; }
        public virtual DbSet<TbMonHoc> TbMonHoc { get; set; }
        public virtual DbSet<TbSinhVien> TbSinhVien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P9QQDV1;Initial Catalog=QuanLySinhVien1109;Integrated Security=True ;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAdmin>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbAdmin__1788CCACCE86D21C");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.PassWord).IsUnicode(false);
            });

            modelBuilder.Entity<TbChinhSach>(entity =>
            {
                entity.HasKey(e => e.MaCs)
                    .HasName("PK__tbChinhS__27258E751938DFFE");

                entity.Property(e => e.MaCs).ValueGeneratedNever();

                entity.Property(e => e.TenCs).IsUnicode(false);
            });

            modelBuilder.Entity<TbDiem>(entity =>
            {
                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.TbDiem)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK__tbDiem__MaMH__59FA5E80");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.TbDiem)
                    .HasForeignKey(d => d.MaSv)
                    .HasConstraintName("FK__tbDiem__MaSV__59063A47");
            });

            modelBuilder.Entity<TbGiaoVien>(entity =>
            {
                entity.HasKey(e => e.MaGv)
                    .HasName("PK__tbGiaoVi__2725AEF3E15F2AFA");

                entity.Property(e => e.MaGv).ValueGeneratedNever();

                entity.Property(e => e.DiaChi).IsUnicode(false);

                entity.Property(e => e.GioiTinh).IsUnicode(false);

                entity.Property(e => e.TenGv).IsUnicode(false);
            });

            modelBuilder.Entity<TbKhoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__tbKhoa__65390405634D91DD");

                entity.Property(e => e.MaKhoa).ValueGeneratedNever();

                entity.Property(e => e.TenKhoa).IsUnicode(false);
            });

            modelBuilder.Entity<TbLop>(entity =>
            {
                entity.HasKey(e => e.MaLop)
                    .HasName("PK__tbLop__3B98D273DA03C488");

                entity.Property(e => e.MaLop).ValueGeneratedNever();

                entity.Property(e => e.TenLop).IsUnicode(false);

                entity.HasOne(d => d.MaKhoaNavigation)
                    .WithMany(p => p.TbLop)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("FK__tbLop__MaKhoa__4BAC3F29");
            });

            modelBuilder.Entity<TbMonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__tbMonHoc__2725DFD94BE79FC1");

                entity.Property(e => e.MaMh).ValueGeneratedNever();

                entity.Property(e => e.TenMh).IsUnicode(false);

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.TbMonHoc)
                    .HasForeignKey(d => d.MaGv)
                    .HasConstraintName("FK__tbMonHoc__MaGV__5629CD9C");
            });

            modelBuilder.Entity<TbSinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__tbSinhVi__2725081A5D7C1851");

                entity.Property(e => e.MaSv).ValueGeneratedNever();

                entity.Property(e => e.DiaChi).IsUnicode(false);

                entity.Property(e => e.GioiTinh).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.Ten).IsUnicode(false);

                entity.HasOne(d => d.MaCsNavigation)
                    .WithMany(p => p.TbSinhVien)
                    .HasForeignKey(d => d.MaCs)
                    .HasConstraintName("FK__tbSinhVien__MaCS__5070F446");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.TbSinhVien)
                    .HasForeignKey(d => d.MaLop)
                    .HasConstraintName("FK__tbSinhVie__MaLop__5165187F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
