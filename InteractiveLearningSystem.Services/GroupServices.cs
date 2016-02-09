namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Constracts;
    using Data.Repositories;
    using Data.Common;
    using Models;

    public class GroupServices : IGroupServices
    {
        private IRepository<Group> groups;

        public GroupServices(IRepository<Group> groups)
        {
            this.groups = groups;
        }

        public void AddStudent(int id, User student)
        {
            groups.GetById(id).Students.Add(student);
            groups.SaveChanges();
        }

        public Group Create(string name, string affinity, string notes, string avatarUrl)
        {
            var group = new Group()
            {
                Name = name,
                Affinity = affinity,
                Notes = notes,
                AvatarUrl = avatarUrl,
                Points = 0,
                Level = 0,
                Experience = 0,
                isDeleted = false
            };

            this.groups.Add(group);

            this.groups.SaveChanges();

            return group;
        }

        public void DeleteId(int id)
        {
            groups.GetById(id).isDeleted = true;
            groups.SaveChanges();
        }

        public IQueryable<Group> GetAll()
        {
            return this.groups.All();
        }

        public void RemoveStudent(int id, User student)
        {
            groups.GetById(id).Students.Remove(student);
            groups.SaveChanges();
        }

        public void Update(int id, Group entry)
        {
            var group = groups.GetById(id);
            group.Level = entry.Level;
            group.Name = entry.Name;
            group.Notes = entry.Notes;
            group.Points = entry.Points;
            group.Experience = entry.Experience;
            group.AvatarUrl = entry.AvatarUrl;
            group.Affinity = entry.Affinity;

            groups.SaveChanges();
        }

        public void UpdateTeacher(int id, User teacher)
        {
            groups.GetById(id).Teacher = teacher;
            groups.SaveChanges();
        }
    }
}
