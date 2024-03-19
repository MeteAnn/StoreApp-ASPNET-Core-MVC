using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Repositories;
using Repositories.Contracts;



namespace StoreApp.Controllers
{

    

    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _manager;

        public CategoryController(IRepositoryManager manager)
        {


            _manager = manager;


        }

        public IActionResult Index()
        {
            
            var model = _manager.Category.FindAll(false);

            return View(model);



        }

   


    }


}