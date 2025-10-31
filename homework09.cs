namespace Homework8._3;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> stu_info = new Dictionary<int, string>();
        stu_info.Add(111, "Alice");
        stu_info.Add(222, "Bob");
        stu_info.Add(333, "Cathy");
        stu_info.Add(444, "David");
        {
            Console.WriteLine("-----STUDENTS ID AND NAME-----");
        }
        foreach (var stu in stu_info)
        {
            Console.WriteLine($"Students information: Student ID: {stu.Key}, Name: {stu.Value}");
        }
        if (stu_info.ContainsKey(333))
        {
            stu_info.Remove(333);
        }
       
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        {
            Console.WriteLine("\n-----STUDENTS NAME AND GPA-----");
        }
        foreach (var stu in gradebook)
        {
            Console.WriteLine($"Name: {stu.Key}, Student GPA {stu.Value}");
        }
        double totalGpa = 0;
        foreach (var student in gradebook)
        {
            totalGpa += student.Value;
        }
        // 4. Check if "Tom" has a record in the gradebook.
        {
            Console.WriteLine("\n-----Check if Tom has a record in the gradebook.-----");
        }
        if (!gradebook.ContainsKey("Tom"))
        {
            // If "Tom" is NOT in the gradebook, insert Tom with a GPA of 3.3
            gradebook.Add("Tom", 3.3);
            Console.WriteLine("Tom was added to the gradebook with a GPA of 3.3.");
        }
        else
        {
            Console.WriteLine("Tom is already in the gradebook.");
        }
        //5. Calculate the average GPA of all students, and print out the average GPA.
         {
            Console.WriteLine("\n-----Calculate the average GPA of all students, and print out the average GPA.-----");
        }
       double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"Average GPA of all students: {averageGPA:F2}");
       {
            Console.WriteLine("\n-----Finally, print out information about students whose GPA is greater than the average GPA.-----");
        }
       Console.WriteLine("Students with GPA greater than the average:");
       // 6. Finally, print out information about students whose GPA is greater than the average GPA. 
       foreach (var student in gradebook)
       {
           if (student.Value > averageGPA)
           {
               Console.WriteLine($"{student.Key} has a GPA of {student.Value:F2}; and that GPA is greater than the average GPA");
           }
       }


    }
}
  //1. Create a Student class  (2 points):
class Student
{
    public static List<Student> student_list = new List<Student>();
    private int stuID { get; set; }
    private string stuName { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"1. Create a Student class: Student ID: {stuID}, Student Name: {stuName}");
    }
    public Student(int inputID, string inputName)
    {
        stuID = inputID;
        stuName = inputName;
        student_list.Add(this);
    }
}