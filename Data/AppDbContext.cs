using ValeAtivos324133124.Models;
using Microsoft.EntityFrameworkCore;

namespace ValeAtivos324133124.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Equipamento> Equipamentos => Set<Equipamento>();
    }
}