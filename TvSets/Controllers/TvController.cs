using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TvSets.Entity;
using TvSets.Models;

namespace TvSets.Controllers
{
    public class TvController : Controller
    {
        // GET: Tv
        public ActionResult Index()
        {
            using (var db = new TvContext())
            {
                var items = db.Tvsets.Select(x => x).Include(c => c.Company).Include(t => t.Technology).ToList();
                return View(items);
            }
        }

        public ActionResult Delete(int id)
        {
            using(var db = new TvContext())
            {
                var item = db.Tvsets.Find(id);
                if(item != null)
                {
                    db.Tvsets.Remove(item);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tvset item)
        {
            using (var db = new TvContext())
            {
                var comp = db.Companies.FirstOrDefault(x => x.Name == item.Company.Name);
                var tech = db.Technologies.FirstOrDefault(x => x.Name == item.Technology.Name);

                if (comp == null)
                {
                    comp = new Company { Name = item.Company.Name };
                    db.Companies.Add(comp);
                    db.SaveChanges();
                }

                if (tech == null)
                {
                    tech = new Technology { Name = item.Technology.Name };
                    db.Technologies.Add(tech);
                    db.SaveChanges();
                }

                item.Company = comp;
                item.Technology = tech;
                if (ModelState.IsValid)
                {
                    db.Tvsets.Add(item);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }             
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using(var db = new TvContext())
            {
                var item = db.Tvsets.Include(c => c.Company).Include(t => t.Technology).FirstOrDefault(x => x.Id == id);
                if(item != null)
                {
                    return View(item);
                }
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(Tvset item)
        {
            using (var db = new TvContext())
            {
                var comp = db.Companies.FirstOrDefault(x => x.Name == item.Company.Name);
                var tech = db.Technologies.FirstOrDefault(x => x.Name == item.Technology.Name);

                if (comp == null)
                {
                    comp = new Company { Name = item.Company.Name };
                    db.Companies.Add(comp);
                    db.SaveChanges();
                }

                if (tech == null)
                {
                    tech = new Technology { Name = item.Technology.Name };
                    db.Technologies.Add(tech);
                    db.SaveChanges();
                }

                item.Company = comp;
                item.Technology = tech;
                if (ModelState.IsValid)
                {
                    var old = db.Tvsets.FirstOrDefault(x => x.Id == item.Id);
                    old.Name = item.Name;
                    old.Resolution = item.Resolution;
                    old.Size = item.Size;
                    old.Technology = item.Technology;
                    old.Year = item.Year;
                    old.Company = item.Company;
                    old.Details = item.Details;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
        }

        public ActionResult View(int id)
        {
            using(var db = new TvContext())
            {
                var item = db.Tvsets.Include(c => c.Company).Include(t => t.Technology).FirstOrDefault(x => x.Id == id);
                if(item != null)
                {
                    return View(item);
                }
                return RedirectToAction("Index");
            }
        }


    }
}