using System.ComponentModel.DataAnnotations.Schema;

namespace FitRestAPI.Models
{
    public class MealIngredientWithPortion : BaseDatabase
    {
        public double PortionSize { get; set; }
        public int IdMeal { get; set; }
        [ForeignKey("IdMeal")]
        public virtual Meal? Meal { get; set; }
        public int IdMealIngredient { get; set; }
        [ForeignKey("IdMealIngredient")]
        public virtual MealIngredient? MealIngredient { get; set; }
    }
}
