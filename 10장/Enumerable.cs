using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10장
{
    class MyList2 : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList2()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get { return array[index];}
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                }
                array[index] = value;
            }
        }

        public object Current
        {
            get
            {
                return array[position];
            }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    internal class Enumerable
    {
        static void Main()
        {
            MyList2 list = new();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
