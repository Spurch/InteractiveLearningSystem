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

        public Message Create()
        {
            throw new NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Message> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
