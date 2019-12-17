using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Suporte.Models;

namespace Suporte.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index(string name, int id)
        {
            var UsersList = new User() { Name = name, Id = id };

            return View(UsersList);
        }

        public ActionResult UsersList()
        {
            return View();
        }
    }
}