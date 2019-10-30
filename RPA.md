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
* Assets are of 4 Data Types:
    1. Credentials
    2. Text
    3. Boolean 
    4. Integer

## Get Credentials
* Credentials type requires 2 input values (Username and Password) in ```Studio``` as well as Orchestrator
* Basically when ```Credential Asset``` is made with two values which are ```Username``` and ```Password```
* Then they are fetched and used at run time in Studio using ```Get Credential``` activity

## Add Queue Item
* This activity is used to send values or add the items to Queue in Orchestrator
* ```DeadLine``` ~> This property is used to set a sepecific time limit within which the queue item is supposed or required to be processed
e.g., ```datetime.Now.addHours(24)```
* ```PostPone``` ~> This property is used to postpone the activity upon reaching ```Deadline``` by some ```time``` like ```datetime.Now.addHours(2)```
* Multiple robots can be assigned to process the same Queue
* ```Reference``` property can be set to an item to identify it uniquely in Orchestrator

## Get Transaction Item
* This activity is used to fetch values or items from the ```Queue``` made in Orchestrator
* When this activity is set into loop it iterates over and fetch all the items in the Queue
* ```transaction.SpecificContent("Column-name").toString```

## Set Transaction Status
* It is used to set status of the processed item from the Queue
* If the Status is not set by the ```Robot``` then it is set to ```Abandon``` automatically after 24 hour

## Set Transaction Progress
* It is used to set some Value for the progress column in Orchestrator regarding the Processes in Queues
