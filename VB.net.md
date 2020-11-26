# VB.Net

* To run ```VB``` programs from ```cmd-line```, we need to setup the Path in Environment as ```C:\Windows\Microsoft.NET\Framework\v4.0.30319```
* A Basic program to print ```Hello World``` in VB
```vb
Imports System
Module Module1
'This program is used to display Hello World
    Sub Main()
        Console.WriteLine("Hello World")
        Console.ReadKey()
    End Sub
End Module
```

* Sub Procedure -> A Sub procedure is a series of Visual Basic statements enclosed by the Sub and End Sub statements. The Sub procedure performs a task and then returns control to the calling code, but it does not return a value to the calling code.
```vb
 Public Sub Function_Name()
```
* Function Procedure -> The Function procedure performs a task and then returns control to the calling code. When it returns control, it also returns a value to the calling code.
* To call a function with multiple parameters, the syntax is
```vb
Function1 "Parameter1",Parameter2,"parameter3"..

Sub Function1(p1 As String,p2 As Integer,p3 As String)
    Statements
End Sub
```

```vb
Public Function Variable_to_Return() As Data_Type
```

* To create an object a class ```Dim object_name As new Class_Name()```
* Data Members are called fields and Procedure members are called methods

* Shared or Static methods are invoked without creating an object of the class
```vb
Shared Sub Main()
    Dim object1 As Class1()
End Sub
```
* ```ScriptEngine``` is a keyword that defines or can be used to check if ```vb``` language is being used as its value is ```VB```

* The ```Dim``` statement is used for variable declaration and storage allocation for one or more variables.The Dim statement is used at module, class, structure, procedure or block level

* To Create a ```DateTime``` object, ```New DateTime(yyyy,mm,dd,hh,mm,ss)```
```vb
Dim waiting As DateTime = New DateTime(2012, 12, 12, 17, 58, 1)
```

## Conversion Functions
1. CBool(expression) -> Converts the expression to Boolean data type.
2. CByte(expression) -> Converts the expression to Byte data type.
3. CChar(expression) -> Converts the expression to Char data type.

4. CDate(expression) -> Converts the expression to Date data type

5. CDbl(expression) -> Converts the expression to Double data type.

6. CDec(expression) -> Converts the expression to Decimal data type.

7. CInt(expression) -> Converts the expression to Integer data type.

8. CLng(expression) -> Converts the expression to Long data type.

9. CObj(expression) -> Converts the expression to Object type.

10. CSByte(expression) -> Converts the expression to SByte data type.

11. CShort(expression) -> Converts the expression to Short data type.

12. CSng(expression) -> Converts the expression to Single data type.


## Constants
* To indicate any variable as ```Constant``` use ```Const``` keyword
```vb
'Use of Constant Keyword
Module constantsNenum
    Sub Main()
        Const pi = 3.14149
        Dim radius,area As Single
        ' pi = 3 if done then will give error as its constant
        radius = 7
        area = radius * pi * radius
        Console.WriteLine("radius {0}",radius) 'radius 7
        Console.WriteLine("Area " & Str(area)) 'Area 153.933
    End Sub
End Module
```

## Enumeration
* An enumerated type is declared using the Enum statement. The Enum statement declares an enumeration and defines the values of its members. The Enum statement can be used at the module, class, structure, procedure, or block level.
```vb
Module constantsNenum
   Enum Colors
      red = 1
      orange = 2
      yellow = 3
      green = 4
      azure = 5
      blue = 6
      violet = 7
   End Enum
   Enum Colors08
      red ' start from 0
      orange '1
      yellow '2
      green
      azure
      blue
      violet
   End Enum
   Sub Main()
      Console.WriteLine("The Color Red is : " & Colors.red)
      Console.WriteLine("The Color Yellow is : " & Colors.yellow)
      Console.WriteLine("The Color Blue is : " & Colors.blue)
      Console.WriteLine("The Color Green is : " & Colors.green)
      Console.ReadKey()
   End Sub
End Module

'Output
'The Color Red is: 1
'The Color Yellow is: 3
'The Color Blue is: 6
'The Color Green is: 4
```

# Input And Message Box
* To Display ```Message Box```, use ```MsgBox("Any Message")```
* To Display ```Input Box```, use ```InputBox("Title of Input")```
```vb
Public Module myModule
Sub Main()
Dim user As String = 
InputBox("What is your name?") 
MsgBox("User name is" & user)
End Sub 
End Module
```

# Conditionals
* The Syntax for ```If``` is
```vb
If (condition) Then
    Statements
ElseIf (condition) Then
    Statements
Else
    Statements
End If
```
* To use short-circuit evaluation, use
```vb
Module Module1
Sub Main()
    Dim x = 5
    Console.WriteLine(If (x=5,"True","False"))
    Console.ReadLine()
End Sub
End Module
```

* The Syntax for ```Switch``` is 
```vb
Module decisions
   Sub Main()
      'local variable definition
      Dim grade As Char
      grade = "B"
      Select grade
          Case "A"
              Console.WriteLine("Excellent!")
        ' Unlike the break in C/C++ it does not require Break statement
          Case "B", "C"         'works for both B and C
              Console.WriteLine("Well done")
          Case "D"
              Console.WriteLine("You passed")
          Case "F"
              Console.WriteLine("Better try again")
          Case Else
              Console.WriteLine("Invalid grade")
      End Select
      Console.WriteLine("Your grade is  {0}", grade)
   End Sub
End Module
```

# Loops
1. For Next
```vb
Module Loops
    Sub Main()
        Dim a As Byte
        For a = 10 to 20 Step 2
            Console.WriteLine("Value of a is "&str(a))
        Next
    End Sub
End Module
'value of a: 10
'value of a: 12
'value of a: 14
'value of a: 16
'value of a: 18
'value of a: 20
```
2. Do Loop
```vb
Module DoLoop
    Sub Main()
        dim a As Integer
        a = 23
        Do
            Console.WriteLine(str(a))
            a += 1
        Loop While (a<=26)
        Check() 'Calling Function
    End Sub

    Sub Check()
        dim a As Integer
        a = 0
        Do
            Console.WriteLine(str(a))
            a += 1
        Loop Until (a>5)
    End Sub
End Module
```
3. For Each Next 
```vb
Live Demo
Module loops
   Sub Main()
      Dim anArray() As Integer = {1, 3, 5, 7, 9}
      Dim arrayItem As Integer
     'displaying the values
      
      For Each arrayItem In anArray
         Console.WriteLine(arrayItem)
      Next
      Console.ReadLine()
   End Sub
End Module
```
4. While ... End While
```vb
Module loops
   Sub Main()
      Dim a As Integer = 10
      ' while loop execution '
      
      While a < 20
         Console.WriteLine("value of a: {0}", a)
         a = a + 1
      End While
      Console.ReadLine()
   End Sub
End Module
```
5. With ... End With
```vb
Module loops
   Public Class Book
      Public Property Name As String
      Public Property Author As String
      Public Property Subject As String
   End Class
   Sub Main()
      Dim aBook As New Book
      
      ' Instead of Writing aBook 3 times to assign value we can
      With aBook
         .Name = "VB.Net Programming"
         .Author = "Piyush"
         .Subject = "Information Technology"
      End With

      aBook.Author = "Pykid"
      
      With aBook
         Console.WriteLine(.Name)
         Console.WriteLine(.Author)
         Console.WriteLine(.Subject)
      End With
      Console.ReadLine()
   End Sub
End Module
```
* VB supports ```GoTo``` statement as
```vb
Live Demo
Module loops
   Sub Main()
      ' local variable definition 
      Dim a As Integer = 10
Line1:
      Do
         If (a = 15) Then
            ' skip the iteration '
            a = a + 1
            GoTo Line1
         End If
         Console.WriteLine("value of a: {0}", a)
         a = a + 1
      Loop While (a < 20)
      Console.ReadLine()
   End Sub
End Module
```

# Strings
* The String keyword in VB is an alias for ```System.String``` class
* You can create string object using one of the following methods:
    1. By assigning a string literal to a String variable
    2. By using a String class constructor
    3. By using the string concatenation operator (+)
    4. By retrieving a property or calling a method that returns a string
    5. By calling a formatting method to convert a value or object to its string representation
```vb
Module strings
    Sub Main()
        Dim fname,lname,fullname As String
        fname = "Piyush"
        lname = "Agarwal"
        fullname = fname + " " + lname
        Console.WriteLine(fullname)

    ' By using String Constructor
    Dim characters As Char() = {"H","E","Y"}
    Console.WriteLine(characters)
    Dim greetings As String = New String(characters)
    Console.WriteLine(greetings)

    ' Methods returning String
    Dim sarray() As String = {"Hey","Piyush","Agarwal"}
    Console.WriteLine(sarray)
    Dim message As String = String.Join(" ",sarray)
    Console.WriteLine(message)

    ' formatting method to convert a value
    Dim waiting As DateTime = New DateTime(2020,11,22,19,21,08)
    Dim chat As String = String.Format("Message Sent At {0:t} on {0:D}",waiting)
    Console.WriteLine(chat)
    End Sub 
End Module
```
## String In Built Functions
1. String.Compare -> returns 0 if strings are equal
```vb
Module strings
   Sub Main()
      Dim str1, str2 As String
      str1 = "This is test"
      str2 = "This is test"
      
      If (String.Compare(str1, str2) = 0) Then
         Console.WriteLine(str1 + " and " + str2 + " are equal.")
      Else
         Console.WriteLine(str1 + " and " + str2 + " are not equal.")
      End If
    
   End Sub
End Module
```
2. String.Contains -> checks if certain substring is present in main string
```vb
Module strings
   Sub Main()
      Dim str1 As String
      str1 = "This is test"
      
      If (str1.Contains("test")) Then
         Console.WriteLine("The sequence 'test' was found.")
      End If
      Console.ReadLine()
   End Sub
End Module
```
3. String.Substring -> returns a Substring from a main string
```vb
Module strings
   Sub Main()
      Dim str As String
      str = "Last night I dreamt of San Pedro"
      Console.WriteLine(str)
      
      Dim substr As String = str.Substring(23)
      Console.WriteLine(substr)
      Console.ReadLine()
   End Sub
End Module
```
4. String.Join -> Used to join an string iterable using a character. Its syntax is ```String.Join("Character to join with","String to join")```
```vb
Module Joining
    Sub Main()
        dim story As String() = {
            "Hey",
            "My Name is {0}",
            "And ofcourse i am  smart"
        }

        Dim name As String = Console.ReadLine()
        Console.WriteLine(String.Format(String.Join(vbCrLf,story),name))
    End Sub 
End Module
```
5. String.Concat -> this function is to concatenate any number of string objects and return a joined string 
```vb
Module ConcatenateString
    Sub Main()
        'Console.Read() reads the values in ASCII value
        Dim word,sentence As String
        word = ""
        sentence = ""
        While(True)
            word = Console.ReadLine()
            If word.length = 0 Then
                Exit While
            End If
            IF sentence.length = 0 Then
                sentence = String.Concat(sentence,word)
            Else
                sentence = String.Concat(sentence," ",word)
            End If
        End While 
        Console.WriteLine(sentence)
    End Sub
End Module
```

# Date and Time
* Data Type of Date Value is ```System.DateTime```
* The ```DateAndTime``` class belongs to the ```Microsoft.VisualBasic``` namespace and the ```DateTime``` structure belongs to the ```System``` namespace
* ```DateTime``` can be used in C# as well but not the ```DateAndTime```
* To Get the DateTime value in ```Universal Time (UTC)``` format, we can use ```UtcNow``` function
* To Find the Complete list of ```DateTime``` methods, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime?redirectedfrom=MSDN&view=net-5.0">Click Me</a>

```vb
Module Module1
    Sub Main()
        ' Date Time Constructor year,month,day,hour,min,sec
        Dim date1 As New Date(2020,11,25,14,23,12)
        ' 25-11-2020
        Console.WriteLine(date1.toShortDateString)

        ' Initialize a new DateTime value
        Dim date2 As Date = #11/25/2020 01:08:52 PM#
        ' 25-11-2020 13:08:52
        Console.WriteLine(date2)

        ' Few properties
        Console.WriteLine(Date.Now) ' 25-11-2020 15:09:24
        Console.WriteLine(Date.UtcNow) '25-11-2020 09:39:24
        Console.WriteLine(Date.Today) '25-11-2020 00:00:00
        
    End Sub
End Module
```
* To Find the Complete list of ```DateAndTime``` class, <a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.dateandtime?redirectedfrom=MSDN&view=net-5.0">Click Me</a>
