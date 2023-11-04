﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWeb1._0.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyWeb1._0.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        ApplicationContext db;
        public ShopController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Games.ToListAsync());
        }
    }
}
