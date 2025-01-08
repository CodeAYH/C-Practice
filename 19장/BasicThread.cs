namespace _19장
{
    internal class BasicThread
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
        static void MainBasicThread(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Starting thread...");
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main: {i}");
                Thread.Sleep(5);
            }

            Console.WriteLine("Wating until Thread stops");
            t1.Join();
            Console.WriteLine("Finished");
        }
    }
}
