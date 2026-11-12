using System;
using System.Collections.Generic;
using System.Text;
using aplicacionesMA.entidades;
using aplicacionesMA.interfaces;
using aplicacionesMA.nucleo;
using Microsoft.EntityFrameworkCore;

namespace aplicacionesMA.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
       
        public Conexion()
        {
        }


        public Conexion(DbContextOptions<Conexion> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                var cadenaConexion = DatosGenerales.StringConexion();
                if (!string.IsNullOrEmpty(cadenaConexion))
                {
                    optionsBuilder.UseSqlServer(cadenaConexion, p => { });
                    optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                }
            }
        }

        public DbSet<Vehiculos> Vehiculos { get; set; } = null!;
    }
}