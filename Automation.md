# Automation Anywhere
## Date: 2nd October 2019

## Agenda
1. Intro
2. Automation anywhere architechture
3. Web control room
4. Bot creator
5. Bot runner
6. Best Practice and techniques


# Intro
* Bot insight -> analytics platform
* Rpa platform -> task and meta bot, meta bot is the advanced version of the task bot
* Cognitive platform-> IQ bot 

# RPA platform
* Rule based
* front end automation
* Multi system integration
* Structured Data

# Cognitive platform
* Algorith based decision
* self learning activity
* Vision,NLP
* Semi structured data
* Dark data ->semi structured(pdf,images) or unstructured , 80 % data is in this form
* IQ bots helps to work on semi structured or unstructred data
* ML and AI abilities are supported with IQ bots

# Analytics Platform
* Provides business insights
* measures effectiveness
* make scaling decisions
* how much should be invest to make sure revnue is being generated

# Able to automate
* reading data from certain platform and writing to another
* works both for web bases and desktop based
* works awesome with Structured Data and good with semi-structured
* rule based decisions

# lacks
* Not able to work with handwritten data
* non rule based general calls

# Notes
* Once bot is set up on control room then it can be used to all other machines connected with same control room
* There are 2 types of clint: 
  1. Development Client -> bot creators
  2. Runtime Client -> bot execution, required once the bot is deployed to control room
* v-10.5, 8GB of RAM is required, CLient only would require 4gb RAM
* current version-: 11.3.3
* Latest Version of AAE Client requires around 16GB RAM
* Control room is equipped with lots of tools and activities, its different in version 11 then 10
* AA community is applicable only for 1 month
* License in AA are customized thus can be developed based on requirements and charges will be applicable as per the needs
* To execute or use the Control Room , we require License to be uploaded on server through the control room application only
* Bots can be scheduled to be execute at certain time only
* autologin feature -> it allows the machine to unlock the software, login the client and do the automated tasks
* Ram usage can be found using variable ```RamUsage``` and CPU usage using ```CPUUsage```.

# Runtime Client
* It is classified into 2 catgories:
  1. Attended -> Requires human interaction
  2. Unattended -> no human interaction required
  
# Time to Create
* KeyStrokes -> insert data in some other application
* Select Window shows the list of all applications opened on your system
* to perform certain hotkey actions just choose options from given list
e.g [ENTER]
* the commands can be reordered by move up or move down option
* Open Program/Files -> to open application,just type its name
* To upload your bot to main control room , just right click on bot file and click upload
* Community edition software does not have access to control room(users can not be created, licenss can not be managed)
* ```atmx``` standard bot file extension
* Repository Manager -> it allows the control room admin to run or schedule the uploaded bots
* To create a user:
  1. Actions Tab
  2. Create User Tab
  3. Set the details and all details are editable
* Various Roles available
  1. Admin -> can never login to the client and make bot, License Allocation:None
  2. AnalyticsConsumer -> work on BotInsight platform, utilize the reports
  3. AnalyticsExpert -> work on BotInsight platform, process the reports
  4. Basic -> mandatory, as it allows to login , for both runner and developer client
  5. IQBotServices  -> Cognitive platform
  6. IQBotValidator -> Cognitive platform
* Automation Anywhere works on R back policy, custom bots can be created to restrict or determine the permissions allowed for a user
* Control Room Recognizes the ```BOTS``` based on their machine id
* Operation Room -> Shows the task that are currently in progress
* Audit Trail -> Its the log file which stores the data regarding each and every activity, success / failures , reasons etc.
* Roles and Permission -> These can be set in control room and custom roles can be created as well
* App Management -> To integrate the system with other applications
* Outgoing Mail Server Application -> to send mails with reference to working or progress of any bots can be set
* On Installation of Control Room , two categories or options are available:
  1. Express Mode -> the master key gets set with machine
  2. Manual Mode -> master key is need to be given at every login instance
* Secure Recording -> It is required to be ```enabled``` so that the recorder would not record snapshots and take only Abstract information
* Help / Support -> it can be customized as per the need

## To Set Auto Login
* Click on Tools
* Click Options
* In Login Settings
  * Set Username and Password
  * Check auto login and scheduler task
  * Finally Apply
 
## Workflow Designer
* Helps to maintain the libraries of the bots
* every workflow can have only single start button
* To Create a ```WorkFlow```
  1. Click on Workflow
  2. Click New Workflow
  3. Drag and Drop ```Start``` activity
  4. ```Run Task``` -> this activity selects the pre build bots or tasks
    * ```Repeat``` -> recursive action
    * ```speed``` -> the way to complete the task, in real time , at backend etc
    * ```Variable``` -> to set dynamic variables for our task such as login credentials
* Its a kind of UML Diagram which can be designed as well as executed at the same moment

## Properties
* ```View Logs``` -> this option is used to check the log file
* ```TimeOut``` -> any bot can be given a timeout after which even if the application wouldn't have completed execution, it will be terminated
* ```Notification``` -> once email settings are done, one can use it to send mails with email trigger
* ```HotKey``` -> shortcut can be set to run some bot

## SCHEDULE
* It can be used to schedule a particular bot and for it t, the machine password is mandatory to be specified

# Practical
# Recorders
* There are 3 types of Recorders:
  1. Smart Recorder
  2. Screen Recorder
  3. Web Recorder
  
## Smart Recorder
* It captures the coordinates
* It captures the image in background
* It captures the object
* Smart Recorder has the inherent ability to identify keystroke actions such as ‘Shift + A’ as capital A. Also, special keystrokes such as ‘Tab’ and ‘Enter’ are saved as separate actions in the command.
* Use Smart Recorder:
    1. To record tasks in Internet Explorer 8 and above only.
    2. To navigate across controls, it is recommended that you use 'Click' action instead of 'TAB'.




## Screen Recorder
* Captures mouse movements,clicks and keystrokes

## Web Recorder
* Based or made for internet related tasks, IE supportable 100% and only
* It provides encoding feature of different languages
* When a task is recorded using Web Recorder, if the layout of a web page changes and the web controls move to a different location on the page, Automation Anywhere is capable of locating the new position of these controls and running the task correctly.

# 3rd October
## DataBase
* Microsft Access -> Microsoft Jet 4.0 OLE DB Provider
* Connect -> this is command used to connect MS access with AA
* Prompt -> Used to prompt user to get an input for True/False or Yes/No which can be stored in a variable
* It has 4 types of commands:
  * Prompt for Value
  * Prompt for File
  * Promp for Folder
  * Prompt for Yes/No
* In prompt, there is option for ```Select Window``` in that use ```Don't write in Any Window``` to make sure what screen will be seen in background while prompt is there
* SQL Commands are not supposed to end with semi-column ```;```
* The input given by user is ```Generic``` by default

    


## Variable Manager
* Create custom variables
* Value Type -> start with 'v' letter for variable name
* Array Type -> start with 'arr' letter for array name
* List Type -> start with 'list' word for list name
* New variables can be created by just using the ```Add``` button

## Read From CSV/Text
* It is an activity which can be used to read data from CSV or Text File
* ```Delimeter``` -> used to differentiate data
* By default Read CSV file activity iterates over line by line
* ```$Counter$``` is an inbuilt function which can be used to iterate and show no of iterations done

## Error Handling
* Isolates errors that occur when running tasks
* To Continue the task even if some error occurs , it is used
* Various Error Handling Options are:
  1. Take Snapshot -> save a pic of error
  2. Run Task -> run any other task
  3. Log Data Into File -> create an log file for errors
  4. Send Email -> To send an email regarding the error
  5. Variable Assignment
  6. Set task status
  
* In error Handling ..if any task fails to accomplish, we can set it to do any of the above tasks
* There are 2 System Variables made to be used for error handling 
   * Error Description
   * Error Line Number
* <b>Variable Watch Table </b> -> it is used to check the variables changing if...```Dynamically```
* <b> Toggle Break Point </b> -> It is use to freeze the executing script and run a step of the process by self click only
* <b> Step Over </b> -> It is clicked to run the next step of process when the code is freezed
* Enabling ```Error Debugging``` mode gives you access to remove errors using its inbuilt features


## PDF Integration
* It allows you to copy text from pdf
* to merge or split two or more pdfs
* to encrypt or make pdf password protected and to decrypt as well

## Encryption
* It is of 2 types:
  1. Symmetric  -> same lock and unlock key
  2. Assymmetric -> differnt lock and unlock key
* In AA, we have 3 activities with us
  1. Encrypt Files -> easily set passphrase and encrypt with any given algorithm
  2. Decrypt Files
  3. Create keys
* Various Symmetric Algorithms available are:
  1. Idea
  2. TripleDES
  3. CAST5
  4. Blowfish
  5. AES128
  6. AES192
  7. AES256
  8. Twofish256
* ```Create keys``` is used to create the public and private keys 
* The file extension of keys should be ```.snk```
* The files Encrypted with ```Public keys``` can only be saved with ```Private Keys```

# 4th October 2019
## Smart Recorder
* It can work with object,image or even coordinates
* ```control``` is keyword to refer to control panel
* It can be used to easily automate ```Coursera``` with less chances of ```Re-Captcha``` detection

## Screen Recorder
* It is dedicated to Static pages

## Email Automation
* Connect to email server (imap.gmail.com) port: 993
* monitor email activities
* download attachments to proper folder
* Extract emails and data based conditions

* To get all messages, Requires
1. HostName
2. UserName
3. Password
* Select Server type
* Insert port number
* specify which mails to read
* Specify message format

* Use ```Get All Messages``` activity to access all the mails
* it can fetch eith ```all``` or ```unread``` or ```read``` mails


## System Variables
* It contains all pre-built system variables 
* the variables such as:
  1. Date/Time
  2. Loop
  3. Excel
  4. Email 
  5. Trigger
  6. PDF
  7. System

## Metabots
* using metabots we can clone a certain application on local machine and can be used for re - use with similar environment
* It is used when certain pages, fields are dynamic in nature and tend to have changes with field positions
* There are 2 types of metabots
  1. Asset -> Screen Capturing and calibration with actual screen and captured screen ( the acceptance should be more than 80 %)
  2. Logic -> Capture the fields and insert data
  
## XML
* Processig XML information generated from web services and cloud computing applications
* Supports sessions,node editing, based on a tree structure of an XML document
* To find any ```Tag``` data in ```AA``` use ```Get Node``` activity
* Format to write node name is ```//node-name``` ... example ```\\IP```
* ```Save Session Data``` -> used to save the processed file as another file
* Functions like ```sum``` can be used

## Certification Process
* Practice 40Hr 
* We have to face 40 Questions at test1 (MCQ Type) Passing Marks: 75% above
* Use case will be given at round 2 , develop a bot with proper format
* need to submit both bot file and output file
* The formats should be checked before submitting files
* Criterias:
  1. components used
  2. Best Practices
* Complete E-learning tutorial


# Automation Anywhere

## RPA
* Rule-Based Robotic
* Front-End Automation
* Multi-System Integration
* "Democratize" Automation
* Structured Data

## Cognitive Platform 
* Algorithm-Based Decision Making
* Self Learning Ability
* Subject Matter Experts - Vision,NLP etc
* Semi-Structured Data

## Analytics Platform
* Business Insights
* Effectiveness Measurement
* Scale Decision Making

## Process Maturity Model
* PMM is an evolutionary improveent path. This path guides organizations as they move towards automated business processes
* Each stage of the PMM is a foundation for the next stage to build upon, and the improvement strategy frawn from a PMM provides a roadmap for continuous process improvement.
* It has 5 stages:
    1. Automation Pipeline ~> This stage helps in identifying and prioritizing processes eligible for automation and includes two phases.These are:
        * Top Level Benefit Analysis
        * Candidate prioritization
    2. Feasibility Analysis ~> This is analysis ad evaluation of a process in the automation pipeline to understand if it is technically feasible within a specific cost bracket
    3. Complexity Assessment ~> This assessment helps determine the effort required to develop and standardize an automated process
    4. ROI Analysis ~> Return-on-Investment analysis helps determine the returns that will be gained upon investing in Automation
    5. Automation Design ~> This is the stage during which process-specific and infrastructure-specific automation solutions are designed
* Each of these stages is an elimination round for processes.Those that do not satisfy the requirement of any of these stages get eliminated from the automation pipeline

# Control Room Settings
* A role-based accessibility model ensures each User views information or data relevant to the role assigned to the User by the Control Room Administrator
* Web CR acts as a centralized server that enables monitoring,deploying and scheduling of Bots anywhere, anytime
* Repository Path ~> It is the shared path of the Control Room repository where physical files are stored
* Client Service Port ~> It is the default port used to communicate with the Enterprise Client
* WebSocket Service Path ~> It indicates the location of the machine from where the WebSocket service is hosted
    click ```tool icon``` to open in edit mode and input the IP or the Hostname and the Port
* The CR Acess URL indicates the path to either the local IIS, the reverse proxy or the load balancer - whichever is used for your web environment
    click ```tool icon``` to open in edit mode and input the IP or the Hostname and the Port
* Outgoing Mail Server Configuration ~> used to send email notifications which can be updated using this command
* Credential Vault ~> To Configure the settings for the Credential VAult, A super admin has tp choose between Express or Manual Mode where
    Express Mode: Use this to auto-connect to the Creential Vault(master key will be stored)
    Manual Mode: Use this to manually connect to the Credential Vault(Highly Secure as need passkey everytime)

## Highlights
* Version COntrol Integration with SVN
* Browser-Based Access
* Interactive Dashboard with real-time data
* Multiple Admin Support
* Role-based access control
* Centralized Licensing
* Audit trail & Analytics
* Credential vault
* App Management

## Control Room Activities
1. Dashboard ~> it allows you to view task-relevant activities
2. Repository Manager ~> It is used to manage the automation files repository.Schedule , Deploy and , or Run tasks
3. Operations Room ~> View the Control Room history and tasks in progress
4. User Management ~> Used to configure Users, which include both the Client and the Administrator , and maintain their rights and permissions. Users can be activated, deactivated or even deleted if necessary
5. Audit Trail ~> It displays recent activities of Users and Administrators
6. Task Schedules ~> It is used to view or create schedules for task execution on Runtime machines
7. Security ~> USed to manage roles. You can create new roles and manage existing roles
8. Clients ~> Displays details relevant to registered client users,including client type, clients machine name , User name , and Application Path
9. Credential Manager ~> location for securely creating and storing sensitive information that is included in automation tasks in the form of Credentials
10. App Management ~> Allows you to edit registration details of existing apps as well as register new apps

## Components of Web CR includes:
    1. Control Room Settings
    2. License Management
    3. Support Site
    4. User Profile
    5. Features Panel

## Admin Privileges
* Can Configure and update the Control Room Settings, such as Repository Path, Web-Socket Service, Control Room Access URL Version Control,Outgoing Mail Server,email Notifications,Credential Vault and URLs for App Management
* WebSocket Service PortNo and Control Room Access features are available in case of Distributed Installation only

## Client Configuration
* It enables you to control the mode of recording done by a Client for business processes.Control Room Administrator can go to CR Setting > Select Client Configuration, where the option Secure Recording is available
* What is:
    1. Secure Recording ~> It ensures none of the objects and properties that comprise sensitive information are captured (Default: Disabled)
    2. Automation Anywhere URLs ~> If you click AA's URLs,you are navigated to the default AA Support Site else 
    3. Product help URLs enable you to redirect user to the links for your own Customer Support Portal
    
## Client Usage Status 
* This tab shows the details regarding License Type , Purchased and Used Licensed
<b> License Type </b> ~> Basically there are 2 types of Licenses
    1. Development Clients are the ones who are given the privilege of creating tasks in Enterprise Client
    2. Runtime Clients are Users who are allowed to run tasks and if purchased, IQ-Bots and MetaBots
<b> Purchased </b> ~> The Purchased Licensed Type displays the number of licenses that have been purchased for Development Clients and TaskBot Clients
    1. Development Client Users can be allowed to create tasks that could include IQ-Bots and/or MetaBot if the required plugins have been installed
    2. The Runtime Client Users can be allowed licenses to enabe the Scheduling Manager - User with scheduling privileges , to run tasks on TaskBot Client User machines

## Allocate License to Client
1. Select the ```tool``` icon to launch the Client ```License Allocation" window and Select the Client type
    1. Select Development type for Bot Creator
    2. Select Runtime for BotRunners
    3. Select None,when you want to allocate license to the non-client users that is Users who are neither Bot Creators not Bot Runners
    

# Workshop Automation Anywhere Student Certification ( 11th to 13th November )
* Bot Heart Beat ~> Failure Rate
* MVP ~> 
* Status ~> Status of each bot
* SLA ~> How many devices can be run at a time in a pool

## Task Bot
* Operates in the presentation layer of any desktop-based application
* Execute multistep Process
* Around the clock
* No errors

## Recorder
1. Standard ~> Captures all mouse clicks and keystrokes
2. Object ~> Ideal for desktop applicatios , captures windows control actions
3. Web ~> Process and extract data from web appications

## Variable Operation
* It is used as an Assign activity

## IQ Bots
* It adds cogitive abilities to automated business processes
* It Provides:
    1. Computer Vision
    2. Multiple AI Techniques
    3. Intelligently digitize and extract data
* Dark Data ~> Semi-Structured and Unstructered Data that can be handled by IQ Bots
* Task Bot users also
    1. Create Learning Instances on the IQ Bot Portal
    2. Deploy the learning instances from staging to production environments
    3. validate documents with exception

## Features and Benefits
1. Semantic Analysis
    * Automated Classification
    * Extracts Data accurately
    * Categorizes various document types and formats
2. Accurately digitizes documents
3. Simplifies the process of training the bots
    * Auto-detects field values
    * Auto-corrects exceptions
    * Flags Exception
    * Provides cross-field mapping rules
    * Resolves field collisions
    * Helps training verification via result preview
4. Handles exceptions faster and seamlessly
5. Supports many languages

## Meta Bots
* Visual Captures ~> GUI Components of screen
* Application APIs ~> Allow low level operations of an application by evading GUI, Supports API on dll
* Navigational flows ~> Pre configured use cases of an application and Leverage visual captures and APIs and Screen and DLLs form the Assets


* STP ~> Number of documents that are processed end-to-end without human intervention



# WorkBench
* It allows the ```Business Process Specialist``` and ```IT Staff``` for ```Streamlining, enhancing and Deploying``` the automated tasks
* Non technical can build automated processes using drag and drop

## Components of Workbench are:
1. Commands Panel ~> Drag and Drop command in Actions list panel and edit or move in bulk 
2. Actions List ~> Opens and Edits multiple task/metabots side by side
3. Actions Buttons (New,Record,Run,Save,Enable Debugging, Set snappoint)
4. Error View Tab ~> Manages Errors,Simultaneous Debugging and Track Progress of longer tasks and debug them
5. Variable Manager tab ~> Displays user defined local variable
6. Filters box ~> Manage time consuming tasks
7. Bot Dependencies/Manage Dependencies ~> Exports depended files to COntrol Room and deploy when required by the  TaskBot

# Tool and Commands 
## Read from CSV/Text
* Used to List sepearated or Tab delimited data
* Read multiple lines
* Encode data into ANSI,UNICODE or UTF8 Encryption format

## Variables
* There are 4 types of Variables
1. List ~> This holds multiple values in a single dimesnion. It is used for retrieving multiple values, or Sending email to multiple recipients or Passing different values inside of a loop or Searching multiple web addresses.
2. Array ~> This is a multi-dimensional variable that holds multiple values in a table of rows and column. Arrays are used for 
    1. Extracting data from web Pages
    2. Extracting multiple rows of data 
    3. Reading or writing data
    4. Filling out order forms
3. Value Variable ~> This is created when a user needs to hold a single value and use it in multiple places
4. Random Variable ~> This generate a random , repetitive or a numerical set. Generally used to create sample test data in form of String or Numerical

* ```AAControlRoom``` ~> System variable used to show the Control room URL
* Variable Manager can be used to Add,Edit,Delete or copy the variables
* ```Table Column``` System Variable Stores the Content from the table extracted through Web Recorders Extract Table Command
* ```List`` Loop is used to perform loop operation based on the selected variable

## Image Recognition
* The Comparison Mode allows 4 options:
    1. Advance(Default & Recommended) ~> Provides accurate results in cases where the screen resolution/zooming or application scaling is subject to change
    2. Normal Mode ~> Compares the RGB components of the pixels with the source
    3. Gray-Scaled mode ~> Converts pixels to an appropriate level of gray-scale prior to comparing
    4. Monochrome mode with Threshold ~> Converts pixels to either black or white prior to comparing
* Image Recognition command allows you to locate an image after the image might be moved, for example, from one location on a web page to another.
* It also allows you to use Image based automation when application UI elements may not be available for automation. For example, when application is exposed over Citrix or when application accessed from RDP, or when object detection is not as reliable such as legacy applications, you can use the Image Recognition command.

## Insert Work Item
* In order to use Work Item command, there are some criteria to be considered. These Include
    1. You need to have a Bot Creator license
    2. You need to have setup the Queue in the Control Room Workload page prior to using it in a Task Bot
    3. You must be added as a participant in a Queue or queues in the Control Room,otherwise, Not Enough Privileges error condition occurs.
* If the queue is in run mode and associated with a bot to prcess work items in the Queue, a ```STAGED``` error condition occurs.


## Error Handling
* The Error Handling command is used to handle errors while running a task and aids in debugging the task
* The Error View Tab in the Workbench can be used to manage errors
* It updates the changes automatically and Tracks and debygs longer tasks
* Error Handling Options are:
    1. Take Snapshot ~> Captures and saves a screenshot of the error screen as file in a default temp folder where file is timestamped with Day, Month, Year, Hour and Minute
    2. Run Task ~> Run another task , when the current task encounters an error
    3. Log Data into File ~> Logs the error data into a file
    4. Send Email ~> Send an email with Snapshot of Screen,Text file containing the value of all variables(user / system)
    5. Variable Assignment ~> Specifies a value to a particular variable and sets a Task Status, while you continue running a task
* By using the Error Handling commands, you can isolate errors that occur when running your TaskBot / MetaBot Logic.
* When an error occurs, you can continue the TaskBot / MetaBot Logic after the error, or stop the Taskbot / MetaBot Logic.


## Manage Web Control Commands
* The Manage Web Controls subcommand is located inside the Web Recorder command
* Web controls are objects on webpages that run when the page is requested and render markup to a browser
* It can be used to insert actions to the following:
    1. Links
    2. Drop Down menus
    3. Checkboxes
    4. Radio buttons
* It can be used to insert text or ```set values``` in Web based text fields same as ```Type Into command``` of UiPath


## Log To File Command
* A log file can be saved with ```.csv``` or ```.txt``` extension
* It provides encoding in the ```ANSI```,```UNICODE``` and ```UTF8``` format
* This command helps to 
    1. Verify that TaskBot or MetaBot logic runs properly
    2. Create a new log file if one does not already exist
    3. Specify custom text to be included in the file
    4. Add a timestamp to the file and
    5. Use the file as a variable


# Assesment (Recorders)
1. While building a task using Screen Recorder, which of the following points should be kept in mind?
Ans. ```Use the same screen resolution for task recording and execution,Use the same operating system for task recording and execution```
2. Which recorder is best used for Internet-based processes
Ans. ```Web Recorder```
3. Which method is used in Smart Recorder to select a button?
Ans. ```Use Click Action```
4. Ginny faced an application error while executing the recorder in Opera. Which web browser is generally recommended to use with recorders?
Ans. ```Internet Explorer 9+```
5. Sharan wants to use a recorder that works primarily by using objects. Which recorder should he use?
Ans. ```Smart Recorder```
6. Which recorder primarily utilizes screen coordinates, mouse clicks, and keyboard operations?
Ans. ```Screen Recorder```
7. Which of the following web-based technologies does Smart Recorder capture?
Ans. ```HTML```