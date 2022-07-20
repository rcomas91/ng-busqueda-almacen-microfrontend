using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Sistia.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursosController : ControllerBase
    {
        private readonly SistiaDB _context;

        public RecursosController(SistiaDB context)
        {
            _context = context;
        }

        // GET: api/Recursos
        [HttpGet]
        public IEnumerable<Articulo> GetRecursos()
        {
            return _context.Articulos;
        }

        // GET: api/Recursos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecurso([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recurso = await _context.Articulos.FindAsync(id);

            if (recurso == null)
            {
                return NotFound();
            }

            return Ok(recurso);
        }

        // PUT: api/Recursos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecurso([FromRoute] int id, [FromBody] Articulo recurso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != recurso.Id)
            {
                return BadRequest();
            }

            _context.Entry(recurso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecursoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Recursos
        [HttpPost]
        public async Task<IActionResult> PostRecurso([FromBody] Articulo recurso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Articulos.Add(recurso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecurso", new { id = recurso.Id }, recurso);
        }

        // DELETE: api/Recursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecurso([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recurso = await _context.Articulos.FindAsync(id);
            if (recurso == null)
            {
                return NotFound();
            }

            _context.Articulos.Remove(recurso);
            await _context.SaveChangesAsync();

            return Ok(recurso);
        }

        private bool RecursoExists(int id)
        {
            return _context.Articulos.Any(e => e.Id == id);
        }
    }
}