using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webAppAway.Model;


namespace webAppAway.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; }
        public List<Student> studentList { get; set; }
        

        public void OnGet()
        {
            var student = new StudentList();
            Message = "Hello, I'm here too!";
            studentList = student.CreateStudentList();

        }
    }
}
