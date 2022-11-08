using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppSql.Models;

namespace WindowsFormsAppSql.Data
{
    public class DbContext1 : DbContext
    {
        public DbContext1() : base("KeyDBcaso1"){}

        public DbSet<Alumno> Alumno { get; set; }

        public DbSet<Profesor> Profesor { get; set; }

        public DbSet<Aula> Aula { get; set; }

        public DbSet<Materia> Programa { get; set; }
    }
}
