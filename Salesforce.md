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
