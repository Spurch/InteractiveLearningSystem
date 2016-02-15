namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Constants
    {
        public static string UNAUTHORIZED = "~/Assets/DefaultUserImages/403.png";
        public static string UNAUTHORIZED_TITLE = "Unauthorized!";
        public static string UNAUTHORIZED_CONTENT = "Ooops! Seems like you don't have permission to be here!";

        public static string PAGENOTFOUND = "~/Assets/DefaultUserImages/404.png";
        public static string PAGENOTFOUND_TITLE = "Page Not Found!";
        public static string PAGENOTFOUND_CONTENT = "This is not the page you are looking for...";
    }
}