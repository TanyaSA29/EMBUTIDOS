using Embutidos.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Infraestructura.AccesoDatos.Repositorio
{
    public class RecetaRepositorioImpl : RepositorioImpl<receta>, IRecetaRepositorio
    {
        public RecetaRepositorioImpl(EmbutidosDBContext context) : base(context)
        {
        }

        public Task<receta> buscarnombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
