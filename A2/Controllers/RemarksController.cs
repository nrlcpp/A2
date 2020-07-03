using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using A2.Models;

namespace A2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemarksController : ControllerBase
    {
        private readonly ReservationsDbContext _context;

        public RemarksController(ReservationsDbContext context)
        {
            _context = context;
        }

        // GET: api/Remarks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Remarks>>> GetRemarks()
        {
            return await _context.Remarks.ToListAsync();
        }

        // GET: api/Remarks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Remarks>> GetRemarks(long id)
        {
            var remarks = await _context.Remarks.FindAsync(id);

            if (remarks == null)
            {
                return NotFound();
            }

            return remarks;
        }

        // PUT: api/Remarks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRemarks(long id, Remarks remarks)
        {
            if (id != remarks.Id)
            {
                return BadRequest();
            }

            _context.Entry(remarks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RemarksExists(id))
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

        // POST: api/Remarks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Remarks>> PostRemarks(Remarks remarks)
        {
            _context.Remarks.Add(remarks);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRemarks", new { id = remarks.Id }, remarks);
        }

        // DELETE: api/Remarks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Remarks>> DeleteRemarks(long id)
        {
            var remarks = await _context.Remarks.FindAsync(id);
            if (remarks == null)
            {
                return NotFound();
            }

            _context.Remarks.Remove(remarks);
            await _context.SaveChangesAsync();

            return remarks;
        }

        private bool RemarksExists(long id)
        {
            return _context.Remarks.Any(e => e.Id == id);
        }
    }
}
