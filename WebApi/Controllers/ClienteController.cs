using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Manager.Interfaces;
using System.Threading.Tasks;
using Core.ModelViews.Cliente;

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
            var clienteRetornado = await clienteManager.GetClienteById(id);

            if (clienteRetornado == null)
                return NotFound(new { message = "Cliente não encontrado!" });

            return Ok(clienteRetornado);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(NovoCliente novoCliente)
        {
            try
            {
                var clienteRetornado = await clienteManager.InsertClienteAsync(novoCliente);

                return CreatedAtAction(nameof(GetById), new { id = clienteRetornado.Id }, clienteRetornado);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno da aplicação {ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(AlteraCliente alteraCliente)
        {
            var clienteAtualizado = await clienteManager.UpdateClienteAsync(alteraCliente);

            if (clienteAtualizado == null)
                return NotFound(new { message = "Cliente não encontrado!" });

            return Ok(clienteAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await clienteManager.DeleteClienteAsync(id);
            return NoContent();
        }
    }
}
