namespace InteractiveLearningSystem.Services.Contracts
{
    using System.Linq;
    using Models;

    public interface ISchoolServices
    {
        IQueryable<School> GetAll();

        IQueryable<School> GetByAffinity(string affinity);

        School Create();

        School GetById(int id);

        School GetByName(string name);

        void Update(int id);

        void DeleteId(int id);
    }
}
