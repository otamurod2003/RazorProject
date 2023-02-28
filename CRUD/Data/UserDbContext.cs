using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class UserDbContext : DbContext
    {
       
        public UserDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> User { get; set; }
    }
}
