using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaCrud.Shared
{
  public class CursoDTO
  {
    public int IdCurso { get; set; }
    public int? Codigo { get; set; }
    public string? NombreCurso { get; set; }
    public int? Creditos { get; set; }
    public int? IdUsuario { get; set; }
  }
}
