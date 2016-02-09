namespace InteractiveLearningSystem.Services.Constracts
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMessageServices
    {
        IQueryable<Message> GetAll();

        Message Create();

        void Update();

        void DeleteId(int id);
    }
}
