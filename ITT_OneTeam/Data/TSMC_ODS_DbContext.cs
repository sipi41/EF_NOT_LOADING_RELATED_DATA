using ITT_OneTeam.Models.FACT;
using ITT_OneTeam.Models.SQLAgentJobs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITT_OneTeam.Data
{
    public class TSMC_ODS_DbContext : IdentityDbContext
    {
        public TSMC_ODS_DbContext(DbContextOptions<TSMC_ODS_DbContext> options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FACT Conversions

            //modelBuilder.Entity<FACT_Entry>()
            //    .Property(p => p.fa_sort)
            //    .HasConversion<string>();

            modelBuilder.Entity<FACT_Entry>()
                .Property(p => p.first_pre_hu)
                .HasConversion<string>();

            #endregion

            

            

            modelBuilder.Entity<FactComment>()
                .HasOne(comment => comment.User)
                .WithMany(user => user.FactComments)
                .HasForeignKey(comment => comment.created_by)
                //.OnDelete(DeleteBehavior.SetNull)
                ;

            base.OnModelCreating(modelBuilder); //REQUIRED for Identity to work properly

        }


        #region FACT

        public DbSet<FACT_Entry> FACT { get; set; }

        public DbSet<FactComment> FACTComments { get; set; }

        #endregion


    }
}
