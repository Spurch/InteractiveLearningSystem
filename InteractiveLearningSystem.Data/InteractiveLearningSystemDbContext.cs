namespace InteractiveLearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using InteractiveLearningSystem.Models;

    public class InteractiveLearningSystemDbContext : IdentityDbContext<User>, IInteractiveLearningSystemDbContext
    {

        public InteractiveLearningSystemDbContext()
            :base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static InteractiveLearningSystemDbContext Create()
        {
            return new InteractiveLearningSystemDbContext();
        }
    }
}
