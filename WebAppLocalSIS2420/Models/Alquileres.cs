using System.ComponentModel.DataAnnotations;
using WebAppLocalSIS2420.Dtos;

namespace WebAppLocalSIS2420.Models
{
    public class Alquileres
    {
        [Key]
        public int IdAlquiler { get; set; }
        [Required]
        public string? NombreCliente { get; set; }

        public DateTime FechaReserva { get; set; }
        [Required]
        public DateTime FechaAlquilar { get; set; }
        [Required]
        public int Adelanto { get; set; }
        public int Saldo { get; set; }
        [Required]
        public int Total { get; set; }

        //foreing keys
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public int AmbientesId { get; set; }
        public Ambientes? Ambientes { get; set; }
    }
}