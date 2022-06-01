using Microsoft.AspNetCore.Mvc;

namespace BusinessCommunicator.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
