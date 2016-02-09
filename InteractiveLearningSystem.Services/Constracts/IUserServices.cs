namespace InteractiveLearningSystem.Services.Constracts
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserServices
    {
        IQueryable<User> GetAll();

        User Create(string name);

        void Update();

        void DeleteId(int id);
    }
}
