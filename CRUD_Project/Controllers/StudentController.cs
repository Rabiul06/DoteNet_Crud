using CRUD_Project.Data;
using CRUD_Project.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Project.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationContext context;
        public StudentController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        
        {
            /*var stdData = context.Students.ToList();
            var classData = context.Classs.ToList();*/
            var data = (from s in context.Students
                        join c in context.Classs
                        on s.StudentId equals c.ClassId
                        select new StudentClassSummaryViewModel
                        {
                            StudentId = s.StudentId,
                            Std_Name = s.Std_Name,
                            gender = s.gender,
                            DOB = s.DOB,
                            name = c.name
                        }).ToList();
            return View(data);
        }
        public ActionResult Create()
        {


            return View();
        }
      
    }
}
