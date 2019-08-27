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
r
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
    (1) byte
    (2) short
    (4) int
    (8) long
    (2) char
    (4) float
    (8) double
    64 - bit system
    (8) float
    (16) double
    (1) boolean  ```till jdk 1.3```
    (1 byte) boolean  ```after 1.3 jdk```
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
* <u> Local Variable </u> ~>  Variable defined inside a method and accessef inside that method only
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
int a1[] = [1,2,3,4,5]; // array as referenced variable = size

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



