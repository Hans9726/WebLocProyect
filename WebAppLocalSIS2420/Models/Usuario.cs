using System.ComponentModel.DataAnnotations;
using WebAppLocalSIS2420.Dtos;

namespace WebAppLocalSIS2420.Models
{
    public class Usuario
    {
        [Key]
        public string? Email { set; get; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
    }
}
