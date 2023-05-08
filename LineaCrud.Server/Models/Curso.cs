using System;
using System.Collections.Generic;

namespace LineaCrud.Server.Models;

public partial class Curso
{
    public int IdCurso { get; set; }

    public int? Codigo { get; set; }

    public string? NombreCurso { get; set; }

    public int? Creditos { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
