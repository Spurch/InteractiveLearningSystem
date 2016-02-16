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
            context.Configuration.LazyLoadingEnabled = true;

            RolesSeed.SeedDbRoles(context);

            var userSeed = new UsersSeed();
            userSeed.SeedDbUsers(context);

            DbInitialDataSeed.SeedDbSchools(context);


            DbInitialDataSeed.SeedDbGroups(context, userSeed.Teachers, DbInitialDataSeed.Schools, userSeed.Students);

            for (int i = 0; i < userSeed.Moderators.Count; i++)
            {
                userSeed.Moderators[i].Moderator.Add(DbInitialDataSeed.Schools[i]);
                DbInitialDataSeed.Schools[i].Moderator = userSeed.Moderators[i];
                context.SaveChanges();
            }


            for (int i = 0; i < userSeed.Advisers.Count; i++)
            {
                userSeed.Advisers[i].Consultant.Add(DbInitialDataSeed.Schools[i]);
                DbInitialDataSeed.Schools[i].Consultant = userSeed.Advisers[i];
                context.SaveChanges();
            }

            var temp = userSeed.Moderators;
            temp.Add(userSeed.Admin);

            DbInitialDataSeed.SeedDbMessages(context, userSeed.Advisers);
            DbInitialDataSeed.SeedDbMessages(context, temp);
            DbInitialDataSeed.SeedDbMessages(context, userSeed.Teachers);
            DbInitialDataSeed.SeedDbMessages(context, userSeed.Students);
        }
    }
}
