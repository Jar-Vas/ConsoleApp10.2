using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Array : IOutput, IMath, ISort
    {
        private int[] Arr { get; set; }

        public Array(int[] arr)
        {
            Arr = arr;
        }

        public void Show()
        {
           foreach (int i in Arr)
           {
               Console.Write(i + " ");
           }
           Console.Write("\n");
        }

        public void Show(string s)
        {
           Console.WriteLine("Descroption" + s);
           foreach (int i in Arr)
           {
               Console.Write(i + " ");
           }
           Console.Write("\n");
        }

        public int Max()
        {
            int max = Arr[0];
            foreach (int i in Arr)
            {
                max = Math.Max(max, i);
            }
            return max;
        }

        public int Min()
        {
            int min = Arr[0];
            foreach (int i in Arr)
            {
                min = Math.Min(min, i);
            }
            return min;
        }

        public float Avg()
        {
            long sum = 0;
            foreach(int i in Arr)
            {
                sum += i;
            }
            return sum / Arr.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int i in Arr)
            {
                if (i == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            Arr.Sort();
        }

        public void SortDesc()
        {
            Arr.Sort();
            Arr.Reverse();
        }
        public void SortByParam(bool t)
        {
            Arr.Sort();
            if (t) { Arr.Reverse(); }
        }














    }
}
