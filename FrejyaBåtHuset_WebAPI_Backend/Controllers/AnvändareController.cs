using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using FrejyaBåtHuset_WebAPI_Backend.Models;

namespace FrejyaBåtHuset_WebAPI_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnvändareController : ControllerBase
    {
        private readonly FrejyaBåtHuset_WebAPI_BackendContext _context;

        public AnvändareController(FrejyaBåtHuset_WebAPI_BackendContext context)
        {
            _context = context;
        }

        // GET: api/Användare
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Användare>>> GetAnvändare()
        {
            return await _context.Användare.ToListAsync();
        }

        // GET: api/Användare/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Användare>> GetAnvändare(int id)
        {
            var användare = await _context.Användare.FindAsync(id);

            if (användare == null)
            {
                return NotFound();
            }

            return användare;
        }

        // PUT: api/Användare/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnvändare(int id, Användare användare)
        {
            if (id != användare.AnvändareID)
            {
                return BadRequest();
            }

            _context.Entry(användare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnvändareExists(id))
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

        // POST: api/Användare
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Användare>> PostAnvändare(Användare användare)
        {
            _context.Användare.Add(användare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnvändare", new { id = användare.AnvändareID }, användare);
        }

        // DELETE: api/Användare/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Användare>> DeleteAnvändare(int id)
        {
            var användare = await _context.Användare.FindAsync(id);
            if (användare == null)
            {
                return NotFound();
            }

            _context.Användare.Remove(användare);
            await _context.SaveChangesAsync();

            return användare;
        }

        private bool AnvändareExists(int id)
        {
            return _context.Användare.Any(e => e.AnvändareID == id);
        }
    }
}
