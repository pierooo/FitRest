using System.ComponentModel.DataAnnotations.Schema;

namespace FitRestAPI.Models
{
    public class Sleep : BaseDatabase
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int DurationInMinutes { get; set; }
        public int DurationInMinutesOfDeepSleep { get; set; }
        public int RatingOfSleep { get; set; }
        public int IdDay { get; set; }
        [ForeignKey("IdDay")]
        public virtual Day? Day { get; set; }

    }
}
