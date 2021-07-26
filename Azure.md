# Microsoft Azure
* <a href="https://portal.azure.com">Open Azure Console</a>

## Cloud Computing
* A Platform that provides access to computing resources over the internet.
* Cloud providers own massive data centers which have hundreds of servers, storage systems and components critical to the organization's working.
* Users only pay for the service they use and nothing else.
* Cloud computing is used for the following services:
    1. Machine learning and data analysis
    2. Data storage and backup
    3. Streaming media content
    4. Creating and testing applications
    5. Automating software delivery
    6. hosting blogs and applications

## WHat is Azure?
* A cloud computing platform and an online portal to access and manage resources and services provided by Microsoft.
* Launched in Feb 1st 2010
* Free to start and also provides pay-per-use model
* Data centers in 42 regions around the world

## Few Azure Services

### Compute
1. Virtual Machine -> Create Windows or linux virtual machines of any configuration in a matter of seconds.
2. Cloud Service -> Uses can create scalable applications within the cloud using the virtual achines whose provisioning, load balancing and health montioring are handled by Azure post-deployment
3. Service Fabric -> Service Fabric simplifies microservices development and application lifecycle management
3. Functions -> Easily build appications using server less functions in any programming language of your choice

### Networking
1. Azure CDN(Content Delivery Network) -> Azure CDN services are used for delivering high bandwidth content to users worldwide. Networks placed in strategic positions to speed up data transit.
2. Express Route -> Express route lets on premise networks into Microsoft cloud through a private connection.
3. Virtual Networks -> Virtual Network enables Azure resources to securely communicate with each other.
4. Azure DNS(domain name system) -> It is a hosting service that allows the user to host their DNS domains in Azure.

### Storage
1. Disk Storage -> Provides cost-effective HDD/SSD options which can be used with Azure Virtual Machines
2. Blob Storage -> Blob storage is optimized for storing massive amounts of unstructured data, such as text or binary data.
3. File Storage -> Managed file storage in the cloud that are accessible via industry standard server message block (SMB) protocol.
4. Queue Storage -> It provides durable message queueing for large workloads and can be accessed from anywhere in the world.

## Uses
1. Application Development
2. Testing
3. Application hosting
4. Creating VM
5. Integrating and syncing features
6. Collecting and storing metrics
7. Virtual hard drives

## Accessing Azure
* Azure can be access and maanaged through:
    1. Azure classic portal
    2. Azure ARM portal (Currently Used)
    3. Azure Resource Manager
    4. Client Tools like:
        * PowerShell
        * Azure CLI
        * Visual Studio with Azure SDK for .NET

# Azure Network Services
* ```Microsoft Azure Network Services``` offer the foundation for developing hybrid cloud solutions with the help of following essential resources.
    1. Azure Virtual Network -> Isolated network within the Microsoft Azure Cloud
    2. Azure Traffic Manager -> Controls how user traffic is distributed between geographies in cloud services
    3. Name Resolution Service -> For internal hostname resolution within a cloud service.
    4. Azure ExpressRoute -> Extend on-premise networks into the virtual network over a dedicated private connection facilitated by a connectivity provider.
    5. Application Gateway -> works at the application later and acts as a reverse-proxy service,terminating the client connection and forwarding requests to back-end endpoints

## What is Virtual Network?
* Virtual Network, also known as VNet constitutes a logical boundary defined by a pivate IP address space that you designate. You can distribute IP address space into one or more subnets.
* This makes it functionally equivalent to on-premises networks
* VNets offers various networking features like:
    1. Ability to customize inter-VM connectivity
    2. Virtual Private Networks
    3. Access control
    4. DNS
    5. Routing
    6. DHCP Blocks
* It allows to securely connect cloud infrastructure to your on-premise datacenter.
* Features:
    1. Isolation
    2. Internet Connectivity
    3. VNet Connectivity
    4. On-Premises Connectivity -> VNets can be connected to on-premises networks through ```point to site``` and ```site to site```
    5. Azure Resource Connectivity


# Azure Compute Services
* These services are used to support applications that have a substantial number of simultaneos users.

## Compute Options in Azure
1. Virtual Machines is an IAAS service that allows you to deploy and manage VMs inside a VNet.
2. App Service is a managed service to host mobile app backends, web apps, RESTful APIs or automated business processes.
3. Service Fabric is known as a distributed systems platform that operates in numerous environments. It is an orchestrator of micoservices across a cluster of machines
4. Azure Batch is called a managed service for operating large scale parallel and high-performance computing applications
5. Cloud Services is a managed service for operating cloud applications and utilizes PaaS hosting model.

## Resource Groups
* Resource groups are containers that are automatically created for VMs,DBs and other assets that are required for your solution.
* They provide a way to monitor, control access, provision and manage billing for collections of assets that are required to run an application.
* All the resources in a group share the same life cycle i.e. deploy, update and delete them together.
* A resource can exist only in resource group.
* A resource group can include resources that reside in different regions
* A resource can interact with resources in different resource groups (Scenarios where two resources are related but do not share the same lifecycle)

## Azure VM
* It is a general-purpose computing environment that lets you create,deploy and manage VMs running in the Microsoft Azure Cloud.
* Uses:
    1. Development and Test
    2. Extended Datacenter
    3. Applications in the cloud
* Different ways to create VM
    1. Azure CLI
    2. Azure Portal
    3. Azure PowerShell
    4. Resource Manager Template -> A Json file is used to define one or more resources to be deployed to a ```resource group``` and define the dependencies between the deployed resources.
* Different VM size available in Microsoft Azure:
    1. A-Series: is basic with no load balancing or auto-scaling support
    2. D-Series: offers faster CPUs and local Hyper-V host SSD (temporary disk)
    3. Dv2 series: provides VMs with configuration up to 448 GB of RAM and 64 data disks. CPU is 35% faster than D-series
    4. DS, DSv2, and GS series: Support for Premium Storage (SSD for operating system and data disks)

## Azure VM Components
### Disks
* Azure Virtual machines use attached virtual hard disks for storage. There are 2 types of VHDs:
    1. Image: It is a template for the creation of a new Azure VM
    2. Disks: It is a bootable VHD that can be used as a mountable disk for a VM
* ```Page Blobs``` back all the disks in Azure Storage and they inherit the benefits of blob storage
* The disks are mounted as drives on the VM

### Virtual Network
* On a physical infrastructure, many components operate the virtual machines in a scalable and secure manner.
* The components could include equipment such as separate network, load balancers, firewall and more
* These components are deployed in an ```Azure Virtual Network```
* AVN provides many features like Subnet,IP address, Load balancer and Network Security Group.

### Availability Sets
* Sometimes there is a slight chance that there could be a failure in physical servers
* If in case a failure occurs, the Azure platform will migrate the failed VM to a healthy host server to reconstitue the VM
* Hence, It is recommended to deploy at least two instances of the VM
* VMs placed in an availability set should perform an identical set of functionalities.
* Azure ensures that the VMs in the ```Availability Set``` are arranged across ```Fault Domains``` on different Racks.
* A ```Fault domain``` is a set of hardware components (rack of resources like servers, power, etc) that share a single point of failure. Web, worker and Virtual Machines are arranged in the hardware.
* ```Update Domain``` in azure means, that all physical servers in one update domain will get host updates like firmware, drivers and OS updates at the same time.

# Various Azure Services

# Azure Storgae
* ```Azure Storage``` is a Microsoft's cloud storage solution for modern enterprises and applications to store data.
* It was the first service built among the Azure services
* It is elastic and can scale applications on demand.
* It uses auto-partitioning system that automatically load balances based on the traffic
* Exposes data resources through REST APIs.
* Key features:
    1. Scalability -> Easy to scale
    2. Durability -> Redundancy
    3. Availability -> Replication
* Advantaes:
    1. Security -> Encrypted data
    2. Accessibility -> The data in storage can be easily accessed through the available ```SDKs in a wide variety of language```. Azure Storage supports scripting in Azure Power Shell or Azure CLI.
    3. Management -> Easy, as Azure takes care of any critical problems and maintenance of the servers.

* Azure Storage offers 4 storage types:
    1. Blob Storage: for unstructured object data like images, videos, document etc
    2. Table Storage: a NoSQL key attribute data storage for structured datasets
    3. Queue Storage: for storing large number of messages.
    4. File Storage: shared storage for sharing files across application components via File service REST API.

## Azure Storage Account
* It is a secure account that provides access to Azure Storage Services.
* It is of 2 types:
    1. ```General Purpose Storage Accounts``` that gives access to blobs, tables, queues, files and Azure virtual machine disks.
    2. ```Blob Storage Accounts```, are specialized storage accounts for unstructured data as blobs. This type of account is recommended for applications that require just the ```block or append block storage```.

## StorSimple
* StorSimple is a ```Hybrid Cloud Storage Solution``` to manage storage tasks between on-premise devices and cloud storage.
* It has ```physical arrays``` for deployments in data centers and virtual arrays for smaller enterprise environments, which require network-attached storage (NAS)
* Local Storage gives the flexibility to retain part/entire data locally and could be useful for getting higher performance.
* It is Ideal for applications requiring high performance and capacity.

## Azure Backup
* It is a multi-tenant Azure service to back up and store data:
    1. Backup all your critical applications and data using the Azure Backup Agent.
    2. Azure ```backup data is encrypted``` at the source, in transit and at rest in the Azure.
    3. ```Configure the retention policy``` of backups as required (30 days or 100 years).
    4. ```Azure Site Recovery``` delivers a seamles portal experience for taking backups and operational recovery.


## Blob
* It is of two types:
    1. Page Blob -> 1 TB , better where changes are not required
    2. Block Blob -> 200gb, better for storage in which certain changes can be required

## Table Storage

## Queue
* It is of 2 types
    1. Storage Queue
    2. Queue Bus

## Azure Files
* Create an SMB server on Azure and use it as a sharepoint
* Sharing can only be used within azure environment.
* To access it publicly, need to use REST end point

## Unstructured Storage
* Azure unstructured storage consists of disk storage, file store, sync, and blob storage.


# Azure Database Services
* Azure provides many Database services to cater the wide range of needs of enterprises.
* Few of them are:
    1. Relational Database Services: SQL, MySQL, PostgresSQL services as PaaaS, making it easier to move existing workloads to Azure.
    2. SQL Data Warehouse: SQL based fully managed elastic data warehouse that can scale up and down as per demand.
    3. Azure Redis Cache: SAAS offering of Redis Cache that provides secure, dedicated cache for applications requiring low latency.

## Data Lake Store
* Azure Data Lake Store is known as ```Highly Scalable Apache Hadoop file system``` that can be used for enterprise-wide big data analytics workloads.
* Key Features:
    1. Unlimited storage and variety of data formats
    2. Can store data in native format without the need for any transformation
    3. Built for workloads requiring massive read throughput and analysis of large amounts of data.
    4. Can be accessed from Hadoop using the WebHDFS-compatible REST APIs.

## Azure Cosmos DB
* Azure Cosmos DB is used to support global distribution and horizontal scale. It extends the idea of a ```index-free database system```
* It offers ```turnkey distribution```by enabling seamless scaling based on user demand in any region or geography.
* ```Turnkey Distribution``` means development and delivery of a component that can be used by the occupants
* It Supports various new data types, making it flexible to work as a ```graph database``` or ```key value database```.
* ```Experience low latency```, owing to read and write from the nearest region.


# Azure App Services
* Azure App Service is Platform As A Service (PaaS) that offers development framework to build and deploy mobile,web,logic and API apps.
* Azure runs these apps on ```fully managed virtual machines(VMs)```, with users choice of shared VM resources or dedicated VMs.
* It allows connecting these apps to any SaaS or enterprise system within minutes and unlock the data.

## Key Features
* Multiple languages and frameworks: supports ASP.NET, Node.js, Java, PHP, Python etc
* DevOps optimization: can set up continuous integration and deployment with Visual Studio Team Services, Github, or BitBucket.
* Global scale with high availability: can scale up or down manually or automatically.
* Security and Compliance: is ISO, SOC and PCI compliant.
* Application templates: can choose from an extensive list of templates in the Azure marketplace.
* Visual Studio Integration: to streamline the work of creating, deploying and debugging.
* Multiple Deployment slots: Can run two or more versions of the same app (Prod and Dev) on the same VM.
* Azure Webjobs: used to execute background processes.

## Mobile App Services
* Mobile Apps is a highly scalable, globally available mobile application development platform for Enterprise Developers and System Integrators.
* It can be used to:
    1. ```Build native and cross platform``` apps using native SDKs.
    2. Connect mobile apps to your enterprise on-premise or cloud resources
    3. ```Build offline-ready apps with data sync```: apps that can work offline
    4. ```Push notifications to millions in seconds``` and engage your customers.

## Logic App Services
* Logic Apps is used for automating business processes and integrating systems and data across clouds without writing code.
* Main features include:
    1. Visually create business process and workflows
    2. Deliver integration capabilities in Web, Mobile, and API Apps.
    3. Integrate with SaaS or Enterprise applications
    4. Automate Business Process
    5. Connect to On-Premises data.

## Azure API App Services
* Azure API App Service offers a rich platform and ecosystem for ```building, consuming and distributing APIs``` in the cloud and on-premises.
* Main Features:
    1. Integrate with SaaS or Enterprise applications
    2. Generate Client proxies or APIs in language.
    3. Automate versioning and deployment of API Apps
    4. Secure APIs with Single Sing-On, OAuth, and Active Directory.
    5. Share APIs internally with organizational gallery

# Azure Analytics and IOT
## Azure HD Insight
* Azure HD Insight is widely used to deliver ```Hadoop As a Service``` on top of the Azure Platform.
* It uses the ```Hortonworks Data Platform (HDP)``` Hadoop Distribution.
* It gives ```open-source analytic clusters``` for Spark, Hive, Storm, Kafka, MapReduce, HBase, and R Server to deploy these big data technologies.
* HD Insight can be used to :
    1. Create Hadoop-powered big data solution and services
    2. Manage and monitor hadoop clusters.
    3. Analyze and report statics on big data utilization and availablity.

## Azure Machine Learning
* It is known as ```cloud predictive analytics service``` that allows quick creation and deployment of ```predictive models```.
* It comes with ```ready-to-use library of algorithms```, to create models and deploy your predictive solutions quickly.

## Azure Stream Analytics
* Azure Stream Analytics strives to ```gather knowledge structures from the continuous ordered streams of data``` with real-time analysis.
* The streams may comprise web searches, ATM Transactions , sensor readings, phone conversations, social network data or computer network traffic.
* It can handle large volumes of information and react very quickly to any change in data.
* Uses:
    1. Monitor Connected Devices
    2. Business Operations
    3. Fraud Detection
    4. Website Analytics

## Event Hubs
* Azure Events Hubs is a ```event ingestion service and scalable data streaming platform``` that receives and processes numerous events per second.
* Event Hubs processes and stores events, data, or telemetry created by distribution devices and software. Data transmitted to an event club can be transformed and stored with the help of any real-time analytics provider or storage/batching adapters.

# Azure Active Directory
* Azure AD is known as an identity management solution that ```offers access and identity services``` for cloud resources.
* It is available as both on cloud and on-premise.
* Helps to:
    1. Configure access to applications
    2. Configure SSO to cloud based SaaS applications.
    3. Manage users and groups
    4. Provision Users
    5. Enable federation between organizations.
    6. Provide an identity management solution.
    7. Multi-factor authentication