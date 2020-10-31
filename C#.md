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
* To get the length of array, we can use ```Array-name.Length```
* For ```2-D Array```, we have got different syntax
```c#
using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            // [,] denotes 2-d array
            int[,] numberGrid = {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {8,9,10,11,12}
            };

            //foreach loop will print all the elements as
            foreach (int arr in numberGrid)
                Console.WriteLine(arr);

            Console.WriteLine(numberGrid[2,3]);
        }
    }
}
```
* For ```3-D Array```, the syntax gets a little different
```c#
using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            int[,,] numberGrid = {
                {
                    {1,2},{2,3}
                },
                {
                    {2,3},{3,4}
                }
            };

            Console.WriteLine(numberGrid[0,1,1]);
        }
    }
}
```
* Basically, the number of ```Semi-colons ,``` represent the ```dimension of array```
    1. 2-D Array -> ```[,]```
    2. 3-D Array -> ```[,,]```
    3. 4-D Array -> ```[,,,]```
* To just initialize the array object, we can do so by ```data-type[dimesnion] var-name = new data-type[row,column]```

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
* Switch Statements in ```C#``` is same as that in ```C```
```c#
using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(Console.ReadLine()));

        }

        static int GetDay(string dayNum)
        {
            switch(dayNum)
            {
                case "Monday":
                    return 0;
                case "Tuesday":
                    return 1;
                case "Wednesday":
                    return 2;
                case "Thursay":
                    return 3;
                default:
                    return -1;
            }
        }
    }
}
```

## Loops
1. ```While Loop```
```c#
using System;

namespace Loops
{
    class Program
    {
        static void Main(String[] args)
        {
            while(condition)
            {
                //.. statements to be executed

                // termination condition
            }
        }
    }
}
```
2. ```Do-While Loop```
```c#
using System;

namespace Loops
{
    class Program
    {
        static void Main(String[] args)
        {
            do
            {
                //.. statements to be executed

                // termination condition
            }while(condition)
        }
    }
}
```
3. ```For Loop```
```c#
using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            for (initial condition; termination condition;Increment/Decrement)
            {
                //..Set of statements
            }
        }

    }
}
```
4. ```Foreach Loop```
```c#
using System;
namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            foreach(data_type var_name in iterative_dataStructure)
                {
                    //.. Set of Statements
                Console.WriteLine(item);
            }
        }
    }
}
```

## Exception Handling
* Exception can be handled by using ```Try-Catch``` block
* It can also be followed by ```finally``` block, which is always executed
```c#
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int num1 = 5;
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(num1/num2);

            }
            catch(System.DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.Write("Awesome "+e.ToString());
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("I am finally block");
            }
        }
    }
}
```

## Classes and Objects
* To create a class ```right-click``` on ```project-name``` and click on ```add``` then ```new item``` and select ```Class```
* To create an ```instance``` of class, ```class-name object-name = new class-name();```
```c#
// Main Program Class
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            Book obj1 = new Book();
            obj1.author = "Pykid";
            obj1.title = "Pykid way of C#";
            obj1.pages = 434;
            obj1.Display();
        }
    }
}

// Book Class
using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public void Display()
        {
            Console.WriteLine("Title: " + title + Environment.NewLine +
                "Author: "+author+Environment.NewLine+
                "Page Count: "+pages);
        }
    }
}
```
* Constructors are methods with same name as class and are called whenever an object is created
```c#
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        // Constructor of class 
        public Book(string aTitle,string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        
        public void Display()
        {
            Console.WriteLine("Title: " + title + Environment.NewLine +
                "Author: "+author+Environment.NewLine+
                "Page Count: "+pages);
        }
    }
}
```
* To Remember that, arguments name for constructor can not be same as variable names of class
* More then one constructor can be created inside of a class


## Getters and Setters
* These are methods that can be used in the classes
* Used for more secure classes and validate the type of data that can be passed
* These are functions/methods that we can use to check if value assigned through an object is a validated statement or not based on conditions
* We can use this function, to make sure that proper value is provided as input
```c#
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Giraffe
{
    class Book
    {
        private string title; // not accessible by anyone other then methods inside class
        public string author;
        public int pages;
        // Constructor of class 
        public Book(string aTitle,string aAuthor,int aPages)
        {
            Title = aTitle; // this is going to call the Title Method declared below
            author = aAuthor;
            pages = aPages;
        }

        // () are not used here, as its not really an method
        public string Title 
        {
            get { return title; } // used to return value to when function is called
            set
            {
                // obj1.Title or new Book("asas","sasa",232)
                if (value == "Piyush") // value is here a variable which automatically fetches the data set by object
                {
                    title = value; // value for private variable will be set
                }
                else
                    title = "Pykid";
            }
            
        }

        public void Display()
        {
            Console.WriteLine("Title: " + title + Environment.NewLine +
                "Author: "+author+Environment.NewLine+
                "Page Count: "+pages);
        }
    }
}

// Main Function
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        {
            Book b1 = new Book("Pimp", "assa", 232);
            b1.Display();
        }
    }
}
```

## Static Class Attribute
* Attribute which is same for all the objects of the class
* It is basically an attribute of class and not of object
* It can be called using ```Class-name.static-variable-name``` but can not be accessed using objects
* To access using objects, we would need to use method for the same


## Static Methods & Classes
* Static Method refers to methods that belongs to a class
* These methods are declared as ```public static return-type method_name(){}```
* To prevent one from creating object a class, we just need to make the ```class static```
```static class class-name```
* We can not create the object of an static class

## Inheritance
* Inheritance is the property of OOPS which allows one class to inherit the functions and methods of another class o r basically inheriting the properties of another class
* In Base class, we can make any function as ```virtual``` to make it possible for child classes to over ride the method with syntax ```public override return-type func-name(){}```
* To inherit another class, syntax is ```class Class-name : class-name-to-be-inherited```