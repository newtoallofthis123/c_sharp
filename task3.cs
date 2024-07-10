class EmployeeClass(string name, int number, int salary)
{
    public string name = name;
    public int number = number;
    public int salary = salary;

    /// <summary>
    /// Display employee details
    /// </summary>
    /// <returns></returns>
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Salary: " + salary);
    }
}

class Task3
{
    public static void Run()
    {
        Console.WriteLine("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine() ?? "");
        EmployeeClass[] employees = new EmployeeClass[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Enter salary: ");
            int salary = int.Parse(Console.ReadLine() ?? "");
            employees[i] = new(name, number, salary);
        }

        for (int i = 0; i < n; i++)
        {
            employees[i].Display();
        }
    }
}
