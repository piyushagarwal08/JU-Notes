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

## Screen Recorder
* Captures mouse movements,clicks and keystrokes

## Web Recorder
* Based or made for internet related tasks, IE supportable 100% and only
* It provides encoding feature of different languages

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

