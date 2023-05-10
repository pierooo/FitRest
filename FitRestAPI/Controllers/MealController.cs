using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitRestAPI.Data;
using FitRestAPI.Models;

namespace FitRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly FitRestContext _context;

        public MealController(FitRestContext context)
        {
            _context = context;
        }

        // GET: api/Meal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeal()
        {
          if (_context.Meal == null)
          {
              return NotFound();
          }
            return await _context.Meal.ToListAsync();
        }

        // GET: api/Meal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetMeal(int id)
        {
          if (_context.Meal == null)
          {
              return NotFound();
          }
            var meal = await _context.Meal.FindAsync(id);

            if (meal == null)
            {
                return NotFound();
            }

            return meal;
        }

        // PUT: api/Meal/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeal(int id, Meal meal)
        {
            if (id != meal.Id)
            {
                return BadRequest();
            }

            _context.Entry(meal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealExists(id))
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

        // POST: api/Meal
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meal>> PostMeal(Meal meal)
        {
          if (_context.Meal == null)
          {
              return Problem("Entity set 'FitRestContext.Meal'  is null.");
          }
            _context.Meal.Add(meal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeal", new { id = meal.Id }, meal);
        }

        // DELETE: api/Meal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeal(int id)
        {
            if (_context.Meal == null)
            {
                return NotFound();
            }
            var meal = await _context.Meal.FindAsync(id);
            if (meal == null)
            {
                return NotFound();
            }

            _context.Meal.Remove(meal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealExists(int id)
        {
            return (_context.Meal?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
