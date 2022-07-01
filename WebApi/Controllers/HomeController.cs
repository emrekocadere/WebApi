using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
 


namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class HomeController : ControllerBase
    {
        public  List<Student> student = new List<Student>();
        //private DataContext dataContext;
        public HomeController()
        {
           

            Student stundet = new Student("emre","kocadere");
            Student stundet2 = new Student("ahmet", "sukru");
            Student stundet3 = new Student("ömer", "zengin");
            Student stundet4 = new Student("ekrem", "ozgur");
            Student stundet5 = new Student("salih", "yılmaz");
            Student stundet6 = new Student("burak", "veyis");

                       //-------------
            student.Add(stundet6);
            student.Add(stundet);
            student.Add(stundet5);
            student.Add(stundet4);
            student.Add(stundet3);
            student.Add(stundet2);
        }


        [HttpGet]
        public List<Student> getAll()
        {
            return student;
        }

        [HttpGet("{id}")]
        public Student get(int id)
        {
            return student[id];
        }

          
    }
}
