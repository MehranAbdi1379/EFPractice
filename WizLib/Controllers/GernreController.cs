using Microsoft.AspNetCore.Mvc;
using WizLib.DataAccess.Data;
using WizLib.Models.Models;

namespace WizLib.Controllers;

public class GernreController : Controller
{
    private readonly ApplicationDbContext _db;

    public GernreController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        List<Genre> objList = _db.Genres.ToList();
        return View(objList);
    }
}