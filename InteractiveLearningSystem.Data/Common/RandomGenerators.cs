namespace InteractiveLearningSystem.Data.Common
{
    using System;
    using System.Text;

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

        public RandomGenerators()
        {
            rand = new Random();
            start = DateTime.UtcNow.AddDays(rand.Next(-200, 0));
        }

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

        public int GenerateRandomInteger(int min, int max)
        {
            return rand.Next(min, max);
        }

        public DateTime GenerateRandomDate()
        {
            int range = (DateTime.UtcNow - start).Days;
            return start.AddDays(rand.Next(range));
        }

        public string GenerateRandomSchoolName()
        {
            var name = new StringBuilder();

            var first = schoolNames[rand.Next(0, schoolNames.Length)];

            name.Append(first);

            return name.ToString();
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

        public string GenerateRandomAddress()
        {
            return addresses[rand.Next(0, addresses.Length)];
        }

        public string GenerateRandomCity()
        {
            return cities[rand.Next(0, cities.Length)];
        }

        public string GenerateRandomAffinity()
        {
            return affinities[rand.Next(0, affinities.Length)];
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
