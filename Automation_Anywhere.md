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


