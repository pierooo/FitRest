using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitRestAPI.Data;
using FitRestAPI.Models;

namespace FitRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SleepController : ControllerBase
    {
        private readonly FitRestContext _context;

        public SleepController(FitRestContext context)
        {
            _context = context;
        }

        // GET: api/Sleep
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sleep>>> GetSleep()
        {
            if (_context.Sleep == null)
            {
                return NotFound();
            }
            return await _context.Sleep.ToListAsync();
        }

        // GET: api/Sleep/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sleep>> GetSleep(int id)
        {
            if (_context.Sleep == null)
            {
                return NotFound();
            }
            var sleep = await _context.Sleep.FindAsync(id);

            if (sleep == null)
            {
                return NotFound();
            }

            return sleep;
        }

        // PUT: api/Sleep/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSleep(int id, Sleep sleep)
        {
            if (id != sleep.Id)
            {
                return BadRequest();
            }

            _context.Entry(sleep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SleepExists(id))
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

        // POST: api/Sleep
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sleep>> PostSleep(Sleep sleep)
        {
            if (_context.Sleep == null)
            {
                return Problem("Entity set 'FitRestContext.Sleep'  is null.");
            }
            if (_context.Day == null)
            {
                return Problem("Entity set 'FitRestContext.Day'  is null.");
            }
            if (sleep == null)
            {
                return BadRequest();
            }
            if (sleep.IdDay == 0)
            {
                _context.Day.Add(sleep.Day);
                await _context.SaveChangesAsync();
            }
            try
            {

                _context.Sleep.Add(sleep);
                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {
                sleep.Id = (_context.Sleep?.OrderByDescending(sl => sl.Id)?.FirstOrDefault()?.Id+1) ?? 1;
                _context.Sleep.Add(sleep);
                await _context.SaveChangesAsync();

                throw;
            }
            return Ok(sleep);
        }

        // DELETE: api/Sleep/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSleep(int id)
        {
            if (_context.Sleep == null)
            {
                return NotFound();
            }
            var sleep = await _context.Sleep.FindAsync(id);
            if (sleep == null)
            {
                return NotFound();
            }

            _context.Sleep.Remove(sleep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SleepExists(int id)
        {
            return (_context.Sleep?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
