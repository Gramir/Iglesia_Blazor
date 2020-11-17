using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9_10.Data;
using Tarea9_10.Models;

namespace Tarea9_10.Services
{
    public class UsuarioServicio
    {
        private IglesiaDbContext IglesiaContext;

        public UsuarioServicio(IglesiaDbContext IglesiaContext)
        {
            this.IglesiaContext = IglesiaContext;
        }
        //lee
        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            return await IglesiaContext.Usuarios.ToListAsync();
        }
        //escribe
        public async Task<Usuario> AgregarUsuario(Usuario usuario)
        {
            try
            {
                IglesiaContext.Usuarios.Add(usuario);
                await IglesiaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return usuario;
        }
    }
}
