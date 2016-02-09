namespace InteractiveLearningSystem.Data.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomGenerators
    {
        private static string[] names = { };
        private static string[] addresses = { };
        private static string[] phones = { };
        private static string[] mobiles = { };

        private static int RAND_MAX = 1001;
        private static int RAND_MIN = 0;

        private static DateTime end;
        private static DateTime start;

        public static int GenerateRandomInteger(int min, int max)
        {
            return 0;
        }

        public static double GenerateRandomDouble(double min, double max)
        {
            return 0;
        }

        public static DateTime GenerateRandomDate()
        {
            return DateTime.Now;
        }

        public static string GenerateRandomName()
        {
            return null;
        }

        public static string GenerateRandomAddress()
        {
            return null;
        }

        public static string GenerateRandomMobile()
        {
            return null;
        }

        public static string GenerateRandomPhone()
        {
            return null;
        }
    }
}
