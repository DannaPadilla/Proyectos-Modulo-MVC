using Microsoft.AspNetCore.Mvc;
using WebApplicationProyectoFinal.Models;
using WebApplicationProyectoFinal.Services;

namespace WebApplicationProyectoFinal.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreServices storeServices;

        public StoreController(StoreServices storeServices)
        {
            this.storeServices = storeServices;
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var stores= await storeServices.GetAllStores();
            return View(stores);
        }
        [HttpPost]
        public async Task<IActionResult> Crear(string name, string street)
        {
            var store = Store.Build(Guid.NewGuid(), name, street);
            await this.storeServices.Crear(store);
            return View();
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
    }
}
