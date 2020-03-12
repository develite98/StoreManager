using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreManager.Models;

namespace StoreManager.Controllers
{
    public class HomeController : Controller
    {
        StoreDbContext db = new StoreDbContext();
        public IActionResult Index()
        {
            List<Users> users = db.Users.ToList();
            return View(users);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
