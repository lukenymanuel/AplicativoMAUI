using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AplicativoAPI.Data;
using AplicativoAPI.Models;

namespace AplicativoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorControllers : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfessorControllers(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ProfessorControllers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> GetProfessor()
        {
          if (_context.Professor == null)
          {
              return NotFound();
          }
            return await _context.Professor.ToListAsync();
        }

        // GET: api/ProfessorControllers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Professor>> GetProfessor(int id)
        {
          if (_context.Professor == null)
          {
              return NotFound();
          }
            var professor = await _context.Professor.FindAsync(id);

            if (professor == null)
            {
                return NotFound();
            }

            return professor;
        }

        // PUT: api/ProfessorControllers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessor(int id, Professor professor)
        {
            if (id != professor.Id)
            {
                return BadRequest();
            }

            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(id))
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

        // POST: api/ProfessorControllers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Professor>> PostProfessor(Professor professor)
        {
          if (_context.Professor == null)
          {
              return Problem("Entity set 'AppDbContext.Professor'  is null.");
          }
            _context.Professor.Add(professor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessor", new { id = professor.Id }, professor);
        }

        // DELETE: api/ProfessorControllers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessor(int id)
        {
            if (_context.Professor == null)
            {
                return NotFound();
            }
            var professor = await _context.Professor.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            _context.Professor.Remove(professor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfessorExists(int id)
        {
            return (_context.Professor?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
