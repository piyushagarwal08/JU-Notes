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


```c++
#include<iostream>
using namespace std;
int main()
{
  int a,b;
  std::cin>>a>>b;
  std::cout<<"a+b="<<a+b<<endl;
  std::cout<<"a-b="<<a-b<<endl;
  std::cout<<"a*b="<<a*b<<endl;
  std::cout<<"a/b="<<a/b<<endl;
  std::cout<<"a%b="<<a%b<<endl;
  return 0;
}
```
```cpp
#include<iostream>
int main()
{
    int a =2;
    int b=9;
    std::cout<<((b=2)==a); // 1
}
```
```cpp
#include <iostream>
int main()
{
  int a=9, b=1, c=3;
  int result1=((a==9)||(b=3));  // 1 || b=1
  std::cout<<"Result1 : "<<result1<<" b : "<<b; // Result1 : 1 b : 1
  int result2=((b>c)&&(c=0));  // 0 && c=3
  std::cout<<"\nResult2 : "<<result2<<" c : "<<c;  // Result2: 0 c 3
}
```

* Integers are of two types:
    1. Positive ~> Stored as Binary Representation
    2. Negative ~> 2's complement
* To Calculate 2's complement ~ convert 1 to 0 and vice versa, add 1 to it and set - sign in front

```cpp
#include<iostream>
int main(){
  int a = 13, b = 45;
  a++; // 14
  b--; // 44
  int c = (++a) + (b--); // c = 14 + 44
  std::cout<<a<<" "<<b<<" "<<c; // 14 , 43, 59
}
```

* Miscellaneous Operators
    1. Sizeof Operator:
        * Unary operator
        * can have a variable or a data-type as an operand
        * returns the size of the operand
    2. Comma Operator
        * Used to separate two or more expressions that are included where only one expression is expected
        * Example: a=(b=3,b+2) // a=5 b = 3
    3. Explicit type-cast operator
        * Converts a value of one type to another data-type
        * x=int(y) , if y is of type float
        * x = int(y) , if y is of type float
    4. Ternary Operator
        * Evaluates one expression, either results in true or false
        * condition?true-expression:false-expression
        * example: ```(7==5)?std::cout<<"equal":std::cout<<"not equal";```

```cpp
#include<iostream>
int main()
{
    int x;
    std::cin>>x;
    x%2==0?std::cout<<"Possible":std::cout<<"Not possible";
    return 0;
}
```
* if two or more operators have same precedency then grouping is followed
```cpp
#include<iostream>
int main()
{
	int a = 10, b = 11, c = 3;
	std::cout << ++a + 2 * b++ / c;
    // 11 + 2 * 11 / 3 \
    11 + 22 / 3 \
    11 + 7 = 18

	return 0;
}
```
```cpp
#include<iostream>
int main()
{
	int a = 1, b = 2, c;
	c = a << b >> 1; 
    // 4 >> 1 ~> c =2
	std::cout<<c;
	return 0;
}
```
* The Newspaper Agency
```cpp
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  // w is no of copies sold and x is cost per copy and y cost agency spends
  
  int w,x,y,result;
  std::cin>>w>>x>>y;
  result = w*x - w*y - 100;
  std::cout<<result;
  return 0;
}
```

```cpp
#include<iostream>
using namespace std;

float round(float var)
{
  float value = (int)(var*100 + 0.5);
  return (float)value/100;
}

int main()
{
  //Type your code here.
  // discount is of 2 % on interest
  int x ;// x =  principal amount borrowed by alice
  int r; // r = rate of interest
  int y; // y - time for interest in years
  float si,amount,discount,result;
  std::cin>>x>>r>>y;
  si = (x*r*y)/100;
  amount = si+x;
  discount = 0.02*(si);
  result = amount-discount;
  std::cout<<round(si)<<"\n"<<round(amount)<<"\n"<<round(discount)<<"\n"<<round(result)<<endl;
  
  return 0;
}
```
* to find square root, we have to use ```cmath``` preprocessing directive
* Hop n Hop
```cpp
#include<iostream>
#include<cmath> // used for sqrt function
using namespace std;
int main()
{
  //Type your code here.
  int x,y,r;
  std::cin>>x>>y;
  r = sqrt((x-3)*(x-3) + (y-4)*(y-4));  // finds the perpendicular distance between 2 points
  std::cout<<r;
  return 0;
}
```

```cpp
#include<iostream>
int main(){
  int x = 67;
  if(x=10) // 10 is assigned to x
    std::cout<<x;  // print 10
}
```

```cpp
#include<iostream>
int main()
{
  int b = 0;
  if(b++) // b is 0
    std::cout<<"Yahoo!";
  else if(++b) // b is 2
    std::cout<<"Wow!";  // printed
  else
    std::cout<<"Yay!";
}
```

```cpp
// leap year
#include <iostream>
using namespace std;
/*
If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
If the year is evenly divisible by 100, go to step 3. Otherwise, go to step 4.
If the year is evenly divisible by 400, go to step 4. Otherwise, go to step 5.
The year is a leap year (it has 366 days).
The year is not a leap year (it has 365 days).
*/
int main() 
{
   // Try out your code here
    int y;
  std::cin>>y;
  if(y%4==0)
  {
    if(y%100==0)
    {
      if(y%400==0)
        std::cout<<"Vicky can celebrate his birthday.";
      else
        std::cout<<"Vicky can't celebrate.";
  	}
    else
      std::cout<<"Vicky can celebrate his birthday.";
  }
  else
    std::cout<<"Vicky can't celebrate.";
  return 0;
}
```

* Expression in switch case can only be int,short,char.
* Switch does not work for float
* ```fallthrough``` is a condition that occurs when break is not used.

```cpp
//Gardening
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int r,c,t;
  std::cin>>r>>c>>t;
  if(t>r && t<=2*r)
    std::cout<<"It is a mango tree";
  else if(t<=r*(c-1) && t > r*(c-2))
    std::cout<<"It is a mango tree";
  else
    std::cout<<"It is not a mango tree";
  return 0;
}
```

```cpp
// Cricket
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int nb,tr,rs,bb,overs;
  float of,trr,crr;
  overs = nb/6;
  of = bb/6 + (bb%6)/10;
  crr = rs/of;
  trr = (float)tr/overs;
  std::cout<<overs<<"\n"<<of<<"\n"<<crr<<"\n"<<trr<<endl;
  if(crr > trr)
    std::cout<<"Elgible to Win";
  return 0;
}
```

```cpp
//game with shapes
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  // x ~> radius of circle , y~> length of square
  int x,y;
  std::cin>>x>>y;
  if(2*x<=y)
    std::cout<<"circle can be inside a square";
  else
    std::cout<<"circle cannot be inside a square";
  return 0;
}
```

```cpp
//boating
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  /* x ~> weight that boat can handle
  	 y ~> number of adults (75kg per person)
     z ~> number of children (30kg per person)
     */
  int x,y,z;
  std::cin>>x>>y>>z;
  if(x>= (y*75 + z*30))
    std::cout<<"Boat is stable";
  else
    std::cout<<"Boat will drow";
  return 0;
}
```

```cpp
//Car mileage
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  float x; //mileage
  int y,z; // litres of petrol, distance to travel
  std::cin>>x>>y>>z;
  x*y>=z?std::cout<<"Can reach":std::cout<<"Cannot reach";
  return 0;
}
```

```cpp
// Age detector
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int x,y;
  std::cin>>x>>y;
  if(y>x)
    std::cout<<y-x<<endl;
  else
    std::cout<<(100+y)-x<<endl;
  return 0;
  
}
```

```cpp
//online shopping
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int amount_of_shirt,discount_offered,shipping_charges; // flipkart
  int amount_of_shirt1,discount_offered1,shipping_charges1; //snapdeal
  int amount_of_shirt2,discount_offered2,shipping_charges2; // amazon
  int F,S,A;
  std::cin>>amount_of_shirt>>discount_offered>>shipping_charges>>amount_of_shirt1>>discount_offered1>>shipping_charges1>>amount_of_shirt2>>discount_offered2>>shipping_charges2;
  F = amount_of_shirt+shipping_charges-(discount_offered*amount_of_shirt)/100;
  S = amount_of_shirt1+shipping_charges1-(discount_offered1*amount_of_shirt1)/100;
  A = amount_of_shirt2+shipping_charges2-(discount_offered2*amount_of_shirt2)/100;
  std::cout<<"In Flipkart Rs."<<F<<"\n"<<"In Snapdeal Rs."<<S<<"\n"<<"In Amazon Rs."<<A<<endl;
  if(F <= A && F <= S)
    std::cout<<"He will prefer Flipkart";
  else if(A <= F && A <= S)
    std::cout<<"He will prefer Amazon";
  else if(S<=F && S<=A)
    std::cout<<"He will prefer Snapdeal";
  return 0;
  
}
```

```cpp
// microwave oven
#include<iostream>
#include<bits/stdc++.h>
using namespace std;
int main()
{
  //Type your code here.
  int n;
  float t;
  std::cin>>n>>t;
  if(n==2)
    std::cout<<fixed<<setprecision(2)<<t+ 0.5*t;
  else if(n==3)
    std::cout<<fixed<<setprecision(2)<<2*t;
  else if(n>3)
    std::cout<<"Number of items is more";
  else
    std::cout<<fixed<<setprecision(2)<<t;
  return 0;
}
```

```cpp
//matinee movie tickets
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int a;
  float t;
  std::cin>>a>>t;
  if(t>13 && t<16)
  {
    if(a > 13)
      std::cout<<"$5.00";
    else
      std::cout<<"$2.00";
  }
  else
  {
    if(a > 13)
      std::cout<<"$8.00";
    else
      std::cout<<"$4.00";
  } 
  return 0;
}
```

```cpp
//Treasure Finder
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int x,y,z;
  std::cin>>x>>y>>z;
  
  if(x>y && x<z || x>z && x<y) // x is second largest
    std::cout<<"The treasure is in box which has number "<<x<<endl;
  else if(y>x && y<z || y>z && y<x)
    std::cout<<"The treasure is in box which has number "<<y<<endl;
  else if(z>x && z<y || z>y && z<x)
    std::cout<<"The treasure is in box which has number "<<z<<endl;
  
  if(y%x==0 && z%x==0)
    std::cout<<"The code to open the box is "<<x;
  else if(z%y==0 && x%y==0)
    std::cout<<"The code to open the box is "<<y;
  else if(x%z==0 && y%z==0)
    std::cout<<"The code to open the box is "<<z;
  else
    std::cout<<"The code to open the box is "<<1;
  return 0;
}
```

```cpp
// mago tree - I
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int r,c,t;
  std::cin>>r>>c>>t;
  if(t<c || t%c==0)
    std::cout<<"Yes";
  else if((t-1)%c==0)
    std::cout<<"Yes";
  else
    std::cout<<"No";
  return 0;
}
```

```cpp
//sece dining
/*
front ~> r1 ~> left
front ~> r2 ~> right
rear ~> r1 ~> right
rear ~> r2 ~> left
Assume rail is attached with the wall
and if no rail is selected, then print based on door
*/
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  string s;
  int rail;
  getline(cin,s);
  std::cin>>rail;
  if(s=="front" && rail==1 || s=="rear" && rail==2)
    std::cout<<"Left Handed";
  else if(s=="front" && rail==2 ||  s=="rear" && rail==1)
    std::cout<<"Right Handed";
  else if(s=="front")
    std::cout<<"Right Handed";
  else
    std::cout<<"Left Handed";
  return 0;
}
```

```cpp
#include<iostream>
using namespace std;
int main()
{
  // Time Sheet
  //Type your code here.
  /*
  100 per hr
  +15 per hr if hr>8
  +25 per hr if hr >40 in one week
  +25% of hr saturday and +50% of hr for sundays
  */
  int a[7],pay=0,total=0;
  std::cin>>a[0]>>a[1]>>a[2]>>a[3]>>a[4]>>a[5]>>a[6];
  for(int i=0;i<7;i++)
  {
    if(a[i]>8)
      pay = pay+15*(a[i]-8);
    
    if(i==0)
      pay = pay+100*a[i]+0.5*100*a[i];
    else if(i==6)
      pay = pay + 100*a[i] + (100*a[i])/4;
    else
    	pay = pay + 100*a[i];
    total = total+a[i];
}
  if(total-a[0]-a[6]>40)
    pay = pay+25;
  std::cout<<pay;
  return 0;
}
```

