namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Ninject;
    using Services;
    using Services.Contracts;

    public class IndexController : BaseController
    {
        [Inject]
        IMessageServices messageServices;
        [Inject]
        IRoleServices roleServices;
        [Inject]
        IUserServices userServices;

        public IndexController(MessageServices messageServices, RoleServices roleServices, 
            UserServices userServices)
        {
            this.userServices = userServices;
            this.roleServices = roleServices;
            this.messageServices = messageServices;
        }

        //private InteractiveLearningSystemDbContext context = InteractiveLearningSystemDbContext.Create();
        // GET: Admin/Index
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult InboxPartial()
        //{
        //    var id = User.Identity.GetUserId();
        //    var messageCount = (from n in messageServices.GetAll()
        //                   where n.Receiver.Id == id && n.isViewed == false
        //                   select n).Count();
        //    ViewData["NewMessages"] = messageCount;
        //    return PartialView("_InboxPartial");
        //}

        //public ActionResult UsersPartial(string currentUser)
        //{
        //    var roleId = userServices.GetById(currentUser).Roles.First().RoleId;
        //    var roleName = roleServices.GetById(roleId).Name;
        //    var roles = roleServices.GetAllRolesExcluding(roleName);
            
        //    return PartialView("_UsersPartial", roles);
        //}

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
