using BRQ.Domain.Interfaces.Domain;
using BRQ.UI.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BRQ.UI.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IBRQ _IBRQ;
        public UserController(IBRQ IBRQ)
        {
            _IBRQ = IBRQ;
        }

        // GET: User
        public ActionResult Index()

        {
            var result = _IBRQ.GetAll();

            return View(result);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var result = _IBRQ.Get(id);

            return View(result);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                _IBRQ.Create(new Domain.Entities.User
                {
                    Name = user.name,
                    Email = user.Email,
                    Password = user.Password

                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            User User = new User();
            var result = _IBRQ.Get(id);

            User.IdUser = result.IdUser;
            User.name = result.Name;
            User.Email = result.Email;
            User.Password = result.Password;
           
            return View(User);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                _IBRQ.Edit(new Domain.Entities.User
                {
                    IdUser  =   id,
                    Name = user.name,
                    Email = user.Email,
                    Password = user.Password

                });

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {

            User User = new User();
            var result = _IBRQ.Get(id);

            User.IdUser = result.IdUser;
            User.name = result.Name;
            User.Email = result.Email;
            User.Password = result.Password;

            return View(User);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                _IBRQ.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
