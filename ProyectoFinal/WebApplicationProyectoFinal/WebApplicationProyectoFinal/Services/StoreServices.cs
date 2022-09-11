using WebApplicationProyectoFinal.Data;
using WebApplicationProyectoFinal.Models;

namespace WebApplicationProyectoFinal.Services
{
    public class StoreServices
    {
        private readonly IRepository repository;
        public StoreServices (IRepository repository)
        {
            this.repository = repository;
        }
        public async Task Crear(Store store)
        {
            //Comprobar parametros
            if (store is null) 
                throw new Exception("Store is null");

            await this.repository.Save(store);
            await this.repository.Commit();
        }
        public async Task Modificar(Store store)
        {
            this.repository.Update(store);
            await this.repository.Commit();
        }
        public async Task Eliminar(Store store)
        {
           this.repository.Delete(store);
            await this.repository.Commit();
        }
        public async Task <List<Store>>GetAllStores()
        {
            return await this.repository.GetAll<Store>();
        }
    }
}
