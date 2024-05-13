namespace Assignment2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(24, "Justin", "Hainline", 'A');
            student.DisplayStudentInfo();



        }
    }

    public class Student
    {
        //private fields
        private int Id;
        private string StudentFname;
        private string StudentLname;
        private char StudentGrade;

        //private properties
        public int _id {
            get { return _id; }
            set { _id = value; }

        }
        public string _studentFname
        {
            get { return _studentFname; }
            set { _studentFname = value; }
        }
        public string _studentLname
        {
            get { return _studentLname; }
            set { _studentLname = value; }
        }
        public string _studentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }

        //constructor
        public Student(int _id, string _studentfname, string _studentlname, char _grade)
        {
            Id = _id;
            StudentFname = _studentfname;
            StudentLname = _studentlname;
            StudentGrade = _grade;
        }
        //display method
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"First Name: {StudentFname}");
            Console.WriteLine($"Last Name: {StudentLname}");
            Console.WriteLine($"Grade: {StudentGrade}");
        }
    }
}
