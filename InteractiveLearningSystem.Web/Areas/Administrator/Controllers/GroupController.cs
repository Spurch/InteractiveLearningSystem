﻿namespace InteractiveLearningSystem.Web.Areas.Administrator.Controllers
{
    using System.Web.Mvc;
    using Services;
    using Infrastructure.Helpers;
    public class GroupController : BaseController
    {
        public GroupController(GroupServices groupServices)
        {
            this.groupServices = groupServices;
        }

        // GET: Admin/Group
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Group/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new ResourceNotFoundException();
            }
            var group = groupServices.GetById(id);
            return View(group);
        }

        // GET: Admin/Group/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Group/Create
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

        // GET: Admin/Group/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Group/Edit/5
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

        // GET: Admin/Group/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Group/Delete/5
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
