namespace InteractiveLearningSystem.Web.Helpers
{
    using System.Linq;
    using System.Web.Mvc;

    public class RoleAuthorizeAttribute: AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
            else if (!this.Roles.Split(',').Any(filterContext.HttpContext.User.IsInRole))
            {

                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/_Unauthorized.cshtml"
                };
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}