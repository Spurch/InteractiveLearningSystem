namespace InteractiveLearningSystem.Data.Migrations
{
    using System.Collections.Generic;
    using InteractiveLearningSystem.Models;
    using InteractiveLearningSystem.Data;
    using Common;

    public class DbInitialDataSeed
    {
        public static List<School> Schools;
        public static List<Group> Groups;
        private static GameDetailsCalculator GameCalculator = new GameDetailsCalculator();
        private static RandomGenerators RandomGenerator = new RandomGenerators();

        /// <summary>
        /// Method that seeds the initial amount of schools based on a given constant.
        /// </summary>
        /// <param name="context"></param>
        public static void SeedDbSchools(InteractiveLearningSystemDbContext context)
        {
            Schools = new List<School>();

            for (int i = 0; i < DataSeedConstants.SCHOOL_COUNT; i++)
            {
                var school = new School()
                {
                    Name = "school"+i,
                    Email = "school" + i + "@ils.edu",
                    Mobile = "0887089841",
                    Phone = "029973778",
                    SiteUrl = "www.school"+i+".edu",
                    AvatarUrl = DataSeedConstants.DEFAULT_SCHOOL_AVATAR,
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
            for (int i = 0; i < DataSeedConstants.GROUP_COUNT; i++)
            {
                if(i%4 == 0)
                {
                    j++;
                }
                var group = new Group()
                {
                    Name = "group" + i,
                    AvatarUrl = DataSeedConstants.DEFAULT_GROUP_AVATAR,
                    Points = 0,
                    Experience = 0,
                    Level = 0,
                    Teacher = teachers[i],
                    School = schools[j]
                };
                for (int z = 0; z <= 4; z++)
                {
                    group.Students.Add(students[k]);
                    k++;
                }

                group.Level = GameCalculator.EvaluateGroupLevel(group);
                group.Points = GameCalculator.EvaluateGroupPoints(group);
                group.Experience = GameCalculator.EvaluateGroupExperience(group);
                teachers[i].Group = group;
                context.Groups.Add(group);
                context.SaveChanges();
                Groups.Add(group);
            }
            EvaluateSchoolGameDetails();
        }

        private static void EvaluateSchoolGameDetails()
        {
            foreach (var school in Schools)
            {
                school.Level = GameCalculator.EvaluateSchoolLevel(school);
                school.Points = GameCalculator.EvaluateSchoolPoints(school);
                school.Experience = GameCalculator.EvaluateSchoolExperience(school);
            }
        }

        public static void SeedDbMessages(InteractiveLearningSystemDbContext context, List<User> users)
        {
            var flag = true;
            var count = users.Count;
            for (int i = 0; i < count*2; i++)
            {
                if(i%3 == 0)
                {
                    flag = false;
                }
                var message = new Message()
                {
                    Title = RandomGenerator.GenerateRandomSentence(5),
                    Content = RandomGenerator.GenerateRandomSentence(30),
                    DateCreated = RandomGenerator.GenerateRandomDate(),
                    Receiver = users[RandomGenerator.GenerateRandomInteger(0, users.Count/2)],
                    Sender = users[RandomGenerator.GenerateRandomInteger(users.Count/2+1, users.Count)],
                    isViewed = flag,
                    Flag = RandomGenerator.GenerateRandomSentence(3)
                };
                context.Messages.Add(message);
            }
            context.SaveChanges();
        }

        public static void SeedDbProblems(InteractiveLearningSystemDbContext context)
        {

        }

        public static void SeedDbAnswers(InteractiveLearningSystemDbContext context)
        {

        }
    }
}
