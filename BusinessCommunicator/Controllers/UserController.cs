using BusinessCommunicator.Models;
using BusinessCommunicator.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BusinessCommunicator.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepository<User> _usersRepository;
        private readonly IRepository<Message> _messageRepository;

        public UserController(IRepository<User> userRepository)
        {
            _usersRepository = userRepository;
        }



        // GET: UserController
        public ActionResult Index()
        {
            return View(_usersRepository.GetAll());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View(_usersRepository.GetById(id));
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View(new User());
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            user.Active = true;
            _usersRepository.Add(user);
                return RedirectToAction(nameof(Index));
         
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_usersRepository.GetById(id));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            _usersRepository.Update(user);
                return RedirectToAction(nameof(Index));
           
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
