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

        public Group Create()
        {
            throw new NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
