using System;
using System.Collections.Generic;

namespace webAppAway.Model
{
    public class Student
    {
        public Student(int id, string name, int classId)
        {
            Id = id;
            Name = name;
            ClassId = classId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
    }
}