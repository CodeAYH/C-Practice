namespace _14장
{
    internal class SimpleLambda
    {
        delegate int Calculate(int a, int b);

        static void MainSimpleLambda(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 4));
        }
    }
}
