using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LineaCrud.Server.Models;

public partial class DbpruebaContext : DbContext
{
    public DbpruebaContext()
    {
    }

    public DbpruebaContext(DbContextOptions<DbpruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.IdAlumno);

            entity.ToTable("ALUMNO");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Papellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PApellido");
            entity.Property(e => e.Sapelldo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SApelldo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__ALUMNO__Id_Usuar__3B75D760");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso);

            entity.ToTable("CURSO");

            entity.Property(e => e.NombreCurso)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__CURSO__Id_Usuari__3C69FB99");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__5B65BF978025198A");

            entity.ToTable("USUARIO");

            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
