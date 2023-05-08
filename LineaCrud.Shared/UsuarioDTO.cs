using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaCrud.Shared
{
  public class UsuarioDTO
  {
    public int IdUsuario { get; set; }
    public string? NombreCompleto { get; set; }
    public string? Correo { get; set; }
    public string? Login { get; set; }
    public string? Clave { get; set; }
  }
}
