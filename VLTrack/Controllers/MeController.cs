using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLTrack.Models;

namespace VLTrack.Controllers
{
    public class MeController : Controller
    {
        ApplicationDbContext _context;
        public MeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Me
        Customer customer = new Customer()
        {
            CutomerName = "Mohamed Abdelwahab",
            CustomerEmail = "m.abdelwahab84@live.com"
        };

        City city = new City();

        public ActionResult Index()
        {
            
            
            return View(city);
        }
        public ActionResult _PersonalDetails()
        {

            return PartialView();
        }
    }
}