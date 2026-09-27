using ApiClientes.Models;

namespace ApiClientes.Services
{
    public interface IClienteService
    {
        IEnumerable<Cliente> ObtenerTodos();
        Cliente? ObtenerPorId(int id);
        void Agregar(Cliente cliente);
        void Actualizar(Cliente cliente);
        void Eliminar(int id);
    }
}