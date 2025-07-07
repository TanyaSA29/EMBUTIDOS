using Embutidos.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Dominio.Modelo.Abstracciones
{
    public interface IProductoRepositorio : IRepositorio<Productoo>

    {
        public Task<List<Productoo>> ListarProductosActivos();
        public Task<List<Productoo>> ListarProductosNombres(string nombres);
    }
}
