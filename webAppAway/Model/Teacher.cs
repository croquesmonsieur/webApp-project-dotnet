using System.Collections.Generic;
namespace webAppAway.Model
{
    public class Teacher
    {
        public Teacher(int id, string name, int classId)
        {
            Id = id;
            Name = name;
            ClassId = classId;
        }

        public int Id;
        public string Name;
        public int ClassId;
        
    }
}