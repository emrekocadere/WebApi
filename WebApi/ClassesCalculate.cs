using System.Collections;
using System;
using System.Collections.Generic;

namespace WebApi
{
    public class ClassesCalculate
    {
        private List<Class> classes;
        private Student student;
        int tempResult;
        public ClassesCalculate(Student _student)
        {
            student=_student;
            classes = student.ReturnClasses();
       
            BestClass();
            WorstClass();
            Avarage();
        }
        
        public void BestClass()
        {
            int tempResult = classes[0].getResult();
           string tempName = classes[0].getName();

            foreach(Class temp in classes)
            {
                if (temp.getResult() > tempResult)
                {
                    tempResult = temp.getResult();
                    tempName = temp.getName();
                }
                    
                else
                    continue;

            }
            student.studentclasses.BestClass("the best class is "+tempName+" : "+tempResult);
        }


        public void WorstClass()
        {
            int tempResult = classes[0].getResult();
             string tempName = classes[0].getName();

            foreach (Class temp in classes)
            {
                if (temp.getResult() < tempResult)
                {
                    tempName = temp.getName();
                    tempResult = temp.getResult();
                }
                else
                    continue;

            }

            student.studentclasses.WorstClass("the worst class is " + tempName + " : " + tempResult);
        }

        public void Avarage()
        {
            
            foreach(Class temp in classes)
              {
                tempResult += temp.getResult();
            }
            student.studentclasses.avarage = (double)(tempResult / classes.Count);
        }
    }
}
