using DIPLOM123.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DIPLOM123.Controllers
{
    public class HomeController : Controller
    {
        //ApplicationDbContext db = new ApplicationDbContext();

        SgkDbContext db;
        public HomeController(SgkDbContext context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            /*// получаем из бд все объекты Book
            IEnumerable<City> cities = db.Cities;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Cities = cities;

            IEnumerable<Station> stations = db.Stations;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Stations = stations;
            // возвращаем представление

            return View(db.Cities.ToList());
            */

            var turbinecharacteristics = db.Turbinecharacteristics.Include(p => p.City).Include(p => p.Station);
            
            return View(turbinecharacteristics.ToList());
        }
    }
}