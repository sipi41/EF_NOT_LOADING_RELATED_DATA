using ITT_OneTeam.Models.FACT;
using Microsoft.AspNetCore.Identity;

namespace ITT_OneTeam.Identity
{
    public class AppIdentityUser : IdentityUser
    {
        public virtual List<FactComment> FactComments { get; set; }
    }
}
