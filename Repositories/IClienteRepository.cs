using ApiClientes.Models;

namespace ApiClientes.Repositories
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ObtenerTodos();
        Cliente? ObtenerPorId(int id);
        void Agregar(Cliente cliente);
        void Actualizar(Cliente cliente);
        void Eliminar(int id);
    }
}