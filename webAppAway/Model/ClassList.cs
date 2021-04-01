using System.Collections.Generic;

namespace webAppAway.Model
{
    public class ClassList
    {
        public string[] allClasses = {"Gummybears", "Sourcherries"};

        public static List<Student> studentList = getStudentList();

        public List<Classes> CreateClassList()
        {
            List<Classes> classList = new List<Classes>();
            for (int i = 0; i < allClasses.Length; i++)
            {
                classList.Add(new Classes(i, allClasses[i]));
            }

            return classList;
        }

        public static List<Student> getStudentList()
        {
            var list = new StudentList();
            studentList = list.CreateStudentList();
            return studentList;
        }

        public List<Student> getStudentClassList()
        {
            List<Student> studentClassList = new List<Student>();
            foreach (var student in studentList)
            {
                if (student.ClassId == 0)
                {
                    studentClassList.Add(student);
                }
            }

            return studentClassList;
        }

        public List<Student> getStudentSecondClassList()
        {
            List<Student> studentSecondClassList = new List<Student>();
            foreach (var student in studentList)
            {
                if (student.ClassId == 1)
                {
                    studentSecondClassList.Add(student);
                }
            }

            return studentSecondClassList;
        }
    }
}