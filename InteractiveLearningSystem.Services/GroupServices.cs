namespace InteractiveLearningSystem.Services
{
    using Constracts;
    using Data.Repositories;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupServices : IGroupServices
    {
        private IRepository<Group> groups;

        public GroupServices(IRepository<Group> groups)
        {
            this.groups = groups;
        }
    }
}
