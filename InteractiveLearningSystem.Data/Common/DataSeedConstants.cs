namespace InteractiveLearningSystem.Data.Common
{
    public class DataSeedConstants
    {
        public static string[] ROLES = { "Administrator", "Moderator", "Adviser", "Teacher", "Student" };

        public static int MODERATOR_COUNT = 10;
        public static int ADVISER_COUNT = 10;
        public static int TEACHER_COUNT = 40;
        public static int SCHOOL_COUNT = 10;
        public static int GROUP_COUNT = 40;
        public static int STUDENT_COUNT = 200;

        public static double INITIAL_LEVEL_EXP = 2000;
        public static double MAX_EXPERIENCE = 1024000;
        public static double EXP_PER_POINT = 100;
        public static double EXP_FACTOR = 2;
        public static double EXP_FACTOR_MULTIPLIER = 1000;
        public static double MAX_LEVEL = 100;

        public static string DEFAULT_ADMIN_AVATAR = "/Assets/DefaultUserImages/admin.png";
        public static string DEFAULT_MODERATOR_AVATAR = "/Assets/DefaultUserImages/moderator";
        public static string DEFAULT_ADVISER_AVATAR = "/Assets/DefaultUserImages/adviser";
        public static string DEFAULT_TEACHER_AVATAR = "/Assets/DefaultUserImages/teacher";
        public static string DEFAULT_STUDENT_AVATAR = "/Assets/DefaultUserImages/student";
        public static string DEFAULT_GROUP_AVATAR = "/Assets/DefaultUserImages/group.png";
        public static string DEFAULT_SCHOOL_AVATAR = "/Assets/DefaultUserImages/school.png";
    }
}
