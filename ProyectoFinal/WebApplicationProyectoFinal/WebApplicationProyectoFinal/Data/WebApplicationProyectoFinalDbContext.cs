
using Microsoft.EntityFrameworkCore;
using WebApplicationProyectoFinal.Models;

namespace WebApplicationProyectoFinal.Data
{
    public class WebApplicationProyectoFinalDbContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public WebApplicationProyectoFinalDbContext(DbContextOptions<WebApplicationProyectoFinalDbContext> options) 
            : base(options) 
            { 
            }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("");
        //}
    }
}
