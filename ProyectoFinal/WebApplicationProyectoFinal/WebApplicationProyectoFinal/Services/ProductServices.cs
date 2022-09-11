using WebApplicationProyectoFinal.Data;
using WebApplicationProyectoFinal.Models;

namespace WebApplicationProyectoFinal.Services
{
    public class ProductServices
    {
        private readonly IRepository repository;
        public ProductServices(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task Crear(Product product)
        {
            //Comprobar parametros
            if (product is null)
                throw new Exception("Product is null");

            await this.repository.Save(product);
            await this.repository.Commit();
        }
        public async Task Modificar(Product product)
        {
            this.repository.Update(product);
            await this.repository.Commit();
        }
        public async Task Eliminar(Product product)
        {
            this.repository.Delete(product);
            await this.repository.Commit();
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await this.repository.GetAll<Product>();
        }
    }
}
