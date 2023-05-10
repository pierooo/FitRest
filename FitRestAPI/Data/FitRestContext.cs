using Microsoft.EntityFrameworkCore;

namespace FitRestAPI.Data
{
    public class FitRestContext : DbContext
    {
        public FitRestContext (DbContextOptions<FitRestContext> options)
            : base(options)
        {
        }

        public DbSet<FitRestAPI.Models.Activity> Activity { get; set; } = default!;

        public DbSet<FitRestAPI.Models.ActivityWithDuration>? ActivityWithDuration { get; set; }

        public DbSet<FitRestAPI.Models.Day>? Day { get; set; }

        public DbSet<FitRestAPI.Models.Meal>? Meal { get; set; }

        public DbSet<FitRestAPI.Models.MealIngredient>? MealIngredient { get; set; }

        public DbSet<FitRestAPI.Models.MealIngredientWithPortion>? MealIngredientWithPortion { get; set; }

        public DbSet<FitRestAPI.Models.Sleep>? Sleep { get; set; }
    }
}
