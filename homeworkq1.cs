namespace Q1Homework;

class Program
{
    static void Main(string[] args)
    { Console.WriteLine("Input a grade in letters: A, B, C, D, or F):");
        string input = Console.ReadLine();

        char grade = (input[0]);

        if (grade == 'A')
        {
            Console.WriteLine("4 GPA points");
        }
        else if (grade == 'B')
        {
            Console.WriteLine("3 GPA points");
        }
        else if (grade == 'C')
        {
            Console.WriteLine("2 GPA points");
        }
        else if (grade == 'D')
        {
            Console.WriteLine("1 GPA points");
        }
        else if (grade == 'F')
        {
            Console.WriteLine("0 GPA points");
        }
        else
        {
            Console.WriteLine("Wrong letter grade!");
        }
    }

}
