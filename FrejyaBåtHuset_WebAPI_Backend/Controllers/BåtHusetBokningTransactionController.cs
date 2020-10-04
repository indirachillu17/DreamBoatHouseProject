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
    public class BåtHusetBokningTransactionController : ControllerBase
    {
        private readonly FrejyaBåtHuset_WebAPI_BackendContext _context;

        public BåtHusetBokningTransactionController(FrejyaBåtHuset_WebAPI_BackendContext context)
        {
            _context = context;
        }

        // GET: api/BåtHusetBokningTransaction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BåtHusetBokningTransaction>>> GetBåtHusetBokningTransaction()
        {
            return await _context.BåtHusetBokningTransaction.ToListAsync();
        }

        // GET: api/BåtHusetBokningTransaction/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BåtHusetBokningTransaction>> GetBåtHusetBokningTransaction(int id)
        {
            var båtHusetBokningTransaction = await _context.BåtHusetBokningTransaction.FindAsync(id);

            if (båtHusetBokningTransaction == null)
            {
                return NotFound();
            }

            return båtHusetBokningTransaction;
        }

        // PUT: api/BåtHusetBokningTransaction/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBåtHusetBokningTransaction(int id, BåtHusetBokningTransaction båtHusetBokningTransaction)
        {
            if (id != båtHusetBokningTransaction.BåtHusetBokningTransactionID)
            {
                return BadRequest();
            }

            _context.Entry(båtHusetBokningTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BåtHusetBokningTransactionExists(id))
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

        // POST: api/BåtHusetBokningTransaction
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BåtHusetBokningTransaction>> PostBåtHusetBokningTransaction(BåtHusetBokningTransaction båtHusetBokningTransaction)
        {
            _context.BåtHusetBokningTransaction.Add(båtHusetBokningTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBåtHusetBokningTransaction", new { id = båtHusetBokningTransaction.BåtHusetBokningTransactionID }, båtHusetBokningTransaction);
        }

        // DELETE: api/BåtHusetBokningTransaction/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BåtHusetBokningTransaction>> DeleteBåtHusetBokningTransaction(int id)
        {
            var båtHusetBokningTransaction = await _context.BåtHusetBokningTransaction.FindAsync(id);
            if (båtHusetBokningTransaction == null)
            {
                return NotFound();
            }

            _context.BåtHusetBokningTransaction.Remove(båtHusetBokningTransaction);
            await _context.SaveChangesAsync();

            return båtHusetBokningTransaction;
        }

        private bool BåtHusetBokningTransactionExists(int id)
        {
            return _context.BåtHusetBokningTransaction.Any(e => e.BåtHusetBokningTransactionID == id);
        }
    }
}
