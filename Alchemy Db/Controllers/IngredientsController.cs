using Microsoft.AspNetCore.Mvc;

namespace Alchemy_Db.Controllers
{
    public class IngredientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
