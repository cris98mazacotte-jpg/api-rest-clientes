using Microsoft.EntityFrameworkCore;
using ApiClientes.Models;

namespace ApiClientes.Data
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}