namespace FitRestAPI.Models
{
    public class Activity : DictionaryTable
    {
        public int CaloriesPerMinute { get; set; }
        public virtual ICollection<ActivityWithDuration>? ActivityDuration { get; set; }

    }
}
