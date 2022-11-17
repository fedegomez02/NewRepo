using Microsoft.EntityFrameworkCore;
using WebApiLibros.Entidades;

namespace WebApiLibros.context
{
    public class ApplicationDbContext :DbContext
    {
        public
  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
        { }
        public DbSet <Author> Autores { get ; set ; }
}
}
