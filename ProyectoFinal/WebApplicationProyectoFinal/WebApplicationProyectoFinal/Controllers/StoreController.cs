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
        public async Task<IActionResult> Create(string name, string street)
        {
            var store = Store.Build(Guid.NewGuid(), name, street);
            await this.storeServices.Crear(store);
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet] 
        public IActionResult Update(Guid id, string name, string street)
        {
            var store = Store.Build(id, name, street);

            return View(store);
        }
        //Update
        [HttpPost]
        public IActionResult Update1(Guid id, string name, string street)
        {
            var store = Store.Build(id, name, street);
            this.storeServices.Update(store);
            return RedirectToAction(nameof(Index)); ;
        }


        //Delete

        [HttpGet]
        public IActionResult Delete(Guid id, string name, string street)
        {
            var store = Store.Build(id, name, street);

            return View(store);
        }

        [HttpPost]
        public IActionResult Delete1(Guid id, string name, string adress)
        {
            var store = Store.Build(id, name, adress);
            this.storeServices.Delete1(store);
            return RedirectToAction(nameof(Index)); ;
        }
    }
}
