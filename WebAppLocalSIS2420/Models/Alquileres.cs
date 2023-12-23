using System.ComponentModel.DataAnnotations;
using WebAppLocalSIS2420.Dtos;

namespace WebAppLocalSIS2420.Models
{
    public class Alquileres
    {
        [Key]
        public int IdAlquiler { get; set; }
        [Required]
        [Display(Name = "Nombre del  Cliente")]
        public string? NombreCliente { get; set; }
        [Display(Name = "Fecha de Reserva")]
        public DateTime FechaReserva { get; set; }
        [Required]
        [Display(Name = "Fecha de Alquilar")]
        public DateTime FechaAlquilar { get; set; }
        [Required]
        public int Adelanto { get; set; }
        public int Saldo { get; set; }
        [Required]
        public int Total { get; set; }

        //foreing keys
        [Display(Name = "Usuario que Registra")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        [Display(Name = "Ambiente que Alquila")]
        public int AmbientesId { get; set; }
        [Display(Name = "Ambiente")]
        public Ambientes? Ambientes { get; set; }
    }
}