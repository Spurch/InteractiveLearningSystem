namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using Data;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class MessageController : Controller
    {
        private InteractiveLearningSystemDbContext context = InteractiveLearningSystemDbContext.Create();
        private bool lastStatus = true;
        // GET: Admin/Message
        public ActionResult Index(bool status)
        {
            lastStatus = status;
            var id = User.Identity.GetUserId();
            var messages = from n in context.Messages
                           where n.Receiver.Id == id && n.isViewed == status
                           select n;
            return View(messages);
        }

        // GET: Admin/Message/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Status"] = lastStatus;
            var message = context.Messages.Where(x => x.Id == id).First();
            message.isViewed = true;
            context.SaveChanges();
            return View(message);
        }

        // GET: Admin/Message/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Message/Create
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

        // GET: Admin/Message/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Message/Edit/5
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

        // GET: Admin/Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Message/Delete/5
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
