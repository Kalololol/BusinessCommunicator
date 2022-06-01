using BusinessCommunicator.Models;
using BusinessCommunicator.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BusinessCommunicator.Controllers
{
    public class MessageController : Controller
    {
        private readonly IRepository<Message> _messageRepository;
        

        public MessageController(IRepository<Message> messageRepository)
        {
            _messageRepository = messageRepository;
        }

        // GET: MessageController
        public ActionResult Index()
        {
            return View(_messageRepository.GetAll());
        }

        // GET: MessageController/Details/5
        public ActionResult Details(int id)
        {
            return View(_messageRepository.GetById(id));
        }

        // GET: MessageController/Create
        public ActionResult Create()
        {
            return View(new Message());
        }

        // POST: MessageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Message message)
        {
            message.Active = true;
            _messageRepository.Add(message);
            _messageRepository.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: MessageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_messageRepository.GetById(id));
        }

        // POST: MessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Message message)
        {
            message.Active = true;
            _messageRepository.Update(message);
            _messageRepository.SaveChanges();
                return RedirectToAction(nameof(Index));
          
        }

        // GET: MessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_messageRepository.GetById(id));
        }

        // POST: MessageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Message message)
        {
            _messageRepository.Delete(message);
            _messageRepository.SaveChanges();
            return RedirectToAction(nameof(Index));
          
        }
    }
}
