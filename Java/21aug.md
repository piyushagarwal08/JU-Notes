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





