namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Web.Mvc;

    public class SearchPartialController : Controller
    {
        public ActionResult SearchPartial()
        {

            return PartialView("_SearchPartial");
        }
    }
}