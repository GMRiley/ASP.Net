using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekNine.Models;
using System.IO;

namespace WeekNine.Controllers
{
    public class HomeController : Controller
    {
        private StoreEntities _db = new StoreEntities();



        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Items.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var itemDetails = (from i in _db.Items
                               where i.Id == id
                               select i).First();

            return View(itemDetails);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude ="Id")] Item itemToCreate)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            string filename = Path.GetFileNameWithoutExtension(itemToCreate.imageFile.FileName);
            string extension = Path.GetExtension(itemToCreate.imageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            itemToCreate.imagePath = "~/Images/" + filename;
            filename = Path.Combine(Server.MapPath("~/Images/"), filename);
            itemToCreate.imageFile.SaveAs(filename);
            _db.Items.Add(itemToCreate);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var itemToEdit = (from i in _db.Items
                              where i.Id == id
                              select i).First();
            return View(itemToEdit);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Item itemToEdit)
        {
           var originalItem = (from i in _db.Items
                               where i.Id == itemToEdit.Id
                               select i).First();

            if (itemToEdit.imageFile == null)
            {
                itemToEdit.imagePath = originalItem.imagePath;
            }
            else
            {
                string filename = Path.GetFileNameWithoutExtension(itemToEdit.imageFile.FileName);
                string extension = Path.GetExtension(itemToEdit.imageFile.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                itemToEdit.imagePath = "~/Images/" + filename;
                filename = Path.Combine(Server.MapPath("~/Images/"), filename);
                itemToEdit.imageFile.SaveAs(filename);
                
            }
            if (!ModelState.IsValid)
            {
                return View(originalItem);
            }

            _db.Entry(originalItem).CurrentValues.SetValues(itemToEdit);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var itemToDelete = (from i in _db.Items
                                where i.Id == id
                                select i).First();
            return View(itemToDelete);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(Item itemToDelete)
        {
            var itemDeleted = (from i in _db.Items
                              where i.Id == itemToDelete.Id
                              select i).First();

            _db.Items.Remove(itemDeleted);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
