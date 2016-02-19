namespace InteractiveLearningSystem.Data.Common
{
    public class DataSeedConstants
    {
        /// <summary>
        /// Predefined User Roles for the initial DB Seed. 
        /// </summary>
        public static string[] ROLES = { "Administrator", "Moderator", "Adviser", "Teacher", "Student" };

        /// <summary>
        /// Constant that gives the number of moderators for the initial DB Seed.
        /// </summary>
        public static int MODERATOR_COUNT = 10;

        /// <summary>
        /// Constant that gives the number of advisers for the initial DB Seed.
        /// </summary>
        public static int ADVISER_COUNT = 10;

        /// <summary>
        /// Constant that gives the number of teachers for the initial DB Seed. 
        /// </summary>
        public static int TEACHER_COUNT = 40;

        /// <summary>
        /// Constant that gives the number of schools for the initial DB Seed.
        /// </summary>
        public static int SCHOOL_COUNT = 10;

        /// <summary>
        /// Constant that gives the number of groups for the initial DB Seed.
        /// </summary>
        public static int GROUP_COUNT = 40;

        /// <summary>
        /// Constant that gives the number of students for the initial DB Seed. 
        /// </summary>
        public static int STUDENT_COUNT = 200;

        /// <summary>
        /// Constant that gives the initial experience for the initial DB Seed. 
        /// </summary>
        public static double INITIAL_LEVEL_EXP = 2000;

        /// <summary>
        /// Constant that gives the maximum experience for the initial DB Seed. 
        /// </summary>
        public static double MAX_EXPERIENCE = 1024000;

        /// <summary>
        /// Constant that gives the experience per point ratio for the initial DB Seed. 
        /// </summary>
        public static double EXP_PER_POINT = 100;

        /// <summary>
        /// Constant that gives the experience Factor for the initial DB Seed. 
        /// </summary>
        public static double EXP_FACTOR = 2;

        /// <summary>
        /// Constant that gives the experience Factor multiplier for the initial DB Seed. 
        /// </summary>
        public static double EXP_FACTOR_MULTIPLIER = 1000;

        /// <summary>
        /// Constant that gives the maximum level for the initial DB Seed. 
        /// </summary>
        public static double MAX_LEVEL = 100;

        /// <summary>
        /// Constant that point to the default Admin avatar url
        /// </summary>
        public static string DEFAULT_ADMIN_AVATAR = "/Assets/DefaultUserImages/admin.png";

        /// <summary>
        /// Constant that point to the default Moderator avatar url
        /// note that the path is not complete - this is done during Users seeding.
        /// </summary>
        public static string DEFAULT_MODERATOR_AVATAR = "/Assets/DefaultUserImages/moderator";

        /// <summary>
        /// Constant that point to the default Adviser avatar url
        /// note that the path is not complete - this is done during Users seeding.
        /// </summary>
        public static string DEFAULT_ADVISER_AVATAR = "/Assets/DefaultUserImages/adviser";

        /// <summary>
        /// Constant that point to the default Teacher avatar url
        /// note that the path is not complete - this is done during Users seeding.
        /// </summary>
        public static string DEFAULT_TEACHER_AVATAR = "/Assets/DefaultUserImages/teacher";

        /// <summary>
        /// Constant that point to the default Student avatar url
        /// note that the path is not complete - this is done during Users seeding.
        /// </summary>
        public static string DEFAULT_STUDENT_AVATAR = "/Assets/DefaultUserImages/student";

        /// <summary>
        /// Constant that point to the default Group avatar url
        /// </summary>
        public static string DEFAULT_GROUP_AVATAR = "/Assets/DefaultUserImages/group.png";

        /// <summary>
        /// Constant that point to the default School avatar url
        /// </summary>
        public static string DEFAULT_SCHOOL_AVATAR = "/Assets/DefaultUserImages/school.png";
    }
}
