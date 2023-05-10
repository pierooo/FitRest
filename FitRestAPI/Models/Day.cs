namespace FitRestAPI.Models
{
    public class Day : BaseDatabase
    {
        public DateTime Date { get; set; }
        public double CaloriesGoal { get; set; }
        public double CarbohydratesGoal { get; set; }
        public double ProteinGoal { get; set; }
        public double FatsGoal { get; set; }
        public virtual ICollection<ActivityWithDuration>? ActivityWithDuration { get; set; }
        public virtual ICollection<Sleep>? Sleep { get; set; }
        public virtual ICollection<Meal>? Meals { get; set; }
    }
}
