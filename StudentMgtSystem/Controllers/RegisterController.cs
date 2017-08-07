using System;
using System.Collections.Generic;
using System.Data.Entity;
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
       
        public ActionResult Edit(string id)
        {
            Stu s = db.Stus.Find(id);
            if(s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Stu s)
        {
            if (ModelState.IsValid)
            {
               db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("reg");
            }
            return View(s);
        }
        

        }
    }
