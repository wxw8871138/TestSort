using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 32, 34, 29, 0, 4, 9 };
            for (int i = 0; i < a.Length-1; i++)
            {
                for(int j = i+1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int k = 0; k< a.Length; k++)
            {
                Console.Write(a[k] + " ");
            }
        }
    }
}
