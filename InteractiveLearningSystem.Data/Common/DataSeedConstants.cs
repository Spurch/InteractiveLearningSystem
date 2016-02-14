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

        public static string DEFAULT_ADMIN_AVATAR = "~/Assets/DefaultUserImages/admin.png";
        public static string DEFAULT_MODERATOR_AVATAR = "~/Assets/DefaultUserImages/moderator.png";
        public static string DEFAULT_ADVISER_AVATAR = "~/Assets/DefaultUserImages/adviser.png";
        public static string DEFAULT_TEACHER_AVATAR = "~/Assets/DefaultUserImages/teacher.png";
        public static string DEFAULT_STUDENT_AVATAR = "~/Assets/DefaultUserImages/student";
        public static string DEFAULT_GROUP_AVATAR = "~/Assets/DefaultUserImages/group.png";
    }
}
