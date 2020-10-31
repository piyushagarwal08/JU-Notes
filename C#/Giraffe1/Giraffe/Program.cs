using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Giraffe
{

    class Program
    {
        //UsefulTools obj1 = new UsefulTools();
        
        public static void Main(string[] args)
        {
            UsefulTools ob1 = new UsefulTools();
            ob1.Func1();
            
            Book ob2 = new Book("title", "author", 232);
            ob1.Func2();
        }
    }
}