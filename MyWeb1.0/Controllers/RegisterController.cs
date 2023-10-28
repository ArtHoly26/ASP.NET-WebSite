﻿using Microsoft.AspNetCore.Mvc;
using MyWeb1._0.Models;

namespace MyWeb1._0.Controllers
{
    public class RegisterController : Controller
    {
        ApplicationContext db;

        public RegisterController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return Redirect("/");
            }

            return View("Index");
        }

    }
}
