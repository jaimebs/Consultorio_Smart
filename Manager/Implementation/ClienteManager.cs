﻿using Core.Domain;
using Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await clienteRepository.GetClientesAsync();
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            return await clienteRepository.GetClienteById(id);
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            return await clienteRepository.InsertClienteAsync(cliente);
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            return await clienteRepository.UpdateClienteAsync(cliente);
        }

        public async Task DeleteClienteAsync(int id)
        {
            await clienteRepository.DeleteClienteAsync(id);
        }
    }
}
