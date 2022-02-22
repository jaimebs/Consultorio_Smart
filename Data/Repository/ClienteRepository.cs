using Core.Domain;
using Data.Context;
using Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CsContext context;
        public ClienteRepository(CsContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await context.Clientes.AsNoTracking().ToListAsync();
        }
        public async Task<Cliente> GetClienteById(int id)
        {
            return await context.Clientes.FindAsync(id);
        }
    }
}
