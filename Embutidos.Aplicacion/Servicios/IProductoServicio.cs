using Embutidos.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Embutidos.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IProductoServicio
    {
        [OperationContract]
        Task AddProductoAsync(Productoo nuevoproducto);
        [OperationContract]
        Task AddAsync(Productoo entidad);

        [OperationContract]
        Task DeleteProductoAsync(int id);
        [OperationContract]
        Task UpdateProductoAsync(Productoo entidad);
        [OperationContract]
        Task<IEnumerable<Productoo>> GetAllProductosAsync();

        [OperationContract]
        Task<Productoo> GetProductoByIdAsync(int id);
      
    }
}
