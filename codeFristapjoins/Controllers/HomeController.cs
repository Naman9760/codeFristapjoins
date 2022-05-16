using codeFristapjoins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codeFristapjoins.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbcontext Db = new ApplicationDbcontext();
        // GET: Home
        public ActionResult Index()
        {
            var data = Db.empoyes.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            var cats = Db.departments.ToList();
            ViewBag.cats = cats;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Empoyes emp)
        {
            Db.empoyes.Add(emp);
            Db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            var emp = Db.empoyes.SingleOrDefault(e => e.Eid == id);
            Db.empoyes.Remove(emp);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var emp = Db.empoyes.SingleOrDefault(e => e.Eid == id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Empoyes emp)
        {
            Db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
            return View();
        }
        public ActionResult Details(int id)
        {

            var emp = Db.empoyes.SingleOrDefault(e => e.Eid == id);
            return View(emp);
        }
    }
}