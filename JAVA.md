# JAVA Day 1
## Date: 21st August 2019   UNIT 1

## Introduction
* Java was initiated by ```James Gosling, Mike Sheridan and patrick Naughton``` at ```sun Microsystems``` in ```1991```
* initially named as ```Oak```
* Originally designed for interactive TV
* Before jdk 1.6 , java was not pure object oriented programming because it used variables not objects that is using primitive ```data types``` instead of project
    ```e.g,. int a;```
* Though from ```jdk 1.6``` or ```java 6``` , it started using ```wrapper ``` classes to become ```pure object oriented programming```
* <u> wrapper classes  </u>  these are used to make objects of primitive data types
    ```e.g., Integer a=new Integer(5);```

## Features of JAVA
1. Simple
    * Syntax similar to C++
    * no use of pointers
    * no need to remove unreferenced pointers

2. OOP's
    * Pure Object oriented language because we are not able to execute a single line of statement in java without using class and objects ```(Interview special)```

3. Platform Independent
    * Once a program is compiled then it can run anywhere and in any system
    * not produce machine specific code
    * software based platform independence
    * Software run on top of other platform
    * It has 2 components:
        1. Runtime environment
        2. Application Programming Interface
    
    #### Why JAVA is platform independentant?
    * Inside ```.exe``` file the code is translated to OS internal commands in C++
    * For example , a ```print``` statement replaces with ```display``` function to print something on ```windows``` console  in C++
    * In Java , after compiling the file created is ```.class``` and not ```.exe``` 
    * The ```.class``` file contains ```byte code``` and is read by ```interpreter``` at run time
    * JAVA program runs inside JVM
    * Uses run time environment of its own

5. Robust
6. Portable
7. High Performance
8. Multi Threading 
9. Dynamic
10. Interpreted 

* Class Loader seperate local file system form network imported files
* byte code verifier to check the code frament for illegal code

## Concepts of OOP's

### Class
* Collection of member variables and member functions
* blueprint to construct object
* By default all members are public in JAVA
* User defined data type
* It has access specifiers private, public, protected
* class is a logical representation
* Things defined inside class are the properties of the objects
* Example
```java
class Lamp
{ // instance variable
private boolean isOn;
//method
public void turnOn(){isOn}}
```

### Object
* instance of a class
* Object is a real world entity
* Need object to access class members
```java
class Lamp
{
    public static void main(String[] args)
    { 
        Lamp l1 = new Lamp(); // create l1 object of Lamp CLass
        Lamp l2 = new Lamp(); // create l2 object of Lamp Class
    }
}
// Object is ```new Lamp```
// l1 is a referenced variable of specified class
```

### Abstraction
* show only essential details
* focus on what class can do and what it must do
* Done in java using interface
* e.g., Email send system
* A phenomena by which we just show essential details to the user and hiding the rest

### Encapsulation
* Wrapping up of data together into a single unit class
* hiding data
* focus on how to achieve the functionality
* Done in java using access modifiers
* e.g., CSE department
* binding the accessibility of some variable inside a class


## Inheritance
* Inheritance is the process by which we can use existing code
* Inheritance is the property by which object of one class can acquire the property of other class
* <u> Base Class or Super Class</u> the class which has main properties
* <u> Derived Class or Sub class </u> inherits the existing properties of a class
* Reusability of code


### Types Of Inheritance
* Multiple inheritance of classes is not allowed in ```JAVA``` because of ```Diamond Problem``` and it has a solution of ```Virtual Classes```
* virtual classes requires pointers but there are no pointers in java
1. Single Level Inheritance
    ``` 
    A
    |
    B
    ```
2. Multi Level Inheritance
    ```
    A
    |
    B
    |
    C
    ```
3. Multiple Level Inheritance (#### Not present in JAVA)
    ```
    B           C
    |___________|
          |
          A
    ```
4. Hierarichal Inheritance
    ```
            A
        ____|____  
        B       C
    ```

## Polymorphism
* One name many forms
* It depends on the instance of objects
* It can be achieved using ```method overloading```
* It is of 2 types
    1. Static Polymorphism ( compile )  -> method overloading, constructor overloading  
    2. Dynamic Polymorphism ( run time ) -> method overriding
    
```java
int getdata (int,int)  //1   
void getdata(int,int)  //2
int getdata(float,float)  //3
void getdata(int,float)   //4
int getdata(float,int)   //5

/* 
1 & 2 are not overloading
1 & 3 are function overloading
1 & 4 are function over loading
1 & 5 are function over loading
*/
```
* 3 rules to find overloading(polymorphism)
    1. ignore the data type declaration ( int, void, char etc)
    2. Name of methods should be same 
    3. no of arguments or types of arguments or order of argument should be different
    

## Java Virtual Machine
* ```JVM``` is the component due to which ```java``` is very ```powerful```
* It is a combination of ```java interpreter and operating system```
* It requires compiled file ```.class``` 
* Communicates between ```.class``` file and OS
* Decodes the ```.class``` file
* JVM is platform dependent and because of JVM java programs are platform independant
* ```JAVA SOFTWARE``` is platform dependant but not its ```programs```


## JDK(Java Development Kit) and JRE(Java Runtime Environment)
* JRE is a collection of ```JVM + Java Libraries```
* Collection of ```JRE + Java Development Tool Kit``` is ```JDK```
* The ```.class``` file contains encoded instruction for the java interpreter and are known as java byte code


## Data Types
* Data types are of two types
    1. Primitive -> defined in language by default
    2. Non Primitive -> user defined data structure
* Primitive Data Types
    1. Numeric 
        * Integer (Int, Float or Double)   
        * Character (char)
    2. Boolean
* Non Primitive
    array,stack,queue
* Types of Size
    32 - bit System
    1. (1) byte
    2. (2) short
    3. (4) int
    4. (8) long
    5. (2) char
    6. (4) float
    7. (8) double
   
    64 - bit system
    1. (8) float
    2. (16) double
    3. (1) boolean  ```till jdk 1.3```
    4. (1 byte) boolean  ```after 1.3 jdk```
* Short is important and char is also used in short

# DATE: 27 August 2019

* ## ```  Narrowing of Data Type is not Allowed JAVA ```
## What is narrowing of Data Type?
* b < S < I < L < F < D   these are data types
* this narrowing is not allowed in java

## Why we can store more data in ```char``` as compared to ```short```
* In short or integer type data type , the storage size is 15 bit due to presence of signed bit 
* In char data type , the storage size is 16 bit as there is no signbit
* 2 byte = 16 bit

## Variable
* Name of a memory location
* Each variable has a datatype
* 4 rules to define a variable are:
    1. the variable name should not start with a numeric digit
    2. variable name should not contain any whitespace
    3. variable name should not contain any ```language keywords``` or ```primitive words```
    4. We can not use special character except ```_```

## Types of variables in JAVA
* There are 3 types of variable
    1. Local Variable
    2. Instance Variable
    3. Static Variable
* <u> Local Variable </u> ~>  Variable defined inside a method and accessed inside that method only
* <u> Instance Variable </u> ~> Value is object specific , value not shared with other instances , Declared inside class but outside the body of method
* <u> Static Variable </u> ~> Declared with static keywords , Shared among all instances , Memory allocated once at compile time, Should be initialized first that is each object will be able to change value of class variables and values will be modified for each object

```java
class Demo 
{
    int a = 50; // instance variable
    static int b = 100; // static variable
    void func()
    {
        int x = 90; //local variable
    }
}
```

## Array
* Collection of homogenous items stored under one name
* size is fixed
* it can be used as a object
* Syntax
```java
// pre declaration of array
int[] a1 = new int[5];  // type name[] = new type[size]

// post declaration of array
int a1[] = {1,2,3,4,5}; // array as referenced variable = size

int []a, b, c[];  // pre declaration gets associated with all variables till semi-column in its right side
// here a is 1d array , b is 1 d array and c is 2d array
```
* no of columns can be variate in JAVA
* To find the length or size of array that is no of elements in array, we use the function ```variable-name.length```
* For 2D array, ```variable-name.length``` will return no of rows and ```variable-name[i].length``` will return no of elements in ```ith ``` row
* For 3D array, ```variable-name.length``` will return no of 2D array in 3D array
```java
int [][]a[]= new int[6][4][2]  // 3D array
/*
| [ [ ] ] | [ [ ] ] | [ [ ] ] |
*/

``` 

### <u> Variable Length of Array </u>
    ```
    |0|1|2|3|4
    |0|1|
    |0|1|2|
    |0|2|3|4|5|6|
    |0|
    ```


## Variable Declaration
* 2D Array
```java
int a[][] = new int[5][4];
int []a[];
int [][]a , b[]; // 3d array
```

# Date: 29th August 2019

## Expression
* built using values,variables, operators and method calls
* (a*2) is an expression and b+ (a*2); is a statement
* Expression is a clause, and the statement is the complete sentence since it forms the complete unit of execution
* expression produces intermediate result

## Types of expression:
* produce a value
* assign a variable
* those that have no result but have a side effect because an expression can include a wide range of elements such as method invocations or increment operators that modify the state.

## Operators
* symbols that operates on one or more arguments to produce results
* Arguments here are operands
    ```
    result = a+b
    ```

## Types of operators
1. Assignment operator
    * lvalue = rvalue -> rvalue is assigned to lvalue
2. Arithmatic operator
3. Relational Operator
    * ```==``` and ```!=``` are object reference operators
4. Logical Operator ```AND (&&)  OR(||)   NOT(!)```
5. Logical Operator bit level
    ```
    AND &
    OR |
    XOR ^
    NOT ~
    ```
    ```java
    int a= 10; // 00001010 = 10
    int b = 12; // 00001100 = 12
   ```
   * logical bit wise opeator checks first condition before proceding further
   * logical operator checks all conditions before taking any conditions
   * Number is represented into 32 bit(Theoretically)
   ```
   result = a & b
   * result is negative then the answer will be 2's complement
   ```
6. Shift Operators
    * Shift Operators(bit level)
    * Shift Left  ```<<``` Fill with zeros
    * Shift Right ```>>``` Based on Sign
        * if number is positive then it will be filled with ```0```
        * if number is negative then it will be filled with ```1```
    * Shift Right ```>>>``` Fill with zeros
    ```
    a = 0011
    a << 2 
    0011 ~> 001100

    a >> 2
    0011 ~> 0000

    b = -4
    b >> 2
    111111111111111111111111100 ~> 11111111111111111
    0100 ~> 0001
    -4 ~> -1 (twos complement)

    a >>> 2
    0011 ~> 0000
    3 ~> 0
    ```

## Control Structures
* Block of program to change the execution of program based on logic and values
* 3 types of control structures are:
1. Conditionals
    1. IF
    ```java
    if (condition)
    {
        //codes
    }
    //codes after if
    ```
    2. if else
    ```java
    if (condition) {

    }
    else if {

    }
    ```
    3. nested if else
    4. switch
    ```java
    switch (condition)
    {
        case 1 : //code
        case 2 : //code
    }
    ```

2. loop
    1. For
    ```java
    for(initialization;testExpression;update)
    {
        //code inside for loop's body   
        // to run it for infinite just testExpression == True
    }
    ```

    2. While loop
    ```java
    int i = 0;
    while(condition)
    {
        statement
        condition update
    }
    ```
    3. Do While
        * It executes atleast once

3. Jump Statements
* unconditionally transfer the program control to another part of program
    1. Continue
    2. Break
    3. Return ~> it immediately quit the current method and return to the calling method

## Basic Syntax
```java
class class-name-user-defined{
    // access-specifier method-static void main(String[] args)
    public static void main(String[] args){
        ... ..      ...
        n=3;
        result = square(n);
        ... .. ...
    }
    private static int square(int i){
        // return statement
    }
    
}
// static method ~> we dont need any object to call the function/method
// String[] is a variable length array which stores the input from cmd
// args is just a variable name which can be user-changeable
```
* file name should be similar to class name but its not compulsory
* at compile time we need ```file-name.java```
* at run time we need ```class-name.class```

                <-----------------The End of Unit 1---------------------->

# Date 3rd September 2019
* To run any code
    1. Save the file with code
    2. Open cmd and run ```javac file-name.java```
    3. it will create a ```.class``` file
    4. to execute ```java file-name```
* Default package always associated with java code is ```java.lang```
* Any word starting with ```Capital Letter``` is a ```Class```
* All methods are iitiated with ```small letters```
* To take input we use class ```java.util.*```
    ```java
        Scanner sc=new Scanner(System.in); // object of the same class
        System.out.print("enter the value of a: ");
        a = sc.nextInt();  // Camel Notation used in java
        // nextInt works same as scanf of C 
    ```
* ```random``` class produces ```17 decimal place``` digit
* Static method can only call other Static methods

## For Each Loop
* Syntax
```
for(data-type variable:iterable-structure)

for(int i:a[])
    further code
```

# Date 4th September 2019


## String
* <u> String </u>  ~> An array of characters is called String
* ```String``` is also a ```class``` in java which can be used by making objects
    ```
    String s = 'Deepak';
    ```
* String objects are immutable
* While creating the first object of any String always ```2 objects``` are created
* The two objects created are ```Heap``` and ```Constant```
* when creating further objects of similar String, the compiler checks the constant object for availablity , and if available then link to its reference else create another ```Heap```
* The Heap object is used to process or compute the String with other commands and Constant for Similar String checking

## Shallow Comparsion
* It is a functionality of java where Strings are compared with each other based on their referecnce variable and not on their actual value
* To compare two strings we use the function ```string-variable-name.equals(another-string-variable-name)```
* To compare two strings without ```CaseSensitive``` we use function ```String1.equalsIgnoreCase(String-2)```
* To convert String to ```Lower Case``` use the function ```toLowerCase()```
* To convert String to ```Upper Case``` use the function ```toUpperCase()```
* To find the charater in a string with ```index``` position use the function ```string-name.charAt(index-position)```
* Constructor can be made ```private``` using ```Single Turn Pattern```


# Date : 5th September 2019

## Inheritance
* To inherit one class in another , we use the function ```extends```
* All the classes being inherited by a ```Derived``` class are written seperated by ```,```
    ```java
    // created a base class
    class Super  // Java has a inbuild keyword super 
    {
        int a = 0;
        public void show()
        {
            System.out.println("A="+a);
        }
    }

    // created a derived class
    class Sub extends Super 
    {
        int b = 0;
        public void display()
        {
            System.out.println("B="+b);
        }
    }
    ```
* if we do not define a specific ```constructor``` in a class then ```compiler``` creates a constructor for the same ```class``` so that a user is able to make ```object``` of the ```class```

* We have three types of constructor
    1. Default ~> to initialise the variable with default data types
    2. Parameterised COnstructor ~> Initialse the variables of the class defined by user at run time
    3. Copy Constructor ~> Previously existing objects are used to create new objects
* Constructor of Super Class can not be called in the derived class just by using its name
* To call the constructor ```Base``` class inside the ```Derived``` class we use the function ```super();```
* If we are using ```super``` keyword then it must be the ```FIRST``` executable keyword in the ```Sub``` or ```Derived``` class created by the ```user```
* If you define same variable as ```argument to a function``` and to be assigned, we can use keyword to differentiate the varaiables
    ```java
    class Sub extends Super 
    {
        int b = 9;
        public Sub(int b)
        {
            super(); // it calls the constructor of the Base Class
            this.b=b;
        }
    }
    ```

# Date : 6th September 2019

## Overloading
* Same name with different names or arguments

## Overriding
* Same name with same number and name of arguments

```java
class Super
{
    int a;
    public Super(int a) // constructor
    {
        this.a = a;  // instance variable
    }
    public void show()
    {
        System.out.println("A=" + a);
    }
}
class Sub extends Super
{
    int b;
    public Sub(int b)
    {
        Super(b*2);
        this.b = b;
    }
    public void display()
    {
        System.out.println("B="+b);
    }
}
class Day4Demo
{
    public static void main(String args[])
    {
        Sub obj = new Sub(10);
        obj.display();
    }
}
```
* ```this``` it differentiates instance variable with arguments
* In Inheriatnce(overriding) , the top variable(variable of base class) can store the Sub/Derived class object or variable where as Sub/Derived class can not do so
```java
Sub obj = new Super(10); // not possible
// where as
Super obj = new Sub(20); // is possible
```

## Method Overloading
```java
class Add
{
    int a , b;
    float c;
    public void getAB(int a,int b,float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public void Sum(int a , int b)
    {
        System.out.println("Sum ="+(a+c));
    }
    public void Sum(int a, float c)
    {
        System.out.println("Sum = " + (a+c));
    }
}
class DayOverriding
{
    public static void main(String args[])
    {
        Add obj = new Add();
        obj.Sum(2,3);    
        obj.Sum(2,2.5); // By default double
    }
    // Sum =5
    // Sum = 4.5
}
```
---
# Date: 17th September 2019
# Unit 2 Types of Java Classes

## Content
1. Abstract Class
2. Static Class
3. Inner Class
4. Package
5. Interface
6. Wrapper Class,Access Control
7. Super,this,final keywords

## Abstract Class
* A class which is declared with the abstract keyword is known as an abstract class in Java. It can have abstract and non-abstract methods
* <b>Abstract</b> is a process of hiding the implementation
* It shows only essential things to user and hides the internal details
* Ways to achieve abstaction
    1. Abstract Class (0 to 100%)  ~> depends on developer
    2. Interface ( only 100%)
* Implementation
    1. must be declared with ```abstract``` keyword
    2. may have abstract method and non abstract method
    3. must have ```Atleast One``` abstract method and vice~versa
    4. it need to be ```extended``` means need to implement inherited
        * the abstract class will be the super class and need to be inherited in some class
    5. it cannot be ```instantiated```, means we can not create object of abstract class

## Abstract Method
* a method without definition is known as abstract method
* it must be declared with abstract keyword
* It must be override in sub class otherwise subclass will become abstract
* Syntax: ```abstract void function-name();```

```java
//abstract return_type Method_Name(ARGS)

abstract void fun(int,int);

abstract class Demo{
    int a,b;
    abstract void fun(int,int);
    void getdata(){
        a=10;
        b=20;
    }
}
```

## Interface
* Interface is a process to achieve abstraction
* interface is the just a blueprint of a class
* it has ```static``` and ```final``` variable ~> value will be constant for all objects
* it has only ```abstract``` method
* interface always be implemented
* it cannot be instantiated just like the abstract class
* It is not a class itself but tells the structure of the class
* Interface must be ```implemented``` where as class must be ```extended``` for ```abstraction```
* interface is a collection of abstract methods and constants
* Can not create ```object``` of ```interface```
* All methods declare in an interface are public abstract by default
* Till ```JDK 1.7``` , Non abstract methods are not allowed in interface
* From ```JDK 1.8```, we can define ```non-abstract methods``` inside ```interface``` as well
* Everything defined inside interface is public by default

```java
// A function with definition but do nothing can be stated as
void func-name()
{

}
```

```java
class A{
    //declaration and definition
}
interface A{
    //declaration only
    // all methods will be abstract
    // 
}
```
```java
interface name_interface{
    //declare variables
    //declare methods
}
interface Animal()
{
    int legs=4;
    void fun();
}
```

## Relation between Class and Interface
* Class extends Class
* Class implements Interface
* Interface extends Interface

## Multiple Inheritance in java by interfcae
```
        (interface)         (interface)
                |                 |
implements      |_________________|          
                        |
                      (Class)

        (interface)         (interface)
                |                   |
                |___________________| (extends)
                        |
                     (Class)
```

## Difference    
<img src="ClassVsInterface.png"></img>

# Date 19th September 2019

## Package
* A java package is a group of similar types of classes , interfaces ad sub-packages
* Package in java can be categorized in two form, built-in package and user-defined package
* ```Abstroict window Toolkit``` is ```AWT```
* There are many buil in packages such as java,lang,awt.javax,swing,net,io,util,sql etc

## Syntax for using Package
```java
package Name_Package;
import.....;
class......{
    statement...
}
// package must be the first line inside the source code file 
```
* Name_Package is the full path of directory separated by ```.```
* E.g., ```Desktop.Ju-Notes.JavaCode```

## Syntax for compile the package program
```
javac -d directory javafilename
javac -d . Demo.java  # example 1
```
* Package is used for classes in which main class function is not included

## Access Control
* It is of 2 types
1. Access Modifiers ~> Defines the accessibility limitations
    * Default
    * Private
    * Protected
    * Public
2. Non-Access Modifiers ~> it defines the functionality but not the accessibility
    * Static
    * Abstract
    * Final
    * Synchronized
* Modifiers provide some kind of feature or limitation to an data structure like class or object or methods

<table>
<tr>
<td>
Access MOdifier
</td>
<td>
within class
</td>
<td>
within package
</td>
<td>
outside package by subclass only
</td>
<td>
outside package
</td>
</tr>

<tr>
<td>
Private
</td>
<td>
Y
</td>
<td>
N
</td>
<td>
N
</td>
<td>
N
</td>
</tr>

<tr>
<td>
Default
</td>
<td>
Y
</td>
<td>
Y
</td>
<td>
N
</td>
<td>
N
</td>
</tr>

<tr>
<td>
Protected
</td>
<td>
Y
</td>
<td>
Y
</td>
<td>
Y
</td>
<td>
N
</td>
</tr>

<tr>
<td>
Public
</td>
<td>
Y
</td>
<td>
Y
</td>
<td>
Y
</td>
<td>
Y
</td>
</tr>
</table>


## Java Inner Classes
* Java ```inner class``` or ```nested class``` is a class which is declared inside the class or interface
* We use inner classes to ```logically group``` classes and interfaces in one place so that it can be more readable and maintainable, that is keeping data which is dependable upon each other can kept together
* It can access all the members of ```outer class``` including ```private data members and methods```
* It is a part of nested class
* Non static nested classes are known as inner classes

## Advantages of Inner Classes
* It can access all the members (data members and methods) of outer class including private

## Types of nested class
1. Non static nested class
    * Member inner class ~> normal inner class
    * Anonymous class ~> name is defined by compiler at the runtime, a class without name
    * Local Inner class ~> class which is defined inside a method
2. Static class
    * Static nested class

### Anonumous Class
* Name is decided by compiler
* Used in Artificial Programs
```java
// Anonymous inner class
abstract class Demo{
    public void show();
}
class testDemo{
    Demo p=new Demo(){ // Anonymous class... name will be decided by compiler at run time
        public void show(){
            S.o.p("Hello Demo");
        }
    };
    p.show();
}//end test demo

// another example
Demo1 d = new Demo1(
    new TestDemo(){    // starting of syntax of anonymous class
    void data()
    {
        ...
    }
}
);
// TestDemo is abstract class
```

## Local Inner Class
```java
class Demo{
    public void display(){
        class inner{
            public void show(){
                SOP("Local inner ");
            }
        
        }//local class ends
        inner obj=new inner()l
        obj.show();
    }//display ends here
}
```

## Static Inner Class
* can access static data members of outer class including private only
```java
class outer{
    static int a = 10;
    int b = 20; // not accessible
    static class inner{
        public void show(){
            s.o.p("value od a="+a);
        }//show ends
    }//inner class ends
}//outer class ends
```

## Final
* it can be applied to variable, method and class
* if we make a variable as final, then it become the constant. That means values of that variable can't be changed
* If we make a method as final then it can't be overridden . That means overriding of final methods are not allowed
* If we make a class as final then it can't be inherited

## Super
* The super keyword in Java is a reference variable which is used to refer ommediate parent class object
* super can be used to refer immediate parent class instance variable
* super can be used to invoke immediate parent class method
* super is used to invoke constructor of ```Super``` or ```base``` class

## This
* this can be used to refer current class instance variable
* this can be used to invoke ```current``` class method (implicitly)
* this() can be used to invoke current class constructor
* this can be passed as an argument in the method call

```java
class Demo{
    Demo(int a){
        x = a;
    }
    Demo(int a, int b){
        y=b;
        this(a)
    }
    Demo(int a, int b,int c){
        z = c;
        this(a,b)
    }
}
```
---

# Date : 9th October 2019
# Unit 3 Exception Handling

## Types of Errors:
1. Compile Time Error -> Some kind of ```Syntax error```
2. Run Time Error -> Not run due to ```environment error``` 
3. Logical Error -> Compiled and run but Error in some code input due to which we are not getting desired output

* ```Exception``` are the cause by which our programs get terminated or giving some wrong output
* If we get such error at ```compile time``` then Exception is known as ```Compile time``` exception in our program
* If we get  such error at ```execution time``` of the program then such errors are known as ```Run time``` exceptions

## Types of Exception
* ```Check``` and ```Uncheck``` exceptions are with respective to the ```compilers``` point of view
1. Compile Time Exception
    * These are also known as ```checked exceptions```
    * Examples
        * I/O Exceptions
        * SQL Exceptions

2. Run Time Exception
    * These are also known as ```unchecked exceptions```
    * Examples
        * Arithmatic Exception (due to some calculation mistake)
        * Array Index Out of Bound Exception

## Handling Exception
* There are two ways to handle ```exception```
    1. ```Throw```
        * All exceptions will be handled by compiler only
        * Program always gets successfully compiled
        ```java
        Class ABC{
            P.S.V.M(String args[]) throw {
                ......
                ...... // Exception occur
                ......
            }
        }
        ```
        * Does not compile when error occurs due to package missing issues
        * We can define the particular ```name of package``` for which error may occur
        e.g., ```IOException```
        * or just define the main class ```Exception```

    2. ```Try , Catch , FInally```
        ```java
        try {
            //Exception Code... the line of code in which we are expecting some exception to be generated
        }
        catch (Exception e) {
            // corrective measure of exception occurring in upper block that is in try block
        }
        finally {
            // it is executed always whether we are having error or not
        }
        
        ```
        * If we are defining ```try``` block then atleast one ```catch``` block is necessary to be defined
        * finally block is not necessary to be defined , its upto the developer
        * It is of 3 types:
            1. Try_catch with single catch
            2. Try_catch woth multiple catch
            3. Try_catch with nested try_catch
        
## User Defined Exception
* Generating a self customized exception and terminating the program as per our need


# UNIT 4 Input/Output Stream
* I/O stream can be implemented by two ways:
    1. Sequence of bytes
    2. Sequence of characters 
* Stream can be defined as flow of data
* To work with any Stream, follow the steps:
    1. Import the specific stream package
    2. Create the object of concern I/O Stream
    3. Determine The input (make source using CLA or at compile time) and output points for work to be performed
* Object is supermost class of Java,for both pre-defined and user-defined classes
* Every Stream should be closed ```.close()``` before exiting the program

## Byte Stream
* Each class has an Input and Output Stream
* Available Classes are  of 7 types:
    1. Input (SYstem.in)
    2. Output (System.out)
    3. Filter Stream
    4. Buffered Stream ~> Tends to save the inputs to input stream and output to output stream which makes it faster at the moment of execution
    5. Data Stream ~> Used in networking tasks , A socket is generated between 2 systems trying to communicate with each other
        ``` |A|~~~> (Socket)~~~>|B|```
    6. Print Stream
    7. File stream ~> Specifically used for ```File Handling```
* to send some errors we can use ```System.err```

## Character Stream
* Reader and Writer
* It is again of 4 types
    1. Input Stream Reader
    2. Output Stream Writer
    3. Buffered Stream Reader/Writer
    4. File Reader/Writer

## Input Streamm class
* Java.io is an abstract class for all input stream
* Basic ```read()``` method read a single unsigned byte of data and returns the integer value of the unsigned byte
* ```read()``` returns ```-1``` at the EOF
* Every input stream should be closed before exiting the program

## Reading Multiple Bytes
* I/O is slow in comparison to memory access, limiting the number of reads and writes is essential
* The basic read() method only reads in a byte at a time
* The following two overloading read() methods read in multiple bytes into an array of bytes
    1. public int read(byte b[])
    2. public int read(byte b[], int offset=2)

## Reading from File Input Streams
```java
import java.io.*;
class FileInputStreamDemo{
    public static void main(String args[]){ //CLA - command line arguments
        try {
            //Create a file input stream
            FileInputStream fis= new FileInputStream("Path" args[0]);
            //read 12 byte from file
            int i;
            while(i=fis.read() != -1) // at EOF byte is -1 which indicates the end of file
            {
                System.out.println(i);
            }//close file output
            fis.close()
        }catch(Exception e){ System.out.println("Exception:"+e)}
    }
}
```
* An example of Buffered Input Stream, it will increase the Execution Speed of the Program
```java
import java.io.*;
class FileInputStreamDemo{
    public static void main(String args[]){ //CLA - command line arguments
        try {
            //Create a file input stream
            FileInputStream fis= new FileInputStream("Path" args[0]);
            //read 12 byte from file
            BufferedInputStream bis = new BufferedInputStream(fis);
            int i;
            while(i=bis.read() != -1) // at EOF byte is -1 which indicates the end of file
            {
                System.out.println(i);
            }//close file output
            fis.close()
        }catch(Exception e){ System.out.println("Exception:"+e)}
    }
}