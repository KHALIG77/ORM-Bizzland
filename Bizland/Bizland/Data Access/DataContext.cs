

using Bizland.Models;
using Microsoft.EntityFrameworkCore;

namespace Bizland.Data_Access
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Service>Service { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
