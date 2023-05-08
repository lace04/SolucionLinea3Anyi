using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaCrud.Shared
{
  public class AlumnoDTO
  {
    public int IdAlumno { get; set; }
    public int? Identificacion { get; set; }
    public string? Nombre { get; set; }
    public string? Papellido { get; set; }
    public string? Sapelldo { get; set; }
    public int? IdUsuario { get; set; }
  }
}
