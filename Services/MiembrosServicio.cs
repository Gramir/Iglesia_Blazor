using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea9_10.Data;
using Tarea9_10.Models;

namespace Tarea9_10.Services
{
    public class MiembrosServicio
    {
        private IglesiaDbContext IglesiaContext;

        public MiembrosServicio(IglesiaDbContext IglesiaContext)
        {
            this.IglesiaContext = IglesiaContext;
        }
        //lee
        public async Task<List<Persona>> GetPersonasAsync()
        {
            return await IglesiaContext.Personas.ToListAsync();
        }
        //escribe
        public async Task<Persona> AgregarPersona(Persona persona)
        {
            try
            {
                IglesiaContext.Personas.Add(persona);
                await IglesiaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return persona;
        }
        //edita
        public async Task<Persona> EditarPersona(Persona persona)
        {
            try
            {
                var PersonaExistete = IglesiaContext.Personas.FirstOrDefault(a => a.Id == persona.Id);
                if (PersonaExistete != null)
                {
                    IglesiaContext.Update(persona);
                    await IglesiaContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return persona;
        }
        //borra
        public async Task BorrarPersona(Persona persona)
        {
            try
            {
                IglesiaContext.Personas.Remove(persona);
                await IglesiaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //buscar
        public async Task<List<Persona>> BuscarPersona(string busqueda)
        {
            return await IglesiaContext.Personas.Where(s => s.Nombres.ToLower().Contains(busqueda.ToLower())).ToListAsync();
        }
    }
}
