using System.ComponentModel.DataAnnotations;
using WebAppLocalSIS2420.Dtos;

namespace WebAppLocalSIS2420.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string? Email { set; get; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public RolEnum Rol { get; set; }


        //relacion a muchos
        public virtual List<Alquileres>? Alquileres { get; set; }


    }
}
