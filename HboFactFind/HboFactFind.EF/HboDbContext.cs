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
        public HboDbContext() : base("HboContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<FactFind> FactFinds { get; set; }
        public virtual IDbSet<PageOne> PageOne { get; set; }
        public virtual IDbSet<PageTwo> PageTwos { get; set; }
        public virtual IDbSet<PageThree> PageThrees { get; set; }
        public virtual IDbSet<PageFour> PageFours { get; set; }
        public virtual IDbSet<PageFive> PageFives { get; set; }
        public virtual IDbSet<PageSix> PageSixs { get; set; }
        public virtual IDbSet<PageSeven> PageSevens { get; set; }
        public virtual IDbSet<PageEight> PageEights { get; set; }
        public virtual IDbSet<PageNine> PageNines { get; set; }
        public virtual IDbSet<PageTen> PageTens { get; set; }
        public virtual IDbSet<FinancialDependant> FinancialDependants { get; set; }
        public virtual IDbSet<NonFinancialDependants> NonFinancialDependantses { get; set; }
        public virtual IDbSet<BreakDownOfLiabilities> BreakDownOfLiabilitieses { get; set; }
        public virtual IDbSet<PensionPolicies> PensionPolicieses { get; set; }
        public virtual IDbSet<ProtectionAndInsurancePolicies> ProtectionAndInsurancePolicieses { get; set; }
        public virtual IDbSet<SavingsAndInvestmentPolicies> SavingsAndInvestmentPolicieses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();

            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageOneClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageTwoClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageThreeClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageFourClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageFiveClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageSixClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageSevenClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageEightClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageNineClientOne).WithOptional();
            modelBuilder.Entity<FactFind>().HasRequired(t => t.PageTenClientOne).WithOptional();

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