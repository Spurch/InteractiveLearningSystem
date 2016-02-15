namespace InteractiveLearningSystem.Data.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomGenerators
    {
        private static string[] names = { "Ivan", "Petkan", "Milcho", "Niki",
            "Ivo", "Georgi", "Gosho", "Pesho", "Pantalei", "Haralampi", "Kosio",
            "Ivaylo", "Maria", "Gergana", "Ivana", "Tanq", "Vqra", "Nadejda"};

        private static string[] families = { "Nikolov", "Ivanov", "Georgiev",
            "Penev", "Nikolaev", "Dimitrov", "Haralampiev", "Petrov", "Peshev"};

        private static string[] addresses = { };

        private static string[] phones = { "925" , "997", "931", "926"};

        private static string[] mobiles = {"0888", "0898", "0887", "0878" };

        private static string[] twoDigits = { "12", "00", "44", "24", "64", "95", "25", "08", "91", "41"};

        private static int RAND_MAX = 1001;
        private static int RAND_MIN = 0;

        private static DateTime end;
        private static DateTime start;

        private Random rand;

        public RandomGenerators()
        {
            rand = new Random();
        }

        public int GenerateRandomInteger(int min, int max)
        {
            return rand.Next(min, max);
        }

        public static DateTime GenerateRandomDate()
        {
            return DateTime.Now;
        }

        public string GenerateRandomName()
        {
            var name = new StringBuilder();

            var first = names[rand.Next(0, names.Length)];

            name.Append(first);

            return name.ToString();
        }

        public string GenerateRandomFamily()
        {
            var name = new StringBuilder();

            var last = families[rand.Next(0, families.Length)];

            name.Append(" ");
            name.Append(last);

            return name.ToString();
        }

        public static string GenerateRandomAddress()
        {
            return null;
        }

        public string GenerateRandomMobile()
        {
            var mobile = new StringBuilder();

            var first = mobiles[rand.Next(0, mobiles.Length)];
 
            mobile.Append(first);

            for (int i = 0; i < 3; i++)
            {
                mobile.Append(twoDigits[rand.Next(0, twoDigits.Length)]);
            }

            return mobile.ToString();
        }

        public string GenerateRandomPhone()
        {
            var phone = new StringBuilder();

            var first = phones[rand.Next(0, phones.Length)];

            phone.Append(first);

            for (int i = 0; i < 2; i++)
            {
                phone.Append(twoDigits[rand.Next(0, twoDigits.Length)]);
            }

            return phone.ToString();
        }
    }
}
