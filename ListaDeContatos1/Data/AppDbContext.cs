using ListaDeContatos1.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeContatos1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> _context) : base(_context)
        {
        }

        public DbSet<ContatoModel> Contato { get; set; }
    }
}
