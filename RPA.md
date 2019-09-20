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
* To close any application, we can use the ```close application``` activity.

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


## Recording
* Single time ```ESC``` pause the recording
* Double Time ```Esc``` Stop the recording
* To use some kind of ```hot-keys``` , do the following
    1. Press ```Esc``` once ~> To pause the recording
    2. In ```Type``` option use the ```send Hotkey``` option to use any shortcut
* ```F2``` pauses the recording for 3 seconds
* ```Right-click``` exit the recording
* In ```web``` recording , it will work similarly as ```selenium``` waiting time
* UiPath has 4 types of Recording:
    1. Basic
    2. Desktop
    3. Web
    4. Citrix
* Citrix is used for automating stuff with virtual machines
* The recorder is able to record:
    1. left clicks on buttons,checkboxes and other clickable items
    2. Typing into editable fields
* Some non-recordable things to remember are:
    ```These are Manual Recording```
    1. Keyboard Shortcuts
    2. Modifier Keys
    3. Right click
    4. Mouse hover
    5. etc
* Desktop recorder is different from basic just because it provides a container based workflow that is different actions in same application are separated by different containers
* ```Indicate on Screen``` is a good function that can be used to change the snapshot used for automation
* ```Text``` function in recorder has ```copy``` function, that can be used to copy some text and store in a ```variable``` which is created itself

### Basic Recording
* generates a full selector for each activity and no container, the resulted automation is slower than one that uses containers and is suitable for single activities.
* Actions are self-contained
* Simpler Workflow
* Can cause interference

## Desktop
* suitable for all types of desktop apps and multiple actions; it is faster than the Basic recorder, and generates a container (with the selector of the top-level window) in which activities are enclosed, and partial selectors for each activity.
* Actions are contained inside an AttachWindow component
* No interference issues
* More Complex workflow

## Web Recoring
* designed for recording in web apps and browsers, generates containers and uses the Simulate Type/Click input method by default.

## Citrix 
* used to record virtualized environments (VNC, virtual machines, Citrix, etc.) or SAP, permits only image, text and keyboard automation, and requires explicit positioning.
* The Citrix Recording toolbar enables you to:
    1. Click an image or text
    2. Simulate keystrokes or hotkeys
    3. Select and copy text from a window
    4. Scrape UI elements
    5. Look for elements or wait for them to vanish
    6. Find an image or wait for it to vanish
    7. Activate a window

## Manual Recording
* Various types of single actions that can not be automated by simple recording are done using manual recordings
* Various Types of Single Actions are:
    1. ```Start and Stop an App or Browser``` ~>These single actions enable you to open an app or browser, as well as close them, by pointing and clicking them. 
    2. ```Click``` ~> These types of actions enable you to record clicks on the desktop or a running application, select an option from a drop-down list or combo box, and select a check box or a radio button
    3. ```Type``` ~> These single actions include those that require input from the keyboard, such as keyboard shortcuts and key presses. To achieve this, two pop-up windows are used to retrieve your keyboard input.
    4. ```Copy``` ~> These actions enable you to copy a selected text from an opened application or web browser, so that you can use it later in the project. Screen scraping is also available under the Copy menu, as it enables you to extract images and text from an app or browser.
    5. ```Mouse Element``` ~> These types of actions enable you to simulate mouse movements that cannot be recorded but give you access to more functionalities, such as right-clicking, hovering or double-clicking. 
    6. ```Find Element``` ~> These types of single actions enable you to identify specific UI elements or pause the automation until a particular window closes or an UI element is no longer displayed. The find relative element action is useful with apps that do not allow direct interaction with UI elements, such as Citrix. 
    7. ```Window Element``` ~> Window element actions enable you to close windows. Studio does this by hooking in the operating system to make sure the application is closed. 
    8. ```Text``` ~> Text single actions enable you to select or hover over text to make tooltips visible for scraping, right-click to make the context menu visible, copy and paste text and many others.
    9. ```Image``` ~> Image single actions enable you to wait for a specified image to disappear, to find a specific image in an app or website, right-click or hover over an image and others. This type of manual recording can be useful with UI elements that are saved as graphics, as they cannot be highlighted as normal fields or text

## Lesson 4 Quiz
1. How can you delay the Automatic Recording?
Ans. ```By hitting the F2 key```
2. Can you combine automatic recording with step-by-step recording in the same recording sequence?
Ans. ```Yes```
3. Which recording wizard would you use to automate Virtual Machine actions? 
Ans. ```Citrix Recording```
4. When is it recommended to use Desktop recording?
Ans. ```When you automate more steps in the same window```
5. Which container will Basic Recording generate?
Ans. ```No container```

## Data Scraping
* Data Scraping is a function which can be used to Record any kind of data which is available in ```link``` form 
* For any kind of link to be extracted as data, you need to specify atleast two links together
* Then click on ```next``` and provide the ```column names``` of each column or data type you wish to scrap data and want in ```csv``` or ```excel``` file
* To extract more data of different type , click on ```Extract correlated data``` and follow the above steps only
* The maximum number of fields represent the number of entries you wish to scrap over the webpage
* After this, click on ```finish``` and click on the ```next``` button over the ```webpage``` from which you are scraping the data
* The above task will make sure that the page will be click next as soon data from single page is extracted successfully
* Data Scrapper is also able to extract a ```tabular data``` as well very easily, as it extracts the table itself on just single click


## Input Methods
1. Default (Generally used,hotkeys can be used)
2. Window Messages(Can work in background,hotkeys can be used)
3. Simulate Type (Fastest,used or prefered with Virtual Machines,hotkeys can not be used)

## Output Screen Scraping
1. Full Text ~> High speed and accuracy, can work in background and able to extract the hidden text
2. Native ~> Get text by position with high speed but unable to work in background
3. OCR ~> uses google and microsoft OCR and works great with citrix automation


## UI Activities Properties
* There are multiple activities that can be used to automate apps or web-apps and you can find them in the Activities panel, under the UI Automation category. 
1. ContinueOnError – specifies if the automation should continue, even if the activity throws an error. This field only supports boolean values (True, False). The default value in this field is False.
2. DelayAfter – adds a pause after the activity, in milliseconds.
3. DelayBefore – adds a pause before the activity, in milliseconds.
4. TimeoutMS – specifies the amount of time (in milliseconds) to wait for a specified element to be found before an error is thrown. The default value is 30000 milliseconds (30 seconds).
5. WaitForReady - Before performing the actions, wait for the target to become ready. The following options are available:
    * None - Does not wait for anything except the target UI element to exist before executing the action
    * Interactive/Complete - Waits all of the UI elements in the target app to exist before actually executing the action.

## Lesson 5 Quiz
1. Which is the best option for scraping tables from a web page?  
Ans. Data scraping wizard
2. What is the Data Scraping wizard for?(Select all that apply.)  
Ans. [Extracting whole tables from the web or other applications,Extracting correlated data from the web or other applications]
3. By using the Full Text scraping method, the robot is able to:  
Ans. [Get editable text.,Get hidden information.,Get the entire visible text.]
4. Which of the text extraction methods can return the hidden text from a UI element?  
Ans. FullText
5. Which of the following text scraping methods preserve the text position?  
Ans. [OCR,Native]

## Selectors
* Selectors are the way we identify User Interface elements on the screen. They are a xml string which contain some properties that uniquely define the specified element. 