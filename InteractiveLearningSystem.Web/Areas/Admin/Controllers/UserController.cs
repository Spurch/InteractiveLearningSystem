namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using InteractiveLearningSystem.Data;
    using Ninject;
    using Services;
    using Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class UserController : Controller
    {

        [Inject]
        IUserServices userServices;

        [Inject]
        IRoleServices roleServices;
        //private InteractiveLearningSystemDbContext context = InteractiveLearningSystemDbContext.Create();

        public UserController(UserServices userServices, RoleServices roleServices)
        {
            this.roleServices = roleServices;
            this.userServices = userServices;
        }

        // GET: Admin/User
        public ActionResult Index(string role)
        {

            var RoleId = roleServices.GetByName(role);
            var users = from u in userServices.GetAll()
                        where u.Roles.Any(r => r.RoleId == RoleId.Id)
                        select u;
            ViewBag.RoleName = RoleId.Name;
            return View(users);
        }

        // GET: Admin/User/Details/5
        public ActionResult Details(string id)
        {
            var user = userServices.GetById(id);
            return View(user);
        }

        // GET: Admin/User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/User/Create
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

        // GET: Admin/User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/User/Edit/5
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

        // GET: Admin/User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/User/Delete/5
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
