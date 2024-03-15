namespace GAClassMethods_ManjulaRajan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 5 grades ranging between 0 and 100
            List<int> willGrades = new List<int> { 85, 92, 78, 90, 88 };

            // Create a new instance of the Student class with the name "Will" and the grades list
            Student willStudent = new Student("Will", willGrades);

            willStudent.AddGrade(78); // Success
            willStudent.AddGrade(200); // Fails
            willStudent.AddGrade(-130); // Fails

            willStudent.DisplayAllGrades();


            willStudent.GetGrade();


        }//class















    }
}//namespace