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
    public class UserController : ControllerBase
    {
        private readonly FrejyaBåtHuset_WebAPI_BackendContext _context;

        public UserController(FrejyaBåtHuset_WebAPI_BackendContext context)
        {
            _context = context;
        }
        public string Message { get; set; }
        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var User = await _context.Users.FindAsync(id);

            if (User == null)
            {
                return NotFound();
            }

            return User;
        }

        [HttpGet]
        [Route("sayhi")]
        public  ActionResult SayHi()
        {
            return Content("HI");
        }
        [HttpPost]
        [Route ("IsValidUser")]
        public  ActionResult<User> IsValidUser(User userData)
        {
            if(!string.IsNullOrEmpty(userData.EmailId) && !string.IsNullOrEmpty(userData.Password))
            {
                var user = _context.Users.FirstOrDefault(i => i.EmailId.ToLower() == userData.EmailId.Trim().ToLower() && i.Password == userData.Password.Trim());
            
                if(user != null)
                {
                    return Accepted(user);
                }
                else
                {
                    return Unauthorized(null);
                }
            }
            else
            {
                return BadRequest(null);
            }
        }

        // PUT: api/User/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User User)
        {
            if (id != User.Id)
            {
                return BadRequest();
            }

            _context.Entry(User).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User User)
        {
            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = User.Id }, User);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var User = await _context.Users.FindAsync(id);
            if (User == null)
            {
                return NotFound();
            }

            _context.Users.Remove(User);
            await _context.SaveChangesAsync();

            return User;
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
