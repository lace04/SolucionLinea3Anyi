using System;
using System.Collections.Generic;

namespace LineaCrud.Server.Models;

public partial class Alumno
{
    public int IdAlumno { get; set; }

    public int? Identificacion { get; set; }

    public string? Nombre { get; set; }

    public string? Papellido { get; set; }

    public string? Sapelldo { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
