﻿namespace InteractiveLearningSystem.Web.Areas.Adviser.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Ninject;
    using Services;
    using Services.Contracts;

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

        public ActionResult Details(int id)
        {
            ViewData["Status"] = lastStatus;
            messageServices.UpdateViewedState(id, true);

            return View(messageServices.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

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

        public ActionResult Edit(int id)
        {
            return View();
        }

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

        public ActionResult Delete(int id)
        {
            return View();
        }

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
