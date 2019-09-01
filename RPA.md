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
