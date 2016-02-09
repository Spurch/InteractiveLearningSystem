namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Data.Repositories;
    using InteractiveLearningSystem.Services.Constracts;
    using Models;

    public class SchoolServices : ISchoolServices
    {
        private IRepository<School> schools;

        public SchoolServices(IRepository<School> schools)
        {
            this.schools = schools;
        }

        public School Create()
        {
            
            throw new NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<School> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
