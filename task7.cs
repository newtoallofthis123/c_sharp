class Task7
{
    // Program to demo
    // 1. Creating a thread
    // 2. Managing a thread
    // 3. Deleting a thread
    public class Hello
    {
        public void MyThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread is running: " + i);
                Thread.Sleep(1000);
            }
        }
    }

    public static void Run()
    {
        Hello hello = new();

        Thread th = new(new ThreadStart(hello.MyThread));
        th.Start();

        Console.WriteLine("Main thread is running");

        th.Join();

        Console.WriteLine("Main thread is finished");

        // th.Abort();
    }
}
