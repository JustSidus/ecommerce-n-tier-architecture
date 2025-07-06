using System.ComponentModel.DataAnnotations;

namespace Usuarios.Presentacion.Models
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public string Email { get; set; }
    }
}
