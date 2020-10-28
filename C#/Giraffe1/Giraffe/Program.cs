using System;
using System.Linq;
using System.Numerics;
using Microsoft.VisualBasic.CompilerServices;

namespace Giraffe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x + 6);
            Console.WriteLine(Console.ReadLine().GetType());
            
        }
    }
}
