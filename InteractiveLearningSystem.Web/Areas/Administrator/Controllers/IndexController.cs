﻿namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    public class IndexController : BaseController
    {
        //private InteractiveLearningSystemDbContext context = InteractiveLearningSystemDbContext.Create();
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Index/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Index/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Index/Create
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

        // GET: Admin/Index/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Index/Edit/5
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

        // GET: Admin/Index/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Index/Delete/5
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
