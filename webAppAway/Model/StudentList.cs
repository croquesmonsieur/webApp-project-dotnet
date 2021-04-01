using System.Collections.Generic;
namespace webAppAway.Model
{
    public class StudentList
    {
        public Student student;
        
        public static List<Classes> classList = GetClassesList();
        
        public string[] allStudents =
            {"Sam", "Kim", "Roger", "Sylvain", "Melchior", "Elkan", "Alyssia", "Eleonora", "Stamatis", "Frauke"};
        
        
        public static List<Classes> GetClassesList()
        {
            var group = new ClassList();
            classList = group.CreateClassList();
            return classList;
        }
        
        public List<Student> CreateStudentList()
        {
            List<Student> studentList = new List<Student>();
            for (int i = 0 ; i < allStudents.Length ; i++)
            {
                if (i < (allStudents.Length / 2))
                {
                    studentList.Add(new Student(i, allStudents[i], classList[0].Id));
                } else if (i >= (allStudents.Length / 2))
                {
                    studentList.Add(new Student(i, allStudents[i], classList[1].Id));
                }
                
            }
            
            return studentList;
        }
    }
}