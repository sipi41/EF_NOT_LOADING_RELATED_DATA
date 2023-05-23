using System.ComponentModel.DataAnnotations.Schema;

namespace ITT_OneTeam.Models.SQLAgentJobs
{
    [NotMapped]
    public class SQLJob
    {        
        [Column("job_id")]
        public Guid JobId { get; set; }
        [Column("name")]
        public string JobName { get; set; }
        public string description { get; set; }
        public int? last_run_date { get; set; }
        public int? last_run_time { get; set; }

        public int? last_run_outcome { get; set; }

        public int? current_execution_status { get; set; }

        [NotMapped]
        public DateTime? lastRun { get; set; }

        [NotMapped]
        public string? statusText { get; set; }

        [NotMapped]
        public string? lastRunOutcomeText { get; set; }

    }
}
