namespace homework3._3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer N for the number of rows: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            if (n > 0)
            {
                // Loop for each row
                for (int i = 1; i <= n; i++)
                {
                    // Loop to print characters in the current row
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* "); // Prints an asterisk and a space
                    }
                    Console.WriteLine(); // Moves to the next line after each row
                }
            }
        }

    }

}