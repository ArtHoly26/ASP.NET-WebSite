using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWeb1._0.Models;

namespace MyWeb1._0.Controllers
{
    public class InfoController : Controller
    {
        ApplicationContext db;
        public InfoController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        { 
            return View(await db.Users.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                User? user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

    }
}
