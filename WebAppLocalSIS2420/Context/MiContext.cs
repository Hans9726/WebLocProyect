using Microsoft.EntityFrameworkCore;
using WebAppLocalSIS2420.Models;

namespace WebAppLocalSIS2420.Context
{
    public class MiContext: DbContext
    {
        public MiContext(DbContextOptions options): base (options)
        { 
        
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ambientes> Ambientes { get; set; }
        public DbSet<Alquileres> Alquileres { get; set; }


    }
}
