using Microsoft.AspNetCore.Mvc;

namespace _1.Task_ProductApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
