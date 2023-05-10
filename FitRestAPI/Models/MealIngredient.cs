namespace FitRestAPI.Models
{
    public class MealIngredient : DictionaryTable
    {
        public int Carbohydrates { get; set; }
        public int Proteins { get; set; }
        public int Fats { get; set; }
        public int Calories { get; set; }
        public string? PortionName { get; set; }
    }
}
