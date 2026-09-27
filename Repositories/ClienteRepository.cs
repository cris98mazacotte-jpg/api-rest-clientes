using ApiClientes.Data;
using ApiClientes.Models;

namespace ApiClientes.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly EmpresaDbContext _context;

        public ClienteRepository(EmpresaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }

        public Cliente? ObtenerPorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void Agregar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Actualizar(Cliente cliente)
        {
            var clienteExistente = _context.Clientes.Find(cliente.Id);

            if (clienteExistente != null)
            {
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Apellido = cliente.Apellido;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Telefono = cliente.Telefono;

                _context.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}