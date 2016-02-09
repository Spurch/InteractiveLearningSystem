namespace InteractiveLearningSystem.Services.Constracts
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGroupServices
    {
        IQueryable<Group> GetAll();

        Group Create(string name, string affinity, string notes, string avatarUrl);

        void Update(int id, Group entry);

        void AddStudent(int id, User student);

        void RemoveStudent(int id, User student);

        void UpdateTeacher(int id, User teacher);

        void DeleteId(int id);
    }
}
