namespace InteractiveLearningSystem.Services
{
    using Constracts;
    using Data.Repositories;
    using Models;

    public class UserServices : IUserServices
    {
        private IRepository<User> users;

        public UserServices(IRepository<User> users)
        {
            this.users = users;
        }
    }
}
