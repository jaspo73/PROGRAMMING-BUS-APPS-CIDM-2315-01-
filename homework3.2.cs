namespace homework2._1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an number (n): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            if (n > 0)
            {
                // Outer loop for rows
                for (int i = 0; i < n; i++)
                {
                    // Inner loop for columns
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("# "); // Print a star and a space
                    }
                    Console.WriteLine(); // Move to the next line after each row
                }
            }
        }
    }
}
