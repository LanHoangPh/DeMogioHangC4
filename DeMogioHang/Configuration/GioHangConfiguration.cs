using DeMogioHang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeMogioHang.Configuration
{
    public class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);

            // thiết laapk mqh 1-1 vs account 
            builder.HasOne(x => x.Users).WithOne(x => x.GioHangs).HasForeignKey<User>(x => x.Id);
        }
    }
}
