using _05_WebAPP.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _05_WebAPP.MVC.Data
{
    public class EntityContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public EntityContext(DbContextOptions<EntityContext> options) :
            base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     options.UseNpgsql($"Host=localhost;Port=5432;Pooling=true;Database=Treinamento;User Id= postgres;Password=admin;");
        // }
    }
}