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
            url.Date = DateTime.Now;
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
            Console.WriteLine(url.Date);
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
            int urlId;
            try
            {
                urlId = Convert.ToInt32(id);
            } catch (Exception ex)
            {
                if (ex is OverflowException || ex is FormatException)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                throw;
            }
            Url url = db.Urls.Find(urlId);
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
            int urlId;
            try
            {
                urlId = Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                if (ex is OverflowException || ex is FormatException)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                throw;
            }
            Url url = db.Urls.Find(urlId);
            db.Urls.Remove(url);
            db.SaveChanges();
            return RedirectToAction("Index");
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