using System.Data.Entity;
using HboFactFind.Domain;

namespace HboFactFind.EF
{
    public class HboDbContext : DbContext
    {
        public HboDbContext() : base("HboContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
    }
}