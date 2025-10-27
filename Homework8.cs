namespace Lecture10Work;

class Program
{
    static void Main(string[] args)
    {
     Customer cus1 = new Customer(cusName: "Alice", cusAge: 33, cusCity: "Amarillo", cusCredit: 198.5);
     Customer cus2 = new Customer(cusName: "Bob", cusAge: 23, cusCity: "Amarillo", cusCredit: 226.0);
     Customer cus3 = new Customer(cusName: "Cathy", cusAge: 45, cusCity: "Amarillo", cusCredit: 89.0);
     Customer cus4 = new Customer(cusName: "David", cusAge: 58, cusCity: "Amarillo", cusCredit: 198.5);
     Customer cus5 = new Customer(cusName: "Jack", cusAge: 28, cusCity: "Canyon", cusCredit: 561.6);
     Customer cus6 = new Customer(cusName: "Tom", cusAge: 36, cusCity: "Canyon", cusCredit: 98.4);
     Customer cus7 = new Customer(cusName: "Tony", cusAge: 24, cusCity: "Canyon", cusCredit: 18.5);
     Customer cus8 = new Customer(cusName: "Sam", cusAge: 35, cusCity: "Canyon", cusCredit: 228.3);
     Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };
     TotalCredit(customer_list);
     AverageAge(customer_list);
     CanyonAgeOver30(customer_list);
 }
public static void TotalCredit(Customer[] customer_list)
{
    double totalCredit = 0;
    foreach(Customer cusItem in customer_list)
    {
        totalCredit += cusItem.cusCredit;
    }
    Console.WriteLine($"The total credits: {totalCredit}");
}
public static void AverageAge(Customer[] customer_list)
{
    double totalAge = 0;
    int countCus = 0;
    foreach (var cusItem in customer_list)
    {
        if (cusItem.cusCity == "Amarillo")
        {
            totalAge += cusItem.cusAge;
            countCus++;
        }
    }
    if (countCus > 0)
    {
        double averageAge = totalAge / countCus;
        Console.WriteLine($"The average age in Amarillo is: {averageAge}");
    }
}
public static void CanyonAgeOver30(Customer[] customer_list)
  {
        Console.Write("Customers who live in Canyon and over 30 years old: ");
    foreach (var cusItem in customer_list)
    {
        if (cusItem.cusAge > 30 && cusItem.cusCity == "Canyon")
        {
                Console.Write($" {cusItem.cusName}. ");
        }
    }
  }
//Customers who live in Canyon and over 30 years old: Tom, Sam,
}
class Customer
{
public string cusName { get; set; } = string.Empty;
public double cusAge { get; set; } = 0;
public string cusCity { get; set; } = string.Empty;
public double cusCredit { get; set; } = 0;
public Customer(string cusName, double cusAge, string cusCity, double cusCredit)
{
   this.cusName = cusName;
   this.cusAge = cusAge;
   this.cusCity = cusCity;
   this.cusCredit = cusCredit;
}
}

