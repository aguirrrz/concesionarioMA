using aplicacionesMA.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace aplicacionesMA.interfaces
{
    public interface IConexion
    {
        DbSet<Vehiculos>? Vehiculos { get; set; }
        
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
