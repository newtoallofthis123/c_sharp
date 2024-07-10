using System.Text;

namespace c_sharp;

/// <summary>
///  Checks if the given number is a palindrome.   
/// </summary>
class Task1
{
    public static void Run()
    {
        string input = Console.ReadLine() ?? "";
        int num = int.Parse(input);
        int temp = num, sum = 0, r = 0;
        while (num > 0)
        {
            r = num % 10;
            sum = (sum * 10) + r;
            num /= 10;
        }

        if (temp == sum)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}