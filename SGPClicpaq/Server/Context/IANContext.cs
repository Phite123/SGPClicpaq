using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SGPClicpaq.Shared.Models;

namespace SGPClicpaq.Server.Context
{
    public partial class IANContext : DbContext
    {
        public IANContext()
        {
        }

        public IANContext(DbContextOptions<IANContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Viaje> Viajes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=192.168.0.12;user=consulta;password=consulta;database=IAN");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Viaje>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Chofer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chofer");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.EstadoStr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoStr");

                entity.Property(e => e.FechaViaje)
                    .HasColumnType("date")
                    .HasColumnName("fechaViaje");

                entity.Property(e => e.Fin)
                    .HasColumnType("datetime")
                    .HasColumnName("fin");

                entity.Property(e => e.Guias)
                    .IsUnicode(false)
                    .HasColumnName("guias");

                entity.Property(e => e.Inicio)
                    .HasColumnType("datetime")
                    .HasColumnName("inicio");

                entity.Property(e => e.Kilometros).HasColumnName("kilometros");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Sucursal).HasColumnName("sucursal");

                entity.Property(e => e.TimeCargando)
                    .HasColumnType("datetime")
                    .HasColumnName("timeCargando");

                entity.Property(e => e.TimeEnCamion)
                    .HasColumnType("datetime")
                    .HasColumnName("timeEnCamion");

                entity.Property(e => e.TimeGenerado)
                    .HasColumnType("datetime")
                    .HasColumnName("timeGenerado");

                entity.Property(e => e.TimeSaleCamion)
                    .HasColumnType("datetime")
                    .HasColumnName("timeSaleCamion");

                entity.Property(e => e.TotalBultos).HasColumnName("totalBultos");

                entity.Property(e => e.TotalGuias).HasColumnName("totalGuias");

                entity.Property(e => e.TotalPeso).HasColumnName("totalPeso");

                entity.Property(e => e.TotalVolumen).HasColumnName("totalVolumen");

                entity.Property(e => e.Transporte)
                    .IsUnicode(false)
                    .HasColumnName("transporte");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unidad");

                entity.Property(e => e.ZonaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zonaDestino");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
