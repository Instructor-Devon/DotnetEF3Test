using Microsoft.EntityFrameworkCore;

namespace TestingMvc.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<Member> Members {get;set;}
    }
}