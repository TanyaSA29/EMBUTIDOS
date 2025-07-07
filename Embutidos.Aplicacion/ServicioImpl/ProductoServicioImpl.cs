using Embutidos.Aplicacion.DTO.DTOs;
using Embutidos.Aplicacion.Servicios;
using Embutidos.Dominio.Modelo.Abstracciones;
using Embutidos.Infraestructura.AccesoDatos;
using Embutidos.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Aplicacion.ServicioImpl
{
    public class ProductoServicioImpl : IProductoServicio
    {
        private IProductoRepositorio productoRepositorio;
        public ProductoServicioImpl(EmbutidosDBContext _embutidosDBContext)
        {
            this.productoRepositorio = new ProductoRepositorioImpl(_embutidosDBContext);
        }
        public async Task AddProductoAsync(Productoo nuevoproducto)
        {
            await productoRepositorio.AddAsync(nuevoproducto);
        }
        public async Task DeleteProductoAsync(int id)
        {
            await productoRepositorio.DeleteAsync(id);
        }

        public async Task<IEnumerable<Productoo>> GetAllProductoAsync()
        {
            return await productoRepositorio.GetAllAsync();
        }

        public Task<Productoo> GetByIdProductoAsync(int id)
        {
            return productoRepositorio.GetByIdAsync(id);
        }

        public Task<List<Productoo>> ListarProductosActivos()
        {
            return productoRepositorio.ListarProductosActivos();
        }

        public Task<List<Productoo>> ListarProductosNombres(string nombres)
        {
            return productoRepositorio.ListarProductosNombres(nombres);
        }

        public Task<List<ProductoTipoProductoDTO>> ListarProductosPorTipo()
        {
            return productoRepositorio.ListarProductosPorTipo();
        }

        public async Task UpdateProductoAsync(Productoo entidad)
        {
            await productoRepositorio.UpdateAsync(entidad);
        }
    }
}