using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9_10.Models;

namespace Tarea9_10.Data
{
    public class IglesiaDbContext:DbContext
    {
        public IglesiaDbContext(DbContextOptions<IglesiaDbContext> options):base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
