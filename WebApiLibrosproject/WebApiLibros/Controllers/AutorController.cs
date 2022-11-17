using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiLibros.context;
using WebApiLibros.Entidades;

namespace WebApiLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public AutorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Author>> Get()
        {
            return context.Autores.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            var resultado = context.Autores.FirstOrDefault(x => x.Id ==
            id);
            if (resultado == null)
            { return NotFound(); }
            return resultado;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Author autor)
        {
            context.Autores.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new
            {
                id =
            autor.Id
            }, autor);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Author value)
        {
            if (id != value.Id)
            {
                BadRequest();
            }
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Author> Delete(int id)
        {
            var resultado = context.Autores.FirstOrDefault(x => x.Id ==
            id);
            if (resultado == null)
            { return NotFound(); }
            context.Autores.Remove(resultado);
            context.SaveChanges();
            return resultado;
        }


    }

}
