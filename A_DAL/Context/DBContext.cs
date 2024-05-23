using System;
using System.Collections.Generic;
using A_DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acount> Acounts { get; set; }

    public virtual DbSet<BbNhanLai> BbNhanLais { get; set; }

    public virtual DbSet<CtNhanLai> CtNhanLais { get; set; }

    public virtual DbSet<CtPbg> CtPbgs { get; set; }

    public virtual DbSet<CtPhieuPhat> CtPhieuPhats { get; set; }

    public virtual DbSet<CtSach> CtSaches { get; set; }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhieuBanGiaoSach> PhieuBanGiaoSaches { get; set; }

    public virtual DbSet<PhieuPhat> PhieuPhats { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TacGium> TacGia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-9SIHFO6\\SQLEXPRESS;Initial Catalog=ThuVien001;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acount>(entity =>
        {
            entity.HasOne(d => d.MaNhanVienNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaNhanVien");
        });

        modelBuilder.Entity<BbNhanLai>(entity =>
        {
            entity.HasKey(e => e.MaBbnhanLai).HasName("PK__BB_NhanL__3563D9426AE9B70C");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.BbNhanLais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaNhanVien2");

            entity.HasOne(d => d.MaTheDocGiaNavigation).WithMany(p => p.BbNhanLais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaTheDocGia1");
        });

        modelBuilder.Entity<CtNhanLai>(entity =>
        {
            entity.HasKey(e => new { e.MaBbnhanLai, e.MaSach }).HasName("PK__CT_NhanL__FE408E009D075117");

            entity.HasOne(d => d.MaBbnhanLaiNavigation).WithMany(p => p.CtNhanLais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaBBNhanLai");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.CtNhanLais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaSach1");
        });

        modelBuilder.Entity<CtPbg>(entity =>
        {
            entity.HasKey(e => new { e.MaSach, e.MaPhieuBanGiao }).HasName("PK__CT_PBG__3FA40C2F5942D9E8");

            entity.HasOne(d => d.MaPhieuBanGiaoNavigation).WithMany(p => p.CtPbgs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaPhieuBanGiao");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.CtPbgs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaSach");
        });

        modelBuilder.Entity<CtPhieuPhat>(entity =>
        {
            entity.HasKey(e => new { e.MaPhieuPhat, e.MaSach }).HasName("PK__CT_Phieu__23578513DCE375E9");

            entity.HasOne(d => d.MaPhieuPhatNavigation).WithMany(p => p.CtPhieuPhats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaPhieuPhat");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.CtPhieuPhats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaSach2");
        });

        modelBuilder.Entity<CtSach>(entity =>
        {
            entity.HasKey(e => e.MaSachCt).HasName("PK__CT_Sach__A51FCCAFC12BD3B5");

            entity.Property(e => e.MaSachCt).ValueGeneratedNever();

            entity.HasOne(d => d.TenTacGiaNavigation).WithMany(p => p.CtSaches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_TenTacGia");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaTheDocGia).HasName("PK__DocGia__BA67A41E53F92A25");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA47E3C5E474");
        });

        modelBuilder.Entity<PhieuBanGiaoSach>(entity =>
        {
            entity.HasKey(e => e.MaPhieuBanGiao).HasName("PK__PhieuBan__D91780290CB242BD");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuBanGiaoSaches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaNhanVien1");

            entity.HasOne(d => d.MaTheDocGiaNavigation).WithMany(p => p.PhieuBanGiaoSaches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaTheDocGia");
        });

        modelBuilder.Entity<PhieuPhat>(entity =>
        {
            entity.HasKey(e => e.MaPhieuPhat).HasName("PK__PhieuPha__E874D251FB834239");

            entity.HasOne(d => d.MaBbnhanLaiNavigation).WithMany(p => p.PhieuPhats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaBBNhanLai1");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742DF81CFF64");

            entity.HasOne(d => d.MaSachCtNavigation).WithMany(p => p.Saches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MaDauSach1");
        });

        modelBuilder.Entity<TacGium>(entity =>
        {
            entity.HasKey(e => e.TenTacGia).HasName("PK__TacGia__2D926E314F4A4260");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
