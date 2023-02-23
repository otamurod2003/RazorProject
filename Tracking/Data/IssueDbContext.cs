using Microsoft.EntityFrameworkCore;
using Tracking.Models;
namespace Tracking.Data
{
    public class IssueDbContext: DbContext
    {
        public IssueDbContext(DbContextOptions options):base(options) { }
        public DbSet<Issue> Issues { get; set; }
    }
}
