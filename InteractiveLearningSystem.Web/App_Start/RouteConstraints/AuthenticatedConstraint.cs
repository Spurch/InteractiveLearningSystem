namespace InteractiveLearningSystem.Web.App_Start.RouteConstraints
{
    using System.Web;
    using System.Web.Routing;

    /*
        As shown by Stephen Walther in his official blog.
    */
    public class AuthenticatedConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.IsAuthenticated;
        }
    }
}