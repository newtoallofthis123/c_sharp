using System.Text;

class Task6
{
    public static void Run()
    {
        String name = "John";
        name = String.Concat("Name: ", name);

        StringBuilder sb = new("Name: ");
        sb.Append("John");

        Console.WriteLine(name);
        Console.WriteLine(sb.ToString());
    }
}