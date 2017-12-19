using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TvSets.Entity;

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
    }
}