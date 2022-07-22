using System.Collections;
using System.Collections.Generic;

namespace WebApi
{
    public class Student
    {
        public int Id { get; set; }//ok
        public string name { get; set; }//ok
        public string lastName { get; set; }//ok
        public int Student_sClassesId { get; set; }//ok
        public  Student_sClasses studentclasses { get; set; }
      

        public List<Class> classesList;
 
        public Student(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;

            //----------------------------
            Classes classes = new Classes();


            //*******************

            classesList = classes.ReturnClasses();
            ClassCalculate();

        }
        public List<Class> ReturnClasses()
        {
            return classesList;
        }


        public void ClassCalculate()
        {
            ClassesCalculate calculate = new ClassesCalculate(this);

        }
    

      

    }
}
