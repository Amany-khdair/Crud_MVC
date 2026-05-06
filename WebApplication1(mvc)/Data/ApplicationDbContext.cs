using Microsoft.EntityFrameworkCore;
using WebApplication1_mvc_.Models;

namespace WebApplication1_mvc_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlServer("Data Source=.;Database=MVC14;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
    }
}
