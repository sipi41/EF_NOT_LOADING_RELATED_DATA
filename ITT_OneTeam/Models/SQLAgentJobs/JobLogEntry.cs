using System.ComponentModel.DataAnnotations.Schema;

namespace ITT_OneTeam.Models.SQLAgentJobs
{
    [NotMapped]
    public class JobLogEntry
    {
        public DateTime runTimestamp { get; set; }
        public TimeSpan runDuration { get; set; }
        public int instance_id { get; set; }
        public int step_id { get; set; }
        public string step_name { get; set; }
        public string message { get; set; }
        public int run_status { get; set; }
        [NotMapped]
        public string statusDesc { get; set; }
    }
}
