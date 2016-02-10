namespace InteractiveLearningSystem.Services.Contracts
{
    using System.Linq;
    using Models;

    public interface IUserServices
    {
        IQueryable<User> GetAll();

        User GetById(string id);

        User Create(string name);

        void Update(string id);

        void DeleteId(int id);
    }
}
