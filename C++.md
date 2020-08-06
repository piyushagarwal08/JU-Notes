# FacePrep
# C++ 

* Hello world program
```c++
#include<iostream>
int main()
{
    std::cout<<"Hello World";
}
// Hello World
```
* Multiple Semicolons means no operation, as in they're empty statements
* Identifier ~> Names of variables,class or functions which could be a long sequence of digits,lowercase and uppercase letters and digits
* Keywords are collectiojns of reserved words and predefined identifiers
* maximum length considered is 31 characters

```c++
#include<iostream>
int main() // main is a predefined identifier not an keyword
{ 
    int main=10;  // common identifier
    std::cout<<main; // 10 will be printed
}
```
* There are 95 keywords in C++

<img src="trigraph_sequence.png">

* In modern compilers, trigraph features are disabled by default
* Generally, C++ compiler ignores the white-spaces
* We can comment also as``` // any comment \ move to next line```
* In all web-based compilers, 0 is assigned to an uninitialized local variable by default. But, in the offline compiler(Dev C++, Turbo C), garbage value is assigned to an uninitialized local variable 
* To String as input we use the code as
```c++
#include<iostream>
using namespace std; // used to declare string datatype
int main()
{
    string x;
    getline(cin,x); // takes a complete line as input
    std::cout<<x;
}
```
* To access global variables we use ```::``` as ```cout<<::global-variable-name;```
* Integer literal prefixes representation:
    1. Decimal ~> 63,23,231
    2. Octal ~> 077, 043, 076 (0 to 7)
    3. Hexadecimal ~> 0x3F, 0x4A (0 to 9 and A to F)
    4. Binary Integer literal ~> 0b011, 0b100
* Adding u or U as a suffix, modifies the integer data-type into unsigned int.
* the suffix l or L indicated the literal and long integer literal. To denote unsigned long int, the suffix to be used is ul or UL. Adding a l or L will make it unsigned long long int.
* Floating point literals are used to represent and store real numbers
* The suffix f or F indicates a type of float, and the suffix l or L indicates a type of long double. If a suffix is not specified, the floating-point constant has a type double.

```c++
#include<iostream>
int main()
{
    float f=54E; // error as there are no digits after E
    std::cout<<f;
}
```
* Carriage Return (\r) ~> Going back to the start of line deleting everything in betweem
* To store multiple characters in a variable we can use, ```std::string variable-name```

```c++
#include<iostream>
int main()
{
    std::cout<<"\"Hi "
    "all " "can you tell""me, what I will print\"";
}
// "Hi all can you tellme,what I will print"
```

```c++
#include<iostream>
int main()
{
    bool isTrue=true;
    bool isFalse=false;
    std::cout<<"This PRINTS " << isTrue << "\n";
    std::cout<<"And this prints " << isFalse << "\n";
}
// This PRINTS 1 \
And this prints 0
```
* ```const``` keyword can be used as a prefix to declare constants of the particular type
```const data-type variable_name = value;```
* constants in C++ can be defined using ```#define and const```
* syntax is ```#define identifier replacement``` and ```#define``` is a preprocessor directive
* A ```modifier``` is used to alter the meaning of the base type so that it more precisely fits the needs of various situations also called ```data modifiers```
* ```Data modifiers``` can alter the length of basic data types

* Integer Type Modifiers:
<table>
<tr><td>Type</td><td>Size</td><td>Range</td></tr>
<tr><td>short</td><td>2</td><td>-32768 to 32767</td></tr>
<tr><td>unsigned short</td><td>2</td><td>0 to 65535</td></tr>
<tr><td>signed short</td><td>2</td><td>same as short</td></tr>
<tr><td>int</td><td>4</td><td>-32768 to 32767</td></tr>
<tr><td>unsigned int</td><td>4</td><td>0 to 65535</td></tr>
<tr><td>signed int</td><td>4</td><td>Same as int</td></tr>
<tr><td>long</td><td>8</td><td>-2147483648 to 2147483647</td></tr>
<tr><td>unsigned long</td><td>8</td><td>0 to 4294967295</td></tr>

<tr><td>signed long</td><td>8</td><td>Same as long</td></tr>
</table>

* Character Type Modifiers ~> char is neither signed nor unsigned
* Floating-point Type Modifiers:
    1. Float - size:4 - precision:7
    2. Double - size:8 - precision:15
    3. long double - size:12 - precision:19
* If no data type is given to a variable after type modifier, then compiler automatically converts it to int data type
* We can't use any modifiers in float data type.If programmer tries to use it, the compiler automatically gives compile time error
* only ```long``` modifiers are allowed for ```double``` data type

* ```typedef``` allows you to create a new name for an existing data type, ```typedef type name```
example: ```typedef int awesome```

* enumeration:  
    1. Syntax ```enum enum_variable{state=0,state=1,...}```
    2. only blue-print is created from above code
    3. to create a variable ```enum enum-name variable-name```
    4. another way is ```enum enum_variable{state=0,state=1,...}variable-name```
```c++
#include<iostream>
enum season{spring,summer,autumn,winter}; // 0,1,2,3
int main()
{
    season climate;
    climate=summer //1
    std::cout<<"Climate = "<<climate; 
    // Climate = 1 
}
```
* All variables will be in an ```auto``` storage class until we define a storage class with a different scope

## Storage Class
* Storage classes provide information like visibility/scope of the variable in a program, memory location of a variable in memory, default value and it's lifetime.
* Supported types are:
    1. ```auto``` :
        * Default storage class
        * Lifetime: inside the block
        * Default value: garbage value
        * Example: int var; or autp int var;
    2. ```register```:
        * stored in CPU registers to allow fast access
        * Lifetime: inside the block
        * Default value: garbage
        * Example: register int var;
    3. ```static```:
        * Scope: local to the function
        * Lifetime: through out the program
        * Default value: 0
        * Example: static int var;
    4. ```extern```:
        * Global scope
        * Lifetime: throughout the program
        * Default value: 0
        * Example: extern int var;
        * while defining extern variable in a function or a block, it should not be initialized.It's because of linkage issues, which we will discuss later in the upcoming lessons
        
    ```c++
    #include<iostream>
    #include "extern_var_pgm.cpp"
    extern int count=1 //declaration of variable count

    int main()
    {
        cout <<"count: " <<count<<endl; // count: 1
        incrementCount(); // count gets 2
        cout<<"count: "<< count <<endl; // count: 2
        return 0;
    }

    // file : extern_var_pgm.cpp
    int count = 7;
    void incrementCount()
    {
        count = count +1;
    }    
    ``` 
    5. ```mutable```:
        * Only applicable to class data members
        * used to restrict the modification



