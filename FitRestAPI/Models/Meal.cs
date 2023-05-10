namespace FitRestAPI.Models
{
    public class Meal : BaseDatabase
    {
        public DateTime TimeOfEating { get; set; }
        public virtual ICollection<MealIngredientWithPortion>? MealIngredientWithPortions { get; set; }
    }
}
