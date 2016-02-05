namespace InteractiveLearningSystem.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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

            string[] Roles = { "Administrator", "Moderator", "Adviser", "Teacher", "Student" };
            //context.Configuration.LazyLoadingEnabled = true;

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            foreach (var role in Roles)
            {
                if (!roleManager.RoleExists(role))
                {
                    roleManager.Create(new IdentityRole(role));
                }
            }

            var userManager = new UserManager<User>(new UserStore<User>(context));

            var admin = new User()
            {
                UserName = "admin@site.com",
                PasswordHash = new PasswordHasher().HashPassword("admin"),
                FirstName = "Admin",
                LastName = "Adminski",
                Email = "admin@site.com",
                AvatarUrl = "http://cdn.meme.am/instances/56124731.jpg"
            };

            if (userManager.FindByName("admin@site.com") == null)
            {
                context.Users.Add(admin);
                userManager.Create(admin);
                context.SaveChanges();

                userManager.AddToRole(admin.Id, "Administrator");
            }
        }
    }
}
