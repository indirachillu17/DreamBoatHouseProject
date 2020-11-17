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
    public class BåtHusetBokningController : ControllerBase
    {
        private readonly FrejyaBåtHuset_WebAPI_BackendContext _context;
       
        public BåtHusetBokningController(FrejyaBåtHuset_WebAPI_BackendContext context)
        {
            _context = context;
        }
        
        //GET: api/BåtHusetBokning
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BåtHusetBokning>>> GetBåtHusetBokning()
        {
            return await _context.BåtHusetBokning.ToListAsync();
        }

        // GET: api/BåtHusetBokning/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BåtHusetBokning>> GetBåtHusetBokning(int id)
        {
            var båtHusetBokning = await _context.BåtHusetBokning.FindAsync(id);

            if (båtHusetBokning == null)
            {
                return NotFound();
            }

            return båtHusetBokning;
        }

        // PUT: api/BåtHusetBokning/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBåtHusetBokning(int id, BåtHusetBokning båtHusetBokning)
        {
            if (id != båtHusetBokning.BåtHusetBokningID)
            {
                return BadRequest();
            }

            _context.Entry(båtHusetBokning).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BåtHusetBokningExists(id))
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

        // POST: api/BåtHusetBokning
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BåtHusetBokning>> PostBåtHusetBokning(BåtHusetBokning båtHusetBokning)
        {
            _context.BåtHusetBokning.Add(båtHusetBokning);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBåtHusetBokning", new { id = båtHusetBokning.BåtHusetBokningID }, båtHusetBokning);
        }

        // DELETE: api/BåtHusetBokning/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BåtHusetBokning>> DeleteBåtHusetBokning(int id)
        {
            var båtHusetBokning = await _context.BåtHusetBokning.FindAsync(id);
            if (båtHusetBokning == null)
            {
                return NotFound();
            }

            _context.BåtHusetBokning.Remove(båtHusetBokning);
            await _context.SaveChangesAsync();

            return båtHusetBokning;
        }

        private bool BåtHusetBokningExists(int id)
        {
            return _context.BåtHusetBokning.Any(e => e.BåtHusetBokningID == id);
        }
    }
}
