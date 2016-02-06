namespace InteractiveLearningSystem.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using InteractiveLearningSystem.Models;
    using InteractiveLearningSystem.Data;

    public class DbInitialDataSeed
    {
        public static List<School> Schools;
        public static List<Group> Groups;

        public static void SeedDbSchools(InteractiveLearningSystemDbContext context)
        {
            Schools = new List<School>();

            for (int i = 0; i < 10; i++)
            {
                var school = new School()
                {
                    Name = "school"+i,
                    Email = "school" + i + "@ils.edu",
                    Mobile = "0887089841",
                    Phone = "029973778",
                    SiteUrl = "www.school"+i+".edu",
                    AvatarUrl = "http://static3cdn.echalk.net/www/ud00/0/08f0bb6891474a62aa9b9cbc92bd397a/Personal_Images/school.jpg",
                    Points = 0,
                    Experience = 0,
                    Level = 0,
                };
                context.Schools.Add(school);
                context.SaveChanges();
                Schools.Add(school);
            }

        }

        public static void SeedDbGroups(InteractiveLearningSystemDbContext context, 
            List<User> teachers, List<School> schools, List<User> students)
        {
            int j = -1;
            int k = 0;
            Groups = new List<Group>();
            for (int i = 0; i < 40; i++)
            {
                if(i%4 == 0)
                {
                    j++;
                }
                var group = new Group()
                {
                    Name = "group" + i,
                    AvatarUrl = "http://www.colourboxphotography.co.uk/v/ui/1004802/p1545402_dww12.11.jpg?1389787471",
                    Points = 0,
                    Experience = 0,
                    Level = 0,
                    Teacher = teachers[i],
                    School = schools[j]
                };
                for (int z = 0; z < 4; z++)
                {
                    group.Students.Add(students[k]);
                    k++;
                }
                context.Groups.Add(group);
                context.SaveChanges();
                Groups.Add(group);              
            }

        }

        public static void SeedDbProblems(InteractiveLearningSystemDbContext context)
        {

        }

        public static void SeedDbAnswers(InteractiveLearningSystemDbContext context)
        {

        }
    }
}
