using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Entidades;

namespace Usuarios.Datos
{
    public interface IPersonaRepositorio
    {
        IEnumerable<Persona> ObtenerTodas();
        Persona ObtenerPorId(int id);
        void Crear(Persona persona);
        void Actualizar(Persona persona);
        void Eliminar(int id);
        void Guardar();
    }
}
