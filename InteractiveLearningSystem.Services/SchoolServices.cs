namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Data.Repositories;
    using InteractiveLearningSystem.Services.Contracts;
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
            return schools.All();
        }

        public IQueryable<School> GetByAffinity(string affinity)
        {
            return schools.All().Where(x => x.Affinity == affinity);
        }

        public School GetById(int id)
        {
            return schools.GetById(id);
        }

        public School GetByName(string name)
        {
            return schools.All().Where(x => x.Name == name).First();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
