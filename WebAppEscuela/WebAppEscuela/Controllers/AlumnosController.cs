using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebAppEscuela.Data;
using WebAppEscuela.Models;

namespace WebAppEscuela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        public DbEscuelaApi Context { get; set; }
        public AlumnosController(DbEscuelaApi Context){
        this.Context = Context;
        }

        public List<Alumno> Get()
        {
            //EF
            List<Alumno> alumnos = Context.Alumnos.ToList();
            return alumnos;
        }

        [HttpGet("{id}")]
        public Alumno Get(int id)
        {
            Alumno alumno = Context.Alumnos.Find(id);
            return alumno;


        }
        [HttpPost("{id}")]
        public ActionResult Post(Alumno alumno)
        {
            Context.Alumnos.Add(alumno);
            Context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return BadRequest();
            }

            //EF para modificar en la DB
            Context.Entry(alumno).State = EntityState.Modified;
            Context.SaveChanges();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult<Alumno> Delete(int Id)
        {
            Alumno alumno = Context.Alumnos.Find(Id);
            if (alumno == null)
            {
                return NotFound();
            }
            Context.Alumnos.Remove(alumno);
            Context.SaveChanges();
            return alumno;
        }
    }
}
