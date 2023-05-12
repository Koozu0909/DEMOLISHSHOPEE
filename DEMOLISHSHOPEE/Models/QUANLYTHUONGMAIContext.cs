using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DEMOLISHSHOPEE.Models
{
    public partial class QUANLYTHUONGMAIContext : DbContext
    {
        public QUANLYTHUONGMAIContext()
        {
        }

        public QUANLYTHUONGMAIContext(DbContextOptions<QUANLYTHUONGMAIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAddress> TbAddresses { get; set; } = null!;
        public virtual DbSet<TbAddressLv1> TbAddressLv1s { get; set; } = null!;
        public virtual DbSet<TbAddressLv2> TbAddressLv2s { get; set; } = null!;
        public virtual DbSet<TbAddressLv3> TbAddressLv3s { get; set; } = null!;
        public virtual DbSet<TbBranch> TbBranches { get; set; } = null!;
        public virtual DbSet<TbBranchFollow> TbBranchFollows { get; set; } = null!;
        public virtual DbSet<TbBranchProduct> TbBranchProducts { get; set; } = null!;
        public virtual DbSet<TbBrand> TbBrands { get; set; } = null!;
        public virtual DbSet<TbCart> TbCarts { get; set; } = null!;
        public virtual DbSet<TbCartBranchProduct> TbCartBranchProducts { get; set; } = null!;
        public virtual DbSet<TbCategory> TbCategories { get; set; } = null!;
        public virtual DbSet<TbComment> TbComments { get; set; } = null!;
        public virtual DbSet<TbDescription> TbDescriptions { get; set; } = null!;
        public virtual DbSet<TbFavourite> TbFavourites { get; set; } = null!;
        public virtual DbSet<TbImageSlide> TbImageSlides { get; set; } = null!;
        public virtual DbSet<TbOrder> TbOrders { get; set; } = null!;
        public virtual DbSet<TbOrderDetail> TbOrderDetails { get; set; } = null!;
        public virtual DbSet<TbOrigin> TbOrigins { get; set; } = null!;
        public virtual DbSet<TbPaymentMethod> TbPaymentMethods { get; set; } = null!;
        public virtual DbSet<TbProduct> TbProducts { get; set; } = null!;
        public virtual DbSet<TbProductImage> TbProductImages { get; set; } = null!;
        public virtual DbSet<TbProductTag> TbProductTags { get; set; } = null!;
        public virtual DbSet<TbRoleCate> TbRoleCates { get; set; } = null!;
        public virtual DbSet<TbStatusOrder> TbStatusOrders { get; set; } = null!;
        public virtual DbSet<TbTag> TbTags { get; set; } = null!;
        public virtual DbSet<TbUser> TbUsers { get; set; } = null!;
        public virtual DbSet<TbWarrantyPeriod> TbWarrantyPeriods { get; set; } = null!;
        public virtual DbSet<TbWarrantyType> TbWarrantyTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QUANLYTHUONGMAI;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAddress>(entity =>
            {
                entity.HasKey(e => e.MaAddress);

                entity.ToTable("tb_Address");

                entity.Property(e => e.ChiTiet).HasMaxLength(200);
            });

            modelBuilder.Entity<TbAddressLv1>(entity =>
            {
                entity.HasKey(e => e.MaA1);

                entity.ToTable("tb_AddressLV1");

                entity.Property(e => e.TenA1).HasMaxLength(50);
            });

            modelBuilder.Entity<TbAddressLv2>(entity =>
            {
                entity.HasKey(e => e.MaA2);

                entity.ToTable("tb_AddressLV2");

                entity.Property(e => e.TenA2).HasMaxLength(50);
            });

            modelBuilder.Entity<TbAddressLv3>(entity =>
            {
                entity.HasKey(e => e.MaA3);

                entity.ToTable("tb_AddressLV3");

                entity.Property(e => e.TenA3).HasMaxLength(50);
            });

            modelBuilder.Entity<TbBranch>(entity =>
            {
                entity.HasKey(e => e.MaCuaHang);

                entity.ToTable("tb_Branch");

                entity.Property(e => e.IsMail).HasColumnName("isMail");

                entity.Property(e => e.MieuTa).HasColumnType("ntext");

                entity.Property(e => e.TenCuaHang).HasMaxLength(50);
            });

            modelBuilder.Entity<TbBranchFollow>(entity =>
            {
                entity.HasKey(e => e.MaBranchFollow);

                entity.ToTable("tb_BranchFollow");
            });

            modelBuilder.Entity<TbBranchProduct>(entity =>
            {
                entity.HasKey(e => e.MaBranchProduct);

                entity.ToTable("tb_Branch_Product");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.SoLuongSp).HasColumnName("SoLuongSP");
            });

            modelBuilder.Entity<TbBrand>(entity =>
            {
                entity.HasKey(e => e.MaThuongHieu);

                entity.ToTable("tb_Brand");

                entity.Property(e => e.TenThuongHieu).HasMaxLength(50);
            });

            modelBuilder.Entity<TbCart>(entity =>
            {
                entity.HasKey(e => e.MaCart);

                entity.ToTable("tb_Cart");
            });

            modelBuilder.Entity<TbCartBranchProduct>(entity =>
            {
                entity.HasKey(e => new { e.MaCart, e.MaBranchProduct });

                entity.ToTable("tb_Cart_Branch_Product");
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSp);

                entity.ToTable("tb_Categories");

                entity.Property(e => e.MaLoaiSp).HasColumnName("MaLoaiSP");

                entity.Property(e => e.ImagePath).HasMaxLength(200);

                entity.Property(e => e.TenLoaiSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenLoaiSP");
            });

            modelBuilder.Entity<TbComment>(entity =>
            {
                entity.HasKey(e => e.MaComment);

                entity.ToTable("tb_Comment");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idreply).HasColumnName("IDReply");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.UpdateDay).HasColumnType("date");
            });

            modelBuilder.Entity<TbDescription>(entity =>
            {
                entity.HasKey(e => e.MaMoTa);

                entity.ToTable("tb_Description");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.MoTa).HasColumnType("ntext");
            });

            modelBuilder.Entity<TbFavourite>(entity =>
            {
                entity.HasKey(e => e.MaYeuThich);

                entity.ToTable("tb_Favourite");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");
            });

            modelBuilder.Entity<TbImageSlide>(entity =>
            {
                entity.HasKey(e => e.MaImageSlide);

                entity.ToTable("tb_ImageSlide");

                entity.Property(e => e.ImageSlidePath).HasMaxLength(200);
            });

            modelBuilder.Entity<TbOrder>(entity =>
            {
                entity.HasKey(e => e.MaDonHang);

                entity.ToTable("tb_Order");

                entity.Property(e => e.CreateDay)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbOrderDetail>(entity =>
            {
                entity.HasKey(e => e.MaDonHangCt);

                entity.ToTable("tb_OrderDetail");

                entity.Property(e => e.MaDonHangCt).HasColumnName("MaDonHangCT");

                entity.Property(e => e.SoLuongSp).HasColumnName("SoLuongSP");
            });

            modelBuilder.Entity<TbOrigin>(entity =>
            {
                entity.HasKey(e => e.MaXuatXu);

                entity.ToTable("tb_Origin");

                entity.Property(e => e.TenXuatXu).HasMaxLength(50);
            });

            modelBuilder.Entity<TbPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.MaPayment);

                entity.ToTable("tb_PaymentMethod");

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            });

            modelBuilder.Entity<TbProduct>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("tb_Product");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDay).HasColumnType("date");

                entity.Property(e => e.GiaSp).HasColumnName("GiaSP");

                entity.Property(e => e.MaLoaiBaoHanh)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaLoaiSp).HasColumnName("MaLoaiSP");

                entity.Property(e => e.SeoName).HasMaxLength(50);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.UpdateDay).HasColumnType("date");
            });

            modelBuilder.Entity<TbProductImage>(entity =>
            {
                entity.HasKey(e => e.MaImage);

                entity.ToTable("tb_ProductImage");

                entity.Property(e => e.ImagePath).HasMaxLength(50);

                entity.Property(e => e.MaSp).HasColumnName("MaSP");
            });

            modelBuilder.Entity<TbProductTag>(entity =>
            {
                entity.HasKey(e => e.MaProductTag);

                entity.ToTable("tb_Product_Tag");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");
            });

            modelBuilder.Entity<TbRoleCate>(entity =>
            {
                entity.HasKey(e => e.MaRole);

                entity.ToTable("tb_RoleCate");

                entity.Property(e => e.TenRole).HasMaxLength(50);
            });

            modelBuilder.Entity<TbStatusOrder>(entity =>
            {
                entity.HasKey(e => e.MaTrangThai);

                entity.ToTable("tb_Status_Order");

                entity.Property(e => e.TenTrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<TbTag>(entity =>
            {
                entity.HasKey(e => e.MaTag);

                entity.ToTable("tb_Tag");

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.TenTag).HasMaxLength(50);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.MaUser);

                entity.ToTable("tb_User");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gmail).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TbWarrantyPeriod>(entity =>
            {
                entity.HasKey(e => e.MaHanBaoHanh);

                entity.ToTable("tb_WarrantyPeriod");

                entity.Property(e => e.HanBaoHanh).HasMaxLength(50);
            });

            modelBuilder.Entity<TbWarrantyType>(entity =>
            {
                entity.HasKey(e => e.MaLoaiBaoHanh);

                entity.ToTable("tb_WarrantyType");

                entity.Property(e => e.LoaiBaoHanh).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
