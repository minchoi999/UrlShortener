using Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UrlShortener.DAL;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class UrlsController : Controller
    {
        private UrlDbContext db = new UrlDbContext();

        // GET: Urls
        public ActionResult Index()
        {
            return View(db.Urls.ToList());
        }

        /* Returns 000000 if url id is empty or null, or else increments by 1 then returns the new id string*/
        /**
         * A method always needs to do just ONE behaviour
         * A method should always try to reduce coupling
         * All programming practices try to aim for low coupling, high cohesion
         * Low coupling means less dependeability on other objects, high cohesion means
         *   methods act on controlled data structures specifically built for that method
         * Below method uses Id property of Url object, and nothing else. Therefore this
         *   method is highly coupled to the Url object, therefore bad.
         */
        public string GenerateID(Url url)
        {
            // you don't need this check according to your Create POST method
            // when you are making a method, or add conditionals to a method, always
            //   check the logical flow of your program so you do not have redundancy
            if (String.IsNullOrEmpty(url.ShortUrl))
            {
                return "000000";
            }
            else
            {
                char[] idChar = url.ShortUrl.ToCharArray();
                int idInt = 0;
                for (int i = 0; i < 6; i++)
                {
                    // try to avoid direct "char" comparison when you retrieve from the database
                    if (idChar[i] == '0')
                    {
                        idInt += (0 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '1')
                    {
                        idInt += (1 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '2')
                    {
                        idInt += (2 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '3')
                    {
                        idInt += (3 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '4')
                    {
                        idInt += (4 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '5')
                    {
                        idInt += (5 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '6')
                    {
                        idInt += (6 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '7')
                    {
                        idInt += (7 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '8')
                    {
                        idInt += (8 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == '9')
                    {
                        idInt += (9 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'a')
                    {
                        idInt += (10 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'b')
                    {
                        idInt += (11 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'c')
                    {
                        idInt += (12 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'd')
                    {
                        idInt += (13 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'e')
                    {
                        idInt += (14 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'f')
                    {
                        idInt += (15 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'g')
                    {
                        idInt += (16 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'h')
                    {
                        idInt += (17 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'i')
                    {
                        idInt += (18 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'j')
                    {
                        idInt += (19 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'k')
                    {
                        idInt += (20 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'l')
                    {
                        idInt += (21 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'm')
                    {
                        idInt += (22 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'n')
                    {
                        idInt += (23 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'o')
                    {
                        idInt += (24 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'p')
                    {
                        idInt += (25 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'q')
                    {
                        idInt += (26 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'r')
                    {
                        idInt += (27 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 's')
                    {
                        idInt += (28 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 't')
                    {
                        idInt += (29 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'u')
                    {
                        idInt += (30 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'v')
                    {
                        idInt += (31 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'w')
                    {
                        idInt += (32 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'x')
                    {
                        idInt += (33 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'y')
                    {
                        idInt += (34 * (int)Math.Pow(35, 5 - i));
                    }
                    else if (idChar[i] == 'z')
                    {
                        idInt += (35 * (int)Math.Pow(35, 5 - i));
                    }
                }
                string idString = "";
                idInt = idInt + 1;
                int remainder;
                for (int j = 0; j < 6; j++)
                {
                    remainder = idInt % 35;
                    // never have one line expression an if statement
                    // this is considered a bad practice
                    if (remainder == 0)
                        idString = "0" + idString;
                    else if (remainder == 1)
                        idString = "1" + idString;
                    else if (remainder == 2)
                        idString = "2" + idString;
                    else if (remainder == 3)
                        idString = "3" + idString;
                    else if (remainder == 4)
                        idString = "4" + idString;
                    else if (remainder == 5)
                        idString = "5" + idString;
                    else if (remainder == 6)
                        idString = "6" + idString;
                    else if (remainder == 7)
                        idString = "7" + idString;
                    else if (remainder == 8)
                        idString = "8" + idString;
                    else if (remainder == 9)
                        idString = "9" + idString;
                    else if (remainder == 10)
                        idString = "a" + idString;
                    else if (remainder == 11)
                        idString = "b" + idString;
                    else if (remainder == 12)
                        idString = "c" + idString;
                    else if (remainder == 13)
                        idString = "d" + idString;
                    else if (remainder == 14)
                        idString = "e" + idString;
                    else if (remainder == 15)
                        idString = "f" + idString;
                    else if (remainder == 16)
                        idString = "g" + idString;
                    else if (remainder == 17)
                        idString = "h" + idString;
                    else if (remainder == 18)
                        idString = "i" + idString;
                    else if (remainder == 19)
                        idString = "j" + idString;
                    else if (remainder == 20)
                        idString = "k" + idString;
                    else if (remainder == 21)
                        idString = "l" + idString;
                    else if (remainder == 22)
                        idString = "m" + idString;
                    else if (remainder == 23)
                        idString = "n" + idString;
                    else if (remainder == 24)
                        idString = "o" + idString;
                    else if (remainder == 25)
                        idString = "p" + idString;
                    else if (remainder == 26)
                        idString = "r" + idString;
                    else if (remainder == 27)
                        idString = "s" + idString;
                    else if (remainder == 28)
                        idString = "t" + idString;
                    else if (remainder == 29)
                        idString = "u" + idString;
                    else if (remainder == 30)
                        idString = "v" + idString;
                    else if (remainder == 31)
                        idString = "w" + idString;
                    else if (remainder == 32)
                        idString = "x" + idString;
                    else if (remainder == 33)
                        idString = "y" + idString;
                    else if (remainder == 34)
                        idString = "z" + idString;
                    idInt = idInt / 35;
                }

                return idString;
            }
        }
        // GET: Urls/Details/5
        public ActionResult Details(string id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Url url = db.Urls.Find(id);
            if (url == null)
            {
                return HttpNotFound();
            }
            return View(url);
        }

        // GET: Urls/Create
        public ActionResult Create()
        {
            return View();
        }
        
        
        // POST: Urls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LongUrl,ShortUrl,Date")] Url url)
        {
            url.ShortUrl = UniqueKey.GenerateId(url.LongUrl);
            var temp = url.LongUrl;
            while (!CodeValid(url))
            {
                temp += "a";
                url.ShortUrl = UniqueKey.GenerateId(temp);
            }
            if (ModelState.IsValid)
            {
                Console.WriteLine("here");
                db.Urls.Add(url);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            Console.WriteLine("there");
            return View(url);
        }

        /* CodeValid checks against database and returns true if no row id equals the url id else false*/
        public Boolean CodeValid(Url url)
        {
            var urls = from u in db.Urls
                       select u;

            if (!String.IsNullOrEmpty(url.ShortUrl))
            {
                urls = urls.Where(u => u.ShortUrl.Equals(url.ShortUrl));
            }

            List<Url> urlList = urls.ToList();

            if (urlList.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // GET: Urls/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Url url = db.Urls.Find(id);
            if (url == null)
            {
                return HttpNotFound();
            }
            return View(url);
        }

        // POST: Urls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LongUrl,ShortUrl,Date")] Url url)
        {
            if (ModelState.IsValid)
            {
                db.Entry(url).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(url);
        }

        // GET: Urls/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Url url = db.Urls.Find(id);
            if (url == null)
            {
                return HttpNotFound();
            }
            return View(url);
        }

        // POST: Urls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Url url = db.Urls.Find(id);
            db.Urls.Remove(url);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToLong(string shortURL)
        {
            Url url = db.Urls.Where(u => u.ShortUrl.Equals(shortURL)).FirstOrDefault();
            return RedirectPermanent(url.LongUrl);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}