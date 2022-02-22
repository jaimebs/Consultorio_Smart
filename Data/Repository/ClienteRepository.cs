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

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await context.Clientes.AddAsync(cliente);
            await context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteConsultado = await GetClienteById(cliente.Id);

            if(clienteConsultado == null)
            {
                return null;
            }
            // Não é a melhor maneira caso tenha vários campos.
            //clienteConsultado.Nome = cliente.Nome;
            //clienteConsultado.DataNascimento = cliente.DataNascimento;

            // Pega os valores ja existentes e atualiza somente os alterados.
            context.Entry(clienteConsultado).CurrentValues.SetValues(cliente);

            await context.SaveChangesAsync();
            return clienteConsultado;
        }

        public async Task DeleteClienteAsync(int id)
        {
            var clienteConsultado = await GetClienteById(id);
            context.Clientes.Remove(clienteConsultado);
            await context.SaveChangesAsync();
        }
    }
}
