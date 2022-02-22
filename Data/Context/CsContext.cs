using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class CsContext : DbContext
    {
        public CsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
