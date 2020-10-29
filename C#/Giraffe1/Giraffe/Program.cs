using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(5, 7));
            
        }

        static int GetMax(int a,int b)
        {
            return a > b ? a : b;
        }
    }
}