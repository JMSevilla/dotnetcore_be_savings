using BSbankcore.Model;
using Microsoft.EntityFrameworkCore;

namespace BSbankcore.DB
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions <ApiDbContext> options) : base(options){ }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
