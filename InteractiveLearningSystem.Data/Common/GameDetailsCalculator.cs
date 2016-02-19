namespace InteractiveLearningSystem.Data.Common
{
    using System.Linq;
    using Models;
   
    /// <summary>
    /// Class that provides public methods for calculating the
    /// gamification details of the Schools and groups based on Users.
    /// </summary>
    public class GameDetailsCalculator
    {
        /// <summary>
        /// Method that evaluates a given school level based on the 
        /// level of the groups in it. The current logic is very simple:
        /// We get the Mode Level of all Groups.
        /// </summary>
        /// <param name="school">A School type object to evaluate level</param>
        /// <returns>The calculated level for the School</returns>
        public int EvaluateSchoolLevel(School school)
        {
            var schoolLevel = school.Groups.GroupBy(v => v.Level)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

            return schoolLevel;
        }

        /// <summary>
        /// Method that evaluates a given school points based on the 
        /// points of the groups in it. The current logic is very simple:
        /// We get the Avarage points of all Groups.
        /// </summary>
        /// <param name="school">A School type object to evaluate points</param>
        /// <returns>The calculated points for the School</returns>
        public int EvaluateSchoolPoints(School school)
        {
            var schoolPoints = school.Groups.Sum(x => x.Points);

            return (int)(schoolPoints / school.Groups.Count());
        }

        /// <summary>
        /// Method that evaluates a given school experience based on the 
        /// experience of the groups in it. The current logic is very simple:
        /// We get the Avarage experience of all Groups.
        /// </summary>
        /// <param name="school">A School type object to evaluate experience</param>
        /// <returns>The calculated experience for the School</returns>
        public int EvaluateSchoolExperience(School school)
        {
            var schoolExperience = school.Groups.Sum(x => x.Experience);

            return (int)(schoolExperience / school.Groups.Count());
        }

        /// <summary>
        /// Method that evaluates a given group level based on the 
        /// level of the Students in it. The current logic is very simple:
        /// We get the Mode Level of all Students.
        /// </summary>
        /// <param name="group">A Group type object to evaluate level</param>
        /// <returns>The calculated level for the Group</returns>
        public int EvaluateGroupLevel(Group group)
        {
            var studentLevel = group.Students.GroupBy(v => v.Level)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

            return studentLevel;
        }

        /// <summary>
        /// Method that evaluates a given group points based on the 
        /// experinces of the Students in it. The current logic is very simple:
        /// We get the Avarage Points of all Students.
        /// </summary>
        /// <param name="group">A Group type object to evaluate points</param>
        /// <returns>The calculated points for the Group</returns>
        public int EvaluateGroupPoints(Group group)
        {
            var studentPoints = group.Students.Sum(x => x.Points);

            return (int)(studentPoints / group.Students.Count());
        }

        /// <summary>
        /// Method that evaluates a given group experince based on the 
        /// experinces of the Students in it. The current logic is very simple:
        /// We get the Avarage Exp of all Students.
        /// </summary>
        /// <param name="group">A Group type object to evaluate experince</param>
        /// <returns>The calculated experience for the Group</returns>
        public int EvaluateGroupExperience(Group group)
        {
            var studentExperience = group.Students.Sum(x => x.Experience);

            return (int)(studentExperience / group.Students.Count());
        }
    }
}
