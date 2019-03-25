using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekNine.Models;

namespace WeekNine.Controllers
{
    public class AccountController : Controller
    {
        private StoreEntities _db = new StoreEntities();
        
        // Get Login

        public ActionResult Login()
        {
            return View();
        }
        // Post Login
        [HttpPost]
        public ActionResult Login(Account accountLogin)
        {
            var accountLoggedIn = (from a in _db.Accounts
                                   where a.userName == accountLogin.userName
                                   && a.password == accountLogin.password
                                   select a).First();
            if (accountLoggedIn.Id == null)
            {
                return View();
            }
            
            
            Session["LoggedIn"] = "true";
            Session["Id"] = accountLoggedIn.Id;
            return RedirectToAction("Index", "Home");
            
        }
        public ActionResult Logout()
        {
            Session["LoggedIn"] = null;
            Session["Id"] = null;
            return RedirectToAction("Index", "Home");
        }
        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude="Id")] Account accountToCreate)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Accounts.Add(accountToCreate);
            _db.SaveChanges();
            Session["LoggedIn"] = "true";
            Session["Id"] = accountToCreate.Id;
            return RedirectToAction("Index", "Home");

        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            var accountToEdit = (from a in _db.Accounts
                              where a.Id == id
                              select a).First();
            return View(accountToEdit);

        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(Account accountToEdit)
        {
            var originalAccount = (from a in _db.Accounts
                                where a.Id == accountToEdit.Id
                                select a).First();
            if (!ModelState.IsValid)
            {
                return View(originalAccount);
            }

            _db.Entry(originalAccount).CurrentValues.SetValues(accountToEdit);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
