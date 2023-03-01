using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ulong> numbers=new List<ulong>();

            numbers.Add(1); 
            numbers.Add(1);

            Console.Write("Koe pored chislo na Fibonachi iskash da ti izchislq?");
            byte numFib=byte.Parse(Console.ReadLine()); 
            for (int i = 2; i < numFib; i++)
            {
                numbers.Add(numbers[i - 2] + numbers[i-1]);
            }
            Console.WriteLine(string.Join(",",numbers));
        }
    }
}
