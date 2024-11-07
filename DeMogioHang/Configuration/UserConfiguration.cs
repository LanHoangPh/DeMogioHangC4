using DeMogioHang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeMogioHang.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // thiết lập khóa chính
            builder.HasKey(x => x.Id);

            //config cho các thuocj tính 

            // thuộc tính pass=> mật khẩu 
            builder.Property(x => x.Pass).IsRequired().HasColumnName("Mật Khẩu").HasColumnType("varchar(255)");
            builder.Property(x => x.Name).IsRequired().IsUnicode(true).IsFixedLength(true).HasMaxLength(256);
            // thiết lập mối qua hệ 1-1 với gH


            builder.HasOne(x => x.GioHangs).WithOne(x => x.Users).HasForeignKey<GioHang>(x => x.UserID);



        }
    }
}
