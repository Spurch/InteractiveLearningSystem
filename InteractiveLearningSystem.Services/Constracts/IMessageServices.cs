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

        Message Create(string title, string content, string flag, string notes);

        void Update(int id);

        void UpdateViewedState(int id, bool state);

        void DeleteId(int id);
    }
}
