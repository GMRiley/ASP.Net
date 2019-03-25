using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MenuApp.Models;
using System.Web.Mvc;

namespace MenuApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        private MenuEntities _db = new MenuEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Menus.ToList());
        }
        
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var menuDetails = (from m in _db.Menus
                               where m.Id == id
                               select m).First();
            return View(menuDetails);

        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Menu newMenuItem )
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Menus.Add(newMenuItem);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var editMenuItem = (from m in _db.Menus
                                where m.Id == id
                                select m).First();
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Menu menuToEdit)
        {
            var originalItem = (from m in _db.Menus
                                where m.Id == menuToEdit.Id
                                select m).First();
            if(!ModelState.IsValid)
            {
                return View(originalItem);
            }
            _db.Entry(originalItem).CurrentValues.SetValues(menuToEdit);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var itemToDelete = (from m in _db.Menus
                                where m.Id == id
                                select m).First();
            return View(itemToDelete);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(Menu itemToDelete)
        {
            var deletedItem = _db.Menus.Find(itemToDelete.Id);
            _db.Menus.Remove(deletedItem);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
