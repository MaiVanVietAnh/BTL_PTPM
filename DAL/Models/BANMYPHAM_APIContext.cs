using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class BANMYPHAM_APIContext : DbContext
    {
        public BANMYPHAM_APIContext()
        {
        }

        public BANMYPHAM_APIContext(DbContextOptions<BANMYPHAM_APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BinhLuan> BinhLuans { get; set; } = null!;
        public virtual DbSet<ChiTietAnhSanPham> ChiTietAnhSanPhams { get; set; } = null!;
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; } = null!;
        public virtual DbSet<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; } = null!;
        public virtual DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = null!;
        public virtual DbSet<ChiTietKho> ChiTietKhos { get; set; } = null!;
        public virtual DbSet<DonHang> DonHangs { get; set; } = null!;
        public virtual DbSet<GiaBan> GiaBans { get; set; } = null!;
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; } = null!;
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<Kho> Khos { get; set; } = null!;
        public virtual DbSet<LienHe> LienHes { get; set; } = null!;
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-K3OJQOHI\\SQLEXPRESS;Database=BANMYPHAM_API;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuan>(entity =>
            {
                entity.HasKey(e => e.MaBinhLuan)
                    .HasName("PK__BinhLuan__87CB66A0A6C7F379");

                entity.ToTable("BinhLuan");

                entity.Property(e => e.NgayGio).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasColumnType("ntext");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.BinhLuans)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BinhLuan__MaKhac__6383C8BA");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.BinhLuans)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BinhLuan__MaSanP__6477ECF3");
            });

            modelBuilder.Entity<ChiTietAnhSanPham>(entity =>
            {
                entity.HasKey(e => e.MaChiTietAnhSanPham)
                    .HasName("PK__ChiTietA__CC1B66028ECE1255");

                entity.ToTable("ChiTietAnhSanPham");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietAnhSanPhams)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietAn__MaSan__534D60F1");
            });

            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => e.MaChiTietDonHang)
                    .HasName("PK__ChiTietD__4B0B45DDF90A0661");

                entity.ToTable("ChiTietDonHang");

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietDo__MaDon__59063A47");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietDo__MaSan__59FA5E80");
            });

            modelBuilder.Entity<ChiTietHoaDonBan>(entity =>
            {
                entity.HasKey(e => e.MaChiTietHoaDonBan)
                    .HasName("PK__ChiTietH__0FD2C161A2BB642C");

                entity.ToTable("ChiTietHoaDonBan");

                entity.HasOne(d => d.MaHoaDonBanNavigation)
                    .WithMany(p => p.ChiTietHoaDonBans)
                    .HasForeignKey(d => d.MaHoaDonBan)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietHo__MaHoa__4F7CD00D");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietHoaDonBans)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietHo__MaSan__5070F446");
            });

            modelBuilder.Entity<ChiTietHoaDonNhap>(entity =>
            {
                entity.HasKey(e => e.MaChiTietHoaDonNhap)
                    .HasName("PK__ChiTietH__7801869A8460064C");

                entity.ToTable("ChiTietHoaDonNhap");

                entity.HasOne(d => d.MaHoaDonNhapNavigation)
                    .WithMany(p => p.ChiTietHoaDonNhaps)
                    .HasForeignKey(d => d.MaHoaDonNhap)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietHo__MaHoa__48CFD27E");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietHoaDonNhaps)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietHo__MaSan__49C3F6B7");
            });

            modelBuilder.Entity<ChiTietKho>(entity =>
            {
                entity.HasKey(e => e.MaChiTietKho)
                    .HasName("PK__ChiTietK__CE825869CE42536B");

                entity.ToTable("ChiTietKho");

                entity.HasOne(d => d.MaKhoNavigation)
                    .WithMany(p => p.ChiTietKhos)
                    .HasForeignKey(d => d.MaKho)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietKh__MaKho__6D0D32F4");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietKhos)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ChiTietKh__MaSan__6C190EBB");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.MaDonHang)
                    .HasName("PK__DonHang__129584AD8DCCA8FD");

                entity.ToTable("DonHang");

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__DonHang__MaKhach__5629CD9C");
            });

            modelBuilder.Entity<GiaBan>(entity =>
            {
                entity.HasKey(e => e.MaGiaSanPham)
                    .HasName("PK__GiaBan__8DCEBB5CD8A17630");

                entity.ToTable("GiaBan");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.GiaBans)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__GiaBan__MaSanPha__6754599E");
            });

            modelBuilder.Entity<HoaDonBan>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonBan)
                    .HasName("PK__HoaDonBa__6A50CA8AB708DA87");

                entity.ToTable("HoaDonBan");

                entity.Property(e => e.NgayBan).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDonBans)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HoaDonBan__MaKha__4CA06362");
            });

            modelBuilder.Entity<HoaDonNhap>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonNhap)
                    .HasName("PK__HoaDonNh__448838B555DEA272");

                entity.ToTable("HoaDonNhap");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.HasOne(d => d.MaNhaCungCapNavigation)
                    .WithMany(p => p.HoaDonNhaps)
                    .HasForeignKey(d => d.MaNhaCungCap)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HoaDonNha__MaNha__45F365D3");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E589BB12C5");

                entity.ToTable("KhachHang");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhachHang).HasMaxLength(200);
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.HasKey(e => e.MaKho)
                    .HasName("PK__Kho__3BDA9350D9851717");

                entity.ToTable("Kho");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.TenKho).HasMaxLength(500);
            });

            modelBuilder.Entity<LienHe>(entity =>
            {
                entity.HasKey(e => e.MaLienHe)
                    .HasName("PK__LienHe__0E73388AE98E7E8C");

                entity.ToTable("LienHe");

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hoten).HasMaxLength(100);

                entity.Property(e => e.Noidung).HasMaxLength(1000);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Tieude).HasMaxLength(500);
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSanP__730A5759FDDE0AFE");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.TenLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNhaCungCap)
                    .HasName("PK__NhaCungC__53DA920501F9BF93");

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNhaCungCap).HasMaxLength(200);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA47AD4B9C4F");

                entity.ToTable("NhanVien");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNhanVien).HasMaxLength(100);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D7C6575BC");

                entity.ToTable("SanPham");

                entity.Property(e => e.Anh)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mota).HasColumnType("ntext");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TenSanPham).HasMaxLength(250);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SanPham__MaLoai__398D8EEE");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK__TaiKhoan__AD7C65293ECA7742");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TaiKhoan");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TaiKhoan__MaKhac__5CD6CB2B");

                entity.HasOne(d => d.MaUserGroupNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaUserGroup)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TaiKhoan__MaUser__5DCAEF64");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.MaUserGroup)
                    .HasName("PK__UserGrou__3795BAE9400FC0BE");

                entity.ToTable("UserGroup");

                entity.Property(e => e.TenQuyen).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
