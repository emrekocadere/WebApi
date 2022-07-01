using System.Collections;
using System.Collections.Generic;

namespace WebApi
{
    public class Student
    {
        public  string name { get; set; }
        public string lastName { get; set; }
        public double avarage { get; set; }
        public string bestClass { get; set; }
        public string worstClass { get; set; }

        public List<Class> classesList { get; set; }
        /*
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Avarage { get => avarage; set => avarage = value; }
        public string BestClass1 { get => bestClass; set => bestClass = value; }
        public string WorstClass1 { get => worstClass; set => worstClass = value; }
        */
        public Student(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;

            //----------------------------
            Classes classes;
            classes = new Classes();

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

        public void WorstClass(string content)
        {
            // ClassesCalculate calculate = new ClassesCalculate(this);
            worstClass = content;


        }

        public void BestClass(string content)
        {
            //ClassesCalculate calculate = new ClassesCalculate(this);
            bestClass = content;

        }

    }
}
