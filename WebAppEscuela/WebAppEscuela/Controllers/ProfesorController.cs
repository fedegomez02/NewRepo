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
    public class ProfesorController : ControllerBase
    {

        public DbEscuelaApi Context { get; set; }
        public ProfesorController(DbEscuelaApi context) {

            this.Context = context;
        }
    

        [HttpGet]
        public List<Profesor> Get()
        {
            //EF
            List<Profesor> profesores = Context.Profesor.ToList();
            return profesores;
        }


        [HttpPost("{id}")]
        public ActionResult Post(Profesor profesor)
        {
            Context.Profesor.Add(profesor);
            Context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(int Id, [FromBody] Profesor profesor)
        {
            if (Id != profesor.Id)
            {
                return BadRequest();
            }
            Context.Entry(profesor).State = EntityState.Modified;
            Context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Profesor> Delete(int Id)
        {
            Profesor profesor =Context.Profesor.Find(Id);
            if(profesor != null)
            {
                return NotFound();
            }
            Context.Profesor.Remove(profesor);
            Context.SaveChanges();
            return profesor;


        }

    }
}
