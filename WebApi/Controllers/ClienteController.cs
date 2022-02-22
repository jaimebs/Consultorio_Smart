using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Manager.Interfaces;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteManager clienteManager;
        public ClienteController(IClienteManager clienteManager)
        {
            this.clienteManager = clienteManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await clienteManager.GetClientesAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await clienteManager.GetClienteById(id);

            if (cliente == null)
                return NotFound(new { message = "Cliente não encontrado!" });

            return Ok(cliente);
        }

    }
}
