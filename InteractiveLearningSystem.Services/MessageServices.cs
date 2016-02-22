namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Data.Repositories;
    using InteractiveLearningSystem.Services.Contracts;
    using Models;

    public class MessageServices : IMessageServices
    {
        private IRepository<Message> messages;

        public MessageServices(IRepository<Message> messages)
        {
            this.messages = messages;
        }

        public Message GetById(int id)
        {
            return messages.GetById(id);
        }

        public Message Create(string sender, string receiver, string title, string content, string flag, string notes)
        {
            var message = new Message()
            {
                SenderId = sender,
                ReceiverId = receiver,
                Title = title,
                Content = content,
                Flag = flag,
                Notes = notes,
                isDeleted = false,
                isViewed = false,
                DateCreated = DateTime.UtcNow
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
            var message = messages.GetById(id);
            messages.SaveChanges();
        }

        public void UpdateViewedState(int id, bool state)
        {
            messages.GetById(id).isViewed = state;
            messages.SaveChanges();
        }
    }
}
