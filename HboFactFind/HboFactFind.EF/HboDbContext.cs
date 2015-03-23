using System.Data.Entity;
using HboFactFind.Domain;
using HboFactFind.Domain.Pages;
using HboFactFind.Domain.Questions;
using HboFactFind.Domain.Questions.Dependants;
using HboFactFind.Domain.Questions.ExistingPlans;

namespace HboFactFind.EF
{
    public class HboDbContext : DbContext
    {
        public HboDbContext()
            : base("HboDbContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<FactFind> FactFinds { get; set; }
        public virtual DbSet<PageOne> PageOnes { get; set; }
        public virtual DbSet<PageTwo> PageTwos { get; set; }
        public virtual DbSet<PageThree> PageThrees { get; set; }
        public virtual DbSet<PageFour> PageFours { get; set; }
        public virtual DbSet<PageFive> PageFives { get; set; }
        public virtual DbSet<PageSix> PageSixs { get; set; }
        public virtual DbSet<PageSeven> PageSevens { get; set; }
        public virtual DbSet<PageEight> PageEights { get; set; }
        public virtual DbSet<PageNine> PageNines { get; set; }
        public virtual DbSet<PageTen> PageTens { get; set; }
        public virtual DbSet<FinancialDependant> FinancialDependants { get; set; }
        public virtual DbSet<NonFinancialDependants> NonFinancialDependantses { get; set; }
        public virtual DbSet<BreakDownOfLiabilities> BreakDownOfLiabilitieses { get; set; }
        public virtual DbSet<PensionPolicies> PensionPolicieses { get; set; }
        public virtual DbSet<ProtectionAndInsurancePolicies> ProtectionAndInsurancePolicieses { get; set; }
        public virtual DbSet<SavingsAndInvestmentPolicies> SavingsAndInvestmentPolicieses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();

            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageTwo).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageThree).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageFour).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageFive).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageSix).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageSeven).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageEight).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageNine).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageTen).WithOptional();

            modelBuilder.Entity<PageOne>();
            modelBuilder.Entity<PageTwo>();
            modelBuilder.Entity<PageThree>();
            modelBuilder.Entity<PageFour>();
            modelBuilder.Entity<PageFive>();
            modelBuilder.Entity<PageSix>();
            modelBuilder.Entity<PageSeven>();
            modelBuilder.Entity<PageEight>();
            modelBuilder.Entity<PageNine>();
            modelBuilder.Entity<PageTen>();

            modelBuilder.Entity<FinancialDependant>()
                .HasRequired(x => x.PageFour)
                .WithMany(x => x.FinancialDependants)
                .HasForeignKey(x => x.PageFourId);

            modelBuilder.Entity<NonFinancialDependants>()
                .HasRequired(x => x.PageFour)
                .WithMany(x => x.NonFinancialDependantses)
                .HasForeignKey(x => x.PageFourId);

            modelBuilder.Entity<BreakDownOfLiabilities>()
               .HasRequired(x => x.PageSeven)
               .WithMany(x => x.BreakDownOfLiabilitieses)
               .HasForeignKey(x => x.PageSevenId);

            modelBuilder.Entity<PensionPolicies>()
               .HasRequired(x => x.PageTen)
               .WithMany(x => x.PensionPolicieses)
               .HasForeignKey(x => x.PageTenId);

            modelBuilder.Entity<ProtectionAndInsurancePolicies>()
               .HasRequired(x => x.PageTen)
               .WithMany(x => x.ProtectionAndInsurancePolicies)
               .HasForeignKey(x => x.PageTenId);


            modelBuilder.Entity<SavingsAndInvestmentPolicies>()
               .HasRequired(x => x.PageTen)
               .WithMany(x => x.SavingsAndInvestmentPolicieses)
               .HasForeignKey(x => x.PageTenId);
        }
    }
}