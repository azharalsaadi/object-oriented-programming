namespace object_oriented_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine($"please enter emp {i} First Name :");
                emp[i].Fname = Console.ReadLine();


                Console.WriteLine($"please enter emp {i} Last Name :");
                emp[i].Lname = Console.ReadLine();

                Console.WriteLine($"please enter emp {i} Wage (Rate per hour) :");
                emp[i].Wage = Decimal.Parse(Console.ReadLine());

                Console.WriteLine($"please enter emp {i} Logged Hours (Working hour) :");
                emp[i].LoggedHours = double.Parse(Console.ReadLine());
            }
            foreach (Employee item in emp)
            {
                decimal NetSalary = (item.Wage * (decimal)item.LoggedHours) - (item.Wage * (decimal)(item.LoggedHours * Employee.TAX));
                Console.WriteLine($"Employee {item.Fname} : Net Salary is {NetSalary}");

            }
        }
    }
}
