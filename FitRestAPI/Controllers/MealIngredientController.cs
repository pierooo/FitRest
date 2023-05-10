using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitRestAPI.Data;
using FitRestAPI.Models;

namespace FitRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealIngredientController : ControllerBase
    {
        private readonly FitRestContext _context;

        public MealIngredientController(FitRestContext context)
        {
            _context = context;
        }

        // GET: api/MealIngredient
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealIngredient>>> GetMealIngredient()
        {
          if (_context.MealIngredient == null)
          {
              return NotFound();
          }
            return await _context.MealIngredient.ToListAsync();
        }

        // GET: api/MealIngredient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MealIngredient>> GetMealIngredient(int id)
        {
          if (_context.MealIngredient == null)
          {
              return NotFound();
          }
            var mealIngredient = await _context.MealIngredient.FindAsync(id);

            if (mealIngredient == null)
            {
                return NotFound();
            }

            return mealIngredient;
        }

        // PUT: api/MealIngredient/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealIngredient(int id, MealIngredient mealIngredient)
        {
            if (id != mealIngredient.Id)
            {
                return BadRequest();
            }

            _context.Entry(mealIngredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealIngredientExists(id))
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

        // POST: api/MealIngredient
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealIngredient>> PostMealIngredient(MealIngredient mealIngredient)
        {
          if (_context.MealIngredient == null)
          {
              return Problem("Entity set 'FitRestContext.MealIngredient'  is null.");
          }
            _context.MealIngredient.Add(mealIngredient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMealIngredient", new { id = mealIngredient.Id }, mealIngredient);
        }

        // DELETE: api/MealIngredient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealIngredient(int id)
        {
            if (_context.MealIngredient == null)
            {
                return NotFound();
            }
            var mealIngredient = await _context.MealIngredient.FindAsync(id);
            if (mealIngredient == null)
            {
                return NotFound();
            }

            _context.MealIngredient.Remove(mealIngredient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealIngredientExists(int id)
        {
            return (_context.MealIngredient?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
