using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitRestAPI.Data;
using FitRestAPI.Models;

namespace FitRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityWithDurationController : ControllerBase
    {
        private readonly FitRestContext _context;

        public ActivityWithDurationController(FitRestContext context)
        {
            _context = context;
        }

        // GET: api/ActivityWithDuration
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityWithDuration>>> GetActivityWithDuration()
        {
          if (_context.ActivityWithDuration == null)
          {
              return NotFound();
          }
            return await _context.ActivityWithDuration.ToListAsync();
        }

        // GET: api/ActivityWithDuration/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityWithDuration>> GetActivityWithDuration(int id)
        {
          if (_context.ActivityWithDuration == null)
          {
              return NotFound();
          }
            var activityWithDuration = await _context.ActivityWithDuration.FindAsync(id);

            if (activityWithDuration == null)
            {
                return NotFound();
            }

            return activityWithDuration;
        }

        // PUT: api/ActivityWithDuration/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityWithDuration(int id, ActivityWithDuration activityWithDuration)
        {
            if (id != activityWithDuration.Id)
            {
                return BadRequest();
            }

            _context.Entry(activityWithDuration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityWithDurationExists(id))
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

        // POST: api/ActivityWithDuration
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActivityWithDuration>> PostActivityWithDuration(ActivityWithDuration activityWithDuration)
        {
          if (_context.ActivityWithDuration == null)
          {
              return Problem("Entity set 'FitRestContext.ActivityWithDuration'  is null.");
          }
            _context.ActivityWithDuration.Add(activityWithDuration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActivityWithDuration", new { id = activityWithDuration.Id }, activityWithDuration);
        }

        // DELETE: api/ActivityWithDuration/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivityWithDuration(int id)
        {
            if (_context.ActivityWithDuration == null)
            {
                return NotFound();
            }
            var activityWithDuration = await _context.ActivityWithDuration.FindAsync(id);
            if (activityWithDuration == null)
            {
                return NotFound();
            }

            _context.ActivityWithDuration.Remove(activityWithDuration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActivityWithDurationExists(int id)
        {
            return (_context.ActivityWithDuration?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
