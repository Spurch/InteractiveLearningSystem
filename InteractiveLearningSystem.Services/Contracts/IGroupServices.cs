namespace InteractiveLearningSystem.Services.Contracts
{
    using System.Linq;
    using Models;

    public interface IGroupServices
    {
        IQueryable<Group> GetAll();

        Group GetById(int id);

        Group Create(string name, string affinity, string notes, string avatarUrl);

        void Update(int id, Group entry);

        void AddStudent(int id, User student);

        void RemoveStudent(int id, User student);

        void UpdateTeacher(int id, User teacher);

        void DeleteId(int id);
    }
}
