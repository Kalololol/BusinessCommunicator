using BusinessCommunicator.Models;
using BusinessCommunicator.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BusinessCommunicator.Controllers
{
    public class MainController : Controller
    {
        private readonly IRepository<Message> _messageRepository;

        public MainController(IRepository<Message> messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public IActionResult Index()
        {
            return View(_messageRepository.GetAll());
        }
    }
}
