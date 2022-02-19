using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheBellApp.Data;
using TheBellApp.Models;

namespace TheBellApp.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EventController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> objList = _db.Event;
            return View(objList);
        }
    }
}
