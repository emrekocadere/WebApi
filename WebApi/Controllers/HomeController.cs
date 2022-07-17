using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Data;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class HomeController : ControllerBase
    {
        public  List<Student> student = new List<Student>();
        private DataContext dataContext=new DataContext();
        public HomeController()
        {
           

            Student stundet = new Student("emre","kocadere");
            Student stundet2 = new Student("ahmet", "sukru");
            Student stundet3 = new Student("ömer", "zengin");
            Student stundet4 = new Student("ekrem", "ozgur");
            Student stundet5 = new Student("salih", "yılmaz");
            Student stundet6 = new Student("burak", "veyisoğlu");

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
        public Student getstudent(int id)
        {
            return student[id];
        }

        [HttpGet("addtodb")]
        public string addToDb()
        {
            Student student1 = new Student("sukru ahmet","kocadere");
            Student_sClasses std1 = student1.studentclasses;
            dataContext.Students.Add(student1);
            dataContext.student_SClasses.Add(std1);
            dataContext.SaveChanges();

            return "done";
        }


    }
}
    