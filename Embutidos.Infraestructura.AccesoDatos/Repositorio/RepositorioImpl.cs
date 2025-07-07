using Embutidos.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;

namespace Embutidos.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T>: IRepositorio<T> where T : class
    {
        private readonly EmbutidosDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public RepositorioImpl(EmbutidosDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo insertar registro" + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                _dbSet.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error No se pudo eliminar registro" + ex.Message);
            }
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase Gnerica: No se pudo listar Datos" + ex.Message);
            }
        }
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase Gnerica: No se pudo recuperar Datos" + ex.Message);
            }
        }
        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo actualizar el  registro" + ex.Message);
            }
        }
    }
}
