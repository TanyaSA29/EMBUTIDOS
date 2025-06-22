using Embutidos.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Infraestructura.AccesoDatos.Repositorio
{
    public class TipoProductoRepositorioImpl : RepositorioImpl<tipo_producto>, ITipoProductoRepositorio
    {
        public TipoProductoRepositorioImpl(EmbutidosDBContext context) : base(context)
        {
        }
    }
}
