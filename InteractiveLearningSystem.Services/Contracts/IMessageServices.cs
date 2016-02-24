namespace InteractiveLearningSystem.Services.Contracts
{
    using System.Linq;
    using Models;
    using System.Threading.Tasks;
    public interface IMessageServices
    {
        IQueryable<Message> GetAll();

        Message GetById(int? id);

        Task<Message> Create(string sender, string receiver, string title, string content, string flag, string notes);

        void Update(int id);

        void UpdateViewedState(int? id, bool state);

        void DeleteId(int id);
    }
}
