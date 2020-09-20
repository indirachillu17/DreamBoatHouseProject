using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FrejaBåthuset_WebAPI_Backend.Models;
using FreyjaBåthuset_WebAPI_Backend.Data;

namespace FreyjaBåthuset_WebAPI_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatTripBookingsController : ControllerBase
    {
        private readonly FreyjaBåthuset_WebAPI_BackendContext _context;

        public BoatTripBookingsController(FreyjaBåthuset_WebAPI_BackendContext context)
        {
            _context = context;
        }

        // GET: api/BoatTripBookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoatTripBooking>>> GetBoatTripBooking()
        {
            return await _context.BoatTripBooking.ToListAsync();
        }

        // GET: api/BoatTripBookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoatTripBooking>> GetBoatTripBooking(int id)
        {
            var boatTripBooking = await _context.BoatTripBooking.FindAsync(id);

            if (boatTripBooking == null)
            {
                return NotFound();
            }

            return boatTripBooking;
        }

        // PUT: api/BoatTripBookings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoatTripBooking(int id, BoatTripBooking boatTripBooking)
        {
            if (id != boatTripBooking.BoatTripBookingID)
            {
                return BadRequest();
            }

            _context.Entry(boatTripBooking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoatTripBookingExists(id))
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

        // POST: api/BoatTripBookings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BoatTripBooking>> PostBoatTripBooking(BoatTripBooking boatTripBooking)
        {
            _context.BoatTripBooking.Add(boatTripBooking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoatTripBooking", new { id = boatTripBooking.BoatTripBookingID }, boatTripBooking);
        }

        // DELETE: api/BoatTripBookings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BoatTripBooking>> DeleteBoatTripBooking(int id)
        {
            var boatTripBooking = await _context.BoatTripBooking.FindAsync(id);
            if (boatTripBooking == null)
            {
                return NotFound();
            }

            _context.BoatTripBooking.Remove(boatTripBooking);
            await _context.SaveChangesAsync();

            return boatTripBooking;
        }

        private bool BoatTripBookingExists(int id)
        {
            return _context.BoatTripBooking.Any(e => e.BoatTripBookingID == id);
        }
    }
}
