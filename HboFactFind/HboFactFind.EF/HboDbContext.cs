using System.Data.Entity;

namespace HboFactFind.EF
{
    public class HboDbContext : DbContext
    {
        public HboDbContext() : base("HboContext")
        {
        }
    }
}