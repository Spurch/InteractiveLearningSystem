﻿namespace InteractiveLearningSystem.Web.Areas.Administrator.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Services;

    public class MessageController : BaseController
    {
        private static bool lastStatus;

        public MessageController(MessageServices messageServices)
        {
            this.messageServices = messageServices;
        }

        // GET: Admin/Message
        public ActionResult Index(bool status)
        {
            lastStatus = status;
            var id = User.Identity.GetUserId();
            var messages = from n in messageServices.GetAll()
                           where n.Receiver.Id == id && n.isViewed == status
                           select n;
            return View(messages);
        }

        // GET: Admin/Message/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Status"] = lastStatus;
            messageServices.UpdateViewedState(id, true);
            
            return View(messageServices.GetById(id));
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
