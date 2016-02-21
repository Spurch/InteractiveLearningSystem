namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    /*
    All credits goes to Richard Dingwall:
    http://rdingwall.com/2008/08/17/strategies-for-resource-based-404-errors-in-aspnet-mvc/
    */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public sealed class ResourceNotFoundException : Exception
    {
        private Type resourceType;
        private object resourceId;

        public Type ResourceType { get { return this.resourceType; } }
        public object ResourceId { get { return this.resourceId; } }
        public ResourceNotFoundException() { }

        public ResourceNotFoundException(Type resourceType, object resourceId) :
            base(string.Format("{0} {1} could not be found.",
                resourceType.Name, resourceId))
        {
            this.resourceType = resourceType;
            this.resourceId = resourceId;
        }
    }
}
