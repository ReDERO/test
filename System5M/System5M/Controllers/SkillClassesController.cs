using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core;
using Core.Models;
using Microsoft.AspNet.Identity;

namespace System5M.Controllers
{
    [Authorize]
    public class SkillClassesController : Controller
    {
        private System5MContext db = new System5MContext();

        // GET: SkillClasses
        public ActionResult Index()
        {
            var classesOfSkills = db.ClassesOfSkills.Include(s => s.User);
            return View(classesOfSkills.ToList());
        }

        // GET: SkillClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillClass skillClass = db.ClassesOfSkills.Find(id);
            if (skillClass == null)
            {
                return HttpNotFound();
            }
            return View(skillClass);
        }

        // GET: SkillClasses/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: SkillClasses/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,UserId")] SkillClass skillClass)
        {
            skillClass.UserId = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                db.ClassesOfSkills.Add(skillClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", skillClass.UserId);
            return View(skillClass);
        }

        // GET: SkillClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillClass skillClass = db.ClassesOfSkills.Find(id);
            if (skillClass == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", skillClass.UserId);
            return View(skillClass);
        }

        // POST: SkillClasses/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,UserId")] SkillClass skillClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skillClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", skillClass.UserId);
            return View(skillClass);
        }

        // GET: SkillClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillClass skillClass = db.ClassesOfSkills.Find(id);
            if (skillClass == null)
            {
                return HttpNotFound();
            }
            return View(skillClass);
        }

        // POST: SkillClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SkillClass skillClass = db.ClassesOfSkills.Find(id);
            db.ClassesOfSkills.Remove(skillClass);
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
