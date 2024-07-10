class Task2
{
    /// <summary>
    /// Add two integers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>int</returns>
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static string Add(string a, string b)
    {
        System.Text.StringBuilder sb = new(a);
        sb.Append(b);

        return sb.ToString();
    }

    public static void Run()
    {
        int a = int.Parse(Console.ReadLine() ?? "");
        int b = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine(Add(a, b));
        Console.WriteLine("Hello World");
    }
}
