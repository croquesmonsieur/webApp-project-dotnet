using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webAppAway.Model;

namespace webAppAway.Pages
{
    public class teacherModel : PageModel
    {
        public List<Teacher> teacherList { get; set; }
        public void OnGet()
        {
            var teacher = new TeacherList();
            teacherList = teacher.CreateTeacherList();
        }
    }
}
