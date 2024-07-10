class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Employee(string name, int age, int number, int salary) : Person(name, age)
{
    public int Number { get; set; } = number;
    public int Salary { get; set; } = salary;

    public new void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Number: " + Number);
        Console.WriteLine("Salary: " + Salary);
    }

}

class Programmer(string name, int age, int number, int salary, string job) : Employee(name, age, number, salary)
{
    public string Job { get; set; } = job;

    public new void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Number: " + Number);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Job: " + Job);
    }
}

class Task4
{
    public static void Run()
    {
        Person p = new("John", 25);
        Employee e = new("Jane", 30, 123, 50000);
        Programmer pr = new("Jack", 35, 456, 70000, "Software Developer");

        p.Display();
        e.Display();
        pr.Display();
    }
}