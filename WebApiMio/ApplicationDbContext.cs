using Microsoft.EntityFrameworkCore;
using WebApiMio.Entidades;

namespace WebApiMio
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
    }
}