# Salesforce 
* Founded in 1999 by Marc Benioff

* The term Cloud refers to a Network or Internet and computing refers to access resources like networks, servers, storage, application, services etc. So Cloud Computing means access resources remotely over the internet

* IaaS : provides access to fundamental resources such as physical machines,virtual machines,storage etc. Moreover, these resources are accessed by the customers as if they own them

* PaaS: PaaS offers the run time environment for applications. It also offers development & deployment tools, required to develop applications

* SaaS: makes the software available over the internet.This model allows to provide software application as a service to the end user
(Google Apps, Salesforce,Cisco WebEx)

* CRM - Customer Relationship Management : Process or methodology used to learn more about customer's needs and behaviours in order to develop stronger relationships with them. It helps team collaborate,both internally and externally, gather insights from social media , track important metrics, and communicate via email,phone,social, and other channels

* Salesforce Administrator: The person involved in this role is a business process expert who works with stakeholders to understand various loopholes in the process or to gather requirements for new process

* Salesforce Developer: Develop cloud based apps with an in-depth know how of Salesforce as well as its limitations. Should have strong knowledge of Salesforce and Visualforce development with hands-on experience in APEX coding.Java is yet another requirement for this

* Salesforce free Edition is called ```Developer Edition```

## Multi-Tenant Architecture
* Single instance of the software runs on a server, serving multiple client organizations (tenants)
* Tenants share IT resources securely among multiple applications and tenants
* Tenants do not share data among other Tenants
* Data to a Tenant is found using OrgID
* There is an extensive set of govenors and resource limits associated with ```Force.com``` code execution which helps to prevent malicious or unintentional monopolization of shared , multitenant system resources    

## MVC Architecture of Salesforce
* Model View Controller (MVC) is a software architecture pattern which separated the representation of information from the user's interaction. So anything displayed to user is a part of view,business logics/implementation is a part of the controller and tables in salesforce is part of Model
    1. Object Creation is part of ```Model```
    2. Visualforce page is part of ```View```
    3. Controller is a part of ```Controller```

* Classic version of apps - 2016 before not much used in todays time
* Lightning Apps - used these days

# Trailhead
* Trailhead Playground -> A Trailhead Playground is an org that you can use for hands-on challenges, learning new features, and testing customizations. 
* We can create only 2 users in a Trailhead Playground and Trailhead Playground never expires as long as you keep using it
* Trail -> A trail is an ordered group of modules, projects, or both that provides a guided learning path to learning a new skill, product, or role.
* Module ->  module covers a single learning topic.
* Units -> Each unit covers a subtopic within a module, and has either a hands-on challenge or a quiz at the end.
* Hands-on-challenge -> gives you a set of requirements that you have to figure out how to meet
* Projects -> A project is a series of hands-on steps that lets you learn Salesforce skills by putting them into practice right away.
* Credentials -> There are currently two types of credential: superbadges and Salesforce certifications.
* To learn and find solutions to problems -> <a href="https://trailhead.salesforce.com/help"> Help Dashboard </a> || <a href=https://developer.salesforce.com/forums?communityId=09aF00000004HMGIA2#!/feedtype=RECENT&dc=Trailhead&criteria=ALLQUESTIONS"> Developer Forum </a> || <a href="https://success.salesforce.com/answers?id=906300000004AYoAAM#!/feedtype=POPULAR&dc=Additional_Products&criteria=OPENQUESTIONS">Trailbazer Community</a>
* Trail Tracker -> The app also allows you to assign badges to employees, and comes with a set of pre-built reports and dashboards to more easily track activity.
* <a href="https://trailhead.salesforce.com/help?article=My-Domain-is-Already-Turned-On-in-Your-Trailhead-Playground" > My Domain</a> ->My Domain is required to create custom Lightning components and set up single sign-on (SSO) in an org. 

* If your playground doesn’t have the Playground Starter app, you can find your Trailhead Playground username and reset your password in Setup
    1. Launch your Trailhead Playground by clicking Launch from any hands-on challenge.
    2. Click Setup and select Setup.
    3. Enter Users in Quick Find and select Users.
    4. Locate your name on the list of users. Check the box next to your name. Take note of the username. This is the username for your Trailhead Playground.
    5. Click Reset Password(s) and OK. This sends an email to the email address associated with your username. Be sure to check your spam folder if you don't see the email.
    6. Click the link in the email.
    7. Enter a new password, confirm it, and click Change Password.

* Package -> A package is a set of pre-created configurations and developments. It allow us to load sample data, custom objects and fields, or just about anything else into your Trailhead Playground.
* To Install a Package
    1. click on ```Install a Package``` tab and copy-paste the ```package id``` in it
    2. Select ```Install for Admins Only```

* Declarative Development -> Developing without code is known as declarative development. With declarative development, you use forms and drag-and-drop tools to perform powerful customization tasks.
* Programmatic Development -> uses things like Lightning components, Apex    code, and Visualforce pages.
* Chatter Feed Trackig -> It provides a way for multiple people to comment and collaborate on a particular record. The discussions and decisions are stored on the record so everyone can stay up to date on important decisions.

* Lookup Relationships ->  A lookup relationship essentially links two objects together so that you can “look up” one object from the related items on another object.
* Lookup relationships can be one-to-one or one-to-many. 
* Master-Detail Relationships -> one object is the master and another is the detail. The master object controls certain behaviors of the detail object, like who can view the detail’s data.

* Hierarchical Relationship -> Hierarchical relationships are a special type of lookup relationship. The main difference between the two is that hierarchical relationships are only available on the User object. You can use them for things like creating management chains between users.

