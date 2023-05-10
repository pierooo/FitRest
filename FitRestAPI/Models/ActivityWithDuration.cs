using System.ComponentModel.DataAnnotations.Schema;

namespace FitRestAPI.Models
{
    public class ActivityWithDuration : BaseDatabase
    {
        public DateTime? StartTime { get; set; }
        public int DurationInMinutes { get; set; }
        public double Intensity { get; set; }
        public int IdDay { get; set; }
        [ForeignKey("IdDay")]
        public virtual Day? Day { get; set; }
        public int IdActivity { get; set; }
        [ForeignKey("IdActivity")]
        public virtual Activity? Activity { get; set; }
    }
}
