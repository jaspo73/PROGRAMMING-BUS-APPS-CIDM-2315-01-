namespace LeapYearHW;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year:");
        int year = Convert.ToInt16(Console.ReadLine());

        if (year % 4 == 0)
        {
            Console.WriteLine("Year entered is a leap year.");
        }
        else
        {
            Console.WriteLine("Year entered is not a leap year.");
        }

    }
}
