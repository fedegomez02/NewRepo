using Microsoft.EntityFrameworkCore;
using WebAppEscuela.Models;

namespace WebAppEscuela.Data
{
    public class DbEscuelaApi : DbContext
    {
        public DbEscuelaApi(DbContextOptions<DbEscuelaApi> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor>Profesor{ get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
    }
}
