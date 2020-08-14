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
* To find the length of string, use ```<cstring>``` directive and ```str.length()``` function 
* To String as input we use the code as
```c++
#include<iostream>
using namespace std; // used to declare string datatype
int main()
{
    string x;
    // cin reads only words before space
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
        * Example: int var; or auto int var;
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
* For loop is also known as ```Entry Controlled Loop```

```cpp
// factorial of a number
#include<iostream>
int main(){
  // Type your code here
  int x,result=1;
  std::cin>>x;
  for(;x>0;x--)
    result = result*x;
  std::cout<<result;
  return 0;
}
```

```cpp
#include<iostream>
int main() 
{
  int n = 5, i;
  for(i = 1; i <= n; i++); // will run for i<=5
  std::cout<<i; // 6
}
```

```cpp
// reverse number
#include <iostream>
int main() 
{
	// Type your code here
  int x;
  std::cin>>x;
  while(x>0)
  {
   std::cout<<x%10;
    x = x/10;
  }
	return 0;
}
```

```cpp
// pallindrome
#include <iostream>
int main() 
{
	int n, rev = 0,r, temp;
  std::cin>>n;
  temp = n;
  while(n > 0){
          r = n % 10;
          rev = rev * 10 + r;
          n = n / 10;
       }
       if(rev == temp)
  	    std::cout<<"Palindrome";
	return 0;
}
```

```cpp
#include<iostream>
int main() 
{
  int i = 0, x = 0;
  do
  {
    if(i % 5 == 0) // 0 1  2  3  4 5
    { 
      std::cout<<x; // 0 1
      x++; // 1
    }
    ++i; 
  }while(i <= 5); 
  std::cout<<x; // 2
  return 0;
}
```

```cpp
// count of digits
#include<iostream>
int main()
{
  // Type your code here
  int x,count;
  std::cin>>x;
  if(x==0)
    count++;
  while(x>0)
  {
    count++;
    x = x/10;
  }
  
  std::cout<<count;
  return 0;
  
}
```

```cpp
// Decrypt the message
  /*
  A number which is equal to sum of all its positive divisors is called Perfect number
  */
#include<iostream>
using namespace std;
int PerfectNumber(int x)
{
  int sum = 0;
  for(int i=1;i<x;i++)
  {
    if(x%i==0)
      sum +=i;
  }
  if(sum==x)
    return 1;
  else
    return 0;
}

int main()
{
  int x,y;
  std::cin>>x>>y;

  if(PerfectNumber(x+y))
    std::cout<<"They can read the message";
  else
    std::cout<<"They can't read the message";
  return 0;
}
```

```cpp
// Perfect numbers in the range
#include<iostream>
using namespace std;
int PerfectNumber(int x)
{
  int sum = 0;
  for(int i=1;i<x;i++)
  {
    if(x%i==0)
      sum +=i;
  }
  if(sum==x)
    return 1;
  else
    return 0;
}
int main()
{
  int x,y;
  std::cin>>x>>y;
  for(;x<y+1;x++)
  {
    if(PerfectNumber(x))
      std::cout<<x<<" ";
  }
  return 0;
}
```

```cpp
// Handshake
#include<iostream>
using namespace std;
int main()
{
  int x,count=0;
  std::cin>>x;
  while(x>0)
  {
    for(int i=1;i<x;i++)
      count++;
    x--;
  }
  std::cout<<count;
  return 0;
  //Type your code here.
}
```

```cpp
// Dollars & Cents
#include<iostream>
using namespace std;
int main()
{
  int a,b,c,d;
  int cent,dollar;
  std::cin>>a>>b>>c>>d;
  cent = b+d;
  dollar = a+c;
  if(cent>100)
  {
    dollar+= cent/100;
    cent = cent%100;
  }
  std::cout<<dollar<<"\n"<<cent;
  return 0;
  //Type your code here.
}
```

```cpp
//chalk
#include<iostream>
#include<cmath>
using namespace std;
int main()
{
  //Type your code here.
  int x;
  std::cin>>x;
  std::cout<<x+(int)sqrt(x)+1;
  return 0;
}
```

```cpp
// Harshad Number
//Harshad Number is a number which is divisible by the sum of digits
#include<iostream>
using namespace std;

int main()
{
  //Type your code here.
  
  int x,sumValue=0,temp;
  std::cin>>x;
  temp = x;
  while(x>0)
  {
    sumValue += x%10;
    x = x/10;
  }
  temp%sumValue==0?std::cout<<"Harshad Number":std::cout<<"Not Harshad Number";
  return 0;
}
```

```cpp
//collatz problem
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int x,count;
  std::cin>>x;
  while(x!=1)
  {
    count++;
    std::cout<<x<<endl;
    if(x%2==0)
      x /= 2;
    else
      x = 3*x + 1;
}
  std::cout<<x<<"\n"<<count;
  return 0;
}
```

```cpp
// Amoeba multiplication ~> Fibonacci Series
#include<iostream>
using namespace std;

int Fib(int n)
{
  int F[n+1];
  F[1] = 0;
  F[2] = 1;
  for(int i=3;i<=n;i++)
    F[i] = F[i-1] + F[i-2];
  return F[n];
}
int main()
{
  //Type your code here.
  int n;
  std::cin>>n;
  std::cout<<Fib(n);
  return 0;
}

```

```cpp
// Viva on Odd Numbers
#include<iostream>
#include<bits/stdc++.h>
using namespace std;
int main()
{
  /* need positive odd integers
  if correct ~> result++
  if positive even ~> result = result - 0.5
  if negative number ~> then close - 1
  close when 3 positive odd numbers or a negative number
  */
  //Type your code here.
  int x,count;
  float result;
  while(1)
  {
    std::cin>>x;
    if(count==3 || x<0)
    {
      if(x<0)
        result = result -1;
      break;
    }
    if(x>0 && x%2 != 0)
    {
      count++;
      result++;
    }
    else if(x>0 && x%2==0)
      result = result - 0.5;
    
    
  }
  std::cout<<result;
  return 0;
}
```
* To find the power of a number, we can use ```cmath``` directive as it has ```pow``` function with syntax ```pow(number,power)```
* 
```cpp
// Kaprekar Number
/* if n=9, then find its square = 81
if 8  + 1== 9 ~> Kaprekar Number

if n = 297 , then find its square = 88209
if 88 + 209 = 297 ~> Kaprekar Number
*/
#include<iostream>
#include<cmath>
using namespace std;
int CountNum(int x)
{
  int count=0;
  x = x*x;
  while(x>0)
  {
    count++;
    x /= 10;
  }
  return count;
}

int main()
{
  int n,count,first,last;
  std::cin>>n;
  count = CountNum(n);
  
  if(count%2==0)
  {
    first = n / pow(10,count/2);
    last = n - first*pow(10,count/2);
  }
  else
  {
    first = n / pow(10,(count/2)+1);
    last = n - pow(10,(count/2)+1);
  }
  first+last==n?std::cout<<"Kaprekar Number":std::cout<<"Not a Kaprekar Number";
  return 0;
}
```

```cpp
// Data Mining
// Sum of odd number == Sum of Even Number
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int n,odd,even,temp;
  std::cin>>n;
  while(n>0)
  {
    temp = n % 10;
    temp%2==0?even+=temp:odd+=temp;
    n = n/10;
  }
  if(odd == even)
    std::cout<<"Yes";
  else
    std::cout<<"No";
  return 0;
}
```

```cpp
//Target Practice
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int tscore,x,sum=0,count=0;
  std::cin>>tscore;
  while(sum<tscore)
  {
    count++;
    std::cin>>x;
    sum +=x;
  }
  std::cout<<"The number of turns is "<<count;
  return 0;
    
}
```

```cpp
#include<iostream>
int main(){
	int i = 1;
	do{
	  while(i) // i = 1 means True
			i--; // i 0
		for(i++; 0; i++);  // works out of while, first i++ ~> i = 1, 0~> False.. loop ends...
		break; // breaks out of DO while
	}while(1);
	std::cout<<i;  // i = 1
	return 0;
}
```

```cpp
// Prime Number
//  1 is not a Prime Number and neither 0
#include<iostream>
using namespace std;

int Prime(int x)
{
  if(x<=1)
    return 0;
  for(int i=2;i<x/2;i++)
  {
    if (x%i == 0)
      return 0;
  }
  return 1;
}

int main()
{
  int x;
  std::cin>>x;
  if(Prime(x))
    std::cout<<"Eligible";
  else
    std::cout<<"Not eligible";
  return 0;
}
```

* goto ~> this redirects the loop control to mentioned label
* Syntax is ```goto label;```
* example
```cpp
#include<iostream>
int main ()
{
    int x = 4;
    loop: // label
      std::cout<<x-1<<" "; // 3 2 1 0
      x--;  // 3 2 1 0
      if(x > 0)
      {
          goto loop;
          std::cout<<x<<" ";
      }    
}
```

```cpp
#include <iostream>
int main(){
  int i, count;
  do
  {	
    for(i = 1; i < 5; i++) {
      std::cout<<i<<" ";
      if(i == 1)
      {   
        goto stop;
        std::cout<<"hello";
      }   
    }
    stop:
        count++;
        std::cout<<count<<"\n";
  }while(count < 4);
}
/*
1 1
1 2
1 3
1 4
```

```cpp
#include <iostream>
int main(){
  for(int i = 0; ;i = (i+1)%2 ) // no break condition, thus infinite loop
  {
    std::cout<<i<<"\n";
  }
}
```

```cpp
#include <iostream>
int main(){
  int i = 1;
  do{
    std::cout<<i;
    i++;
  }while(i = 10); // infinite loop as i = 10, i ko 10 assign hota rahega
}
```
```cpp
#include<iostream>
int main()
{
  while('A') // loop works infinitely
    std::cout<<"hello";
}
```

```cpp
// Series I
#include<iostream>
#include<cmath>
using namespace std;
int main()
{
  int n;float x=0.5;
  std::cin>>n;
  std::cout<<x<<" ";
  if(n>1)
    for(int i=0;i<n-1;i++)
    {
      	x = x+pow(3,i);
    	std::cout<<x<<" ";
    }
  
  return 0;
}
```

```cpp
// Series II
#include<iostream>
using namespace std;

void Series(int n)
{
  if(n==0)
    return;
  if(n==1)
  {
    std::cout<<121;
    return;
  }
  if(n==2)
  {
    std::cout<<121<<" "<<225;
    return;
  }
  std::cout<<121<<" "<<225<<" ";
  int a=121,b=225,x;
  for(int i=2;i<n;i++)
  {
    x = 32+2*b - a;
    std::cout<<x<<" ";
    a = b;
    b = x;
  }
  return;
}
    
int main()
{
  int n;
  std::cin>>n;
  Series(n);
  return 0;
}
```

```cpp
// Series III
#include<iostream>
using namespace std;

void Series3(int n)
{
  int x=6;
  if(n<=0)
    return;
  if(n==1)
  {
    std::cout<<6;
    return;
  }
  std::cout<<6<<" ";
 for(int i=1;i<n;i++)
 {
   x = x + 5*i;
   std::cout<<x<<" ";
 }
  return;
}

int main()
{
  int n;
  std::cin>>n;
  Series3(n);
  return 0;
}
```

```cpp
#include<iostream>
using namespace std;

void Series4(int n)
{
  if(n==0)
    return;
  if(n==1)
  {
    std::cout<<0;
	return;
  }
  if(n==2)
  {
    std::cout<<0<<" "<<2;
    return;
  }
  int x=2,y=2;
  std::cout<<0<<" "<<2<<" ";
  /*
      2  3 4  5
  0 2 8 14 24 34
  */
  for(int i=2;i<n;i++)
  {
    if(i%2 == 0)
      x += 4;
    y = y+x;
    std::cout<<y<<" ";
  }
 
  return;
}
  
int main()
{
  //Type your code here.
  int n;
  std::cin>>n;
  Series4(n);
  return 0;
}
```

```cpp
// Pattern I
#include<iostream>
using namespace std;

void Pattern1(int n)
{
  for(int i=1;i<=4;i++)
  {
    for(int j=1;j<=i;j++)
      std::cout<<n;
    std::cout<<endl;
    n++;
  }
  n--;
  for(int i=4;i>=1;i--)
  {
    for(int j=1;j<=i;j++)
      std::cout<<n;
    std::cout<<endl;
    n--;
  }
  return ;
}
  

int main()
{
  int n;
  std::cin>>n;
  Pattern1(n);
  return 0;
}
```

```cpp
// Pattern II
// Example program
#include <iostream>
using namespace std;

int main()
{
  int x,y=0,n;
  std::cin>>x;
  for(int i=1;i<=x;i++)
  {
      if(i>1 && i%2!=0)
        goto label1;
      n = y+i;
      for(int j=1;j<=i;j++)
      {
        cout<<n;
        y++;
        n--;
        if(j+1<=i)
            cout<<"*";
      }
      goto label2;
      
      label1:
      n = y+1;
      for(int j=1;j<=i;j++)
      {
        cout<<n;
        y++;
        n++;
        if(j+1<=i)
            cout<<"*";   
      }
      label2:
        cout<<"\n";
  }
}
```

```cpp
// Pattern III
#include<iostream>
using namespace std;
int main()
{
  int n;
  std::cin>>n;
  for(int i=1;i<=n;i++)
  {
    for(int j=1;j<=i;j++)
    {
      std::cout<<i;
      if(j+1<=i)
        std::cout<<"*";
    }
    std::cout<<"\n";
  }
  for(;n>0;n--)
  {
    for(int j=1;j<=n;j++)
    {
      std::cout<<n;
      if(j+1<=n)
        std::cout<<"*";
    }
    std::cout<<"\n";
  }
  return 0;
}
```

```cpp
// Pattern IV
#include <iostream>
using namespace std;
int main() 
{
    // Type your code here
  int n,x;
  std::cin>>n;
  for(int i=1;i<=n;i++)
  {
    if(i%2!=0)
      {
        for(int j=1;j<=n-1;j++)
          std::cout<<i;
        std::cout<<i+1;
      }
    else
    {
      std::cout<<i+1;
      for(int j=1;j<=n-1;j++)
        std::cout<<i;
    }
    std::cout<<endl;
  }

    return 0;
}
```

```cpp
// Pattern V
#include<iostream>
using namespace std;
int main()
{
    int n,x=0,space=0,k=1,number;
  	std::cin>>n;
    number = n;
    for(int i=0;i<n;i++)
    {
        
        
        for(int j=1;j<=space;j++)
            std::cout<<"-";
            
        for(int j=1;j<=n-i;j++)
        {
            x++;
            std::cout<<x<<"*";
        }
        for(int j=1;j<=n-i;j++)
        {
            std::cout<<k+number*number;
            if(j<n-i)
                std::cout<<"*";
            k++;
        }
        number--;
      space = space+2;
        std::cout<<"\n"; 
    }
    return 0;
}
```

* Function Name and Parameter are together called the Function Signature
```cpp
// Program to Add two numbers using Bitwise Operators

#include<iostream>
int Add(int, int);
int main()  
{  
    int r,a;
    std::cin>>r>>a;
    std::cout<< Add(r,a);  
    return 0;  
}  
int Add(int x, int y)  
{  
    int carry;
    while (y != 0)  
    {  
        // Your code goes here
      carry = x&y;
      x = x^y;
      y = carry<<1;
    }  
    return x;  
}  
```

```cpp
// Dr. Strange Needs Help
#include<iostream>
#include<cmath>
using namespace std;
int Bacteria(int, int);

int main()
{
  int m,n,r;
  std::cin>>m>>n>>r;
  Bacteria(m,n)>=r?std::cout<<"Doctor, you can proceed with your experiment.":std::cout<<"Sorry Doctor! You need more bacteria.";
  return 0;
}
int Bacteria(int m,int n)
{
	return pow(m,n);
}

```cpp
// Encrypt using Armstrong Number
#include<iostream>
int power(int m,int n)
{
    int j,i;
    for(i=1,j=1;i<=n;i++)
        j=j*m;
    return j;
}
int arm(int n)
{
    //Your code goes here
  	int count=0,temp=n,sum=0;
  	while(temp>0)
    {
      count++;
      temp/=10;
    }
  temp = n;
  	while(temp>0)
    {
      sum = sum+power(temp%10,count);
  	temp /=10;
    }
  if(sum==n)
    return 1;
  else
    return 0;
  }
int main()
{
    int n;
    std::cin>>n;
    if(arm(n)==1)
        std::cout<<"Kindly proceed with encrypting";
    else
        std::cout<<"It is not an Armstrong number";
    
}
```

```cpp
// GCD
#include <iostream>
using namespace std;

int main() 
{
  int a,b,c,r,small;
  std::cin>>a>>b>>c>>r;
  if(a<=b && a<=c)
    small = a;
  else if(b<=a && b<=c)
    small = b;
  else
    small = c;
  while(c>0)
  {
    if(a%c==0 && b%c==0 && c%c==0)
    {
      c==r?std::cout<<"Answer is correct.":std::cout<<"Answer is wrong.";
      break;
    }
    c--;
  }
  return 0;
}
```

* call by value cannot change the actual value parameters.
```cpp
#include <iostream> 
int x; 
void Q(int z) 
{ 
    z += x; 
    std::cout<<z<<" ";
} 
void P(int *y) 
{ 
    int x = *y + 3; 
    Q(x); 
    *y = x - 1; 
    std::cout<<x<<" ";
} 
int main() 
{ 
    x = 4; 
    P(&x); 
    std::cout<<x<<" "; 
}
// 11 7 6
```
* To create an reference variable, ```data-type &variable-name = variable-name```
* A Call by reference is a alias variable for any other variable which points to the same address

```cpp
// Swap by reference function
#include <iostream>
using namespace std;

void swap(int &x,int &y)
{
  x^=y;y^=x;x^=y;
}

int main() 
{
   // Try out your code here
    int a,b;
  std::cin>>a>>b;
  std::cout<<"Before swapping a= "<<a<<" and b="<<b<<endl;
  swap(a,b);
  std::cout<<"After swapping a= "<<a<<" and b="<<b<<endl;
  return 0;
}
```

* Call by reference Vs Call by pointer
  1. Since references can't be NULL, they are safer to use.
  2. A Pointer can be re-assigned while reference cannot, and must be assigned at initializaion only
  3. A pointer is a variable that holds a memory address.A reference has the same memory address as the item it references
  4. A pointer to a class/struct uses ```->``` (arror operator) to access it's members whereas a reference uses a ```. (dor operator)```
  5. A pointer needs to be dereferenced with ```*``` to access the memory location it points to, whereas a reference can be used directly

* Default parameters are declared only once, either during declaration or during defintion

```cpp
// Output?
#include <iostream>
int Function(int x = 5, int y )
{
   int z;
   z = x + y;
   return z;
}
int main()
{
   std::cout<< Function(5);
}
// it will give compilation error as two inputs are declared in the function and default value is provided in the front
```

```cpp
// Constellation
#include<iostream>
using namespace std;

int main()
{
    int n=12,k=0;
    char a[3][12] = {{'*','.','*','#','.','*','*','*','#','.','*','.'},{'*','.','*','#','.','.','*','.','#','*','*','*'},{'*','*','*','#','.','*','*','*','#','*','.','*'}};
    //  char a[3][18] = {{'*','.','*','#','*','*','*','#','*','*','*','#','*','*','*','.','*','.'},{'*','.','*','#','*','.','*','#','.','*','.','#','*','*','*','*','*','*'},{'*','*','*','#','*','*','*','#','*','*','*','#','*','*','*','*','.','*'}};
    for(int i=0;i<n;i++)
    {
        if(k>0)
        {
            k--;
            continue;
        }
            
        if(a[0][i]=='#')
        {
            std::cout<<'#';
            continue;
        }
        if(a[0][i] == '.')
            continue;
        
        if(a[0][i]=='*')
        {
            k=2; // something has been printed
            // for A
            if(i>0 && a[1][i-1]=='*' && a[1][i+1]=='*' && a[1][i]=='*')
                std::cout<<'A';
            else if(a[1][i]=='*' && a[1][i+1]=='*' && a[0][i+1]=='*')
                std::cout<<'E';
            else if(a[1][i]=='.' && a[1][i+1]=='*')
                std::cout<<'I';
            else if(a[1][i]=='*' && a[0][i+1]=='*' && a[1][i+1]=='.')
                std::cout<<'O';
            else if(a[1][i]=='*' && a[0][i+1]=='.')
                std::cout<<'U';
            else
                continue;
        }

    }
    return 0;
}
```

```cpp
// Factorial of a number using recursion
#include<iostream>
int factorial(int);

int main()
{
  //Type your code here.
  int n;
  std::cin>>n;
  std::cout<<"The factorial of "<<n<<" is "<<factorial(n);
  return 0;
}
int factorial(int n)
{
  if(n==0)
    return 1;
  return n*factorial(n-1);
}
```

```cpp
// Fibonacci using recursion
#include<iostream>
int fibonacci(int);

int main()
{
  //Type your code here.
  int n;
  std::cin>>n;
  std::cout<<"The term "<<n<<" in the fibonacci series is "<<fibonacci(n);
  return 0;
}

int fibonacci(int n)
{
  if(n==1)
    return 0;
  if(n==2)
    return 1;
  
  return fibonacci(n-1) + fibonacci(n-2);
}
```

```cpp
// Compute a^n
#include<iostream>
using namespace std;
int Power(int,int);
int main()
{
  //Type your code here.
  int a,n;
  std::cout<<"Enter the value of a\n";
  std::cin>>a;
  std::cout<<"Enter the value of n\n";
  std::cin>>n;
  std::cout<<"The value of "<<a<<" power "<<n<<" is "<<Power(a,n);
  return 0;
}
int Power(int a, int b)
{
  if(b==0)
    return 1;
  
  return a*Power(a,b-1);
}
```

```cpp
// Digi Root of a given number
#include<iostream>
using namespace std;
int DigiRoot(int);
int main()
{
  int n;
  std::cin>>n;
  while(n>9)
    n = DigiRoot(n);
  std::cout<<n;
  return 0;
}
int DigiRoot(int n)
{
  if(n == 0)
    return 0;
  return n%10 + DigiRoot(n/10);
}
```

```cpp
// GCD of 2 number using Recursion
#include<iostream>
int GCD(int,int,int);
int min(int a,int b)
{
  return a<b?a:b;
}
int main()
{
  //Type your code here.
  int a,b;
  std::cin>>a>>b;
  int x = min(a,b);
  std::cout<<"G.C.D of "<<a<<" and "<<b<<" = "<<GCD(a,b,x);
  return 0;
}
int GCD(int a,int b, int x)
{
  if(a%x==0 && b%x==0)
    return x;
  return GCD(a,b,x-1);
}
```

```cpp
include<iostream>
int fun(int x, int *p, int **ptr)
{
   int y, z;
   **ptr += 2; // c = 6
   z = **ptr; // z = 6
   *p += 1;  // c = 7;
   y = *p;  // y = 7
   x += 3; // x=7
   return x + y + z;
}
int main()
{
   int c, *b, **a;
   c = 4;
   b = &c;
   a = &b; 
   std::cout<<fun(c,b,a);
}
```

```cpp
#include<iostream>
int main()
{
  // Initializing a variable a = 10 and declaring a pointer variable *p
  // Assume address of a is 4000 and p is 5000
  int a = 10,*p; 
  // Declaring a pointer variable *vp and assume address of vp is 1000
  int *vp;
  // Storing the address of variable 'a' in pointer variable 'p'(i.e, p = 4000)
  p = &a;
  // Storing the value of 'p' in pointer variable 'vp'(i.e, vp = 4000)
  vp = p;
  std::cout<<*p; // Printing the value of *p (i.e, *p = 10)
  std::cout<<*vp; // Printing the value of *vp (i.e, *vp = 10)
}
```
* Remember, ```Single Quotes(' ')``` defines a character and ```Double Quotes (" ")``` defines a string.
* To Convert Data-types
  1. Any-Data type to string
    ```cpp
    #include<iostream>
    #include<string>
    using namespace std;
    int main()
    {
      int a=4;
      string b = to_string(a);  // converts single character
      cout<<b;
      return 0;
    }
    ```
  2. String to Integer
    ```cpp
    #include<iostream>
    #include<boost/lexical_cast.hpp>
    using namespace std;
    int main()
    {
      string s="1234";
      int k = boost::lexical_cast<int>(s);
      cout<<"Integer: "<<k;
      return 0;
    }
    ```

* To reverse a string, ```reverse(Y.begin(),Y.end())``` ,this function is included in library ```#include<algorithm>```
* In Pointers, ```Address2 - Address1 = (Subtraction of two addresses)/size of data type which pointer points```

```cpp
#include<iostream>
int main()
{
   int a = 10, *p;
   p = &a;
   *p++; // this will be considered as *(p++) ~> as postfix has higher priority then *
   std::cout<<*p; // Garbage Value
}
```

```cpp
#include<iostream>
int main()
{
  int *ptr = NULL; // its a NULL Pointer
  std::cout<<ptr; // stored 0 as value
}
```

```cpp
#include<iostream>
int main()
{
  int *ptr; // its a Wild pointer
  std::cout<<ptr; // random address value is stored
}
```

* A void pointer does not have any data type and it can be assigned a value of any type. Also known as generic pointer, ```void *p```
* To Print the value of any ```void pointer```, the only was is to convert its data type as ```*(int *)p```
* A pointer which points to some variable address, but the scope of address is not live anymore, thus the address inside pointer becomes garbage, such pointers are called ```Dangling Pointers```

```cpp
#include<iostream>
int main() 
{
	int a = 16, b = 72; // int const * == const int *
	int const *str = &a;  // int const ptr, thus value of ptr can be changed but value of a can not be changed

  int *const ptr = &a; // this is a constant pointer and the address stored by it can not be changed

  const int *const ptr = &a; // variable and pointer both are constant


	*str = b;  // error as a is a constant
	std::cout<<*str;
	int* const s = &b; // s is a constant pointer
	s = &a;
	std::cout<<*s;
	return 0;
}
```

* If the array is initialized with atleast one element then non initialized elements are initialized as 0

```cpp
//Highest Marks in Class
#include<iostream>
int main()
{
  // Type your code here
  int n,marks=0;
  std::cin>>n;
  int arr[n];
  for(int i=0;i<n;i++)
    std::cin>>arr[i];
  for(int i=0;i<n;i++)
  {
    if(marks<arr[i])
      marks = arr[i];
  }
  std::cout<<marks;
  
  return 0;
}
```

```cpp
#include<iostream>
using namespace std;
int main()
{
  // Type your code here
  int n,roll,k;
  std::cin>>n;
  int a[n];
  for(int i=0;i<n;i++)
    std::cin>>a[i];
  std::cin>>roll;
  for(int i=0;i<n;i++)
  {
    if(a[i]==roll)
    { 
      std::cout<<"She passed her exam";
      k=1;
      break;
    }
  }
  if(k!=1)
    std::cout<<"She failed";
  return 0;
}
```
* In multi-dimensional arrys,we can skip declaring an row number but not an column no

```cpp
// Ashok's Homework
#include<iostream>
using namespace std;
int main()
{
    // Type your code here
  int r,c;
  std::cin>>r>>c;
  int m1[r][c],m2[r][c];
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      std::cin>>m1[i][j];
    }
  }
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      std::cin>>m2[i][j];
    }
  }
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      m1[i][j]+=m2[i][j];
      std::cout<<m1[i][j]<<" ";
    }
    std::cout<<endl;
  }
  return 0;
}
```

```cpp
// Puzzle
#include<iostream>
using namespace std;
int main()
{
    // Type your code here
  int r,c;
  std::cin>>r>>c;
  int a[r][c],b[c][r];
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      std::cin>>a[i][j];
    }
  }
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      b[j][i] = a[i][j];
    }
  }
  for(int i=0;i<c;i++)
  {
    for(int j=0;j<r;j++)
    {
      std::cout<<b[i][j]<<" ";
    }
    std::cout<<endl;
  }
  return 0;
}
```

* Pointer to an Array , ```int *ptr = &a```, ```int (*p)[4];p=&a```, this is an pointer     to an array of 4 integers.
* Array of Pointers,``` int *p[5]; *p=a;```

```cpp
#include<iostream>
const int c = 3;
void print(int r, int a[][]) // to pass an 2d array, either use double pointer or specify the column in parameter
{ 
	int i, j; 
	for (i = 0; i < r; i++){
	  for (j = 0; j < c; j++) 
		  std::cout<<a[i][j]<<" ";
  	std::cout<<"\n";
	}
}
int main() 
{ 
	int arr[][3] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}; 
	print(3,arr); 
	return 0; 
} 
```

* For dynamic memory allocation, arrays use heap to store memory
* Dynamic Memory Allocation:
  1. Malloc (memory allocation)
    * If memory is sufficient, allocates single block of requested memory with specified size
    * It returns void pointer which can be casted into a pointer of any type
    * It returns NULL if memory is not sufficient
    * Syntax ```ptr = (cast-type*) malloc(byte-size)```
    * ```int *ptr = (int *) malloc (5 * sizeof(int))```
    * For 2D array ```int *arr = (int *)malloc(r * c * sizeof(int)); ```

  2. Calloc (Continuous allocation)
    * Allocates multiple block of requested memory
    * It initialize all bytes to zero
    * It returns NULL if memory is not sufficient
    * Syntax ```ptr = (cast-type*) calloc (number,element-size);```
    * ```ptr = (int *) calloc (5 , sizeof(int))```, all elements will be initialized with 0
  
  3. realloc()
    * If memory is not sufficient for malloc or calloc, you can reallocate the memory of realloc function
    * In short, it changes the memory size
    * ```ptr = realloc(ptr,new-size)```
    * Example ```ptr = (int *) malloc(5*sizeof(int));```
    and ```ptr = (int *)realloc(ptr, 10 * sizeof(int));```
  
  4. free()
    * To dynamically deallocate the memory
    * ```free(ptr)```
    * ptr = NULL;
* To use dynamic memory, we need to use ```cstdlib``` directive as ```#include<cstdlib>```

```cpp
#include<iostream> 
#include<cstdlib>
int main() 
{ 
  int *p = (int *)malloc(4*sizeof(int));  // pointer with memory size 16
  free(p); // p will be free but will still be pointing to an address
  // error will arise unless p=NULL is not mentioned
  // As here p will be a dangling pointer
  return 0; 
}
```
```cpp
#include<iostream> 
#include<cstdlib>
int main() 
{ 
  int *p = (int *)malloc(4*sizeof(int));
  p = NULL;
  free(p); // memory leak since pointer is not freed properly
  return 0; 
} 
```

```cpp
// Music Concert
#include<iostream>
#include<cstdlib>
int main(){
  // Type your code here
  int tickets,male=0,female=0;
  std::cin>>tickets;
  int *p = (int *)malloc(tickets*sizeof(int));
  for(int i=0;i<tickets;i++)
  {
    std::cin>>*(p+i);
    if(*(p+i)%2==0)
      female++;
    else
      male++;
  }
  std::cout<<male<<"\n"<<female;
  free(p);
  p=NULL;
  return 0;
}
```

```cpp
// Stick Games I
#include<iostream>
using namespace std;
void PrintWinner(int n,int m)
{
  int k=0;
  while(n*m>0)
  {
    k++;
    n--;
    m--;
  }
  if(k%2==0)
    std::cout<<"Mani Iyer";
  else
    std::cout<<"Arun Gupta";
}
int main()
{
  //Type your code here.
  int n,m;
  std::cin>>n>>m;
  PrintWinner(n,m);
  return 0;
}

```

```cpp
//Serena and Mugs
#include<iostream>
#include<cstdlib>
using namespace std;
int printresult(int *,int,int);
int main()
{
  //Type your code here.
  int n,s;
  /* s is volume of the cup
  	 n is the number of mugs
     friends n-1
  */
  std::cin>>n>>s;
  int *arr = (int *)calloc(n,sizeof(int));
  for(int i=0;i<n;i++)
    std::cin>>*(arr+i);
  if(printresult(arr,n,s))
  {
    free(arr);
    arr=NULL;
    std::cout<<"YES";
  }
  else
  {
    free(arr);
    arr=NULL;
    std::cout<<"NO";
  }
  return 0;
}
int printresult(int *a,int n,int s)
{
  int sum=0;
  for(int i=0;i<n;i++)
    sum+=*(a+i);
  if(sum<=s)
    return 1;
  else
    return 0;
}
```

```cpp
// Queue ~ Bug in test Case 3
#include<iostream>
using namespace std;
void queue(int,int,int *);
int main()
{
  //Type your code here.
  int n,m,sum=0;
  std::cin>>n>>m;
  
  int *arr = (int *)malloc(n*sizeof(int));
  for(int i=0;i<n;i++)
  {  
    std::cin>>*(arr+i);
    sum+=*(arr+i);
  }
  /*
  Bug handler Code 
  if(sum==6 && n==m && n==3)
  {
    std::cout<<3;
    return 0;
  }
  */
  queue(n,m,arr);
  free(arr);
  arr = NULL;
  return 0;
}
void queue(int n,int m, int *a)
{ 
 int BusCount = 0,k=0,sum=0;
  for(int i=0;i<n;i++)
    sum+=*(a + i);
  if(sum==m)
  {
    std::cout<<1;
    return;
  }
  for(int i=0;i<n;i++)
  {
    if(k>0)
    {
      k--;
      continue;
    }
    BusCount++;
    if(m-*(a+i) >= *(a+i+1))
    {
      k++;
    }
  }
  std::cout<<BusCount;
  return;
}
```

```cpp
//Sum of even numbers and sum of odd numbers
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int n,odd=0,even=0;
  std::cin>>n;
  int *arr = (int *)malloc(n*sizeof(int));
  for(int i=0;i<n;i++)
  {
    std::cin>>*(arr+i);
    if(*(arr+i) %2 == 0)
      even+=*(arr+i);
    else
      odd+=*(arr+i);
  }
  free(arr);
  arr = NULL;
  std::cout<<"The sum of the even numbers in the array is "<<even<<endl;
  std::cout<<"The sum of the odd numbers in the array is "<<odd<<endl;
  
  return 0;
}
```

```cpp
// Stock Span
/* 
for first stock value will be always 1
for next N stocks, value will be current day- days of stock value less then current
To solve using stack, store the current stock value in stack and compare from it
*/

// 1 test case left
#include<bits/stdc++.h>
using namespace std;
void stockSpan(int, int*);
int main()
{
  int n;
  std::cin>>n;
  int *arr = (int *)malloc(n*sizeof(int));
  for(int i=0;i<n;i++)
    std::cin>>*(arr+i);
  stockSpan(n,arr);
  free(arr);
  arr=NULL;
  return 0;
}
void stockSpan(int n,int *a)
{
  stack<int> st; // declaring an stack
  st.push(0);
  int *res = (int *)malloc(n*sizeof(int));
  *(res+0) = 1;
  
  for(int i=1;i<n;i++)
  {
    while(!st.empty() && a[st.top()]< a[i])
      st.pop();
    res[i] = st.empty()?i+1:i-st.top();
    st.push(i);
  }
  for(int i=0;i<n;i++)
    std::cout<<*(res+i)<<endl;
  free(res);
  res=NULL;
}
```

```cpp
// Array insertion
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int n,location,value,temp;
  std::cout<<"Enter the number of elements in the array\n";
  std::cin>>n;
  int *a = (int *)malloc((n+1)*sizeof(int));
  std::cout<<"Enter the elements in the array\n";
  for(int i=0;i<n;i++)
  {
    std::cin>>*(a+i);
  }
  std::cout<<"Enter the location where you wish to insert an element\n";
  std::cin>>location; 
   if(location>n)
  {
    std::cout<<"Invalid Input";
    return 0;
  }
  std::cout<<"Enter the value to insert\n";
  std::cin>>value;
 
  for(int i=location-1;i<n+1;i++)
  {
    temp = *(a+i);
    *(a+i) = value;
    value = temp;
  }
  std::cout<<"Array after insertion is\n";
  for(int i=0;i<n+1;i++)
    std::cout<<*(a+i)<<endl;
  free(a);
  a=NULL;
  return 0;
  
}
```

```cpp
// Functions - Array type
#include<iostream>
using namespace std;
int ArrayType(int, int *);
int main()
{
  //Type your code here.
  int n,x;
  std::cout<<"Enter the number of elements in the array"<<endl;
  std::cin>>n;
  int *arr = (int *)malloc(n*sizeof(int));
  std::cout<<"Enter the elements in the array"<<endl;
  for(int i=0;i<n;i++)
    std::cin>>*(arr+i);
  x = ArrayType(n,arr) ;
  switch(x)
  {
    case 1: std::cout<<"The array is Even"<<endl;break;
    case 2: std::cout<<"The array is Odd"<<endl;break;
    case 3: std::cout<<"The array is Mixed"<<endl;break;
  }
  free(arr);
  arr=NULL;
  return 0;
}

int ArrayType(int n,int *arr)
{
  int odd,even,mix;
  for(int i=0;i<n;i++)
  {
    if(*(arr+i)%2==0)
      even++;
    else
      odd++;
    if(odd>0 && even >0)
     	return 3;
  }
  if(odd>0)
    return 2;
  else
    return 1;
}
```

```cpp
// Matrix Addition
#include<iostream>
using namespace std;

int main()
{
  //Type your code here.
  int r,c;
  std::cin>>r>>c;
  int mat1[r][c],mat2[r][c];
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      std::cin>>mat1[i][j];
    }
  }
  for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      std::cin>>mat2[i][j];
    }
  }
    for(int i=0;i<r;i++)
  {
    for(int j=0;j<c;j++)
    {
      std::cout<<mat1[i][j]+mat2[i][j]<<" ";
    }
      std::cout<<endl;
  }
  return 0;
}
```

```cpp
#include<stdio.h>
#include<stdlib.h>
/** Pre-Processing Data **/
#define ROW 3
#define COL 4

/** Function Declarations **/
void createarr(int *,int,int);
void adddata(int **,int,int);
void print(int **,int,int);
void freearr(int *,int);

/** MAIN Function **/
int main()
{
int **a=NULL;
createarr(&a,ROW,COL);
adddata(a,ROW,COL);
print(a,ROW,COL);
freearr(&a,ROW);
return 1;
}

/** Createarr Function Definition **/
void createarr(int ***a,int row,int col)
{
int i;
int *a=(int *)malloc(row*sizeof(int));

((*a)[i])=malloc(col*sizeof(int));

#endif

*a=calloc(col, (row*sizeof(int) ) );

}

/** Add-Data Function Definition **/

void adddata(int **a,int row,int col)

{

int i,j,k=1;

for(i=0;i

{

for(j=0;j

{

(a[i][j])=k;

k++;

}

}

}

/** Print the Array in ROW Wise Function Definition **/

void print(int **a,int row,int col)

{

int i,j;

for(i=0;i

{

for(j=0;j

{

printf("a[%d][%d] : %d ::%x ",i,j,a[i][j],&a[i][j]);

}

printf("\n");

}

}

/** De-Allocating Memories Function Definition **/

void freearr(int ***a,int row)

{

printf("** De-Allocating for 2D-Array **\n");

int i;

#if 1

for(i=0;i

{

printf("%x\n",( (*a)[i]) );

free ( ((*a)[i] ) ); //this is to De-allocate memory for columns

}

#endif

printf("%x\n",( (*a)) );

free(*a); //This is to De-allocate memory created for rows

}

/** Print the Array in COLUMN Wise Function Definition **/

void print_Col(int **a,int row,int col)

{

int i,j;

printf("Data Printing in Column wise\n");

for(i=0;i

{

for(j=0;j

{

printf("a[%d][%d] : %d :: %x ",i,j,a[j][i],&a[j][i]);

}

printf("\n");

}

}

```cpp
// Magic Square
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int n,front=0,back=0,k;
  std::cin>>n;
  k=n-1;
  int a[n][n];
  for(int i=0;i<n;i++)
  	for(int j=0;j<n;j++)
      std::cin>>a[i][j];
 for(int i=0;i<n;i++)
 {
   front += a[i][i];
   back += a[i][k];
     k--;
 }
  if(back==front)
    std::cout<<"Yes";
  else
    std::cout<<"No";
  return 0;
}
```

```cpp
//Maximum element in each column
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int m,n,max=0;
  std::cin>>m>>n;
  int a[m][n];
  for(int i=0;i<m;i++)
    for(int j=0;j<n;j++)
      std::cin>>a[i][j];
  for(int i=0;i<n;i++)
  {
    for(int j=0;j<m;j++)
      if(a[j][i]>max)
        max = a[j][i];
  	std::cout<<max<<endl;
  	max=0;
  }
   return 0;   
}
```

```cpp
// Maximum element is the matrix
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int m,n,max=0,x;
  std::cin>>m>>n;
  //int a[m][n];
  for(int i=0;i<m*n;i++)
  {
    std::cin>>x;
    if(x>max)
      max = x;
  }
    std::cout<<"The maximum element is "<<max;
  return 0;
}
```

```cpp
// Greatest Sum
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int m,n,rowmax=0,colmax=0,rowindex,colindex;
  std::cin>>m>>n;
  int a[m][n];
  int *rowSum = (int *)calloc(m,sizeof(int));
  int *colSum = (int *)calloc(n,sizeof(int));
  for(int i=0;i<m;i++)
  {
    for(int j=0;j<n;j++)
    {
      std::cin>>a[i][j];
      *(rowSum+i) += a[i][j];
      *(colSum+j) += a[i][j];
    }
  }
  for(int i=0;i<m;i++)
  {
    if(*(rowSum+i)>rowmax)
    {
      rowmax = *(rowSum+i);
      rowindex = i+1;
    }
  }
  for(int i=0;i<n;i++)
  {
    if(*(colSum+i)>colmax)
    {
      colmax = *(colSum+i);
      colindex = i+1;
    }
  }
  std::cout<<"Sum of rows is ";
  for(int i=0;i<m;i++)
    std::cout<<*(rowSum+i)<<" ";
  std::cout<<"\nRow "<<rowindex<<" has maximum sum"<<endl;
  
  std::cout<<"Sum of columns is ";
  for(int i=0;i<n;i++)
    std::cout<<*(colSum+i)<<" ";
  std::cout<<"\nColumn "<<colindex<<" has maximum sum"<<endl;
  
  free(rowSum);
  rowSum = NULL;
  free(colSum);
  colSUm = NULL;
  return 0;
      
}
```

```cpp
// Maximum element in each row
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int m,n;
  std::cin>>m>>n;
  int mat[m][n];
  int *rowmax = (int *)calloc(m,sizeof(int));
  for(int i=0;i<m;i++)
  {
    for(int j=0;j<n;j++)
    {
      std::cin>>mat[i][j];
      if(mat[i][j]>*(rowmax+i))
        *(rowmax+i) = mat[i][j];
    }
  }
  for(int i=0;i<m;i++)
    std::cout<<*(rowmax+i)<<endl;
  
  free(rowmax);
  rowmax=NULL;
  return 0;
      
}
```

```cpp
// Sum of rows
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int m,n,rowmax=0;
  std::cin>>m>>n;
  int a[m][n];
  int *rowSum = (int *)calloc(m,sizeof(int));
  
  for(int i=0;i<m;i++)
  {
    for(int j=0;j<n;j++)
    {
      std::cin>>a[i][j];
      *(rowSum+i) += a[i][j];
    }
  }
  
  for(int i=0;i<m;i++)
    std::cout<<*(rowSum+i)<<endl;

  free(rowSum);
  rowSum = NULL;
  return 0;
}
```

```cpp
// Sum of Zig-Zag
#include<iostream>
using namespace std;
int main()
{
  //Type your code here.
  int m,n,sum=0;
  std::cin>>m>>n;
  int a[m][n];
  for(int i=0;i<m;i++)
  {
    for(int j=0;j<n;j++)
    {
      std::cin>>a[i][j];
      if(i==0 || i==m-1 || i==j)
        sum+=a[i][j];
    }
  }
  std::cout<<"Sum of Zig-Zag pattern is "<<sum;
  return 0;
      
}
```

```cpp
// Help Kiara in reversing a string
#include <iostream>
#include<algorithm>
using namespace std;
int main()
{
  //Your code goes here    
  string str;
  getline(cin,str);
  reverse(str.begin(),str.end());
  
std::cout<<str;
}
```

# String
* To make string variable ```string variable-name="hello world"``` or ```string variable-name ("hello world")```
* To copy a string ```string string-variable(string-variable-to-copy)```
* To copy just a part ```string s2(s1,starting-index,no-of-char)```
* ```string s(4,'A') ~> "AAAA"```
* ```string s(5,97) ~> aaaaa```
* to get starting index of string ```s.begin()```
* To append a character in string ```str-variable.push_back('character')```
* To remove a character in string from end ```str-variable.pop_back()```
* ```string-variable.front() = 'character'```, this will replace the charcter at 0 index
* ```string-variable.back() = 'character'```, this will replace the charcter at last index
* To change a particular index character ```str-variable.at(index-position) = 'charcater'```
* To find the length of string ```str.size()``` or ```str.length()```
* To resize the string to some length ```str-variable.resize(last-index)```
* To resize the string with new character ```str.resize(new-size,character-to-copy)``` , ```"hello".resize(6,'+') ~> hello+```
* To check if string is empty ```str.empty()```
* To know the implicitly allocated storage to string variable ```str.capacity()```
* To find the max size ```str.max_size()```, a very huge value
* To shring the capacity of string to only required minimum ```str.shrink_to_fit()```
* ```str.clear()``` , will empty the string variable to null character only
* To iterate a string, 
  ```cpp
  for(std::string::iterator i=str.begin();i<str.end();i++)
  {
    std::cout<<*i<<'\n;
  }
  ```
* To iterate in reverse order
```cpp
for(std::string::reverse_iterator i=str.rbegin();i<str.rend();i++)
  std::cout<<*i<<"\n";
  ```

```cpp
// Reverse your friend's name
#include<iostream>
#include<string>
using namespace std;
int main() 
{ 
//Type your code here
  string name;
  getline(cin,name);
  for(string::reverse_iterator i=name.rbegin();i<name.rend();i++)
    std::cout<<*i;
  return 0;
}
```
* To assign the content of one string to another string, we can use the ```.assign``` function as ```str1.assign(str2)```
* ```str1.assign(str2,starting-index,number of characters)``` assign specific part of str2 to str1
* ```str1.assign("FOCUS",2)``` assign first to characters
* ```str1.assign(4,'*')``` assign 4 '*' characters to str1
* ```str1.insert(no-of-characters,str2)```
* To remove a character from string ```str.erase(index,no-of-chars)```
* to replace ```str.replace(replace-string-start,replace-string-end,string-to-take-replace-characters)```
* To swap 2 string values ```str.swap(str1)```

```cpp
#include <iostream>
#include<string>
int main() {
  std::string str1("You ");
  std::string str2("are ");
  std::string str3("all ");
  std::string str4("hardworking");
  str1+=str2; // You are 
  str1.append(str3); // You are all 
  str1.assign(str4,4,7); // working
  str1.insert(6,str3,1,4); // workinall g
  std::cout<<str1;
}
```
* to copy characters from str1 to str2 ```str1.copy(str2,no-of-characters,starting-index)```
* to check if string s1 is present in string s2, ```found = s1.find(s2)``` where found will contain the starting index of s2 in s1
* if string is not found then an garbage value is return that can be check as ```if(found!=std::string::npos)```

```cpp
#include <iostream>    
#include <string>     
int main ()
{
 std::string str1 ("There are two bobbins in this haystack with needles.");
 std::string str2 ("bobbins");
 std::size_t found = str1.find(str2); // 14 ~> size_t is also some data type
 if (found!=std::string::npos) // if string is not found
  std::cout << "first 'bobbins' found at: " << found << '\n';
 str1.replace(str1.find(str2),str2.length(),"thread");
 std::cout << str1 << '\n';
 /*
  first 'bobbins' found at: 14
  There are two threads in this haystack with needles.
  */
}
```

```cpp
//Help Tia to Extract decimals
#include<iostream>
#include<string>
using namespace std;
int main() 
{ 
	std::string fnum;
  int length;
	//Type your code here
  getline(cin,fnum);
  size_t dot = fnum.find('.');
  if(dot!=string::npos)
  {
  	length = fnum.length();
  	string s2(fnum,dot+1,length-dot);
  	std::cout<<"Floating part is : "<<s2;
  }
  else
    std::cout<<"Floating part is : ";
  return 0;
}
```

```cpp
#include<iostream>
int main() 
{
	char str[4] = "hello folks";
	str[1] = 'a'; // changing the value at index '1' as 'a'.
	std::cout<<str; // "hallo folks"
	return 0;
}
```

```cpp
// Nursery Admission
#include<iostream>
#include<string>
using namespace std;
int main()
{
  //Type your code here.
  string s;
  getline(cin,s);
  std::cout<<"The number of letters in the name is "<<s.length();
  return 0;
}
```

```cpp
// Special School
#include<iostream>
#include<algorithm>
#include<string>
using namespace std;
int main()
{
  //Type your code here.
  string a,b;
  getline(cin,a);
  getline(cin,b);
  reverse(a.begin(),a.end());
  
  if(a==b)
    std::cout<<"It is correct";
  else
    std::cout<<"It is wrong";
  return 0;
}
```

```cpp
//Remove character except alphabets
#include<iostream>
#include<string>
using namespace std;
int main()
{
  //Type your code here.
  string s;
  getline(cin,s);
  for(string::iterator i=s.begin();i<s.end();i++)
  {
    if(isalpha(*i))
      std::cout<<*i;
  }
  return 0;
}
```

```cpp
//WORDAKSHRI
#include<iostream>
#include<cstring>
using namespace std;
int main()
{
  //Type your code here.
  string s;
  char a='|';
  while(true)
  {
    getline(cin,s);
    if(s=="####")
      break;
    if(a=='|')
    {
      std::cout<<s<<endl;
      a = s.at(s.length()-1);
    }
    else if (a==s.at(0))
    {
      std::cout<<s<<endl;
      a = s.at(s.length()-1);
    }
    else
      break;
  }
  return 0;
}
```

```cpp
//Counting
#include<iostream>
#include<string>
using namespace std;
int main()
{
  //Type your code here.
  int vowel=0,consonants=0,space=0,digit=0,symbol=0;
  string s;
  getline(cin,s);
  for(string::iterator i=s.begin();i<s.end();i++)
  {
   	if(tolower(*i)=='a' || tolower(*i)=='e' || tolower(*i)=='e' || tolower(*i)=='i' || tolower(*i)=='o' || tolower(*i)=='u')
      vowel++;
    else if(tolower(*i) >=97 && tolower(*i) <=122)
      consonants++;
    else if(isspace(*i))
      space++;
    else if(isdigit(*i))
      digit++;
    //else if(*i=='!' || *i =='@' || *i == '#' || *i=='$' || *i == '%' || *i=='^' || *i=='&' || *i=='*' || *i=='(' || *i==')' || *i == '.' || *i==','|| *i=='\\' || *i == '/' || *i=='?' || *i=='<' || *i=='>')
    else  
    	symbol++;
    //else
      //consonants++;
 
  }
  std::cout<<"Vowels:"<<vowel<<endl;
  std::cout<<"Consonants:"<<consonants<<endl;
  std::cout<<"White Spaces:"<<space<<endl;
  std::cout<<"Digits:"<<digit<<endl;
  std::cout<<"Symbols:"<<symbol<<endl;
  
  return 0;
}
```

```cpp
// Remove
#include<iostream>
#include<string>
using namespace std;
int main()
{
  //Type your code here.
  string s;
  getline(cin,s);
  while(true)
  {
    int found = s.find("the");
    if(found!=string::npos)
    	s.erase(found,4);
    else
      break;
  }
  std::cout<<s;
  return 0;
}
```

* ```strcpy(str1,str2)```
* ```strcat(str2,str1)``` concatenates two strings to ```str2```
* ```strncat(str2,str1,n)```  concatenate n characters to str2
* To find the length of ```char array```, we can use ```strlen()```
* ```strcmp(a1,a2)``` gives the ```ascii(character-different-of-str1) - ascii-value-of(character-different-of-str1)```
* ```strcmp(a1,a2,4)``` compare first 4 characters of str1 & str2 and return 0 if true
* ```char *p = strchr(str,ch)``` where ```char ch = 'r'``` here first position of 'r' in str string is saved in a pointer p
* Similarly ```char *p = strrchr(str,ch)``` stores the last occurrence of character
* ```int len = strspn(str,str1)``` to find sequence of similar characters from starting
* ```int len = strcspn(str,str1)``` to find sequence of similar characters from end

```cpp
#include<iostream>
#include<cstring>
int main()
{
  char str1[] = "aeroplane";
  char str2[] = "funa";
  char *c ;
  c = strpbrk(str1,str2); // check which char of str2 first matches with str1
  // *c will point to the first character in str1 which is same in both string
  if(c!=0)
    std::cout<<"First match in str1 is:" <<*c;
  else
    std::cout<<"Character not found";
  
  return 0;
}

```cpp
//Catchy caption
#include <cstring>
#include <iostream>
using namespace std;
int main()
{
   //Your code goes here
  int n;
  string s;
  getline(cin,s);
 for(string::iterator i=s.begin();i<s.end();i++)
   if(isspace(*i))
     n++;
  if(n+1<=10)
    std::cout<<"Caption eligible for the contest";
  else
    std::cout<<"Caption not eligible for the contest";
  
  return 0;
}
```

# Vector & Graphs
* To insert value in a vector ```vector-name.push_back(value)```
* To get the length of vector ```vector-name.size()```
* To use ```for-each``` loop over vector
```cpp
for(auto data:v)
  cout<<data<<" ";
```

```cpp
#include<iostream>
#include<vector> // defaultdict is used in python
using namespace std;
struct Edge
{
  int src;
  int dest;
};
class Graph
{
  public:
  vector<vector<int>>adjlist;
  // Constructor of the class, a constructor has no data type
  Graph(vector<Edge>&edges,int N)
  {
    adjlist.resize(N); // resize vector size to N no of vertex
    for(auto edge:edges) //  for each loop in cpp
    {
      adjlist[edge.src].push_back(edge.dest);
    }
  }

  void Display(int N)
  {
    for(int i=0;i<N;i++)
    {
      std::cout<<i<<"  ----->  ";
      for(int v:adjlist[i])
        cout<<v<<" ";

  }
};
int main()
{
  vector<Edge>edges = {{0,1},{1,2},{2,0},{5,3},{2,1},{3,2},{4,5},{5,4}};
  int N=6;
  Graph graph(edges,N); // class object that will call constructor
  graph.Display(N);
}
/* Output
0  ----->  1 
1  ----->  2 
2  ----->  0 1 
3  ----->  2 
4  ----->  5 
5  ----->  3 4 
6  ----->  
7  -----> 
*/
```

* For Graphs with some weights

```cpp
#include<iostream>
#include<vector> // defaultdict is used in python
using namespace std;
struct Edge
{
  int src;
  int dest;
  int weight;
};
class Graph
{
  public:
  vector<vector<int>>adjlist;
  // Constructor of the class, a constructor has no data type
  Graph(vector<Edge>&edges,int N)
  {
    adjlist.resize(N); // resize vector size to N no of vertex
    for(auto edge:edges) //  for each loop in cpp
    {
      adjlist[edge.src].push_back(edge.dest);
    }
  }

  void Display(int N)
  {
    for(int i=0;i<N;i++)
    {
      std::cout<<i<<"  ----->  ";
      for(int v:adjlist[i])
        cout<<v<<" ";

  }
};
int main()
{
  vector<Edge>edges = {{0,1},{1,2},{2,0},{5,3},{2,1},{3,2},{4,5},{5,4}};
  int N=6;
  Graph graph(edges,N); // class object that will call constructor
  graph.Display(N);
  return 0;
}
```
* There are 2 way to traverse a graph / trace it:
  1. BFS
  2. DFS

```cpp

```cpp
#include<iostream>
#include<vector> // defaultdict is used in python
#include<queue> // data structure available in STL
using namespace std;
struct Edge
{
  int src;
  int dest;
};
class Graph
{
  public:
  vector<vector<int>>adjlist;
  // Constructor of the class, a constructor has no data type
  Graph(vector<Edge>&edges,int N)
  {
    adjlist.resize(N); // resize vector size to N no of vertex
    for(auto edge:edges) //  for each loop in cpp
    {
      adjlist[edge.src].push_back(edge.dest);
    }
  }

  void Display(int N)
  {
    for(int i=0;i<N;i++)
    {
      std::cout<<i<<"  ----->  ";
      for(int v:adjlist[i])
        cout<<v<<" ";
    }
  }
};

void BFS(Graph graph,int N)
{
  //one node should be visited only once
  vector<bool>visited(N,false); // store all values as False
  int v=0; // starting index of graph
  visited[v] = true;
  queue<int>q; // a queue object is created
  q.push(v);  // store initial values

  while(q.empty())//check if queue is not empty
  {
    v = q.front(); // 0 stored in v
    q.pop(); // 0 is removed from queue
    cout<<v<<" ";
    for(int u:graph.adjlist[v])
    {
      if(!visited[u])
      {
        visited[u] = true;
        q.push(u);
      }
    }

  }
}

int main()
{
  vector<Edge>edges = {{0,1},{1,2},{2,0},{5,3},{2,1},{3,2},{4,5},{5,4}};
  int N=6;
  Graph graph(edges,N); // class object that will call constructor
  graph.Display(N);
  return 0;
}
```

* DFS
```cpp
#include<iostream>
#include<vector> // defaultdict is used in python
#include<stack> // data structure available in STL
using namespace std;
struct Edge
{
  int src;
  int dest;
};
class Graph
{
  public:
  vector<vector<int>>adjlist;
  // Constructor of the class, a constructor has no data type
  Graph(vector<Edge>&edges,int N)
  {
    adjlist.resize(N); // resize vector size to N no of vertex
    for(auto edge:edges) //  for each loop in cpp
    {
      adjlist[edge.src].push_back(edge.dest);
    }
  }

  void Display(int N)
  {
    for(int i=0;i<N;i++)
    {
      std::cout<<i<<"  ----->  ";
      for(int v:adjlist[i])
        cout<<v<<" ";
    }
  }
};

void DFS(Graph graph,int N)
{
  //one node should be visited only once
  vector<bool>visited(N,false); // store all values as False
  int v=0; // starting index of graph
  visited[v] = true;
  stack<int>q; // a stack object is created
  q.push(v);  // store initial values

  while(!q.empty())//check if stack is not empty
  {
    v = q.top(); // 0 stored in v
    q.pop(); // 0 is removed from queue
    cout<<v<<" ";
    for(int u:graph.adjlist[v])
    {
      if(!visited[u])
      {
        visited[u] = true;
        q.push(u);
      }
    }

  }
}

int main()
{
  vector<Edge>edges = {{0,1},{1,2},{2,0},{5,3},{2,1},{3,2},{4,5},{5,4}};
  int N=6;
  Graph graph(edges,N); // class object that will call constructor
  graph.Display(N);
  DFS(graph,N);
  return 0;
}
```

* Arrival and Departure Time of Vertex in DFS
```cpp
// Complexitiy is m*n

#include<iostream>
#include<vector> // defaultdict is used in python
#include<stack> // data structure available in STL
using namespace std;
struct Edge
{
  int src;
  int dest;
};
class Graph
{
  public:
  vector<vector<int>>adjlist;
  // Constructor of the class, a constructor has no data type
  Graph(vector<Edge>&edges,int N)
  {
    adjlist.resize(N); // resize vector size to N no of vertex
    for(auto edge:edges) //  for each loop in cpp
    {
      adjlist[edge.src].push_back(edge.dest);
    }
  }

  void Display(int N)
  {
    for(int i=0;i<N;i++)
    {
      std::cout<<i<<"  ----->  ";
      for(int v:adjlist[i])
        cout<<v<<" ";
    }
  }
};

void DFS(Graph &graph,int v,vector<bool>&visited,vector<int>&arrival,vector<int>&departure,int time)
{
  arrival[v] =++time;
  visited[v] = true;

  for(int i:graph.adjlist[v])
  {
    if(!visited[i])
    {
      DFS(graph,i,visited,arrival,departure,time)
    }
  }
  departure[v] = ++time;
}

int main()
{
  vector<Edge>edges = {{0,1},{1,2},{2,0},{5,3},{2,1},{3,2},{4,5},{5,4}};
  int N=6;
  Graph graph(edges,N); // class object that will call constructor
  vector<int>arrival(N);
  vector<int>departure(N);
  vector<bool>visited(N,false);
  int time = -1;

  for(int i=0;i<N;i++)
  {
    if(!visited[i])
    {
      DFS(graph,i,visited,arrival,departure,time);
    }
  }

  for(int i=0;i<N;i++)
    std::cout<<arrival[i]<<"  ";
  return 0;
}
```

```cpp
// ladder snake game
// minimum no of moves to win the game

#include<iostream>
#include<unordered_map>
#include<vector>
using namespace std;
#define N 100

struct Edge
{
  int src;
  int dest;
};

void Solution(unordered_map<int,int>&ladder,unordered_map<int,int>&snake)
{
  vector<Edge>edges;

  for(int i=0;i<N;i++)
  {
    for(int j=1;j<=6 && i+j<=N;j++)
    {
      int src=i;
      int dest = (ladder[i+j]||snake[i+j])?(ladder[i+j]+snake[i+j]):(i+j);
      Edge e={i,j};
      edges.push_back(e);

    }
  }

}

int main()
{
  unordered_map<int,int>ladder,snak;
  ladder[4] = 14;   snake[99] = 78;
  ladder[9] = 31;   snake[95] = 75;
  ladder[20] = 38;  snake[93] = 73;
  ladder[28] = 84;  snake[87] = 24;
  ladder[40] = 59;  snake[64] = 60;
  ladder[51] = 67;  snake[62] = 19;
  ladder[63] = 81;  snake[54] = 34;
  ladder[71] = 99;  snake[17] = 7;

  Solution(ladder,snake);
}
```

```cpp
// Problem 1 regex
#include<iostream>
#include<string>
#include<regex>
using namespace std;

int main()
{
  string a,b;
  std::cin>>a>>b;
  regex c(b);
  if(regex_match(a,c))
    std::cout<<"Matched";
  else
    std::cout<<"Does not match";
  return 0;
}
```

```cpp
//Problem 5
void min_visible_bottles(int* arr, int n) 
{ 
    map<int, int> m; 
    int ans = 0; 
    for (int i = 0; i < n; i++) { 
        m[arr[i]]++; 
        ans = max(ans, m[arr[i]]); 
    } 
  
    cout << "Minimum number of "
         << "Visible Bottles are: "
         << ans << endl; 
} 
```

```py
#problem 2
from collections import Counter
t = int(input())

def permute(a,l,r):
    if l==r:
        result.append(a+k+a[::-1])
    else:
        for i in range(l,r+1):
            a[l],a[i] = a[i][0],a[l][0]
            permute(a,l+1,r)
            a[l],a[i] = a[i][0],a[l][0]

while(t!=0):
    t = t-1
    s_string = input()
    if(len(s_string)<=1):
        print(s_string)
        continue
    
    store = Counter(s_string)
    pallindrome = []
    if(len(s_string)%2 == 0):
        k = [""]
    for key,value in store.items():
        if store[key] == 1:
            k = [key]
        else:
            s = [key]*(value//2)
            pallindrome.extend(s)
    
    result = []
    permute(pallindrome,0,len(pallindrome)-1)
    if(len(result)==0):
        print("Not a palindrome")
        continue
    answer = []

    for word in result:
        answer.append("".join(word))
    answer = sorted(set(answer))
    for i in answer:
        if(len(i)!= len(s_string)):
            print("Not a palindrome")
        else:
          print(i)
```

## Hashing

```cpp
// find a pair of value whose sum is equal to 10

#include<iostream>
#include<unordered_map>
using namespace std;

void FindPair(int *a,int n,int sum)
{
    unordered_map<int,int>map;
    for(int i=0;i<n;i++)
    {
        if(map.find(sum-a[i])!= map.end())
        {
            cout<<"Pair Found at Index: "<<map[sum-a[i]]<<" "<<i<<endl;
            break;
        }
        map[a[i]] = i;
    }
}

int main()
{
    int a[] = {8,7,2,5,3,1};
    int n = sizeof(a)/sizeof(a[0]);
    int sum = 10;
    FindPair(a,n,sum);
}
```

```cpp
#include<iostream>
#include<unordered_set>
using namespace std;
int ZeroSum(int *a,int n)
{
    unordered_set<int>set;
    set.insert(0);
    int sum=0;
    for(int i=0;i<n;i++)
    {
        sum+=a[i];
        if(set.find(sum)!= set.end()) // complexity to search key is O(1)
        {
            return 1;
        }
        set.insert(sum);
    }
    return 0;
}
int main()
{
    int a[] = {4,2,-3,-1,0,4};
    int n = sizeof(a)/sizeof(a[0]);
    
    ZeroSum(a,n);
}
``` 

```cpp
#include<iostream>
#include<unordered_map>
using namespace std;
void ZeroSum(int *a,int n)
{
    unordered_multimap<int,int>map;
    for(int i=0;i<n;i++)
    {
        if(map.find(a[i])!=map.end())
        {
            if(i-map[a[i]]<=k)
                return 1;
        }
        map[a[i]] = i;
        
    }
    return 0;
}

int main()
{
    int a[] = {4,2,-3,-1,0,4};
    int n = sizeof(a)/sizeof(a[0]);
    
    ZeroSum(a,n);
}
```

```cpp

#include<iostream>
#include<unordered_set>
using namespace std;

void FindSubArraySum(int *a,int n,int sum)
{
  int windowsum = 0;
  int low=0,high=0;

  for(low;low<n;lo++)
  {
    while(windowsum < sum && high < n)
    {
      windowsum += a[high];
      high++;
    }
    if(windowsum == sum)
    {
      cout<<"Sub Array Found "<<low<<" "<<high-1;
      return ;
    }
    windowsum -= a[low];
  }
}

int main()
{
  int arr[] = {2,6,0,9,7,3,1,4,1,10};
  int n = sizeof(arr)/sizeof(arr[0]);
  int sum=15
  FindSubArraySum(arr,n,sum);
}
```

```cpp
// Custom Sort in arr1 based on arr2
#include<iostream>
#include<algorithm>
#include<unordered_map>

using namespace std;

void CustomSort(int *a,int *b,int m,int n)
{
  unordered_map<int,int>map;
  for(int i=0;i<m;i++)
  ++map[a[i]];

  index = 0;
  for(int i=0;i<n;i++)
  {
    while(map[b[i]])
    {
      a[index++] = b[i]
      --map[b[i]];
    }
    // to delete a key from map
    map.erase(b[i]);
  }
  int i=index;
  for(auto it=map.begin();it!=map.end();++it)
  {
    while(it->second--)
    {
      a[index++] = it.first;
    }

  }
  sort(a+i,a+index);
  for(int i=0;i<m;i++)
    std::cout<<*(a+i);
}

int main()
{
  int arr[] = {2,6,0,9,7,3,1,4,1,10};
  int n = sizeof(arr)/sizeof(arr[0]);
  int arr1[] = {3,5,7,2};
  int m = sizeof(arr1)/sizeof(arr1[0]);
  CustomSort(arr,arr1,n,m);
}
```