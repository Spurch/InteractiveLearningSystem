﻿namespace InteractiveLearningSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Microsoft.AspNet.Identity;
    using Common;

    public class UsersSeed
    {
        public List<User> Moderators;
        public List<User> Advisers;
        public List<User> Teachers;
        public List<User> Students;
        public User Admin;
        private UserGameDetailsGenerator Generator;
        private RandomGenerators RandomGenerator;
        private Random rand;
        private double experience;
        private int level;
        private string firstName;
        private string lastName;

        public UsersSeed()
        {
            Moderators = new List<User>();
            Advisers = new List<User>();
            Teachers = new List<User>();
            Students = new List<User>();
            rand = new Random();
            Generator = new UserGameDetailsGenerator();
            RandomGenerator = new RandomGenerators();
            experience = 0;
            level = 0;
            firstName = "";
            lastName = "";
        }

        public void SeedDbUsers(InteractiveLearningSystemDbContext context)
        {
            var userManager = new UserManager<User>(new UserStore<User>(context));
            List<User> currentGroup = new List<User>();
            /*
            Creating the Interactive Learning System one and only Admin!
            */
            var admin = new User()
            {
                UserName = "admin@ils.edu",
                PasswordHash = new PasswordHasher().HashPassword("admin"),
                FirstName = RandomGenerator.GenerateRandomName(),
                LastName = RandomGenerator.GenerateRandomFamily(),
                Email = "admin@ils.edu",
                AvatarUrl = DataSeedConstants.DEFAULT_ADMIN_AVATAR,
                Level = 100,
                Experience = 999999,
                Points = 999999,
                Notes = "He is the one and only!!!",
                PhoneNumber = RandomGenerator.GenerateRandomMobile()
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
                var count = rand.Next(0, 512);
                firstName = RandomGenerator.GenerateRandomName();
                lastName = RandomGenerator.GenerateRandomFamily();
                level = (int)Generator.GenerateUserLevel();
                experience = Generator.GenerateUserExperience(level);
                var moderator = new User()
                {
                    UserName = firstName + "_" + lastName + count * i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword(firstName),
                    FirstName = firstName,
                    LastName = lastName,
                    Email = firstName + "_" + lastName + count * i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_MODERATOR_AVATAR + "0" + rand.Next(0, 2) + ".png",
                    Experience = experience,
                    Level = level,
                    Points = Generator.GenerateUserPoints(experience),
                    PhoneNumber = RandomGenerator.GenerateRandomMobile(),
                    Notes = "Moderator"
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
                var count = rand.Next(0, 512);
                firstName = RandomGenerator.GenerateRandomName();
                lastName = RandomGenerator.GenerateRandomFamily();
                level = (int)Generator.GenerateUserLevel();
                experience = Generator.GenerateUserExperience(level);
                var teacher = new User()
                {
                    UserName = firstName + "_" + lastName + count * i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword(firstName),
                    FirstName = firstName,
                    LastName = lastName,
                    Email = firstName + "_" + lastName + count * i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_TEACHER_AVATAR + "0" + rand.Next(0, 2) + ".png",
                    Experience = experience,
                    Level = level,
                    Points = Generator.GenerateUserPoints(experience),
                    PhoneNumber = RandomGenerator.GenerateRandomMobile(),
                    Notes = "Teacher"
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
                var count = rand.Next(0, 512);
                firstName = RandomGenerator.GenerateRandomName();
                lastName = RandomGenerator.GenerateRandomFamily();
                level = (int)Generator.GenerateUserLevel();
                experience = Generator.GenerateUserExperience(level);
                var adviser = new User()
                {
                    UserName = firstName + "_" + lastName + count * i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword(firstName),
                    FirstName = firstName,
                    LastName = lastName,
                    Email = firstName + "_" + lastName + count * i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_ADVISER_AVATAR + "0" + rand.Next(0, 2) + ".png",
                    Experience = experience,
                    Level = level,
                    Points = Generator.GenerateUserPoints(experience),
                    PhoneNumber = RandomGenerator.GenerateRandomMobile(),
                    Notes = "Adviser"
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

            for (int i = 0; i < DataSeedConstants.STUDENT_COUNT; i++)
            {
                var count = rand.Next(0, 512);
                firstName = RandomGenerator.GenerateRandomName();
                lastName = RandomGenerator.GenerateRandomFamily();
                level = (int)Generator.GenerateUserLevel();
                experience = Generator.GenerateUserExperience(level);
                var student = new User()
                {
                    UserName = firstName + "_" + lastName + count*i + "@ils.edu",
                    PasswordHash = new PasswordHasher().HashPassword(firstName),
                    FirstName = firstName,
                    LastName = lastName,
                    Email = firstName + "_" + lastName + count * i + "@ils.edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_STUDENT_AVATAR + "0" + rand.Next(0, 3) + ".png",
                    Experience = experience,
                    Level = level,
                    Points = Generator.GenerateUserPoints(experience),
                    PhoneNumber = RandomGenerator.GenerateRandomMobile()
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
