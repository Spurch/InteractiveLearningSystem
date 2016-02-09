namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
