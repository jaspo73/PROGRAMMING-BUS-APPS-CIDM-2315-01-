namespace HomeworkQ2;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("First number:");
        a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Second number:");
        b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Third number:");
        c = Convert.ToInt16(Console.ReadLine());

        if (a < b && a < c)
        {
            Console.WriteLine($"{a} is the smallest.");
        }
        else if (b < a && b < c)
        {
            Console.WriteLine($"{b} is the smallest.");
        }
        else
        {
            Console.WriteLine($"{c} is the smallest.");
        }


    }

}
