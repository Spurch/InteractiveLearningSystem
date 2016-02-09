namespace InteractiveLearningSystem.Services
{
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
    }
}
