namespace InteractiveLearningSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InteractiveLearningSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(InteractiveLearningSystemDbContext context)
        {
            //We'll consider a scenario where having users means that we have the whole DB seeded.
            if (context.Users.Any())
            {
                return;
            }

            context.Configuration.LazyLoadingEnabled = true;

            RolesSeed.SeedDbRoles(context);

            UsersSeed.SeedDbUsers(context);

            DbInitialDataSeed.SeedDbSchools(context);

            DbInitialDataSeed.SeedDbGroups(context, UsersSeed.Teachers, DbInitialDataSeed.Schools, UsersSeed.Students);

            for (int i = 0; i < UsersSeed.Moderators.Count; i++)
            {
                UsersSeed.Moderators[i].Moderator.Add(DbInitialDataSeed.Schools[i]);
            }
            context.SaveChanges();

            for (int i = 0; i < UsersSeed.Advisers.Count; i++)
            {
                UsersSeed.Advisers[i].Consultant.Add(DbInitialDataSeed.Schools[i]);
            }
            context.SaveChanges();

            var msg = new Message()
            {
                Sender = UsersSeed.Teachers[1],
                Receiver = UsersSeed.Admin,
                DateCreated = DateTime.Now,
                Content = "Test message content",
                Flag = "test flag",
                Title = "test title",
                isViewed = false
            };
            context.Messages.Add(msg);
            context.SaveChanges();

            msg = new Message()
            {
                Sender = UsersSeed.Teachers[1],
                Receiver = UsersSeed.Admin,
                DateCreated = DateTime.Now,
                Content = "Test message content is viewed",
                Flag = "test flag",
                Title = "viewed test title",
                isViewed = true
            };
            context.Messages.Add(msg);
            context.SaveChanges();
        }
    }
}
