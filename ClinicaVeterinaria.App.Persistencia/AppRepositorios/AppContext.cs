using ClinicaVeterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Administrador> Administrador {get; set;}
        public DbSet<Auxiliar> Auxiliar { get; set;}
        public DbSet<Consulta> Consulta {get; set;}
        public DbSet<Dueño> Dueño { get; set;}
        public DbSet<HistoriaClinica> HistoriaClinica { get; set;}
        public DbSet<Mascota> Mascota { get; set;}
        public DbSet<Veterinario> Veterinario { get; set;}

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ClinicaVeterinariaDos.Data");
            }
        }
    }
}
