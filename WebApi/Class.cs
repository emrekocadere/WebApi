using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    [Keyless]
    public class Class
    {
        public string name { get; set; }
        public int result { get; set; }
        
        //propfull detaylı bak..
        /*
        public int _result
        {
            get { return result; }
            set { result = value; }
        }
            
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        */
        public int getResult()
        {
            return result;
        }

        public string getName()
        {
            return name;
        }


        public Class(string name, int result)
        {
            this.name = name;
            this.result = result;
        }

        
    }
}
