using Embutidos.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoRepositorioImpl : RepositorioImpl<Productoo>, IProductoRepositorio
    {
        public ProductoRepositorioImpl(EmbutidosDBContext context) : base(context)
        {
        }
    }
}
