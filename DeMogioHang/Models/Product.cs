using System.ComponentModel.DataAnnotations;

namespace DeMogioHang.Models
{
    public class Product
    {
        [Key]
        public Guid SpID { get; set; }

        [Required]
        public string SpName { get; set; }

        [Required]

        public decimal Price { get; set; }

        public ICollection<GiohangChitiet> GioHangChiTiets { get; set; }
    }
}
