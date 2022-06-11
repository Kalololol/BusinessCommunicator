using BusinessCommunicator.Models;
using BusinessCommunicator.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
