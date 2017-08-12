using System.Web.Mvc;
using System.Data.Entity;
using UrlShortener.Models;
using System.Collections.Generic;
using UrlShortener.DAL;
using System.Threading.Tasks;

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
        [HttpPost]
        public ActionResult Index(FormCollection fc, string LongUrl, string ShortUrl)
        {
            Url newUrl = new Url();
            newUrl.LongUrl = LongUrl;
            newUrl.ShortUrl = ShortUrl;


            return View();
        }
        // GET: /HelloWorld/Welcome/ 


        public string Welcome()
        {
            return "Welcome to Url Shortner";
        }
    }
}