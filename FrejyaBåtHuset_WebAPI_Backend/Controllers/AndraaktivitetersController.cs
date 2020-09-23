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
    public class AndraaktivitetersController : ControllerBase
    {
        private readonly FrejyaBåtHuset_WebAPI_BackendContext _context;

        public AndraaktivitetersController(FrejyaBåtHuset_WebAPI_BackendContext context)
        {
            _context = context;
        }

        // GET: api/Andraaktiviteters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Andraaktiviteter>>> GetAndraaktiviteter()
        {
            return await _context.Andraaktiviteter.ToListAsync();
        }

        // GET: api/Andraaktiviteters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Andraaktiviteter>> GetAndraaktiviteter(int id)
        {
            var andraaktiviteter = await _context.Andraaktiviteter.FindAsync(id);

            if (andraaktiviteter == null)
            {
                return NotFound();
            }

            return andraaktiviteter;
        }

        // PUT: api/Andraaktiviteters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAndraaktiviteter(int id, Andraaktiviteter andraaktiviteter)
        {
            if (id != andraaktiviteter.AndraaktiviteterID)
            {
                return BadRequest();
            }

            _context.Entry(andraaktiviteter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AndraaktiviteterExists(id))
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

        // POST: api/Andraaktiviteters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Andraaktiviteter>> PostAndraaktiviteter(Andraaktiviteter andraaktiviteter)
        {
            _context.Andraaktiviteter.Add(andraaktiviteter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAndraaktiviteter", new { id = andraaktiviteter.AndraaktiviteterID }, andraaktiviteter);
        }

        // DELETE: api/Andraaktiviteters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Andraaktiviteter>> DeleteAndraaktiviteter(int id)
        {
            var andraaktiviteter = await _context.Andraaktiviteter.FindAsync(id);
            if (andraaktiviteter == null)
            {
                return NotFound();
            }

            _context.Andraaktiviteter.Remove(andraaktiviteter);
            await _context.SaveChangesAsync();

            return andraaktiviteter;
        }

        private bool AndraaktiviteterExists(int id)
        {
            return _context.Andraaktiviteter.Any(e => e.AndraaktiviteterID == id);
        }
    }
}
