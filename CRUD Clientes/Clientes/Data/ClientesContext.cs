using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clientes.Models;

namespace Clientes.Data
{
    public class ClientesContext : DbContext
    {
        public ClientesContext (DbContextOptions<ClientesContext> options)
            : base(options)
        {
        }

        public DbSet<Clientes.Models.Cliente> Cliente { get; set; } = default!;
    }
}
