namespace InteractiveLearningSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Microsoft.AspNet.Identity;
    using Common;

    public class UsersSeed
    {
        public static List<User> Moderators;
        public static List<User> Advisers;
        public static List<User> Teachers;
        public static List<User> Students;
        public static User Admin;

        public static void SeedDbUsers(InteractiveLearningSystemDbContext context)
        {
            var userManager = new UserManager<User>(new UserStore<User>(context));

            Moderators = new List<User>();
            Advisers = new List<User>();
            Teachers = new List<User>();
            Students = new List<User>();

            List<User> currentGroup = new List<User>();
            /*
            Creating the Interactive Learning System one and only Admin!
            */
            var admin = new User()
            {
                UserName = "admin@ils.edu",
                PasswordHash = new PasswordHasher().HashPassword("admin"),
                FirstName = "Admin",
                LastName = "Adminski",
                Email = "admin@ils.edu",
                AvatarUrl = DataSeedConstants.DEFAULT_ADMIN_AVATAR,
                Level = 0,
                Experience = 0,
                Points = 0,
                Notes = "He is the one and only!!!"
            };
            context.Users.Add(admin);
            userManager.Create(admin);
            context.SaveChanges();

            userManager.AddToRole(admin.Id, "Administrator");
            Admin = admin;
            /*
            Creating 10 moderators for the Interactive Learning System.
            */
            for (int i = 0; i < DataSeedConstants.MODERATOR_COUNT; i++)
            {
                var moderator = new User()
                {
                    UserName = "moderator" + i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword("moderator" + i),
                    FirstName = "Moderator" + i,
                    LastName = "Moderatorski" + i,
                    Email = "moderator" + i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_MODERATOR_AVATAR,
                    Level = 0,
                    Experience = 0,
                    Points = 0
                };
                context.Users.Add(moderator);
                userManager.Create(moderator);
                context.SaveChanges();
                userManager.AddToRole(moderator.Id, "Moderator");
                Moderators.Add(moderator);
            }

            /*
            Creating 40 teachers for the Interactive Learning System.
            */
            for (int i = 0; i < DataSeedConstants.TEACHER_COUNT; i++)
            {
                var teacher = new User()
                {
                    UserName = "teacher" + i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword("teacher" + i),
                    FirstName = "Daskal" + i,
                    LastName = "Shkolski" + i,
                    Email = "teacher" + i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_TEACHER_AVATAR,
                    Level = 0,
                    Experience = 0,
                    Points = 0
                };
                context.Users.Add(teacher);
                userManager.Create(teacher);
                context.SaveChanges();
                userManager.AddToRole(teacher.Id, "Teacher");
                Teachers.Add(teacher);
            }

            /*
           Creating 10 advisers for the Interactive Learning System.
           */
            for (int i = 0; i < DataSeedConstants.ADVISER_COUNT; i++)
            {
                var adviser = new User()
                {
                    UserName = "adviser" + i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword("adviser" + i),
                    FirstName = "Rezil" + i,
                    LastName = "Psiharski" + i,
                    Email = "adviser" + i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_ADVISER_AVATAR,
                    Level = 0,
                    Experience = 0,
                    Points = 0
                };
                context.Users.Add(adviser);
                userManager.Create(adviser);
                context.SaveChanges();
                userManager.AddToRole(adviser.Id, "Adviser");
                Advisers.Add(adviser);
            }

            /*
          Creating 200 students for the Interactive Learning System.
          */
            var rand = new Random();
            for (int i = 0; i < DataSeedConstants.STUDENT_COUNT; i++)
            {
                var student = new User()
                {
                    UserName = "student" + i,
                    PasswordHash = new PasswordHasher().HashPassword("student" + i),
                    FirstName = "Murzel" + i,
                    LastName = "Obitashki" + i,
                    Email = "student" + i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_STUDENT_AVATAR +"0"+rand.Next(0,3)+".png",
                    Level = 0,
                    Experience = 0,
                    Points = 0
                };
                context.Users.Add(student);
                userManager.Create(student);
                context.SaveChanges();
                userManager.AddToRole(student.Id, "Student");
                Students.Add(student);
            }
        }
    }
}
