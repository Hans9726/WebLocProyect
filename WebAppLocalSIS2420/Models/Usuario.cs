using WebAppLocalSIS2420.Dtos;

namespace WebAppLocalSIS2420.Models
{
    public class Usuario
    { 
        public string? Email { set; get; }
        public string? NombreCompleto { get; set; }
        public string? Password { get; set; }
        public RolEnum Rol { get; set; }
    }
}
