namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Data.Repositories;
    using InteractiveLearningSystem.Services.Constracts;
    using Models;

    public class MessageServices : IMessageServices
    {
        private IRepository<Message> messages;

        public MessageServices(IRepository<Message> messages)
        {
            this.messages = messages;
        }

        public Message Create(string title, string content, string flag, string notes)
        {
            var message = new Message()
            {
                Title = title,
                Content = content,
                Flag = flag,
                Notes = notes,
                isDeleted = false,
                isViewed = false,
                DateCreated = DateTime.Now
            };

            messages.Add(message);

            messages.SaveChanges();

            return message;
        }

        public void DeleteId(int id)
        {
            messages.GetById(id).isDeleted = true;
            messages.SaveChanges();
        }

        public IQueryable<Message> GetAll()
        {
            return messages.All();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateViewedState(int id, bool state)
        {
            messages.GetById(id).isViewed = state;
            messages.SaveChanges();
        }
    }
}
