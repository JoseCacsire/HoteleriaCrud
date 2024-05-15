using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BD_HOTELERIA.Models
{
    public partial class HOTELERIA_SQLContext : DbContext
    {
        public HOTELERIA_SQLContext()
        {
        }

        public HOTELERIA_SQLContext(DbContextOptions<HOTELERIA_SQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FotoHabitacion> FotoHabitacions { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<Habitacion> Habitacions { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Reservacion> Reservacions { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TipoHabitacion> TipoHabitacions { get; set; }
        public virtual DbSet<TipoServicio> TipoServicios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
		public virtual DbSet<servicio_por_gastos> Servicio_Por_Gastos { get; set; }
		public virtual DbSet<usuario_por_reservaciones> Usuario_Por_Reservaciones { get; set; }
		public virtual DbSet<habitaciones_piso_tipo> Habitaciones_Piso_Tipos { get; set; }
		public virtual DbSet<reservaciones_caras> Reservaciones_Caras { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-HOVR2QKO\\SQLEXPRESS;database=HOTELERIA_SQL;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<FotoHabitacion>(entity =>
            {
                entity.HasKey(e => e.IdFotoHabitacion)
                    .HasName("PK__fotoHabi__8902F1384F859E8E");

                entity.ToTable("fotoHabitacion");

                entity.Property(e => e.IdFotoHabitacion).HasColumnName("idFotoHabitacion");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("foto");

                entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");

                entity.HasOne(d => d.IdHabitacionNavigation)
                    .WithMany(p => p.FotoHabitacions)
                    .HasForeignKey(d => d.IdHabitacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__fotoHabit__idHab__412EB0B6");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.HasKey(e => e.IdGastos)
                    .HasName("PK__gastos__9C14561A0EC90F00");

                entity.ToTable("gastos");

                entity.Property(e => e.IdGastos).HasColumnName("idGastos");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdReservacion).HasColumnName("idReservacion");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdReservacionNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__gastos__idReserv__49C3F6B7");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__gastos__idServic__4AB81AF0");
            });

            modelBuilder.Entity<Habitacion>(entity =>
            {
                entity.HasKey(e => e.IdHabitacion)
                    .HasName("PK__habitaci__D9D53BE2F62294CF");

                entity.ToTable("habitacion");

                entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");

                entity.Property(e => e.NumeroHabitacion).HasColumnName("numeroHabitacion");

                entity.Property(e => e.Piso).HasColumnName("piso");

                entity.Property(e => e.Precio8Horas)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio8Horas");

                entity.Property(e => e.PrecioDia)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precioDia");

                entity.HasOne(d => d.IdTipoHabitacionNavigation)
                    .WithMany(p => p.Habitacions)
                    .HasForeignKey(d => d.IdTipoHabitacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__habitacio__idTip__3E52440B");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK__pais__BD2285E391D5E03B");

                entity.ToTable("pais");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombrePais");
            });

            modelBuilder.Entity<Reservacion>(entity =>
            {
                entity.HasKey(e => e.IdReservacion)
                    .HasName("PK__reservac__C813D8AD62699AE0");

                entity.ToTable("reservacion");

                entity.Property(e => e.IdReservacion).HasColumnName("idReservacion");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasColumnName("fechaEntrada");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("date")
                    .HasColumnName("fechaSalida");

                entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdHabitacionNavigation)
                    .WithMany(p => p.Reservacions)
                    .HasForeignKey(d => d.IdHabitacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reservaci__idHab__45F365D3");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservacions)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__reservaci__idUsu__44FF419A");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__rol__3C872F76ABC75CD4");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombreRol");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Rols)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rol__idUsuario__2B3F6F97");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__servicio__CEB98119DEB43EBD");

                entity.ToTable("servicio");

                entity.Property(e => e.IdServicio).HasColumnName("idServicio");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__servicio__idTipo__30F848ED");
            });

            modelBuilder.Entity<TipoHabitacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoHabitacion)
                    .HasName("PK__tipoHabi__64CD3F69CB53B779");

                entity.ToTable("tipoHabitacion");

                entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");

                entity.Property(e => e.Camas).HasColumnName("camas");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.Eliminado).HasColumnName("eliminado");

                entity.Property(e => e.Exterior)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("exterior")
                    .IsFixedLength(true);

                entity.Property(e => e.Internet)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("internet")
                    .IsFixedLength(true);

                entity.Property(e => e.Jacuzzi)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jacuzzi")
                    .IsFixedLength(true);

                entity.Property(e => e.Netflix)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("netflix")
                    .IsFixedLength(true);

                entity.Property(e => e.Salon)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("salon")
                    .IsFixedLength(true);

                entity.Property(e => e.Terraza)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("terraza")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio)
                    .HasName("PK__tipoServ__27861676ECFA7FE7");

                entity.ToTable("tipoServicio");

                entity.Property(e => e.IdTipoServicio).HasColumnName("idTipoServicio");

                entity.Property(e => e.NombreServicio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreServicio");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuario__645723A616DAB477");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ApellidoMadre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidoMadre");

                entity.Property(e => e.ApellidoPadre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidoPadre");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Eliminado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("eliminado")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__usuario__idPais__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
