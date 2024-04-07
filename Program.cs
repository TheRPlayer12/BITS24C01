using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits__24_C01
{
    internal class Program
    {
        static int Lcm(int[] nums)
        {
            return nums.Aggregate((x, y) => x * y / Gcd(x, y));
        }

        static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return Gcd(b, a % b);
        }

        static void Main()
        {
            Console.WriteLine("Welcome to LCM finder :)");
            Console.Write("Enter the numbers you want to find the LCM of separated with spaces- ");

            int[] numbers = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("LCM of {0} is {1}", string.Join(", ", numbers), Lcm(numbers));
            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}
