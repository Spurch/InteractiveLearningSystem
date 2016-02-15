namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class GameDetailsEvaluationHelper
    {
        public GameDetailsEvaluationHelper()
        {

        }

        public int EvaluateSchoolLevel(School school)
        {
            var schoolLevel = school.Groups.GroupBy(v => v.Level)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

            return schoolLevel;
        }

        public int EvaluateSchoolPoints(School school)
        {
            var schoolPoints = school.Groups.Sum(x => x.Points);

            return (int)(schoolPoints / school.Groups.Count());
        }

        public int EvaluateSchoolExperience(School school)
        {
            var schoolExperience = school.Groups.Sum(x => x.Experience);

            return (int)(schoolExperience / school.Groups.Count());
        }

        public int EvaluateGroupLevel(Group group)
        {
            var studentLevel = group.Students.GroupBy(v => v.Level)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

            return studentLevel;
        }

        public int EvaluateGroupPoints(Group group)
        {
            var studentPoints = group.Students.Sum(x => x.Points);

            return (int)(studentPoints / group.Students.Count());
        }

        public int EvaluateGroupExperience(Group group)
        {
            var studentExperience = group.Students.Sum(x => x.Experience);

            return (int)(studentExperience / group.Students.Count());
        }
    }
}