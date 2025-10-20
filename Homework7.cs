namespace HelloLecture20oct;

class Program
{
    static void Main(string[] args)
    {
    // Create two customers with id, age, name and updated id:
    Customer C1 = new Customer();
    C1.C_ID = 111;
    C1.C_age = 28;
    C1.C_name = "Alice";

    Customer C2 = new Customer();
    C2.C_ID = 121;
    C2.C_age = 30;
    C2.C_name = "Bob";

    C1.PrintInfo();
    C2.PrintInfo();

    C1.UpdateID(220);
    C1.PrintInfo();

    C2.UpdateID(221);
    C2.PrintInfo();

    C1.CompareAges(C2);
  }
}
public class Customer
{
  private int c_id;
  public int C_ID
  {
      get { return c_id; }
      set { c_id = value; }
  }
  public string C_name { get; set; } = string.Empty;
  public int C_age { get; set; } = 0;
  public Customer(int c_age, string c_name)
  {
      this.C_age = c_age;
      this.C_name = c_name;
  }
   public void PrintInfo()
   {
       System.Console.WriteLine($"Customer: {C_ID}, name: {C_name}, age: {C_age}");
   }
  public void UpdateID(int new_id)
  {
   C_ID = new_id;
  }
   public Customer()
   {
   }
  public void CompareAges(Customer objCustomer)
  {
       if (this.C_age >= objCustomer.C_age)
       {
           Console.WriteLine($"{this.C_name} is older.");
       }
       else
       {
           Console.WriteLine($"{objCustomer.C_name} is older");
       }
  }
}
