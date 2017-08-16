using System.Web.Mvc;
using System.Data.Entity;
using UrlShortener.Models;
using System.Collections.Generic;
using UrlShortener.DAL;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace UrlShortener.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        public async Task<ActionResult> Index()
        {
            using (var db = new UrlDbContext())
            {
                return View(await db.Urls.ToListAsync());
            }
        }

        public async Task<ActionResult> Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc, string LongUrl, string ShortUrl)
        {
            Url newUrl = new Url();
            newUrl.LongUrl = LongUrl;
            newUrl.ShortUrl = ShortUrl;


            return View();
        }

        // GET: /HelloWorld/Welcome/ 
       
        private UrlDbContext db = new UrlDbContext();
        [HttpGet]
        public ActionResult RedirectToLong(string shortURL)
        {
            Url url = db.Urls.Where(u => u.ShortUrl.Equals(shortURL)).FirstOrDefault();
            Console.WriteLine(shortURL);
            return RedirectPermanent(url.LongUrl);
        }



        public string Welcome()
        {
            return "Welcome to Url Shortner";
        }
    }
}