using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Datos;
using Usuarios.Entidades;

namespace Usuarios.Negocio
{
    public class PersonaServicio
    {
        private readonly IPersonaRepositorio _repositorio;

        public PersonaServicio(IPersonaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Persona> ObtenerTodas() => _repositorio.ObtenerTodas();

        public Persona ObtenerPorId(int id) => _repositorio.ObtenerPorId(id);

        public void Crear(Persona persona) => _repositorio.Crear(persona);

        public void Actualizar(Persona persona) => _repositorio.Actualizar(persona);

        public void Eliminar(int id) => _repositorio.Eliminar(id);

        public void Guardar() => _repositorio.Guardar();
    }
}
