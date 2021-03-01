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
