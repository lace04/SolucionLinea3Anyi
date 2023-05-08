using System;
using System.Collections.Generic;

namespace LineaCrud.Server.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Correo { get; set; }

    public string? Login { get; set; }

    public string? Clave { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
