using Microsoft.AspNetCore.Mvc;
using ApiClientes.Models;
using ApiClientes.Services;

namespace ApiClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClientesController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            return Ok(_service.ObtenerTodos());
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var cliente = _service.ObtenerPorId(id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult Crear(Cliente cliente)
        {
            _service.Agregar(cliente);

            return CreatedAtAction(
                nameof(ObtenerPorId),
                new { id = cliente.Id },
                cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, Cliente cliente)
        {
            var clienteExistente = _service.ObtenerPorId(id);

            if (clienteExistente == null)
            {
                return NotFound();
            }

            cliente.Id = id;

            _service.Actualizar(cliente);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var cliente = _service.ObtenerPorId(id);

            if (cliente == null)
            {
                return NotFound();
            }

            _service.Eliminar(id);

            return NoContent();
        }
    }
}