namespace InteractiveLearningSystem.Services
{
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
    }
}
