using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeMogioHang.Models
{
    public class GioHang
    {
        [Key]
        public Guid Id { get; set; }

        public string UserName { get; set; }
        [ForeignKey("User")]
        public Guid? UserID { get; set; } // Khóa ngoại

        public User? Users { get; set; }


        public ICollection<GiohangChitiet> GioHangChiTiets { get; set; }
    }
}
