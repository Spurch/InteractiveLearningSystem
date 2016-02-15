namespace InteractiveLearningSystem.Data.Common
{
    using System;

    public class UserGameDetailsGenerator
    {
        Random rand;

        public UserGameDetailsGenerator()
        {
            rand = new Random();
        }

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

        public double GenerateUserPoints(double experience)
        {
            return Math.Round(experience/DataSeedConstants.EXP_PER_POINT);
        }

        public double GenerateUserLevel()
        {
            return rand.Next(0, (int)DataSeedConstants.MAX_LEVEL);
        }
    }
}
