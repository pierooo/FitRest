using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitRestAPI.Data;
using FitRestAPI.Models;

namespace FitRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealIngredientWithPortionController : ControllerBase
    {
        private readonly FitRestContext _context;

        public MealIngredientWithPortionController(FitRestContext context)
        {
            _context = context;
        }

        // GET: api/MealIngredientWithPortion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealIngredientWithPortion>>> GetMealIngredientWithPortion()
        {
          if (_context.MealIngredientWithPortion == null)
          {
              return NotFound();
          }
            return await _context.MealIngredientWithPortion.ToListAsync();
        }

        // GET: api/MealIngredientWithPortion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MealIngredientWithPortion>> GetMealIngredientWithPortion(int id)
        {
          if (_context.MealIngredientWithPortion == null)
          {
              return NotFound();
          }
            var mealIngredientWithPortion = await _context.MealIngredientWithPortion.FindAsync(id);

            if (mealIngredientWithPortion == null)
            {
                return NotFound();
            }

            return mealIngredientWithPortion;
        }

        // PUT: api/MealIngredientWithPortion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealIngredientWithPortion(int id, MealIngredientWithPortion mealIngredientWithPortion)
        {
            if (id != mealIngredientWithPortion.Id)
            {
                return BadRequest();
            }

            _context.Entry(mealIngredientWithPortion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealIngredientWithPortionExists(id))
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

        // POST: api/MealIngredientWithPortion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealIngredientWithPortion>> PostMealIngredientWithPortion(MealIngredientWithPortion mealIngredientWithPortion)
        {
          if (_context.MealIngredientWithPortion == null)
          {
              return Problem("Entity set 'FitRestContext.MealIngredientWithPortion'  is null.");
          }
            _context.MealIngredientWithPortion.Add(mealIngredientWithPortion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMealIngredientWithPortion", new { id = mealIngredientWithPortion.Id }, mealIngredientWithPortion);
        }

        // DELETE: api/MealIngredientWithPortion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealIngredientWithPortion(int id)
        {
            if (_context.MealIngredientWithPortion == null)
            {
                return NotFound();
            }
            var mealIngredientWithPortion = await _context.MealIngredientWithPortion.FindAsync(id);
            if (mealIngredientWithPortion == null)
            {
                return NotFound();
            }

            _context.MealIngredientWithPortion.Remove(mealIngredientWithPortion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealIngredientWithPortionExists(int id)
        {
            return (_context.MealIngredientWithPortion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
