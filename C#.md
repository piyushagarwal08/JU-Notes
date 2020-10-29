# C#
* To Start with C#, we would need an ```IDE``` like ```Visual Studio 2019``` with ```.net Desktop Environment```
* Start with a new project with ```C# console app```

* A simple print statement would be ```Console.WriteLine("Any-Text")```
* ```Console.WriteLine``` always prints in a new line
* ```Console.Write``` is used to continue text in same line
* The default input type taken using ```ReadLine``` is ```System.String```

```c#
using System; // default required module

namespace Giraffe // namespace name - same as file name
{
    class Program // class name
    {
        static void Main(string[] args)  // Main function
        {
            Console.WriteLine("    /|"); // Simple print statement
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /___|");
        }
    }
}
```

## Variables
* In C# we can concatenate just string any integer easily without need of any explicit type conversion
```c#
using System;

namespace Giraffe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            String variableName = "Piyush";
            int age = 35;
            Console.WriteLine("hey " + variableName + ",Is your age " + age);
            age -=23;
            Console.WriteLine(age); // 12
        }
    }

}
```

## DataTypes
* For string, we have ```string var-name = "any text";```
* For char, we have ```char var-name = 'any-single-character';```
* For integer, we have ```int var-name = value;```
* ```decimal``` very precise data-type, one could think to use for calculation of money/amount
* For double, we have ```doube var-name  = 3.0m```
* For float, we have syntax as ```float var-name = 4.45454f```
* we have got ```bool``` as ```bool var-name=true or false```

```c#
using System;

namespace Giraffe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Pykid is awesome";
            char grade = 'A';
            int age = 34;
            float age1 = 34.87847f;
            double gpa = 9.8;
            decimal gpa1 = 9.445m;
            bool isMale = true;
            Console.WriteLine(phrase+" who belongs from grade "+grade+Environment.NewLine+"with age of "+age+" and having an gpa of: "+gpa+Environment.NewLine+"he is: "+isMale+Environment.n);
        }
    }
}
```

## String Functions
1. ```Length``` -> find the length of string
2. ```toUpper()``` -> converts the string to upper case 
3. ```toLower()``` -> converts the string to lower case
4. ```Contains``` -> gives an boolean value wrt to existance of substring in main string
5. ```IndexOf``` -> index position of first occurrence of any character and if doesn't exist it will return ```-1```
6. ```Substring``` -> 2 arguments will be taken, ```starting index``` and ```length of string```
```c#
using System;
using System.Linq;

namespace Giraffe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "hello pykid";
            Console.WriteLine(phrase.IndexOf("ello"));
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("pyk"));
            Console.WriteLine(phrase.Substring(4,3));
        }
    }

}
```

## Numbers
* Just like C, C# also follows data-type conersion flow
* That is in simple terms ```5/3``` is ```1``` where as ```5.0/3``` is ```1.666666667```
* There are many usefull math functions which can be used such as:
    1. ```Math.sqrt```
    2. ```Math.Max```
    3. ```Math.Round```
```C#
using System;
using System.Linq;

namespace Giraffe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Max(4, 20));
            Console.WriteLine(Math.Round(3.3433));
        }
    }

}
```

## Getting User Input
* To read any text of input, we use ```Console.ReadLine()```

```c#
using System;
using System.Linq;

namespace Giraffe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }
    }
}
```
* For inputs of type integer, we can do type conversion from string to integer using ```Convert.toInt32```
* ```Convert``` function can be used for multiple conversions between different data-types


## Arrays
* To use arrays in C#, the syntax is ```data-type[] array-name = {initialize with values}```
```c#
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
            int [] integer_Arr = { 1, 2, 3, 2, 1 };
            string[] string_Arr = { "hello", "hi" };
            Console.WriteLine(integer_Arr[0]);
            Console.WriteLine(string_Arr[0]);
        }
    }
}
```

## Methods
* All the methods in C# should start with ```static``` keyword
* Its best practice to start method names with ```Capital Letters```
* Methods are same as in all other languages
```c#
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
            Console.Write("Enter your name: ");
            Greet(Console.ReadLine());
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hii " + name);
        }
    }
}
```

## Conditionals
* The if-else syntax is same as in C
```c#
using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            char x = Convert.ToChar(Console.ReadLine());
            
            if (x == 'A')
            {
                Console.WriteLine("First if condition" + x);
            }
            else if (x == 'B')
            {
                Console.WriteLine("Second if statement" + x);
            }
            else
                Console.Write("Enter your Name:");
                Console.WriteLine("Your name is: " + Console.ReadLine());
        }
    }
}
```
* The logical operators are also same as:
    1. ```And``` -> ```&&```
    2. ```Or``` -> ```||```
    3. ```not``` -> ```!```

* using terniary operator in C#, is
```c#
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
```
