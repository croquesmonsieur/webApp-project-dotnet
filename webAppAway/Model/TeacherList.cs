using System.Collections.Generic;
namespace webAppAway.Model
{
    public class TeacherList
    {
        public Teacher teacher;
        
        public static List<Classes> classList = GetClassList();
        
        public string[] allTeachers = {"Mr.Cocktail", "Ms.Mocktail"};

        public static List<Classes> GetClassList()
        {
            var group = new ClassList();
            classList = group.CreateClassList();
            return classList;
        }

        public List<Teacher> CreateTeacherList()
        {
            List<Teacher> teacherList = new List<Teacher>();
            for (int i = 0; i < allTeachers.Length; i++)
            {
                teacherList.Add(new Teacher(i, allTeachers[i], classList[i].Id));
            }

            return teacherList;

        }
    }
}