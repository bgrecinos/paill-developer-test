using Microsoft.EntityFrameworkCore;
using PaillApp.Entities;

#nullable disable

namespace PaillApp.Data
{
    public partial class PaillContext : DbContext
    {
        public PaillContext()
        {
        }

        public PaillContext(DbContextOptions<PaillContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<EmpleadoHabilidad> EmpleadoHabilidads { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea)
                    .HasName("Pk_Area");

                entity.ToTable("Area");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("Pk_Empleado");

                entity.ToTable("Empleado");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Empleado_Area");
            });

            modelBuilder.Entity<EmpleadoHabilidad>(entity =>
            {
                entity.HasKey(e => e.IdHabilidad)
                    .HasName("Pk_EmpleadoHabilidad");

                entity.ToTable("EmpleadoHabilidad");

                entity.Property(e => e.NombreHabilidad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.EmpleadoHabilidads)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_EmpleadoHabilidad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
