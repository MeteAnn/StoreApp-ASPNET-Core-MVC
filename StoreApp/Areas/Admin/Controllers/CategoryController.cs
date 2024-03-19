using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {


        public IActionResult Index()
        {


            return View();

        }


    }
}