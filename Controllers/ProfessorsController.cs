﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using wx092414_SD1.DAL;
using wx092414_SD1.Models;

namespace wx092414_SD1.Controllers
{
    public class ProfessorsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Professors
        public ActionResult Index()
        {
            return View(db.professor.ToList());
        }

        // GET: Professors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = db.professor.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // GET: Professors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "professorID,firstName,lastName,phone")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.professor.Add(professor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(professor);
        }

        // GET: Professors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = db.professor.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "professorID,firstName,lastName,phone")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        // GET: Professors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = db.professor.Find(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Professor professor = db.professor.Find(id);
            db.professor.Remove(professor);
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
