using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Entidades;

namespace Usuarios.Datos
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        private readonly AplicacionDbContext _contexto;

        public PersonaRepositorio(AplicacionDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Persona> ObtenerTodas() => _contexto.Personas.ToList();

        public Persona ObtenerPorId(int id) => _contexto.Personas.Find(id);

        public void Crear(Persona persona) => _contexto.Personas.Add(persona);

        public void Actualizar(Persona persona) => _contexto.Personas.Update(persona);

        public void Eliminar(int id)
        {
            var persona = _contexto.Personas.Find(id);
            if (persona != null)
                _contexto.Personas.Remove(persona);
        }

        public void Guardar() => _contexto.SaveChanges();
    }

}
