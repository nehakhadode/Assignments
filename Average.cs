using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1stAssignment
{
    internal class Average
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, total, avg;

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            n3 = Convert.ToInt32(Console.ReadLine());

            total = n1 + n2 + n3;
            avg = total / 3;
        }
    }
}
