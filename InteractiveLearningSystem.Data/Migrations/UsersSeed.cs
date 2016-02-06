namespace InteractiveLearningSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Microsoft.AspNet.Identity;

    public class UsersSeed
    {
        public static void SeedDbUsers(InteractiveLearningSystemDbContext context)
        {
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

            var moderator = new User()
            {
                UserName = "moderator@site.com",
                PasswordHash = new PasswordHasher().HashPassword("moderator"),
                FirstName = "Moderator",
                LastName = "Moderatorski",
                Email = "moderator@site.com",
                AvatarUrl = "http://cdn.meme.am/instances/56124731.jpg"
            };

            if (userManager.FindByName("moderator@site.com") == null)
            {
                context.Users.Add(moderator);
                userManager.Create(moderator);
                context.SaveChanges();

                userManager.AddToRole(moderator.Id, "Moderator");
            }
        }
    }
}
