using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09장
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    record RTransaction3
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
    internal class RecordComp
    {
        static void MainRecordComp()
        {
            CTransaction trA = new CTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100

            };

            CTransaction trB = new CTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine(trA.Equals(trB));

        }
    }
}
