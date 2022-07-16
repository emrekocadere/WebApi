namespace WebApi
{
    public class Student_sClasses
    {
        public int Id { get; set; }
        public double avarage { get; set; }
        public string bestClass { get; set; }
        public string worstClass { get; set; }
        public void WorstClass(string content)
        {
            worstClass = content;


        }

        public void BestClass(string content)
        {
            bestClass = content;
        }
    }
}
