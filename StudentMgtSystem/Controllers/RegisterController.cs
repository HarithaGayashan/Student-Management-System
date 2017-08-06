using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMgtSystem.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        StudentContext db = new StudentContext();
        public ActionResult reg()
        {
            return View(db.Stus.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
      [HttpPost]
      public ActionResult Create(Stu stu)
        {
            if (ModelState.IsValid)
            {
                db.Stus.Add(stu);
                db.SaveChanges();
                return RedirectToAction("reg");
            }
            return View(stu);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Stu s)
        {
            if (ModelState.IsValid)
            {
                db.Stus.Add(s);
                db.SaveChanges();
                return RedirectToAction("reg");
            }
            return View(s);
        }
        

        }
    }
