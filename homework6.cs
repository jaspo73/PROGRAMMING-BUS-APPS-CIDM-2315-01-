namespace HomeworkTryAgain;

/*Q1: C# Class Implementation (6 points) 
Based on the provided UML class diagram, implement the Professor and Student classes.*/
class Program
{
   static void Main(string[] args)
  {
      Student s1 = new Student();
      s1.studentName = "Lisa";
      s1.Grade = 90;
      s1.course = "Java";
      s1.PrintStudentInfo();




      Student s2 = new Student();
      s2.studentName = "Tom";
      s2.Grade = 80;
      s2.course = "Math";
      s2.PrintStudentInfo();




      Professor p1 = new Professor();
      p1.profName = "Alice";
      p1.Salary = 9000;
      p1.classTeach = "Java";
      p1.PrintStudentInfo();




      Professor p2 = new Professor();
      p2.profName = "Bob";
      p2.Salary = 8000;
      p2.classTeach = "Math";
      p2.PrintStudentInfo();
  }
}
class Student
{
  public string? studentName;
  private int grade;
  public int Grade
   {
       get { return grade; }
       set{ grade = value; }
  }
  public string? course;
  public void PrintStudentInfo()
  {
      System.Console.WriteLine($"Name: {studentName}");
      System.Console.WriteLine($"Grade: {Grade}");
      System.Console.WriteLine($"Course: {course}");
      System.Console.WriteLine();
  }
}
class Professor
{
  public string? profName;
  public string? classTeach;
  private double salary_amount;
  public double Salary
   {
       get { return salary_amount; }
       set { salary_amount = value; }
  }
  public void PrintStudentInfo()
   {
       System.Console.WriteLine($"Name: {profName}");
       System.Console.WriteLine($"Class: {classTeach}");
       System.Console.WriteLine($"Salary: ${Salary}");
       System.Console.WriteLine();
   }
}


/*Q2: Printing and Calculating Results (4 points)
Print the following details for each professor:
Name
Class they teach
Salary
Print the following details for each student:
Name
Class they're enrolled in
Grade
Calculate and print the difference in salary between the two professors.
Calculate and print the total grade of Lisa’s Java course and Tom’s Math course*/


class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.Salary = 9000;
        p1.classTeach = "Java";
        p1.PrintProfInfo();


        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.Salary = 8000;
        p2.classTeach = "Math";
        p2.PrintProfInfo();


        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.Grade = 90;
        s1.course = "Java";
        s1.PrintStudentInfo();


        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.Grade = 80;
        s2.course = "Math";
        s2.PrintStudentInfo();

        double salary_diff = p1.Salary - p2.Salary;
        Console.WriteLine($"Salary difference: {salary_diff}");
        double grade_diff = s1.Grade - s2.Grade;
        Console.WriteLine($"Grade difference: {grade_diff}");


    }
}
class Professor
{
   public string? profName;
   public string? classTeach;
   private double salary_amount;
   public double Salary
   {
       get { return salary_amount; }
       set { salary_amount = value; }
   }
   public void PrintProfInfo()
   {
       System.Console.WriteLine($"Professor {profName} teaches {classTeach} and the salary is: ${Salary}");
   }
}
class Student
{
public string? studentName;
private int grade;
public int Grade
{
    get { return grade; }
    set{ grade = value; }
}
public string? course;
 public void PrintStudentInfo()
 {
 System.Console.WriteLine($"Student {studentName} enrolls {course}, and the grade is {Grade}");
 }
}



