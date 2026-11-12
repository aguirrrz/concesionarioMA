using aplicacionesMA.entidades;
using aplicacionesMA.interfaces;
using Microsoft.EntityFrameworkCore;

namespace aplicacionesMA.implementaciones 
{
    public class VehiculosAplicacion 
    {
        private readonly IConexion _conexion;

        public VehiculosAplicacion(IConexion conexion)
        {
            _conexion = conexion;
        }

        public Vehiculos Actualizar(Vehiculos entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("El vehículo no ha sido guardado previamente.");

            if (Validar(entidad))
                throw new Exception("Falta información obligatoria en el vehículo.");

            var entry = _conexion.Entry<Vehiculos>(entidad);
            entry.State = EntityState.Modified;
            _conexion.SaveChanges();
            return entidad;
        }

        public Vehiculos Borrar(Vehiculos entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("El vehículo no es válido para eliminar.");

            _conexion.Vehiculos!.Remove(entidad);
            _conexion.SaveChanges();
            return entidad;
        }

        public List<Vehiculos> Buscar(Vehiculos entidad)
        {
     
            var query = _conexion.Vehiculos!.AsQueryable();

            if (!string.IsNullOrEmpty(entidad.Placa))
            {
                query = query.Where(x => x.Placa!.Contains(entidad.Placa));
            }
            else if (!string.IsNullOrEmpty(entidad.Modelo))
            {
                query = query.Where(x => x.Modelo!.Contains(entidad.Modelo));
            }

            return query.ToList();
        }

        public List<Vehiculos> Consultar()
        {
            return _conexion.Vehiculos!.Take(5).ToList();
        }

        public Vehiculos Insertar(Vehiculos entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("El vehículo ya fue guardado.");

            if (Validar(entidad))
                throw new Exception("Falta información obligatoria en el vehículo.");

            _conexion.Vehiculos!.Add(entidad);
            _conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Vehiculos entidad)
        {
          
            return string.IsNullOrEmpty(entidad.Placa) ||
                   string.IsNullOrEmpty(entidad.Modelo) ||
                   entidad.Precio <= 0;
        }
    }
}