using System.Collections;
using System;
using System.Collections.Generic;

namespace WebApi
{
    public class ClassesCalculate
    {
        private List<Class> classes;
        private Student student;
        
        public ClassesCalculate(Student _student)
        {
            student=_student;
            classes = student.ReturnClasses();
            BestClass();
            WorstClass();
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
            student.BestClass("the best class is "+tempName+" : "+tempResult);
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

            student.WorstClass("the worst class is " + tempName + " : " + tempResult);
        }
    }
}
