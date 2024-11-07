using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeMogioHang.Models
{
    public class GiohangChitiet
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("GioHang")]
        public Guid? GioHangId { get; set; }

        [ForeignKey("Product")]
        public Guid? SanPhamId { get; set; }

        public int SoLuong { get; set; }

        public GioHang? GioHang { get; set; }

        public Product? Product { get; set; }
    }
}
