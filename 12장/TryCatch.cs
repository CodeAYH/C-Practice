namespace _12장
{
    internal class TryCatch
    {
        static void MainTryCatch(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            } catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
