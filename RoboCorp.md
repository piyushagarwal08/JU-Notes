# RoboCorp

# Resource Links
1. <a href="https://developer.mozilla.org/en-US/docs/Web/API/Element"> Learn About Elements </a>
2. <a href="http://maxmelnick.com/2016/04/19/python-beginner-tips-and-tricks.html">Jupyter Notebook Shortcuts </a>


# Notes
* RoboCorp is a Python or YAML based programming platform using which we can automate many things like Web Automation and Desktop Automation
* Unlikek other platforms like UiPath and Automation Anywhere, it is coding based but do provides an feature to select and locate the element attributes from application
* The RoboCorp follows a certain structure:
    1. Every Robot is created inside an virtual environment
    2. It consists of 3 files by default ```robot.yaml```, ```tasks.robot```, ```conda.yaml```
* ```robot.yaml``` -> This file defines the settings of the bot like python-path or basic python command to run the files
* ```conda.yaml``` -> It is used to define the dependencies need to be present while running the program
* ```tasks.robot``` -> This is the main file in which we write the code to execute bot
* To Download files from web we can use ```RPA.HTTP```
* To Use Excel without installing excel in system we can use ```RPA.Excel.Files```
* To Automate on web we use ```RPA.Browser.Selenium```
* To print anything for testing purpose we can use ```Log``` keyword as ```Log ${variable_name}```
* In keywords if we have multiple arguments then we can pass them on multiple lines by using ```...``` in beginning of each line
```yaml
Keyword     Argument1="Some Value"
...     Argument2="Some Value 2"
...     Argument3="Some Value 3"
```
* To use space in paths use ```\``` , like ```/Users/piyus/Desktop/JOB/Piyush\ Agarwal\ _10.jpg```

# Tasks
* The Tasks file structure consists of 3 major parts
    1. Settings -> define the       ```Documentation``` and ```Library``` required for the bot
    2. ```Keywords``` -> One can understand keywords as a block of code resembling an function definition
    3. ```Tasks``` -> This is the section which runs the bot and we call the keywords inside it
* The idea of ```tasks.robot``` is to separate all the functions of bot into multiple keywords and call each keyword based on required sequence in the ```Tasks``` context

## Keywords
* keywords are to be understand as functions
* They can be with or without arguments
* An Keyword Example without argument is
```
*** Keywords ***
Open The Website For Me
    Open Avaialble Browser      https://www.google.com
```

* An Keyword Example with argument is
```
*** Keywords ***
Iterate Using Arguments
    [Arguments]     ${variable_name}
    ...more keywords
```

# locator
* It is an argument for web keywords which are used to detect the element on which some action is to be performed over browser
* There can be multiple ways to detect elements such as using ```name```, ```id```, ```css```, ```XPath```, ```FullXPath```

# RPA.Browser.Selenium
* This is a library used for web automation and includes various keywords that can be used for the same
* Example is ```Open Available Browser  https://www.google.com```
* Keywords used are:
    1. Open Available Browser : Keyword url
    2. Input Text : Keyword locator text-to-be-entered
    3. Input Password : Keyword locator text-for-password-field
    4. Submit Form : Keyword    (used to enter the form)
    5. Wait Until Page Contains Element : Keyword locator
    6. Click Button: Keyword button_name
    7. Select From List By Value: Keyword locator text_input
    8. Get Element Attribute : keyword locator outerHTML
    
# RPA.HTTP
* This is a library used for downloading files from web browser using urls something like ```curl```
* keywords used are:
    1. Download : Keyword url

# RPA.Excel.Files
* This is a library used for automating tasks with excel without having excel installed in the system
* Keywords Used are:
    1. Open Workbook : Keyword FilePath
    2. Read Worksheet As Table : ${variable_name}= Keyword
    3. Close Workbook : Keyword

# RPA.PDF
* This library is used to do operations related to PDF
* Keywords Used are:
    1. HTML To PDF : Keyword variable_with_html_attribute Output_File_Path_For_PDF

# Loops
* Syntax for loop is as
```
FOR     ${variable}      IN      @{collection_variable}
    Keyword To Call     ${variable}
END
```

# Built In Variable
* There are various <a href="https://robocorp.com/docs/languages-and-frameworks/robot-framework/variables#built-in-variables">built-in variables</a> that can be used 
* Few Useful variables are:
    1. ```${CURDIR}``` -> represents the current directory where our task file resides
    2. ```${/}``` -> represents the path separator for the current operating system
    3. ```[Teardown]``` -> ensures that the keyword is executed for sure even if other keyword faces some error. It can be understood as the finally block of try-catch
    4. ```[Return]``` -> To Return any value from a ```Keyword``` which is basically a function we use this in-built variable
    5. ```[Arguments]``` -> To send arguments to the keyword while calling we use this in-built variable

# Vault
* Credentials in RoboCorp are stored in vault
* Locally we can access credentials through ```Json``` file and over cloud we use ```Vault``` of ```RoboCorp```
* To Access ```Credentials```, we need to configure few things:
    1. Create a directory named ```devdata``` in main folder
    2. Create a ```devdata/env.json``` file in ```devdata```
    3. Add the following content inside the ```env.json``` file
    ```json
    {
        "RPA_SECRET_MANAGER": "RPA.Robocloud.Secrets.FileSecrets",
        "RPA_SECRET_FILE": "/Users/<your-username-here>/vault.json"
    }
    ```
* The content of ```vault.json``` is like
```json
{
  "credentials": {
    "username": "some-username",
    "password": "some-password"
  },
  "maria": {
    "user": "maria",
    "pass": "thoushallnotpass"
  }
}
```
* To Access Credentials we use the ```RPA.Robocloud.Secrets``` library
* Which contains the ```Get Secret``` keyword
```yaml
${secret}=      Get Secret      Credential_Name
```
* To access any key from a dictionary, ```${secret}[key-name-without-quotes]```

# Send Mail
* To Send mails, we use ```RPA.Email.ImapSmtp``` library
* It takes two arguments that are ```server name``` and ```port```
```yaml
Library     RPA.Email.ImapSmtp      smtp_server=smtp.gmail.com      smtp_port=587
```
* To Authorize your mailing credentials, we use ```Authorize``` keyword as
```yaml
Authorize       account="username"      password="pass"
```
* To Send Message
```yaml
Send Message        sender="sender-email"
...     recipients="reciever-email"
...     subject="subject line"
...     body="mailing body"
```
* Attachments can be send using the ```attachments``` parameter
* we can either send individual attachments or a ```list``` of attachments
```yaml
Send Message        sender="sender-email"
...     recipients="reciever-email"
...     subject="subject line"
...     body="mailing body"
...     attachments=    file.txt
```
```yaml
Send Message        sender="sender-email"
...     recipients="reciever-email"
...     subject="subject line"
...     body="mailing body"
...     attachments=@{Attachments}
```
* Emails retrieved from Imap contains following keys which can be used
```
'Mail-Id', 'Message','Return-Path','Received','Message-ID','From','To','Subject','Date','MIME-Version','Content-Type','Body','Delivered-To','Has-Attachments'
```
* Example to retrieve mails from server is
```yaml
Get Messages Where Subject Contains
    [Arguments]     ${subject}
    @{emails}    List Messages       SUBJECT "${subject}"
    FOR     ${email}    IN      @{emails}
        Log     ${email}
        Log     ${email}[Subject]
        Log     ${email}[From]
        Log     ${email}[Date]
        Log     ${email}[Received]
        Log     ${email}[Has-Attachments]
    END
    [Return]    @{emails}
```
* Example to download the attachments
```yaml
Download Attachments
    [Arguments]    @{emails}
    FOR    ${email}    IN    @{emails}
        Run Keyword If    ${email}[Has-Attachments] == True
        ...    Save Attachment    ${email}    target_folder=${CURDIR}${/}output    overwrite=True
    END
```

# File System
* For file system operations we use ```RPA.FileSystem```
* Keywords for ```Directories``` are:
```yaml
    ${dir_exists}=    Does Directory Exist    ${CURDIR}
    ${dir_does_not_exist}=    Does Directory Not Exist    ${CURDIR}
    ${dir_tree}=    Log Directory Tree    ${CURDIR}
    ${dir_is_empty}=    Is Directory Empty    ${CURDIR}
    ${dir_is_not_empty}=    Is Directory Not Empty    ${CURDIR}
    Create File    ${TEXT_FILE}    Hello    overwrite=True
    Wait Until Created    ${TEXT_FILE}
    Touch File    ${TEXT_FILE}
    ${file_exists}=    Does File Exist    ${TEXT_FILE}
    ${file_does_not_exist}=    Does File Not Exist    ${TEXT_FILE}
    ${file_is_empty}=    Is File Empty    ${TEXT_FILE}
    ${file_is_not_empty}=    Is File Not Empty    ${TEXT_FILE}
    ${found_files}=    Find Files    \*.txt
    Append To File    ${TEXT_FILE}    World!
    ${text_content}=    Read File    ${TEXT_FILE}
    ${absolute_path}=    Absolute Path    ${TEXT_FILE}
    ${created}=    Get File Creation Date    ${TEXT_FILE}
    ${extension}=    Get File Extension    ${TEXT_FILE}
    ${modified}=    Get File Modified Date    ${TEXT_FILE}
    ${name}=    Get File Name    ${TEXT_FILE}
    ${size}=    Get File Size    ${TEXT_FILE}
    Copy File    ${TEXT_FILE}    ${TEXT_FILE_COPY}
    ${files}=    List Files In Directory    ${CURDIR}
    ${directories}=    List Directories In Directory    ${CURDIR}
    Create Directory    ${NEW_DIR_1}
    ${files_to_move}=    Create List    ${TEXT_FILE}    ${TEXT_FILE_COPY}
    Move Files    ${files_to_move}    ${NEW_DIR_1}    overwrite=True
    Run Keyword If File Exists
    ...    ${NEW_DIR_2}/${TEXT_FILE}
    ...    Remove Directory    ${NEW_DIR_2}    recursive=True
    Move Directory    ${NEW_DIR_1}    ${NEW_DIR_2}    overwrite=True
    Run Keyword And Ignore Error
    ...    Copy Directory    ${NEW_DIR_2}    ${NEW_DIR_2_COPY}
    Run Keyword And Ignore Error
    ...    Change File Extension
    ...    ${NEW_DIR_2}/${TEXT_FILE_COPY}
    ...    .md
    Empty Directory    ${NEW_DIR_2_COPY}
```

# Access Windows Credential Manager
* By Default ```RoboCorp``` does not provide this feature
* We can use ```keyring``` module for the same using its function ```get_credential(Address_Name,None)```
```py
import keyring

def Credentials(Address_Name):
    secret = dict()
    c = keyring.get_credential("Address_Name")
    secret["Username"] = c.username
    secret["Password"] = c.password
    return secret
```

 