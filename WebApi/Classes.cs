using System;
using System.Collections;//sor
using System.Collections.Generic;

namespace WebApi
{
    public class Classes
    {
        private List<Class> classes = new List<Class>();
        public Classes()
        {
            Random random = new Random(DateTime.Now.Second);
            Class physics = new Class("physics",random.Next(0,100));
            Class math = new Class("math", random.Next(0, 100));
            Class programming1 = new Class("programming1", random.Next(0, 100));
            Class programming2 = new Class("programming2", random.Next(0, 100));
            Class OOP = new Class("OOP", random.Next(0, 100));

            classes.Add(physics);
            classes.Add(OOP);
            classes.Add(math);
            classes.Add(programming2);
            classes.Add(programming1);

        }

        public List<Class> ReturnClasses()
        {
            return classes;
        }
    }
}
