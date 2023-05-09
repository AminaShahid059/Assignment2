using Microsoft.EntityFrameworkCore;
using EveryHourEatsProject.Models;

namespace EveryHourEatsProject.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base (options)
        {

        }
        public DbSet<Order> Order { get; set; }
    }
}
