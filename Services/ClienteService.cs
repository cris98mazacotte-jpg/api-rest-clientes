using ApiClientes.Models;
using ApiClientes.Repositories;

namespace ApiClientes.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Cliente> ObtenerTodos()
        {
            return _repository.ObtenerTodos();
        }

        public Cliente? ObtenerPorId(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public void Agregar(Cliente cliente)
        {
            _repository.Agregar(cliente);
        }

        public void Actualizar(Cliente cliente)
        {
            _repository.Actualizar(cliente);
        }

        public void Eliminar(int id)
        {
            _repository.Eliminar(id);
        }
    }
}