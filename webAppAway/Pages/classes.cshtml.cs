using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webAppAway.Model;

namespace webAppAway.Pages
{
    public class classesModel : PageModel
    { 
        public List<Student> studentClassList { get; set; }
        public List<Student> studentSecondClassList { get; set; }
        
        public void OnGet()
        {
            var list = new ClassList();
            studentClassList = list.getStudentClassList();
            studentSecondClassList = list.getStudentSecondClassList();
        }
    }
}
