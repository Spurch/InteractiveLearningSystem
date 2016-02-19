namespace InteractiveLearningSystem.Data.Common
{
    using System;
    using System.Text;

    /// <summary>
    /// A class that contains public method for generating different types of
    /// random value - Integer, DateTime, context specific Strings etc.
    /// </summary>
    public class RandomGenerators
    {
        private static string[] words = { "is", "not", "words", "world", "friend",
            "work", "teacher", "class", "school", "a", "have", "as", "are", "was",
            "wasn't", "isn't", "Peter", "moderator", "student", "adviser", "admin",
            "child", "children", "homework", "home", "parents", "father", "mother",
            "separate", "way", "gym", "play", "game", "atention", "warning", "final",
            "danger", "continue", "working", "playing", "attending", "score", "start",
            "end", "summer", "winter", "classmates", "teachers", "commision", "deputy",
            "library", "maths", "biology", "literature", "read", "calculate", "evaluate",
            "external", "town", "city", "high", "highschool", "elementary", "preliminary"  };

        private static string[] schoolNames = {"157 GICE Cesar Vallejo", "78 SOU Hristo Smirnenski",
            "64 SOU Willian Gladston", "5 OU Emilyan Stanev", "147 SOU Konstantin Irechek" };

        private static string[] names = { "Ivan", "Petkan", "Milcho", "Niki",
            "Ivo", "Georgi", "Gosho", "Pesho", "Pantalei", "Haralampi", "Kosio",
            "Ivaylo", "Maria", "Gergana", "Ivana", "Tanq", "Vqra", "Nadejda"};

        private static string[] families = { "Nikolov", "Ivanov", "Georgiev",
            "Penev", "Nikolaev", "Dimitrov", "Haralampiev", "Petrov", "Peshev"};

        private static string[] cities = {"Sofia", "Burgas", "Varna", "Plovdiv", "Stara Zagora",
            "Pernik", "Veliko Turnovo", "Bankya", "Ruse", "Vidin", "Montana" };

        private static string[] addresses = {"Vasil Levski 100", "Ilarion Makariopolski 15", "Suedinenie 2",
            "Vuzrajdane 8", "Opulchenska 15", "Hristo Smirnenski 23", "Nikola Vaptsarov 11", "Maria Luiza 7" };

        private static string[] affinities = {"Science", "Literature", "Mathematics", "Biology", "Computer Science",
            "Chemistry", "Languages", "Sports" };

        private static string[] phones = { "925", "997", "931", "926" };

        private static string[] mobiles = { "0888", "0898", "0887", "0878" };

        private static string[] twoDigits = { "12", "00", "44", "24", "64", "95", "25", "08", "91", "41" };

        private DateTime start;

        private Random rand;

        /// <summary>
        /// An overwriten empty constructor that initializes private variables
        /// of type Random() and DateTime that are used in the public methods.
        /// </summary>
        public RandomGenerators()
        {
            rand = new Random();
            start = DateTime.UtcNow.AddDays(rand.Next(-200, 0));
        }

        /// <summary>
        /// Method that generates a string of random words. The number of words depends on the 
        /// integer value provided as an input parameter.
        /// </summary>
        /// <param name="wordsCount">The number of random words to be returned - Integer value</param>
        /// <returns>String of the given number of random words</returns>
        public string GenerateRandomSentence(int wordsCount)
        {
            var sentence = new StringBuilder();

            for (int i = 0; i < wordsCount; i++)
            {
                sentence.Append(words[rand.Next(0, words.Length)]);
                sentence.Append(" ");
            }

            return sentence.ToString();
        }

        /// <summary>
        /// Method that generates a random integer value based on a given 
        /// lower upper bound range.
        /// </summary>
        /// <param name="min">Range lower bound</param>
        /// <param name="max">Range upper bound - exclusive</param>
        /// <returns>A random integer value in the provided range (upper bound exclusive)</returns>
        public int GenerateRandomInteger(int min, int max)
        {
            return rand.Next(min, max);
        }

        /// <summary>
        /// Method that returns a random DateTime in range.
        /// </summary>
        /// <returns>A random DateTime based on the current DateTime.UtcNow and a predefined DateTime start range</returns>
        public DateTime GenerateRandomDate()
        {
            int range = (DateTime.UtcNow - start).Days;
            return start.AddDays(rand.Next(range));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GenerateRandomSchoolName()
        {
            var name = new StringBuilder();

            var first = schoolNames[rand.Next(0, schoolNames.Length)];

            name.Append(first);

            return name.ToString();
        }

        /// <summary>
        /// Context specific method that returns a random school name.
        /// </summary>
        /// <returns>School name as string</returns>
        public string GenerateRandomName()
        {
            var name = new StringBuilder();

            var first = names[rand.Next(0, names.Length)];

            name.Append(first);

            return name.ToString();
        }

        /// <summary>
        /// Context specific method that returns a random person family name.
        /// </summary>
        /// <returns>Random family name</returns>
        public string GenerateRandomFamily()
        {
            var name = new StringBuilder();

            var last = families[rand.Next(0, families.Length)];

            name.Append(" ");
            name.Append(last);

            return name.ToString();
        }
        
        /// <summary>
        /// Context specific method that returns a random address.
        /// </summary>
        /// <returns>A random address</returns>
        public string GenerateRandomAddress()
        {
            return addresses[rand.Next(0, addresses.Length)];
        }

        /// <summary>
        /// Context specific method that returns a random city.
        /// </summary>
        /// <returns>A random city</returns>
        public string GenerateRandomCity()
        {
            return cities[rand.Next(0, cities.Length)];
        }

        /// <summary>
        /// Context specific method that returns a random affinity.
        /// </summary>
        /// <returns>A random affinity</returns>
        public string GenerateRandomAffinity()
        {
            return affinities[rand.Next(0, affinities.Length)];
        }

        /// <summary>
        /// Context specific method that returns a random mobile.
        /// </summary>
        /// <returns>A random mobile</returns>
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

        /// <summary>
        /// /// Context specific method that returns a random phone.
        /// </summary>
        /// <returns>A random phone</returns>
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
