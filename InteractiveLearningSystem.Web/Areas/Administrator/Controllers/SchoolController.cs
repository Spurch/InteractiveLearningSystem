﻿namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;
    using InteractiveLearningSystem.Services;

    public class SchoolController : BaseController
    {
        public SchoolController(SchoolServices schoolServices)
        {
            this.schoolServices = schoolServices;
        }

        // GET: Admin/School
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/School/Details/5
        public ActionResult Details(int id)
        {
            var school = schoolServices.GetById(id);
            return View(school);
        }

        // GET: Admin/School/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/School/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/School/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/School/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/School/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/School/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
