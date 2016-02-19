namespace InteractiveLearningSystem.Data.Common
{
    using System;

    /// <summary>
    /// A class that contains public methods for calculating the initial values
    /// of the Gamification properties of the Users seeded in the Database.
    /// </summary>
    public class UserGameDetailsGenerator
    {
        private Random rand;

        /// <summary>
        /// A overwriten empty constructor that initializes a private variable
        /// of type Random() that is used in the UserGameDetailsGenerator class
        /// methods
        /// </summary>
        public UserGameDetailsGenerator()
        {
            rand = new Random();
        }

        /// <summary>
        /// This method returns User experience based on the given User level. The calculation
        /// is done based on the provided level and the value of the DataSeedConstants.EXP_FACTOR
        /// constant value and DataSeedConstants.EXP_FACTOR_MULTIPLIER constant value.
        /// </summary>
        /// <param name="level">The level of the given User represented as an Integer</param>
        /// <returns>The calculated User experience plus a given random deviation.</returns>
        public double GenerateUserExperience(int level)
        {
            var exp = 0;
            while(level > 0)
            {
                level--;
                exp += level * (int)(DataSeedConstants.EXP_FACTOR * DataSeedConstants.EXP_FACTOR_MULTIPLIER);
            } 
            return rand.Next(exp, exp + 1024);
        }

        /// <summary>
        /// This method returns User points based on the given User experience. The calculation
        /// is done based on the provided experience and the value of the DataSeedConstants.EXP_PER_POINT
        /// constant value.
        /// </summary>
        /// <param name="experience">A double value representing User experience represented as a Double.</param>
        /// <returns>Rounded value representing the points of the user.</returns>
        public double GenerateUserPoints(double experience)
        {
            return Math.Round(experience/DataSeedConstants.EXP_PER_POINT);
        }

        /// <summary>
        /// This method returns a random User level based on the given MAX_LEVEL
        /// constant in the DataSeedConstants class.
        /// </summary>
        /// <returns>A random integer value between 0 and DataSeedConstants.MAX_LEVEL</returns>
        public double GenerateUserLevel()
        {
            return rand.Next(0, (int)DataSeedConstants.MAX_LEVEL);
        }
    }
}
