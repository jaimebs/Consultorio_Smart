using Core.Domain;
using Core.ModelViews.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IClienteManager
    {
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteById(int id);
        Task<Cliente> InsertClienteAsync(NovoCliente cliente);
        Task<Cliente> UpdateClienteAsync(AlteraCliente alteraCliente);
        Task DeleteClienteAsync(int id);
    }
}
