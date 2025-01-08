namespace _10장
{
    internal class ArraySample
    {
        static void MainArraySample(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int a in scores)
            {
                Console.WriteLine(a);
            }

            int sum = 0;
            foreach (int a in scores)
            {
                sum += a;
            }
            int average = sum / scores.Length;
            Console.WriteLine(average);
        }
    }
}
