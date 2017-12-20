using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using TvSets.Entity;
using TvSets.Models;

namespace TvSets.Controllers
{
    public class TvController : Controller
    {
        Random rnd = new Random();


        public ActionResult Index(string search, string sort)
        {
            using (var db = new TvContext())
            {
                List<Tvset> items = new List<Tvset>();

                if (string.IsNullOrEmpty(search))
                {
                    items = db.Tvsets.Include(c => c.Company).Include(t => t.Technology).ToList();
                    ViewBag.Search = "";
                }
                else
                {
                    items = db.Tvsets.Where(x =>
                        x.Name.Contains(search) ||
                        x.Company.Name.Contains(search) ||
                        x.Technology.Name.Contains(search)).Include(c => c.Company).Include(t => t.Technology).ToList();
                    ViewBag.Search = search;
                }


                if (!string.IsNullOrEmpty(sort))
                {
                    switch (sort)
                    {
                        case "low":
                            ViewBag.Sort = "high";
                            return View(items.OrderBy(x => x.Price).ToList());

                        case "high":
                            ViewBag.Sort = "low";
                            return View(items.OrderByDescending(x => x.Price).ToList());
                    }
                }


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
                    //удаление картинки
                    if (!string.IsNullOrWhiteSpace(item.ImageLink))
                    {
                        var path = "~/img/" + Path.GetFileName(item.ImageLink);
                        System.IO.File.Delete(HostingEnvironment.MapPath(path));
                    }

                    db.Tvsets.Remove(item);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            using (var db = new TvContext())
            {
                SelectList technologies = new SelectList(db.Technologies.ToList(), "Id", "Name");
                ViewBag.Technologies = technologies;
                return View();
            }           
        }

        [HttpPost]
        public ActionResult Create(Tvset item)
        {
            using (var db = new TvContext())
            {
                var comp = db.Companies.FirstOrDefault(x => x.Name == item.Company.Name);
                var tech = db.Technologies.FirstOrDefault(x => x.Id == item.TechnologyId);

                if (Request.Files.Count != 0)
                {
                    item.ImageLink = GenerateImageLink(Request.Files[0]);
                }

                if (comp == null && !string.IsNullOrWhiteSpace(item.Company.Name))
                {
                    comp = new Company { Name = item.Company.Name };
                    db.Companies.Add(comp);
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

                SelectList technologies = new SelectList(db.Technologies.ToList(), "Id", "Name");
                ViewBag.Technologies = technologies;
                return View();
            }             
        }

        private string GenerateImageLink(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileNameHash = Math.Abs(file.FileName.GetHashCode() * rnd.Next(0, 100)) + Path.GetExtension(file.FileName);
                var serverUrl = "~/img/" + fileNameHash;
                Regex regex = new Regex(@"^.*\.(jpg|gif|png|bmp|jpeg)$", RegexOptions.IgnoreCase);
                if (!regex.IsMatch(Path.GetExtension(serverUrl)))
                {
                    return null;
                }
                file.SaveAs(HostingEnvironment.MapPath(serverUrl));

                //создает ссылку из конфига
                return ConfigurationManager.AppSettings["siteUrl"] +
                    VirtualPathUtility.ToAbsolute(serverUrl);
            }
            return null;
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            using(var db = new TvContext())
            {
                var item = db.Tvsets.Include(c => c.Company).Include(t => t.Technology).FirstOrDefault(x => x.Id == id);
                if(item != null)
                {
                    SelectList technologies = new SelectList(db.Technologies.ToList(), "Id", "Name");
                    ViewBag.Technologies = technologies;
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
                var tech = db.Technologies.FirstOrDefault(x => x.Id == item.TechnologyId);

                if (Request.Files.Count != 0)
                {
                    item.ImageLink = GenerateImageLink(Request.Files[0]);
                }

                if (comp == null && !string.IsNullOrWhiteSpace(item.Company.Name))
                {
                    comp = new Company { Name = item.Company.Name };
                    db.Companies.Add(comp);
                    db.SaveChanges();
                }


                item.Company = comp;
                item.Technology = tech;
                var old = db.Tvsets.FirstOrDefault(x => x.Id == item.Id);
                if (ModelState.IsValid && old != null)
                {
                    old.Name = item.Name;
                    old.Resolution = item.Resolution;
                    old.Size = item.Size;
                    old.Technology = item.Technology;
                    old.Year = item.Year;
                    old.Company = item.Company;
                    old.Details = item.Details;

                    //удаление старой картинки
                    if (!string.Equals(old.ImageLink, item.ImageLink))
                    {
                        var path = "~/img/" + old.ImageLink;
                        System.IO.File.Delete(HostingEnvironment.MapPath(path));
                    }

                    old.ImageLink = item.ImageLink;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                SelectList technologies = new SelectList(db.Technologies.ToList(), "Id", "Name");
                ViewBag.Technologies = technologies;
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