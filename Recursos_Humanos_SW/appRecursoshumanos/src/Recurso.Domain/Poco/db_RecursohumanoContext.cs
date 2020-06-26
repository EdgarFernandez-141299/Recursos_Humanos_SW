using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Recurso.Domain.Poco
{
    public partial class db_RecursohumanoContext : DbContext
    {
        public db_RecursohumanoContext(){}

        public db_RecursohumanoContext(DbContextOptions<db_RecursohumanoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Discapacidad> Discapacidad { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<Titulo> Titulo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;user=recurso_humano;password='edgar1234;';database=db_Recursohumano");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discapacidad>(entity =>
            {
                entity.HasKey(e => e.IdDiscapacidad)
                    .HasName("PRIMARY");

                entity.ToTable("discapacidad");

                entity.Property(e => e.IdDiscapacidad)
                    .HasColumnName("id_discapacidad")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Discapacidad1)
                    .IsRequired()
                    .HasColumnName("discapacidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PRIMARY");

                entity.ToTable("empleado");

                entity.HasIndex(e => e.IdDiscapacidad)
                    .HasName("FK_discap_idx");

                entity.HasIndex(e => e.IdEstadoNac)
                    .HasName("FK_estado_idx");

                entity.HasIndex(e => e.IdGenero)
                    .HasName("FK_gen_idx");

                entity.HasIndex(e => e.IdPuesto)
                    .HasName("FK_puesto_idx");

                entity.HasIndex(e => e.IdTituloObtenido)
                    .HasName("FK_titul_idx");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("apellido_materno")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApellidoPaterno)
                    .HasColumnName("apellido_paterno")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ComunidadIndigena)
                    .HasColumnName("comunidad_indigena")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'''null'''");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EstadoNacimiento)
                    .HasColumnName("estado_nacimiento")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estatura)
                    .HasColumnName("estatura")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FecNac)
                    .HasColumnName("fec_nac")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdDiscapacidad)
                    .HasColumnName("id_discapacidad")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.IdEstadoNac)
                    .HasColumnName("id_estado_nac")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGenero)
                    .IsRequired()
                    .HasColumnName("id_genero")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdPuesto)
                    .HasColumnName("id_puesto")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IdTituloObtenido)
                    .HasColumnName("id_titulo_obtenido")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.InsFec)
                    .HasColumnName("ins_fec")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumeroSeguroSocial)
                    .HasColumnName("numero_seguro_social")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcedeComunidadIndigena)
                    .HasColumnName("procede_comunidad_indigena")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RedSocial)
                    .HasColumnName("red_social")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SueldoDeseado)
                    .HasColumnName("sueldo_deseado")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelefonoLocal)
                    .HasColumnName("telefono_local")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'''null'''");

                entity.Property(e => e.TelefonoMovil)
                    .HasColumnName("telefono_movil")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'''null'''");

                entity.Property(e => e.TrabajaActualmente)
                    .HasColumnName("trabaja_actualmente")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnidadMedicinaFamiliar)
                    .HasColumnName("unidad_medicina_familiar")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdDiscapacidadNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdDiscapacidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_discap_idx");

                entity.HasOne(d => d.IdEstadoNacNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdEstadoNac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_estado_idx");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gen_idx");

                entity.HasOne(d => d.IdPuestoNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdPuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_puesto_idx");

                entity.HasOne(d => d.IdTituloObtenidoNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdTituloObtenido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_titul_idx");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstadoNac)
                    .HasName("PRIMARY");

                entity.ToTable("estado");

                entity.Property(e => e.IdEstadoNac)
                    .HasColumnName("id_estado_nac")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado1)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PRIMARY");

                entity.ToTable("genero");

                entity.Property(e => e.IdGenero)
                    .HasColumnName("id_genero")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Genero1)
                    .IsRequired()
                    .HasColumnName("genero")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.IdPuesto)
                    .HasName("PRIMARY");

                entity.ToTable("puesto");

                entity.Property(e => e.IdPuesto)
                    .HasColumnName("id_puesto")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Puesto1)
                    .IsRequired()
                    .HasColumnName("puesto")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Titulo>(entity =>
            {
                entity.HasKey(e => e.IdTituloObtenido)
                    .HasName("PRIMARY");

                entity.ToTable("titulo");

                entity.Property(e => e.IdTituloObtenido)
                    .HasColumnName("id_titulo_obtenido")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Titulo1)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
