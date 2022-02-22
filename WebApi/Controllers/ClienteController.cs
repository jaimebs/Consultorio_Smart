using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace WebApi.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = new List<Cliente>
            {
                new Cliente{
                    Id = 1,
                    Nome = "José",
                    DataNascimento = new DateTime(1994,11,24)
                    },
                new Cliente{
                    Id = 2,
                    Nome = "Maria",
                    DataNascimento = new DateTime(2010,05,10)
                    },
            };

            return Ok(clientes);
        }
    }
}
