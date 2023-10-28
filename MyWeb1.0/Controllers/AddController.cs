using Microsoft.AspNetCore.Mvc;
using MyWeb1._0.Models;

namespace MyWeb1._0.Controllers
{
    public class AddController : Controller
    {
        ApplicationContext db;

        public AddController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> CreateGame(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                await db.SaveChangesAsync();
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
