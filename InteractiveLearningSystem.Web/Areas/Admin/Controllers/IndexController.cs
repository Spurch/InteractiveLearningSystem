namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using Data;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class IndexController : Controller
    {
        private InteractiveLearningSystemDbContext context = InteractiveLearningSystemDbContext.Create();
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Messages(bool status)
        {
            var id = User.Identity.GetUserId();
            var messages = context.Messages.Where(x => x.isViewed == status).ToList();
            return View(messages);
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
