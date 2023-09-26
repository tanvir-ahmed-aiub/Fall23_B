using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Program
    {
        static int Add(params int[] a) {
            var sum = 0;
            for (int i = 0; i < a.Length; i++) {
                sum += a[i];
            }
            return sum;
        }
        
        static void Main(string[] args)
        {

            
            Add(11, 12);
            Console.WriteLine("Hello " + Add(11,2,4,3,45,35,3,5));
        }
    }
}
