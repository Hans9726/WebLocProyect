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
        [Required]
        public string? NombreAmbAqluilar { get; set; }
        public DateTime FechaReserva { get; set; }
        [Required]
        public DateTime FechaAlquilar { get; set; }
        [Required]
        public int Adelanto { get; set; }
        public int Saldo { get; set; }
        [Required]
        public int Total { get; set; }
    }
}