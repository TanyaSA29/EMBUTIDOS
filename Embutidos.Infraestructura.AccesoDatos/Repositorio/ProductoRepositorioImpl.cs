using Embutidos.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoRepositorioImpl : RepositorioImpl<Productoo>, IProductoRepositorio
    {
        private readonly EmbutidosDBContext _dbContext;

        public ProductoRepositorioImpl(EmbutidosDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Productoo>> ListarProductosActivos()
        {
            try
            {
                var result = from prod in _dbContext.Productoo
                             where prod.estado == 1
                             select prod;
                return await result.ToListAsync();

            }

            catch (Exception ex)
            {
                throw new Exception("Error al listar productos activos: " + ex.Message);
            }

        }
        public Task<List<Productoo>> ListarProductosNombres(string nombres)
        {
            try
            {
                var result = from prod in _dbContext.Productoo
                             where prod.nombre == nombres
                             select prod;
                return result.ToListAsync();

            }

            catch (Exception ex)
            {
                throw new Exception("Error al listar productos activos: " + ex.Message);
            }
        }
    }
}
