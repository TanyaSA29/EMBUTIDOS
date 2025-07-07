using Embutidos.Aplicacion.ServicioImpl;
using Embutidos.Aplicacion.Servicios;
using Embutidos.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Security.Cryptography.Xml;

namespace TestEmbutidosSQL
{
    public class Tests
    {
        private EmbutidosDBContext _context;  //crear el contextor de cadena
        private IProductoServicio _productoServicio; //acceso a la arquitectura

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<EmbutidosDBContext>()
                .UseSqlServer("Data Source=STEPHYR;Initial Catalog=EmbutidosDB;Integrated Security=True; Encrypt = true; TrustServerCertificate = true;")
                .Options; //cadena de conexcion a las BD
            _context = new EmbutidosDBContext(options); //inicializar el contexto
            _productoServicio = new ProductoServicioImpl(_context); //inicializar el servicio de producto   
        }

        [Test]
        /* public async Task InsertarProducto()
         {
             var producto = new Productoo { nombre = "Salchichas de pollo", descripcion = "tipo 1", estado = 1 };
             await _productoServicio.AddProductoAsync(producto);
             /*var producto = new Productoo { nombre = "Jamon", descripcion = "tipo 2", estado = 1 };
             await _productoServicio.AddProductoAsync(producto);
             /*var result = await _productoServicio.GetAllProductoAsync();
             Console.WriteLine(result.ToList());
             Assert.Pass();
         }

       public async Task ListarProductos()

        {
            var productos = _productoServicio.ListarProductosActivos();
        }*/

        public async Task ListarProductos()

        {
            var productos = _productoServicio.ListarProductosNombres("Embutidos");
        }





        [TearDown]
        public void Limpiar()
        {
            _context.Dispose(); //liberar los recursos del contexto
        }
    }
}