using Microsoft.EntityFrameworkCore;

namespace DeMogioHang.Models
{
    public class DemoGHAppDbcontext :DbContext
    {
        // nếu đẻ chuổi kn trong class dbcontext thì bắt buộc phải có contructor ko có tham số 
        // còn nếu đẻ ở chuỗi ở appsetting thì có hoặc ko có đều đc 
        public DemoGHAppDbcontext(DbContextOptions<DemoGHAppDbcontext> options)
        : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<GioHang> gioHangs { get; set; }

        public DbSet<GiohangChitiet> giohangChitiets { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}
