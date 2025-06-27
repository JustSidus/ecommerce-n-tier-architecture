using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Entidades;

namespace Usuarios.Datos
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
