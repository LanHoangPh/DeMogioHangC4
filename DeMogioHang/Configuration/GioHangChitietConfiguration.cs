using DeMogioHang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeMogioHang.Configuration
{
    public class GioHangChitietConfiguration : IEntityTypeConfiguration<GiohangChitiet>
    {
        public void Configure(EntityTypeBuilder<GiohangChitiet> builder)
        {
            builder.HasKey(x => x.Id);
            // thiết lập mối quan hệ 1-n giỏ hàng
            builder.HasOne(x => x.GioHang).WithMany(x => x.GioHangChiTiets).HasForeignKey(x => x.GioHangId);

            // thiết lập mqh 1-n sản phẩm 
            builder.HasOne(x => x.Product).WithMany(x => x.GioHangChiTiets).HasForeignKey(x => x.SanPhamId);
        }
    }
}
