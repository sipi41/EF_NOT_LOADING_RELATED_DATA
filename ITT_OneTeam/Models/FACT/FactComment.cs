using ITT_OneTeam.Identity;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ITT_OneTeam.Models.FACT
{
    [Table("FACT_COMMENTS")]
    public class FactComment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid comment_guid { get; set; }

        [ForeignKey("FACT_Entry"), Required]
        public Guid tool_guid { get; set; }       

        [MaxLength(1500), Required(AllowEmptyStrings = false, ErrorMessage = "Please provide the Comment's content")] 
        public string Comment { get; set; }

        [Required, ForeignKey("User")]
        public string? created_by { get; set; }

        [ForeignKey("created_by")]
        public virtual AppIdentityUser User { get; set; }

        public DateTime created_date { get; set; } = DateTime.Now;

        [JsonIgnore]
        public virtual FACT_Entry FACT_Entry { get; set; }

    }
}
