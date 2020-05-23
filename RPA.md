# RPA Robot Processing Automation
# Date: 29th August 2019


## Notes:
* Global Exceptional Handler ~> The job of RPA Developers becomes easier by using this feature, since the handler only needs to be defined once per each automation project and, unlike the Try Catch blocks, does not need to be attached to each activity. It will execute every time an activity fails to execute.
* Repo Browser ~> It allows you to browse through, open, and save shared automation projects stored in TFS and SVN repositories.
* WebHook ~> Regardless of how complex the app network that was integrated with Orchestrator is, information can be sent to a variety of tools such as dynamic case management, business process management or even customer relationship management programs.
* Development Robot Decoupling feature ~> a “floating” robot can be used between multiple machines by the Administrators in a Development environment without having to associate it with a certain machine. In addition, Standard Attended robots can also be converted to “floating” robots. and only Administrators can access this robot
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
* These are of 2 types:
    1. Full Selectors ~> Used in general automation
    2. Partial Selectors ~> Comes in use when containerisation automation is done
* A selector has the following structure:
    ```<node_1/><node_2/>...<node_N/>```

## WildCards
* There are basically 2 types of wildcards in UiPath that are:
    1. ```*``` ~> Replace any number of characters
    2. ```?``` ~> Replace exactly one character

## Highlight
* It is an activity that is used to simple ```Highligh``` an UI Element as the name suggestes

## UIExplorer
* It is Automation Tool which is used to easily manage or edit the Selectors 
* To add some variable inside the selector the following way should be followed
    ```
    <wind some-selectors-code "+ variable name +" further selector code>
    ```
* It is used to be able to automate and manage dynamic selectors faced during web automation

## Anchor Base Activity
* This activity is used to find ```elements``` with unreliable selectors
* It uses the position of elements on screen
* ```Find Element``` this column is used to indicate the reliable field in the element we wish to search for our automation such as the name of the field
* ```Activity Field``` is used to declare the task to be done once the indicated element or field is finded by ```Anchor Base Activity```
* ```Anchor Position``` ~> it is the property of this activity which can be used to define the position where the required element to search for

## Relative Selector
* It works in background and relies on the internal structure of application

## Properties
* Various properties of selectors are:
    1. <u>Validate</u> ~>The button shows the status of the selector by checking the validity of the selector definition and the visibility of the target element on the screen.
    2. <u>Indicate Element</u> ~>Indicate a new UI element to replace the previous one.
    3. <u>Repair</u> ~> Enables you to re-indicate the same target UI element and repair the selector. This operation does not completely replace the previous selector. The button is available only when the selector is invalid.
    4. <u>Highlight</u> ~> Brings the target element in the foreground. The highlight stays on until the option is disabled with a click. The button is enabled only if the selector is valid.
    5. <u>Edit Attributes</u> ~> Contains all the application components needed to identify the target application (a window, a button etc.). This section is editable.
    6. <u>Edit Selector</u> ~> Holds the actual selector. This section is editable.
    7. <u>Open in UI Explorer</u> ~> Launches the UI Explorer. The option is enabled only for valid selectors.

## Lesson 6 Quiz
1. Can variables be used to build dynamic selectors?
Ans. ```Yes```
2. How can you see the full list of attributes of Ui elements?
Ans. ```By using the UiExplorer tool.```
3. What is a Selector?
Ans. ```The “path” to the UI element, starting from the root, all the way to target element.```
4. Which of the following is true regarding the Anchor Base activity?
Ans. ```Use the screen position of the anchor and the target element.```
5. What are the supported wildcard characters for selectors in UiPath Studio? 
Ans. ``` * and ? ```


## Image and Text Automation
### <u>Mouse Activities</u>
* Using ```click image``` we can click on almost anything that is button,checkbox,textfield etc
* ```Click Text``` uses oCR to scan the screen of Virtual Machine... where as ```click image``` faster and more reliable ut fails only if background color changes
* This is done using ```Image Recording```, it is preferred to be used when we are working on an image of a system that could be referred as the ```AWS instance``` or a ```Virtual Box```
* In this , the main function of recording is ```click image``` and the recording to be done manually only
* ```click image``` -> this functin or activity is used as dragging and selecting an area with respect to which we can decide where to click 
* ```click Text``` it does the same way as ```click image``` but in a different manner, it takes an OCR of the image and tries to find the element with same ```name``` as provided and ```click``` with respect to its position

## <u>Keyboard Actions</u>
* If sometimes, the ``` mouse actions``` fails to find the element , we can use the keyboard actions and automate the workflow using the ```keyboard shortcuts``` such as ```tab```,```ctrl+v``` etc.

### Select and Copy
* this activity is used to copy the ```selectable``` fields inside an virtual environment
* it works similarly as , selecting the field we wish to copy

### Scrap Relative
* This activity is used to copy data from ```non-clickable``` area which is done or preferred to be done using ```Google OCR``` and it can be set to find element with respect to some ```relative position```

## Lesson 7 Quiz Time
1. Creating automations in a Citrix environment is challenging because:
Ans. ```You need to interact with the app using Image Recognition or OCR.```
2. Is Reset Clipping Region mandatory to be executed at the end of a scrape relative sequence?
Ans. ```No, for the next actions we can use other Clipping Regions.```
3. What activities can be used to interact with applications in a Citrix environment?
Ans . ```Type into, Click Image, Click Text```
4. How can you scrape a field on a Citrix Environment when the value in that field changes each transaction?
Ans. ```Find a static element nearby and use Scrape Relative```
5. Click Image and Click OCR Text are not 100% reliable in Citrix environments. What method can be used instead (when applicable) to have safer actions?
Ans. ```Setting focus on a reliable element and then navigating around the app using keyboard (up/down arrows, tab, etc) or using keyboard shortcuts.```
(Failed in above attempt)
6. Having an app in a Citrix environment with multiple text-boxes that look the same (size/style), how can you identify one of them to type into?
Ans. ```By clicking relative to an unique text/image next to the textbox., You can’t identify it if it doesn’t have something unique next to it (text/image).```
7. Is it possible to click a button with Click Image Activity if the target is not visible on the screen?
Ans. ```No, you could click a button which is not visible only using selectors```
8. Consider having an application in Citrix Environment that has a button named ‘Accept’ and also a label that contains the Accept word. How can Click Text be customized in order to access the correct button?
Ans. ```By using the Occurrence property.```
9. How can you improve accuracy when scraping with OCR a region that contains only digits?
Ans. ```Use Google OCR with “Numbers Only”```
(Passed in above attempt)


## Advanced Citrix Automation

### Find Image
* This activity is used to ```pause``` the state of program until an certain ```Element``` is not found or loaded completely
* As output it gives the ```element``` which is defined to be found

### Highlight
* it is used to detect/show/highlight a certain element over screen
* Highlighting a certian element can be done using
    1. Clipping Region
    2. Selector
    3. Element
* Highlight Time ~> The timeout or the amount of time for which to ```highlight``` a certain element is calculated in ```microseconds``` that is ```2000 == 2 sec```
* In highlight the color can be defined as well for customized workflow

### Working with opening applications
* A better practice to open a certain ```app``` or ```application``` is to set ```shortcuts``` and open the app using ```send hotkey``` activity

### Pick Activity
* This activity is a container based activity which further accomodates ```Pick branches```
* This activity is used to set a certain activity to be completed in different possible conditions or scenarios 
* Basically we provide a same action like ```opening a folder``` to be automate but in more then one possible condition of ```screen``` or ```background```

## Lesson 8 Quiz Time
1. What can be done when the Windows Remote Connection doesn’t allow sending hotkeys?
Ans. ```It should work if the Windows Remote Connection is in ‘full-screen’ mode.```
2. How can the robot pass a variable argument when opening an application in Citrix (eg: a web address for a browser)?
Ans. ```In the command prompt, type in the path to the application and the argument```
3. Which of the following activities can be used to select an item in drop down list, in Citrix?(Select all that apply.)
Ans. ```Click Image , Click OCR Text```
4. What happens if Find Image doesn’t actually find the desired image?
Ans. ```An exception is thrown..```
5. What is the EASIEST navigation method to be used in a form within Citrix?
Ans. ```By sending keyboard commands/hotkeys```
(Passed)


# Excel Automation
* ```Excel application scope``` ~> it is a container based activity and is used to do all workflows regarding the Excel file
* ```Visible``` ~> It is an inbuilt activity which if we checked tells ```UiPath``` to work on file using ```MSOffice``` and if not then all tasks are performed internally
* While using Direct access only single process can work where as while using MSOffice multiple can be done at the same time
* A range can be specified by defining the cells separated by ```:```.
    ```A1:C5```
* ```Build Data Table``` ~> this activity is used to create more data tables with very easy and simple GUI
* ```Add Data Row``` ~> this activity is used to add another row(data) inside the build data table activity or table made from it
* ```Append Range``` ~> It is used to append more data to same file
* Data tables are ```zero-indexed``` same as a ```list in python```
* ```sort data table``` ~> This activity is used to sort some tabular data based on a certain column
* ```Select Range``` ~> This activity is used to select a range of cells over which further actions like ```copy/delete/paste``` can be performed
* ```Join Data Table``` ~> This activity is used to perform the ```JOIN``` operation
    * The ```Join Operation``` is of 4 types:
        1. inner join
        2. left join
        3. full join
* The table join ```criteria``` can be defined using either ```column data type``` or simple by ```column name``` written inside ```double-quotes```
* the conditions can be set as more then one or either on one using ```AND``` and ```OR``` logical operators
* ```Output Data Table``` ~> This activity is used to convert a ```data table ``` type variable to ```String```
* ```Read Cell``` ~> used to read a specific cell from an excel file
* ```Write Cell``` ~> used to write  in a specific cell from an excel file
* All numeric data read by ```Read Range``` function from Excel is interpreted as an ```Double``` data type
* ```Get row item``` ~> this activity is used to fetch the values of a specific column from a certain row
* ```Add data row``` ~> this activity is used to add a new row in an ```Excel file``` using an ```array of data``` which is defined using ```circular or curly``` brackets as ```(var1,var2) or {var1,var2}```
* ``` inputsTable.Rows.Count``` ~> it can be used to count the total number of rows
* Use of ```Workbooks``` is prefferable over ```Excel files``` as they do not require Excel to be ```installed```

## Lesson 9 Quiz Time
1. What happens if the AddHeaders option is checked for Read Range Activity? 
Ans. ```The first row from the specified range is considered to be the column names```
2. In order to loop through all the rows of a data table, which activity should be used?
Ans. ```For Each row```
3. What activity can you use to create a DataTable from an input string?
Ans. ```Generate Data Table```
4. What happens if you try to use a Write Range activity to a .xlsx file that does not exist?
Ans. ```It will create that file for you and write the data in it.```
5. Can Excel related activities be used without having the Excel Application installed? 
Ans. ```Yes, but only for xlsx files```
(Passed)


# PDF Automation
* ```Read PDF``` ~> This activity is used to read text from a PDF
* ```Read PDF with OCR``` ~> It goes by the name and is able to read the ```Image Text``` present in the PDF
* While using OCR to read PDF's , we have got 3 options
    1. Google OCR
    2. Microsoft OCR
    3. Abby's OCR ~> Maintains the structure of text present in PDF
* PDF activities are categorised into 2 parts:
    1. Processing large chunks of data
    2. Working on specific part of the file
* Anchor base method is more reliable then others since it can handle structural changes
* While trying to read text it is preferable to use ```Read PDF``` rather then ```Read PDF with OCR``` as OCR is more prone to errors
* In properties of PDF, the range of PDF pages can be set in the following format ```"1-4"```

## Lesson 10 Quiz Time
1. Will the Read PDF with OCR activity open the PDF document on the screen in order to read it?Will the Read PDF with OCR activity open the PDF document on the screen in order to read it?
Ans. ```No```
2. What is the easiest way to get the invoice number from a native PDF file? 
Ans. ```Open the PDF file with Adobe Acrobat Reader and scrape only the relevant information.```
3. Which of the following activities requires the PDF file to be opened with Acrobat Reader in order to read it?
Ans. ```Get Text```
4. How can a robot read only the first page of a PDF file, using the PDF activities? 
Ans. ```Set the Range property to: “1”```
5. If the PDF contains both images and native text, what activity should you use to read all the text from it?
Ans. ```Read PDF with OCR```

# Email Automation
* Various activities supported in ```email automation``` are:
    1. SMTP ~> used to send mails
    2. POP3 ~> used to recieve mails supported by various domains
    3. IMAP ~> supports reading messages as well as marking them read or shifting to different folders
    4. Exchange ~> Microsoft supported activity for all kinds of email activities
    5. Outlook ~> automate the pre installed outlook software
* Four activities present to check mail are :
    1. POP3
    2. Outlook
    3. IMAP
    4. Exchange
* The data type of messages is ```System.net.mail.message```
* ```Save Attachments``` activity is used to save attachments from a mail, it requires two arguments a ```mail type instance``` and path to save folder
* ```mail.Headers('Date')``` provides the Date Timestamp for any mail
* to filter mails fetched by UiPath set a filter in the properties menu such as
    ```"[RecievedTime] > '14/10/2019 09:41 AM'"``` or ```"[RecievedTime] > Now.AddDays(-1).ToString('MM/dd/yyyy hh:mm tt')"```
* ```Take Screenshot``` is the activity used to take a screen shot at run time which is to be saved in a certain location using ```save image``` activity
* The ```attachment``` section of the ```Send Mail``` activity requires a file path to be sent 
* To make something like message Dynamic in ```sending messages``` we can use format type same as ```python``` just replace the content to be changed dynamically with ```{0}``` and provide the argument in ```body section``` of send mail activity

## Quiz Time Lesson 11
1. What activity can you use to send an email without entering the username and password of the email account?
Ans. ```Send Outlook Mail Message```
2. What activities can you use to send an email message?
Ans. ```Send Outlook Mail Message. and Send SMTP Mail Message.```
3. What is the supported variable type in the Output property field of all Get Mail activities (POP3, IMAP, Outlook, Exchange)? 
Ans. ```List (MailMessage)```
4. If you are using the For Each activity to loop through a list of MailMessage variables, what should you set the TypeArgument property to?
Ans. ```System.Net.Mail.MailMessage```
5. The Send Outlook Mail Message activity will work without having Microsoft Outlook installed:
Ans. ```False```
6. Which of the following properties are found in the Get Outlook Mail Messages activity? 
Ans. ```MailFolder```
7. Which of the following activities will allow you to only retrieve only unread messages?  (Select all that apply.)
Ans. ```Get OUTLOOK Mail Message and Get IMAP Mail Message```
8. If you want to get only filtered MailMessage variables, what activity should you use?
Ans. ```Get Outlook mail messages```
9. Which Visual Basic property within the MailMessage class will you use to get the Date of an email? 
Ans. ```Headers(“Date”)```
(Passed)


# Debugging And Exception Handling
* Slow Steps ~> This is the tool provided with ```Debugging Toolkit``` , it highlights each activity executing 
* In Options ~> Highligh Element activity , ```highlights``` the ```UiElement``` being interacted with a ```Red Color```
* Breakpoint ~> It is set an activity where we feel some error migth occur and then we have 3 options to continue our program execution
    1. Continue
    2. Step Over
    3. Step Into
* In ```Input Activities``` we have an option ```Simulate check``` in their properties which tend to send the input using ```Background Processes``` without using the ```mouse or keyboard```
* ```Timeout``` property makes the ```activities``` wait for an element to appear or the activity to execute before giving an error
* ```Element Exists``` ~> This activity returns a ```boolean``` value that is ```True``` or ```False``` for an Element to be present on sceen or not
* ```Log Message``` ~> this activity can be used to set or give some message in output tab given in right side Properties panel... that is seen while execution
* ```Find Element``` ~> Stops the workflow until an element is found
* ```Wait Element Vanish``` ~> Waits for an element to disappear before continuing

## Try Catch Finally
* ```Try Catch``` activity ~> it works same as in programming , if any activity fails in ```Try``` block then ```catch``` block will run followed by ```finally``` block
* ```System.Exception``` ~> It catches all types of errors
* To select all activities, it is easy by just dragging the cursor on all
* Once the type of Exception is selected in ```catch``` block.. followed by ```enter``` collapses the ```try``` block and we can start addig activities to work when error occurs
* ```rethrow``` activity ~> is used in ```catch``` block to show an error popup
* ```exception.message``` this is a ```primitive``` variable which contains the error message that might have occured

## Logging Levels
* There are 6 log levels in UiPath:
    1. Verbose
    2. Trace 
    3. Information
    4. Warning
    5. Error
    6. Critical
* Each log level has its own significance
*  Verbose < Trace < Information < Warning < Error < Critical 
* <b>Creating user-defined log fields that have the same name as a default log field causes the logging process to become corrupted and may cause issues in the workflow you are running.</b>
* Various Default Log Fields are:
    1. Message - The log message.
    2. Level - Defines the log severity.
    3. Timestamp - The exact date and time the action was performed.
    4. FileName - The name of the .xaml file being executed.
    5. jobId - The key of the job running the process.
    6. processName - The name of the process that triggered the logging.
    7. processVersion - The version number of the process.
    8. windowsIdentity - The name of the user that performed the action that was logged.
    9. robotName - The name of the robot (as defined in Orchestrator).

* for type conversion to integer we can use ```CInt``` as ```CInt(variable)```
* You can separate individual components of your automation into different workflow files and then call them using ```Invoke Workflow.```

## Quiz Time Lesson 12
1. If you need to know if a UI Element is available on the screen or not, what activity should you use?
Ans. ```Element Exists```
2. What does the Locals panel display when you are working in Debug mode?
Ans. ```The current values of your variables.```
3. How many Catches can you have in a Try/Catch block?
Ans. ```There is no limit on the number of catches.```
4. What activity can be used in a Citrix environment to check whether a UI element is displayed or not?
Ans. ```Image Exists```
5. The Finally block of a Try/Catch activity is executed when:
Ans. ```Every time, regardless if an exception occurred or not.```
(Passed)


# Project Organization
* Following the best practices makes our project:
    1. Reliable ~> Solid Robust workflows that can handle errors
    2. Efficient ~> Shorter development time and smooth execution in production environment
    3. Maintainable ~> Easy to update when changes are required
    4. Extensible ~> New Usecases can be added

## Best Practice
* Pick an appropriate layout for each workflow
    1. main WF -> flowchart/ state machine
    2. bussiness logic -> flowchart
    3. Ui Interactions(woring in same order) -> Sequence
    4. Avoid nested If else and use flowchart instead
* Break the whole process into smaller workflows
    1. Develop and test pieces independently
    2. reuse workflows across projects
    3. collaborate working on separate files
* Use Exception Handling
    1. Put problematic workflows inside Try_Catch
    2. Put externally invoked Workflows
    3. Implement recover sequence
* Make your workflows readable 
    1. Give descriptive names to activities
    2. leave explanatory notes and comments using ```comment``` activity
    3. log real time execution process
* Keep it clean
    close applications,windows and web pages not being used

## Invoke Method
* UiPath offers an activity same as ```import``` in python that is ```Invoke Method``` activity
* In this activity , we can execute any workflow and even pass arguments and import arguments
* Arguments just work as values which are provided for variables and these arguments or values of variables, can be either given as input or can be extracted as an output for another activity
* ```Direction``` column in variables define the redirection of values which can be ```In``` or ```Out``` or both ```In/Out```
* ```Deserialize JSON``` activity ~> It is used to parse a ```json``` file and can be used to read or extract data from it
* to convert a variable... we can do it like ```convert.ToInt32(variable-name)```

## Quiz Time Lesson 13
1. What is the recommended layout for sequential activities?
Ans. ```Sequence```
2. What type of arguments can you use in a workflow?
Ans. ```In/Out Out  In ```
3. Is notifying the user via a Message Box activity a good way to keep track of a workflow’s execution progress ?
Ans. ```No```
4. What is the recommended layout for a sequence of UI interactions?
Ans. ```Sequence```
5. Which of the following is a good example of a workflow name?
Ans. ```GetCustomerNumber.xaml```
(Passed)


# RPA Developer Foundation Training - Final Test
(Passed Successfully)

-----
# Level 2 Orchestrator Training
<a href='https://cdn2.dcbstatic.com/files/u/i/uipath_docebosaas_com/1572411600/MyKk8x1tGHs0mwWm_M1sNw/item/e815437971b14c9b896d9f5064e968915d0d1e0e.pdf'> Link TO Version Details Of Different Orchestrators</a>

* ```UiPath Orchestrator``` is a web based application
* It Enables efficient resource management
* It allows Workload allocation, Scheduling and monitoring of robots
* Streamlines the teamwork

## Should Stop
* This activity is used in workflow to stop a executing process from ```Orchestrator```
* It return a ```Boolean Value``` which can be used by ```Decision Flow```

## Asset
* In UiPath Studio we have an activity called ```Get Asset```
* It gets the ```asset``` value from the Orchestrator and this activity works only when the ```workflow``` is published to Orchestrator
* ```Asset``` is basically just a variable which can be defined in the Orchestrator and used by the workflow
* It can be specified for multiple robots or individual that is using same ```asset variable``` for multiple bots with ```different values```
* In properties panel, name of asset should be written as string that is if the name is ```Name``` then in properties write it as ```"Name"```
* Assets are of 4 Data Types:
    1. Credentials
    2. Text
    3. Boolean 
    4. Integer

## Get Credentials
* Credentials type requires 2 input values (Username and Password) in ```Studio``` as well as Orchestrator
* Basically when ```Credential Asset``` is made with two values which are ```Username``` and ```Password```
* Then they are fetched and used at run time in Studio using ```Get Credential``` activity
* To use the pass acquired from the ```Get Credentials``` we would need to use ```Type Secure Text``` activity

## Type Secure text
* This activity is used to decrypt the ```.NET``` secured string from encrypted password to normal decrypted text

## Queue
*  the transaction items in a queue are processed in chronological order
* The items inside Queues can be processed by multiple Robots.

## Add Queue Item
* This activity is used to send values or add the items to Queue in Orchestrator
* ```DeadLine``` ~> This property is used to set a sepecific time limit within which the queue item is supposed or required to be processed
e.g., ```datetime.Now.addHours(24)```
* ```PostPone``` ~> This property is used to postpone the activity upon reaching ```Deadline``` by some ```time``` like ```datetime.Now.addHours(2)```
* Multiple robots can be assigned to process the same Queue
* ```Reference``` property can be set to an item to identify it uniquely in Orchestrator
* ```ItemInformation``` ~> this property is used to define the values to be added in the Queue present in Orchestrator


## Get Transaction Item
* This activity is used to fetch values or items from the ```Queue``` made in Orchestrator
* When this activity is set into loop it iterates over and fetch all the items in the Queue
* ```transaction.SpecificContent("Column-name").toString```

## Set Transaction Status
* It is used to set status of the processed item from the Queue
* If the Status is not set by the ```Robot``` then it is set to ```Abandon``` automatically after 24 hour

## Set Transaction Progress
* It is used to set some Value for the progress column in Orchestrator regarding the Processes in Queues

## Complete Documentation can be found at 
<a href = 'https://docs.uipath.com/orchestrator/'> <b> Orchestrator </b></a>

## Terminating and stopping a process
* Pressing Stop requires you to use the Should Stop activity in Studio while developing the process. The activity returns a boolean value. It informs  whether the Stop button has been pressed in Orchestrator by the time the Control Flow reached the Should Stop activity. This is similar to a Save Game function in a computer game.
* Pressing Kill is the equivalent of stopping a process from the Studio. Orchestrator will connect to your Robot and send a stop command to the process.

## Trigger
* Trigger is like  Scheduling a process that is having Orchestrator press Play for you at a time which you specify.

## Steps to Use Orchestrator
1. Create your workflow that you wish to deploy over Orchestrator
2. Open the Following url <a href='https://cloud.uipath.com'>Cloud Uipath</a>
3. In ```Service``` section , select the ```StudentDefault``` service (UiPath Orchestrator will be opened)
4. Create a machine
    1. Click on Machine in Left panel under ```MANAGEMENT``` section
    2. Click on ```+``` icon followed by ```Standard Machine```
    3. In Name write the Name of your Laptop(you can get that from next step) and Description as you like
    4. Click on Provision
5. Open UiPath Robot on your local Machine 
    1. Click on ```Settings``` icon
    2. Select ```Orchestrator Settings``` option
    3. Enter the Machine Key(you can get that by clicking on ```edit``` on Machine made in previous step)
    4. In Orchestrator Url type the cloud-orchestrator-url
    5. Click on Connect(Local System gets connected to Orchestrator at cloud)
6. Now to Add your Robot
    1. In ```UiPath Studio``` , click on ```Publish``` button given in Design Panel(just click ok)
    2. Select ```Machine Name``` given in previous step
    3. In Username, type the name configured with your ```UiPath Studio```
    4. Click create
7. Set Environment
    1. In Robots tab, Click on environments
    2. add a new environment
    3. Click on ```manage``` in properties of environment
    4. Select your ```robot``` and click on ```Update```
8. Set The Process
    1. Go to ```Process``` Tab
    2. Click on ```+``` icon
    3. Select the ```Package Name``` and ```Environment```
    4. Click on Create
9. Finally you are ready to run/execute your bot
    1. Go to ```Jobs```
    2. Click on Start Button
    3. Select The Process made in previous step
    4. Select your ```Robot```
    5. Click Start and all done

----

# Level 3 Advance Training

# UiPath Robotic Enterprise Framework
* This Framework is a Template provided by UiPath for ```transactional``` activities or workflow
* <b> Transactional Activities</b>~> Basically every project can be divided into 4 states
    1. Initial State ~> Start/Open all applications
    2. Get Transactional Information ~> Take Input or Fetch from Queue/Excel all the Data need to be processed or used for processing
    3. Process Transaction ~> Process all the information(calculation,Decision taking,Data Conversion etc)
    4. End Process ~> Close all the applications which are not required
* It can be accessed through ```START``` panel of ```UiPath``` Studio in the ```Template``` Section
* REFramework consists of few pre-build workflows which are used to simplify the Automation Task in a proper manner that are:
    1. InitAllSettings ~> Processes / Reads the config file containing essential details
    2. InitAllApplications ~> Start the Initial State and Open all neccessary applications
    3. GetAppCredential ~> In terms of Login , gain user credentials with proper security
    4. GetTransactionData ~> Get Transactional Information from User/Queues/Excel Files etc
    5. SetTransactionStatus ~> Set the status for information being used(Processed/retried/abandon/NeedToBeProccessed etc)
    6. KillAllProcess ~> To Stop the Process completely on recieving ```STOP``` signal
    7. CloseAllApplications ~> Close the applications in Workflow as soon as their work is completed
    8. TakeScreenshot ~> During Exception Occurrence, Used to Take Screenshot and store in ```Exceptions_Screenshots``` folder,to help developer
* RefFramework is based on the principle that data is stored in the form of a ```Queue``` that is ```FIFO```
* Building productive Robots require:
    1. Proper Exception Handling(try_Catch)
    2. Recovery Abilities(ReStart or Recover from Possible failures)
    3. Effective Logging(Secure the Status of Each part of workflow)
    4. Reporting Functionalities(logs and screenshots)
    5. High Maintainability
    6. Extensibility(Easy to modify)
    7. Reusability
    8. Ease of Development
* The Framework files can be downloaded from the following ```Github``` Repository link <a href='https://github.com/UiPath/ReFrameWork'>FrameWork</a>
* ```Request Credential``` ~> This is an activity used to get ```credentials``` from user same as ```input dialog```
* This Framework mainly  works on State machine activity which includes 
    1. Main State Machine
    2. Exceptions Handling
    3. Recovery Methods
    4. States
        1. InitState(Config file,InitAllApplications) ~> Initialization(Open Application,login to website,startup required values etc)
        2. Get Transaction Data(TransactionItem,TransactionNumber)
        3. Process Transaction
        4. End State
    5. SetTransactionStatus
    6. GetAppCredentials

## InitAllSettings
* In The Reframework, it is the Initial ```xaml``` file to be used
* It contains a Config workbook with 3 sheets
    1. Settings ~> We can store any configuration related to the business process such as Urls,filepaths,credentials and any process specific piece of information
    2. Constants ~> It stores the technical settings that are useful for Developers, it contains information like number of delays , retries, timeouts,image accuracy settings, static log parts
    3. Assets
* In Settings Sheet , there are 3 columns
    1. Name ~> Always contains a string which is the key in the Dictionary
    2. Value ~> Holds the dictionary value
    3. Description ~> Holds the detailed account of each setting

## Exceptions
* There are 2 kinds of Exception that are:
    1. Business Exception ~> In Case of issues in data , invalid data,missing information in data.
        Transaction status is ```set as failed``` and transaction is ```not re-tried```
    2. System/Application Exception ~> In case application not available(UI Element not available or unknown error)
        Transaction is ```re-tried```

## Working of REFramework
Note: 
* In case Exception occurs anywhere we set ```SystemError``` to ```exception``` with data type ```Exeption```
* At Every Phase of This Framework , logging is done for better development experience and Easy Debuggig
1. We always initiate the workflow with ```main.xml``` file
    * It contains a Flowchart with following Transactions
        1. Init
        2. Get Transaction Data
        3. Process Transaction
        4. End Process
2. Starting With ```Init``` transaction, It contains a Try_Catch_Finally block of activity
    * Assign a ```SystemError``` variable to nothing which used for Exception Verification
    * For first Time,by default reads the config file present at ```Folder/Data/config.xlsx``` to acquire basic pre-set settings/values and kills all initally running processes as defined in ```KillAllProcesss.xaml```
    * Run ```InitAllApplications.xaml``` to open all required application upon which we have to work
3. Upon Failure of above process we move to ```EndProcess Transaction``` else
    * Move to ```Get Transaction Data``` transaction
    * It checks for ```StopSignal``` that is recieved from ```Cloud Console```
    * Starts to access/fetch data from Queue in Orchestrator using ```Get Transaction Item``` which gives an Queue as output
    * If some Error occurs,logs are set and ```TransactionItem``` is set to ```Nothing```
4. If no data/TransactionItem is fetched from above Transaction, The workflow moves towards ```End Process``` transaction else
    * Move to ```Process Transaction``` 
    *  In this, we initiate the main ```Processing``` workflow ```xaml``` file that uses the input and complete the task
    * If Some Error is Faced the workflow sets the ```Bussiness Exception``` and ```System Exception``` to initiate the Recovery Process
    * Most of the time, Upon recieving Error, its best to stop the processing
    * After Completion of the activities.. a ```Finally``` block is used to always set the ```transaction status``` of each Transaction Item
5. Upon Reaching the ```End Process``` transaction
    * It intially try to normally ```Close``` all applications and upon not being able to do so
    * It uses ```KillAllProcess``` to forcefully to its work


## Transaction Processing
* A transaction represents the minimum amount of data and the necessary steps required to process the data, as to fulfill a section of a business process
* Once processed, the data is no more required

* A Business process can be divided into 3 categories:
    1. Linear ~> The steps of the process are performed only once and, if there is the need to process different data, the automation needs to be executed again.
    ```
    INIT ~> GET DATA ~> PROCESS DATA ~> END
    ```
    2. Iterative ~> The steps of the process are performed multiple times, but each time different data items are used
    ```
    INIT ~> GET DATA ~> | Process Data in Loop | ~> END
    ```
    3. Transactional ~> Similarly to iterative processes, the steps of transactional processes repeat multiple times over different data items. However, the automation is designed so that each repeatable part is processed independently

* Dispatcher ~> The dispatcher is a process used to push transaction items to an Orchestrator queue. It extracts data from one or multiple sources and uses it to create Queue items to be processed by Performer robots.
* Performer ~> The performer is a process used to pull transaction items from an orchestrator queue and process them as needed in the company. Queue items are processed one at a time.It uses error handling and retry mechanisms for each processed item.

* Dispatcher and Performer models advantages:
1. Better seperation of processes (between dispatcher & performer)
2. Better separation & distinction between architecture and process layers
3. Better error handling and retry mechanism
4. Possibility to run processes across several machines (availability)
5. Better re-usability within your project's created components
6. Improved built-in configuration & Orchestrator integration
7. Previous workflows created without REFramework can be easily adapted and deployed in order to use REFramework and the dispatcher / performer model



# UiPath Security Training

## Layers in Orchestrator
1. Presentation Layer(accessed via browser)
    * Communication between clients (browser,robots) and Orchestrator is encrypted using the secure https channel 
    * user session is saved in a session cookie(with a configured expiration time)
    * the password complexity is configurable
    * account automatic locking after a configurable number of failed attempts
    * Protection against CSRF token
2. Service Layer(containing the business logic)
    * Role-based access control(RBAC)
    * no data sent outside customers network
    * logging - default actions are logged for auditing, and so are the  users actions
    * the section containing the encryption key in the configuration files can be encrypted
3. Persistence Layer ~> Build using SQL and elastic search
    * encrypted communication with SQL server
    * each password is encrypted with a different encryption key
    * login attempts are logged - result ,IP Address, timestamp , browser info
    * user roles can be defined for data stored in SQL server to prevent unauthorized access

## Potential Risks associated with RPA Projects are:
1. Robots having access to Credentials normally used by human workers
2. Robots having access to privileged information such as personal data of commpany staff, financial data
3. Unauthorized modifications of automation workflows in the development or testing phase
4. Unauthorized modification of automation workflows or runtime parameters in the production environment

## Features
Features are the characteristics that are embedded in the product or solution and implemented in order to enhance the security and mitigate risks

## Guidelines
Best Practices to be used while setting up RPA workflows

## Code Review
* It aims to ensure that the process that will run on the live data is safe and no security breaches are possible
* Checks whether the credentials are used only where needed and are not passed outside the trusted environment
* Prevent sending sensitive data outside the trusted scope

## Notes
* We can keep track of RPA projects with multiple developers in working by keeping the source code files(XAML files) in  ```Source Code Control System```
* To Store Credentials in UiPath we use:
    1. Orchestrator Credential Assets ~> encrypted using ```AES 256``` and stored on the ```SQL server base``` but should be configured with ```value per robot``` to prevent unauthorized access
    2. Windows Credential Manager ~> works as a local machine storage and should be used only in case Orchestrator in not accessible

## Protect Sensitive Data
1. Configuring a trusted Channel : VPN Connections,secure FTP sesions, HTTPS websites
2. Data encryption, when using untrusted channels
3. Usage of limited access environments, such as restricted shared folders or restricted Sharepoint domains

## Environment Isolation
* During RPA Projects the ```Developer Team``` and ```Production Team``` should work in different environments
* Development Environment
    1. The RPA Developers and their robots interact only with systems that have sandbox environments
    2. the robots should not be able to connect to the UAT and production orchestartor
* Productin Environment
    1. The robots permanently monitored for malicious tempering of packages and the execution of correct version of the package
    2. access to the robots in the production should be restricted to the trusted individuals

## Multitenancy
* It is a feature of Orchestrator that allows complete seperation of Data among tenants, providing a dedicated share of the instance including its data,configuration, user and role management up unitl license management
* In simple terms, using Single Orchestrator Instance an organisation can have, multiple role based users each having having seperate:
    1. Robots
    2. processes
    3. Assets
    4. Queues
    5. Data
    6. Configuration
    7. Users
    8. Roles

## Protecting data in Transit and at Rest using
1. Transport Level Security 1.2 Protocol
2. Advanced Encryption Standard on 256-bit cipher
3. Secure Hash Algorithm 2

## Quiz Time
1. What are the main differences between guidelines and security features?
Ans. ```Guidelines are recommended general best practices, while security features are already implemented in the product```
2. User access to the Orchestrator web app is protected using the following features:
Ans. ```a) communication between client and Orchestrator is encrypted with HTTPS; b) Password complexity is configurable; c) the account is locked after a configurable number of unsuccessful attempts```
3. Is Storing Credentials a feature or a guideline?
Ans. ```Feature```
4. Authenticating the users on the Orchestrator platform can be done with:
Ans. ```Google accounts with OpenAuthentication 2.0,Local username and password,Active Directory username,using Windows Authentication, Azure Active Directory authentication```
5. A valid SSL certificate is required to install Orchestrator.
Ans. ```True```
6. Is Package Securing a feature or a guideline?
Ans. ```Feature```
7. With the Account Lockout security feature you can prevent additional logins for a period of time after a number of failed attempts.
Ans. ```True```
8. The Audit page on the Orchestrator platform allows you to filter by:
Ans. ```Component and Action```
9. What is the common practice to keep the different versions of each XAML file in an RPA project?
Ans. ``` Source Code Control System```
10. Packages uploaded into Orchestrator (either manually or published from Studio) are automatically uploaded by Orchestrator to all robots that can execute these packages.
Ans. ```False```
11. Orchestrator offers the functionality to create any number of custom roles.
Ans. ```True```
12. In an organization with Development, Testing and Production environments, an RPA Developer should not have access to the Production Environment
Ans. ```true```
13. CyberArk can be integrated with the Orchestarator in order to retrieve the robot credentials from CyberArk instead of SQL Server DB.
Ans. ```True```
14. Is Isolating Environments a feature or a guideline?
Ans. ```Guideline```
15. Security risks can appear in:
Ans. ```Both development and production phases```


# UiPath Licensing Training

## License for Studio
1. Named User ~> Single specific User, enables each user to access the software at any time ,on any machine
2. Concurrent User ~> Useful in  BPO scenarios,indicates how many users can access the software simultaneously
3. Concurrent Runtime ~> Indicates the number of robots that can be simultaneously connected to Orchestrator , regardless of the user or machine
4. Server License ~> is required to install orchestrator instace

## Notes
* All the licenses for all the robots can be easily managed by Orchestrator
* Named and Concurrent User License can not coexist in single orchestrator instance
* All the platform license must have same anniversary date

## Host Licensing
* It provides full control of all the licenses belonging to an organization
* Allows centralised license management and distribution

## StandAlone License
* Used when Orchestrator is not used
1. Named User License
2. Node Locked License ~> completely similar to ```Concurrent User license```

<img src="Licenses.jpg">

## License Activation
* To Activate any license in machine follow the following steps:
1. Open CMD as administrator
2. CD to Uipath studio folder
3. run command ```regutil activate /email_address /license_code```
4. To check if license activated successfully run command ```regutil.exe get-info```, it shows complete information about license
5. To export the information to a file, run command ```regutil export-info /out_file=Path-to-store```

## QuizTime
1. What Robot type is used to test an automation workflow?
Ans. ```NonProduction```
2. A Node Locked License...
Ans. ```Can be activated and used on a single machine,allows multiple users to work successively on a machine using the same software instance, is available for unattended robots```
3. A developement robot
Ans. ```Activates studio,enables workflow execution on local machine,ensures the ability to connect the local studio instance to orchestrator```
4. A Concurrent User License is dedicated to a single specific user.
Ans. ```False```
5. Which license types are available for Attended Robots and Studio?
Ans. ```Named User and Concurrent User```
6. Which UiPath Platform licenses can be managed through Orchestrator?
Ans. ```Concurrent User,Named User, Concurrent Runtime```
7. Concurrent User licenses are usually suitable in BPO scenarios, for companies whose employees work in shifts. 
Ans. ```True```
8. Named User and Concurrent User licenses can coexist within a single Orchestrator tenant.
Ans. ```False```
9. All the platform licenses (managed through Orchestrator) must have the same anniversary date.
Ans. ```True```
10. For Unattended Robots, the only available Standalone License option is
Ans. ```Node Locked```
11. The number of Concurrent Runtime licenses indicates...
Ans. ```The number of robots that can be simultaneously connected to Orchestrator , regardless of the user or machine```
12. What is the required license type in a scenario where employees must be able to execute processes whenever needed?
Ans. ```Named User```


# SAP Automation
* When automating SAP,start with recording the actions, most of the time it will work fine
* To Interact with unrecognised elements you can use ClickText & ClickImage and keyboard shortcuts to reach difficult buttons or menu items
* For ```Elusive UI Elements``` , simulate human activities that is what human will do activate it
* For tabular data you have to use loops , although that is hardly SAP specific
* To Read an tabular data of unknown length, read each row in an infinite loop until an operation fails
* To work on checkboxes and special elements , use the ```getAttributes``` activity, it shows a bunch of hidden information that can prove to be very useful

## QuizTime
1. Can SAP client be automated if it is web hosted?
Ans. ```It's a trap. SAP is not available on web```
2. In a situation where a data table cannot be scraped by using Data Scraping but each cell is accessible by selectors, how can the robot extract all the cells from a column with a large number of rows?
Ans. ```By generating a selector for the first cell and configuringits TableRow property to iterate through all the rows```
3. If you want to record a Click activity on an ephemeral element that appears only after focusing on a text-box relative to it, can that be done?
Ans. ```Yes, press F2 and in the 3 second pause put the focus on the text-box.```
4. In a SAP application, you would like the robot to click on a specific folder in a folder hierarchy. The panel containing the hierarchy doesn’t allow more granular selectors inside of it, thus no selector can be created for a specific folder. What can be used?
Ans. ```A Click Image activity, A Click Text activity with Native as scraping method.```
5. Some UI Elements are not selectable in SAP client, but some of them are. Which might be the problem?
Ans. ```The scripting is enabled only on the client side```
6. Which is the easiest method in order to extract a table from SAP that has the scripting enabled on both sides?
Ans. ```Using the Data Scraping wizard```
7. How can the robot identify if a checkbox is checked or not?
Ans. ```By using get Attribute activity```
8. Consider having to click a button which cannot be accessed by using a selector. What other options can be used?
Ans. ```Click relative to an element that can be identified by a selector,Use a Click Image activity set to click the image of that button, See if clicking the button can be replaced with sending a combination of keys.```

# RPA Developer Continuous Learning

## Regex Selectors
* A Regular Expression, regex or regexp is a sequence of characters that define a search pattern.  
* In order to use it:
1. You can specify the target search tag by using matching:<tag_name>=’regex’;
2. You can specify the search pattern by using <tag_name>='<regex_command>'
e.g., ```aaname={{regex}} matching:aaname='regex'``` where ```regex is variable with required expression```

## Fuzzy Selector
* Fuzzy string matching is a technique to search strings which are not 100% match, and match a pattern approximately, rather than exactly.
* A selector’s fuzzy search capability enables you to locate strings based on a pattern, rather than on an exact match to your input. 
* In order to use the fuzzy search capabilities, you need to include in the top-level tag of the target selector a matching option:
1. You can specify the target search tag by using matching:<tag_name>=fuzzy;
2. Determines the matching threshold by using fuzzyLevel:<tag_name>=<numerical_value>. 
3. The values supported are numerical from 0 to 1, a closer to 0 value returns results with lower similarity, and a value closer to 1 returns the results with higher similarity.
* If more elements are found, the target action is executed on the first one. 
e.g., ```aaname={{regex}} matching:aaname='fuzzy' fuzzylevel:aaname='0.7'```

## Non-Greedy Selector
* Non-Greedy search gives you the option to search the subsequent tags in all the windows that match the top-level tag.
* In order to use the Non-Greedy search capabilities, you need to include in the top-level tag of the target selector an Idx() attribute:
    You can search through all active window instances for the element matching the top-level tag by using <idx='*'>.
* Please note that the <idx='1'> option only searches through the window instances in focus. 
* So if there are multiple tabs open and you want ```Bot``` to apply or find the given selectors to all tabs without bringing them to foreground then we use these ```Non-Greedy Selector```
* Non-Greedy  Selectors are supported only for <wnd> and <html>.

Note:
* You should extend the selector definition to have a new namespace for search matching and for the fuzzy level where:
```matching = regex, fuzzy, fuzzywords, fuzzyLevel = 0 .. 1```


# WebDriver
* WebDriver is a remote control interface that enables introspection and manipulation of Document Object Model (DOM) elements in web browser.
* The Document Object Model (DOM) is a cross-platform and language-independent interface that treats an XML or HTML document as a tree structure wherein each node is an object representing a part of the document.
* Using this protocol, headless browser automation (simulate work) becomes possible automating web pages through the WebDriver API,without having to install extensions and even without using the GUIs
* Headless testing is when you run a UI-based browser test without showing the browser UI. It's running a test or running a script against a browser but without the browser, UI starting up.
* Types of supported drivers:
1. <a href="https://chromedriver.chromium.org/">Chrome Driver </a>
2. <a href="https://github.com/mozilla/geckodriver/releases">Mozilla Firefox </a>


## Installing the Web Driver Protocol
1. Start by downloading the WebDriver executable corresponding to the browser you want to use;
2. Install and download WebDriver in a location of your choice,such as ```C:\webdriver\Chrome```
3. Select the Path variable either from User or System and Edit
4. Click and set path as ```C:\webdriver\Chrome``` 
5. Restart the Robot Service for the changes to take effect and you are good to go

## Activity Configuration
1. To enable the ```WebDriver``` capabilities in your browser activities select the browser you are using from the ```BrowserType``` field , then the WebDriver option from the ```Communications Method```
2. To perform activities without the ```Headless Browser``` leave the ```Hidden``` checkmark ```unchecked``` within the ```Properties panel``` else vice-versa

# Triggers
* In New Orchestrator, we have 2 types of triggers:
1. Time Triggers (ex Schedule) : plans a recurrent job
2. Queue Trigger : Triggers job whenever new items are added to Queue
* A Queue can have only 1 trigger associated with it
* When we enable an SLA,the association between the process and the queue is automatically made

# Credential Store Integration in Orchestrator
* A Credential Store is a named location within a secure store from which you can retrieve robot credentials and credential assets when needed.
* Mostly Used ones are:
    1. CyberArk <a href="https://docs.uipath.com/orchestrator/docs/cyberark-integration"> integration </a>
    2. Azure KeyVault <a href="https://docs.uipath.com/orchestrator/docs/azure-key-vault-integration"> integration </a>
    3. Orchestrator database (default)
* To add 3rd party plugins, edit the ```web.config``` file found in the ```installed orchestrator``` files by looking for ```plugins.SecureStores``` and add file names simply by adding values using comma```.``` and restart orchestrator service


# IT Automation
* The activities are built on top of the official APIs or SDKs provided by the technology vendors (e.g. Microsoft, Amazon, VMware, Citrix, and others)
* The activities run in the background, not via the UI
* The activities are developed and owned by UiPath
* They are published on the official feed and we offer long term support and official maintenance
* The activities are certified and scanned with ```VERACODE``` and ```FOSSA```


## What are the capabilities of IT Automation Activity Packages?

* Easy to Use - Easily create, update, manage and run IT automation processes
* The list of supported technologies is continuously expanding - Automation for On-Premise and Cloud IT infrastructures & services, User Management systems, Virtualized Environments;
* Seamless integration - secure integration with your existing Systems & Applications.
* Examples: Deploy Server(Cloud/onprem), AD-Create User/Reset User Password, VMware export VM to OVF...and many more

## Features
* easy to use by drag and drop
* reduced setup time
* background running via APIs
* no additional costs with implementation
* blends with your existing partner ecosystem
* secure Veracode certified
* official long-term support by UiPath

## Integration
1. Self Service & Delegation, Triggers, Integrations
    * schedule jobs from the Orchestrator web application - for example, the controlled maintenance power-off of a datacenter
    * jobs automatically triggered by an event - for example, a password reset based on a ticket
    * nightly trigger a servers power-off job to stop unused computers and save costs.
2. Orchestrator mobile app
    * start process jobs from your mobile devices
    * access logs and reports on the go
    * reply to Long Running Workflows approval requests
    * react to critical IT requests in real time.
3. Integrate the existing IT scripts in the UiPath automations
    * increased security - for example, credentials can be safely stored in Orchestrator assets or secure vaults
    * access control - delegate workflow executions to other colleagues
    * mobility: run them on the go
    * integrated with approval and persistence
    * support for Audit / ISO certifications - logging layer and reporting.

<img src="IT_Automation.png"/>

## Important Terms 
1. Microsoft Active Directory
* Active Directory (AD) is a directory service that Microsoft developed for the Windows domain networks. It is included in most Windows Server operating systems as a set of processes and services. Active Directory uses Lightweight Directory Access Protocol (LDAP) versions 2 and 3, Microsoft's version of Kerberos, and DNS.
* <a href="https://en.wikipedia.org/wiki/Active_Directory">Fore more info</a>

2. Domain Controller
* A Server running in Active Directory Domain Service(AD DS) is called a domain controller.It authenticates and authorizes all users and computers in a Windows domain type network-assigning and enforcing security policies for all computers and installing or updating software

3. sAMAccountName
* The sAMAccountName property is a login name used to support clients and servers from the previous versions of Windows, such as Windows NT 4.0,Windows 95,Windows 98, and LAN Manager.The login name must be less than 20 characters and be unique among all security principal objects within the domain
* <a href="https://docs.microsoft.com/en-us/windows/win32/ad/active-directory-domain-services-reference">Fore more info</a>

4. Microsoft Exchange Server
* Microsoft Exchange Server is a mail server and calendaring server developed by Microsoft. It runs exclusively on Windows Server operating systems
* <a href="https://products.office.com/en-us/exchange/microsoft-exchange-server">Fore more info</a>

5. MailBox
* User mailboxes are Exchange mailboxes that are associated with people,typically one mailbox per person. Each user mailbox has an associated Active Directory account that gives the person access to the mailbox to send and receive email messages and create meetings and appointments
* <a href="https://docs.microsoft.com/en-us/exchange/recipients/create-user-mailboxes?view=exchserver-2019">Fore more info</a>

6. Exchange Management Shell
* The Exchange Management Shell is built on Windows PowerShell technology and provides a powerful command-line interface that enables the automation of Exchange administration tasks.
* It can be used to:
    1. Create email accounts
    2. Create Send connectors
    3. Receive connectors
    4. Configure mailbox database properties
    5. Manage distribution groups
    6. Bulk Operations
* In fact, when you do something in the Exchange admin center (EAC), the Exchange Control Panel (ECP), or the Exchange Management Console (EMC), it's the Exchange Management Shell that does the work behind the scenes. 
* <a href="https://docs.microsoft.com/en-us/powershell/exchange/exchange-server/exchange-management-shell?view=exchange-ps">Fore more info</a>


## Active Directory and Exchange Server Activity
### Prerequisites for Active Directory
1. Active Directory Server
2. Username
3. Password

* It offers activities for Microsoft Active Directory Domain Services (AD DS)
* It provides a hierarchical data storage for objects in a network.This set of activities enables IT professionals to easily automate important operations with Active Directory objects like users,groups,and computers

* Possible operations that can be automated are:
    1. Creating and updating user groups
    2. Managing group membership
    3. AD object management
    4. Access control and 
    5. rights management

### Microsoft Exchange Server
1. Install Exchange Management shell on the Exchange Server
2. The machine where the workflow is running should be domain-joined with the Exchange Server, and access should be available - FQDN(Fully Qualified Domain Name ) of the Exchange Server should be known/resolved by the robot machine.
e.g., Mail.devsl.local

* It offers administration activities for On-Prem Microsoft Exchange Server 2016 and 2019
* With these activities, you can delete and create Exchange mailboxes , as well as enable and disable archiving for existing mailboxes.

## Various Possible Processes that can be automated
1. Employees Onboarding
* When a new employee is hired in a company, the HR department provides the input for a UiPath automation process which can be in any format, let's say Excel.

* Our workflow will create a corresponding new user account in Active Directory, will generate a random password for it and will set it to expire after the first login, and lastly adds the user account to a list of specified groups. 

2. Employees Offboarding
* When an employee leaves the company, the associated Active Directory user account is removed from the groups it belongs to and the user account is disabled.

3. Password Reset & User Account Unlock
* These are the most common IT operations that are happening on a daily basis in any company. Automating them will make the life of IT admins easier. 

* For example, employees can make requests to an IT Help Desk Chatbot which automatically triggers a UiPath process to respond to their requests for password reset or user account unlock. This can happen almost instantly.

4. Active Directory Objects Management
* These are the most common IT operations that are happening on a daily basis in any company. Automating them will make the life of IT admins easier. 

* For example, employees can make requests to an IT Help Desk Chatbot which automatically triggers a UiPath process to respond to their requests for password reset or user account unlock. This can happen almost instantly.

5. Access Control & Rights Delegation
* You can manage the access to miscellaneous resources via Active Directory group memberships.


# Orchestration Process

### Long-running workflows
* A Long running workflow is a workflow which needs to wait for an external service to complete a period of time to pass or a Human user to provide input before it can continue
* These go into a ```suspended state``` until the conditions are met for it to resume. This greatly reduces resource usage
* While the long-running workflow is waiting, the workflow context (The state variables ad of the execution) remains persistent

### Asynchronous Processing
* When executing a set steps ```synchronously```,like in the case of a ```For Each``` activity, the system waits for each iteration of the loop to complete before executing to the next one.
* When executing the steps ```asynchronously```,like in the case of a ```Parallel for Each``` activity ,multiple transactions can be processed at the same time. The transactions are executed in different ```threads```. Threads are series of activities that can run concurrently.
<img src="Asynchronous Processing.png" />

### When should we choose Orchestration Process
* When our process will run in an unattended environment and requires that we use a rules engine to stitch together robot tasks, human tasks and asynchronous processing.

* When the execution of our process needs to wait for an event to complete and we don't want the robot to keep polling for resources

