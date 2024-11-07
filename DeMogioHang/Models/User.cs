using System.ComponentModel.DataAnnotations;

namespace DeMogioHang.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(450, MinimumLength = 10, ErrorMessage = "Độ dài 10-450")]
        public string UserName { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Pass { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Đúng format 10 chữ số: XXX-XXX-XXXX")] // REGULAR EXPRESSION c#
        public string SDT { get; set; }

        public GioHang? GioHangs { get; set; }
    }
}
