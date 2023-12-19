using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppLocalSIS2420.Dtos;

namespace WebAppLocalSIS2420.Models
{
    public class Ambientes
    {
        [Key]
        public int IdAmbiente { get; set; }
        public string? Fotos { get; set; }
        [Required]
        public string? NombreAmbiente { get; set; }
        [Required]
        public string? Direccion { get; set; }

        public string? Zona { get; set; }
        [Required]
        public int Capacidad { get; set; }
        
        public TarimaEnum Tarima { get; set; }
        [Required]
        public EstadoEnum Estado { get; set; }
        [Required]
        public int Precio { get; set; }
        [NotMapped]

        [Display(Name ="Cargar Foto")]
        public IFormFile? FotoFile { get; set; }

        //relacion a muchos
        public virtual List<Alquileres>? Alquileres { get; set; }
    }
}
