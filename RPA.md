# RPA Robot Processing Automation
# Date: 29th August 2019


## Notes:
* VB - > Visual Basic
* To create a variable click on activity dialog box and then create 
* Single activity can have multiple input boxes
* Message box is used to print some output to screen, generally used to print the variabes
* Open Browser-> To open a browser by program
* Get visible Text -> used to indicate which text to work on and in output section select the variable name to store the data
* Write Line-> used to write lines
* Open Application -> used to open an application
* Type Into -> used to write something inside the application
* To generate new random values we can use the function ```new Random().Next(range)```


## Properties
* Present on right hand side tab
* used to define what our activity will do

## Input
* Title -> defines a message as for what the input is made for
* Label -> used to define the question the user will be prompted with
* Result -> the variable to store the input to

## Variables 
* In ```UIPATH``` variables can store different types of data like 
    1. Numbers
    2. Text
    3. Images
    4. Files
    5. Colors
* Data Types for variables are:
    1. Integer
    2. String ( between " ")
    3. Boolean
    4. Generic ( All of the above)
    5. Array of ( A list of any type)
* Default column in ```variable``` is used to set some default value for any variable
* ```Scope``` is the region or field inside which a variable will be visible and can be used

## WorkFlows
* There are 2 types of workflows in UIPATH:
    1. Sequence ~> If our process is ```linear``` and involves execution of several consecutive actions,its best
    2. Flowchart ~> If our process involves ```complex connections``` between activities , then ```flowcharts``` are more convenient

## Assign
* It is used to ```assign``` some value to a variable
* something like ```x=7``` with x as variable

## Control Flow
* It is the process of defining the rules and the automatic decisions that will be taken during the execution of workflow,through the use of if/else decisions,loops,and so on.

## Operators
* ```%``` is represent by ```mod```
* ```!=``` is represent by ```<>```
* ```==``` is represent by ```=```
* 

## FlowChart
* To check some in condition inside a flow chart we use ```Flow Decision```

## Sequence
* It uses ```If``` activity for checking coditions
* It consists of 3 columns
    1. Condition ~> check the ```True``` or ```False``` condition
    2. Then ~> it does the work if a specific condition is set True
    3. Else ~> this block is run when the condition is found ```False```

## Loops
* Loops are structures most often used to automate repeatitive tasks 
* easily implemented in Flowcharts
* Always make sure to provide an exit point in the flowchart

### Types of Loops in Sequence
    1. while Loop (pre - condition check)
    2. Do While Loop (post - condition check)
    3. For Each Loop ( it works on iteration over items of a list just like iteration in python list)
      
## Select Folder
* it is an action that allows you to access all files inside the specifed folder
* To get files from a folder, in this ```Misc``` section of ```Select Folder``` type into the ```Value``` field
* to get the list of files use the command ```Directory.GetFiles(path-of-folder)```
* Type of variable should be array of strings ```System.String()```

## Generic Value Methods
* Certain functions inbuild i UIPATH that are helpful in type conversion are :
    1. Split
    2. Replace
    3. Substring
    4. Length
    5. Contains
    6. Trim
    7. IndexOf
    8. ToUpper,ToLower
    9. ToInt
    10. ToString

## Data Manuplation
* <u> Scalar Variables </u> ~> Holds a single value of a fixed type, for example Characters , Booleans , Numbers, Date Times
* <u> Collections </u> ~> Like Arrays, Lists and Queues or Strings, Dictionaries
* <u> Tables </u> ~> A Table is siilar to an array of dictionaries where values are accessible by row index and column names
* <u> Generic Value </u> ~> It can represent basic types of data, including text,number and date/times.
* ```ctrl + k``` create the variable with appropriate ```data type``` in properties of a particular activity


## Get Password
* By default ```UiPath``` is not able to type in a string into a password element
* For that purpose, we use ```Get Password``` activity to create or convert a ```string``` to ```password``` type varaible\
    ```qwerty12345 to ********```
* After creating a password type variable simply use ```Type Into``` activity to perform the task


## Recording
* Single time ```ESC``` pause the recording
* Double Time ```Esc``` Stop the recording
* To use some kind of ```hot-keys``` , do the following
    1. Press ```Esc``` once ~> To pause the recording
    2. In ```Type``` option use the ```send Hotkey``` option to use any shortcut
* In ```web``` recording , it will work similarly as ```selenium``` waiting time


## Array and Lists & Dictionary
* TO define an array type variable, with variable type``` Array of T``` or ```String[]``` and default array can also be written
* To define an list we set the variable data type as ```List<String>``` and with default value as ```new List(of String) from ['v1','v2']```
* ```Invoke Method``` is used to append new elements to the ```List```
* Dictionary has the data type ```Dictionary<String,String>``` and values can be appended to it using simply ```Assign``` function and works like normal ```dictionary``` does

## String Functions
* The string functions here works similarly as ```python```
* For example, to check if a ```String``` contains a particular ```word``` just use
    ```variable-name.Contains(word-to-find)```
* In ```Split(" "c)``` function,we can use ```ctrl + shift + space``` to find all kinds of examples we can use with ```split``` method
* In split function we can pass more then one delimeter to split string using an ```array``` as ```variable.Split({"word1 "," word2"},StringSplitOptions.None)```

## Handling Text
* To print date just use the functioon ```Now.ToString```
* To print only Month And Year use ```Now.ToString('MMMM yyyy')```

## Table Activity
* Read ```csv``` files by using activity ```Read CSV```
* To create a ```Table``` from csv file use the function ```output data table```
* it is preferable used while web scrapping 
* To access data from table just like ```DBMS``` use something like ```variable-name.Select("condition")```
* To access a specific column of a specific row , use ```sampleData.Rows(0)("Name").ToString```
* We must use ```[]``` with the ```Select```     method when the column name contains spaces.
* Accessing a specific value from a row, ```row("First").ToString```

## Quiz Lesson 3
1. How can a string variable called myString be converted to an all-capitals representation for future use?
Ans. ```By using an Assign activity with myString on the left side and myString.ToUpper on the right side.```
2. Which .Net method of the datatable object can be used to filter a table by a condition?
Ans. ```Select```
3. Which activity can be used to loop through each row from a DataTable?
Ans. ``` For Each Row```
4. Which activity can be used to modify the value of an existing cell in a DataTable?
Ans. ```Modify Cell Activity```
5. How can you identify a column in a data table?(Select all that apply.)
Ans. ``` Using column index and name```
6. Which of the following statements are true regarding the Output DataTable activity?
Ans. ```Returns the data contained in a DataTable as a string in a csv format```
7. The String.Format(“Input = {0} and Output = {1}”, “1”,”2”) expression returns which of the following text:
Ans. ```Input = 1 and Output = 2```
8. How can we test if a given address (a string variable called fullAddress) can be found on a particular street (a string variable called streetName)?
Ans. ```fullAddress.Contains(streetName)```
9. How can the index integer variable be displayed inside a Message Box activity?
Ans. ```“Current index is: “ + index.ToString```
