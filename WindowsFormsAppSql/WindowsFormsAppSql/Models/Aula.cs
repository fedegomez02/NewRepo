using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppSql.Data;

namespace WindowsFormsAppSql.Models
{
    [Table("Aula")]
   public class Aula
    {
        
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Column(TypeName = "char")]
        [StringLength(1)]
        [Required]
        public string Codigo { get; set; }

    }
}
