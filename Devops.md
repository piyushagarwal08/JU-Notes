# Docker @ Ashu sir

## Notes
* Name of Mac OS kernel is : Darwin
* DNS stands for Domain Name System
* Check public Ip from linux terminal using ```curl ifconfig.me```
* cgroups can limit the resources provided to a container
* namespace is responsible for container isolation
* Kubernetes is Container Run Time Engine
* Mercurial is an example of distributed version system
* Jenkins is written in Java(Pure)
* To Add pass to a user , run
    ```echo "my-user-passwd" | passwd user-name --stdin```
* The sudoers file name can be anything just its locaition should be ````/etc/sudoers.d```

## Docker Images
* These can be build using 3 methods
    1. Manual
    2. DockerFile
    3. Buildah
* To Integrate DockerFile with some programming code:
    1. Create your program
    2. Create a File called ```DockerFile```
    3. Contents of DockerFile are not case sensitive
    ```
    FROM python # it will check for python image in docker engine if not present then will pull from docker hub
    MAINTAINER piyushagarwal.0108@gmail.com , pykid # Developer of Docker Image, keyword is optional
    RUN mkdir /mycode # This run instruction can execute any linux command inside my docker image that i am going to create
    COPY file-name-with-extension /mycode/file-name-with-extension # it will copy code from local system to docker image
    CMD python /mycode/file-name-with-extension # this will run the code as default parent process
    ```
* ```docker build -t name:version -f Dockerfile.txt .```

* Port Forwarding ~> A way to forward the user from ```ip:port``` to a specific container

* Never create different images of same code,instead merge the new and old one

* ```docker history imagename:version``` ~> used to check the history of all commits in docker image

* ```ENV ``` this tag is used in dockerfile to set certain variable environment
* ```.dockerignore``` ~> A file read by Dockerfile which states that which files are not to be copied that is it restricts Dockerfile to copy data from your current directory
* to check the values of current environment variables we use the command
```docker exec -it container-name env```
* ``` -e ``` is used to change the environment variables

## Docker Networking
* By networking the containers can communicate with each other with being isolated from each other
* ```docker inspect container-name``` used to check ip of container
* When install Docker for the first time, 3 Docker bridges are created by default
* Out of these 3, one bridge is named ```docker0``` given by OS and docker has named these 3 bridges as
    1. Bridge (default)
    2. host
    3. None
* To check present docker bridges 
    ```docker network ls```
* To remove non-default bridges
    ```docker network rm $(docker network -q)```
* Containers use the ```host ip``` to connect to internet that is the outside world and this feature of netwrok addressing is called ```Network Addressing Translation```
* If we want that, container do not to default network bridge, we use the command
    ``` docker run -itd --name t5 --nework host alpine sh ```

* Containers can be configured that even being on same host , they can not communicate to each other that is possible by creating self customized containers

* To create a new network, run the command
    ```docker network create network-name```


```yaml
FROM java
maintainer piyush
env classname=devops
# optional
run mkdir /codes
add devops.java /codes/devops.java
workdir /codes/
# changes the directory
RUN javac devops.java
# executes the java object file
CMD java devops
```

<u> CMD </u>

```yaml
FROM alpine
maintainer piyush
cmd cal
```
* If we give some command then it runs it else runs the pre defined command

<u> EntryPoint </u>

```yaml
FROM alpine
maintainer piyush
Entrypoint cal
```

* If we give or not give some command, the cal command will run always

## Add vs Copy
* Add can be used to add URL directly to the Dockerfile
* Copy can not be used for the same
* Both works similar when we try to copy data from local system


## Docker Hub
* To upload any image over docker hub, we need
    1. docker login
    2. image to be tagged
* To tag image use
    ```docker image tag image-name:version user-name/imagename:version```
* To Push or pull images
    ```docker push user-name/imagename:version```


# Docker Storage
1. Docker Engine ~> by defaults reads and writes data in ```/var/lib/docker```
2. Containers

* Containers are ephemerial/non-persistent in nature that is as soon as container is removed, data is also lost


## Docker Volume
* command to create volume is
    ```docker volume create vol-name```
* check volume using ```docker volume ls```

* To attach a volume
    ```docker run -it --name name -v vol-name:/myimpdata image-name cmd-to-run```
* To check volume
    ```docker volume inspect vol-name```

* To share or use a folder in containers, we can use
    ```docker run -it --name name -v folder-path:/folder-to-mount image-name  cmd-to-run```
* even a file can also be mounted as storage place.
* more then one volume can also be mounted as
```docker run -it --name name -v folder-path:/folder-to-mount -v folder-path1:/folder1-to-mount image-name  cmd-to-run```


# Docker Compose
* It relies on Docker engine
* It is a file based approach which can be written in ```YAML``` and ```JSON```
* YAML ~> Yet Another Markup Language
* JSON ~> JavaScript Object Notation
* To check if ```compose``` is installed, check by running
    ```docker-compose```
* If compose is not present,download the script from ```docs.docker.com``` and make it executable using root permissions.
* Docker compose is required/installed on client side

## Versions
### 1. <u>Version1</u>
* By default, containers are deployed into default bridge
* This version is no more available
### 2. <u>Version2</u>
* New Docker network is create
* Requirement:
    * Empty Directory
    * Network of container will be same as of directory, so directory names should be unique
    * File name should be ```docker-compose.yaml``` or ```docker-compose.yml``` or ```docker.json```

### 3. <u>Version3</u>
    * New Docker network is created

## Compose File
* Everything is written in key:value pair
* It has 4 Sections
1. Version ~> 2.x or 3.x
2. Services ~> containers information
3. Network (Optional)
4. Volume (Optional)

```yaml
version: '3.5'
services:
 ashuapp11: #service name
  image: alpine    # image name
  container_name: ashuc11   # container name
  command: ping fb.com    # parent-process

 ashuapp12:
  image: alpine
  container_name: ashuc12
  command: ping google.com
```
* To start this compose file, network and container gets created
    ```docker-compose up -d```
* To show container
    ```docker-compose ps```
* To stop - remove everything
    ```docker-compose down```
* To kill container,all the containers will be exited not removed (forcefully)
    ```docker-compose kill```
* To stop container - not remove it (gracefully)
    ```docker-compose stop```
* To initiate only specific service
    ```docker-compose up -d service-name```
* To define a compose file with another name
    ```docker-compose -f file-name.yml up -d```

* example 2
```yaml
version: '3.8'
services:
 ashuwebapp1:
  image: dockerashu/ckad:v2
  container_name: ashucccc
  ports:
   - '11111:80`
```

Notes: 
* :set shiftwidth=1 ~> in vim can set enter space equal to 1
* syntax in compose file
``` 
    version:<space>'version-name'
    services:
    <space>app1:
    <space><space>about it
```
* using docker-compose stop is preferable
* network-name is same as folder name in which it is created.

## Docker Compose integration with DockerFile
* Dockerfile
```bash
FROM centos
MAINTAINER pykid
ENV x=web1
RUN dnf install httpd -y
# you can use instead of yum
ADD web1 /var/www/html
ENTRYPOINT httpd -DFOREGROUND
```
* Docker-compose
```yaml
version: '3.8'
services:
 app1:
  image: image-name-to-be-build # basically write the name of image supposed to be build from docker file
  build: .  # location of docker file
  container_name: pykidc1  # optional : if not given a random name is taken
  ports:
   - "9991:80"
```

* if docker file name is not ```Dockerfile```
```yaml
version: '3.8'
services:
 app1:
  image: image-name-to-be-build # basically write the name of image supposed to be build from docker file
  build: 
   context: . #location of docker file
   dockerfile: file-name # name of docker file
  container_name: pykidc1  # optional : if not given a random name is taken
  ports:
   - "9991:80"
  network:
   - network-name # i want to use this bride but this is not present as of now
  volume:
   - vol-name:/path-to-attach

networks:
 network-name:   # this will create a network of this name
volumes:
 vol-name:     # this will create new volume
```
* If image is present already build then docker-compose will not build it again
* But to rebuild the image, just use code
    ```docker-compose up --build -d ```


* docker run -itd --name webui -p 8388:9000 -v /var/run/docker.sock:/var/run/docker.sock   portainer/portainer
* portainer's port no is 9000

## Database Containers
* Environment variables can be setup for easy database settings
* ```-e``` is given for setting Environment Variables
* ```mysql -u root -ppassword``` can be used to open mysql
* In compose file, we can write a keyword ```depends_on:``` to make one service wait for another service to be ready

```yaml
version: '3.8'
services: 
 db:
  image: mysql
  command: --default-authentication-plugin:mysql_native_password
  restart: always
  environment:
   MYSQL_ROOT_PASSWORD: redhat

adminer:
  image: adminer
  restart: always
  depends_on:
   - db
   - another-service-name
  ports:
   - 8080:8080
```

## ASSIGNMENT
1. 
    * Create A docker image with DJango/flask/html website and simple form in container
    * Create another docker image for db and connect both
2. Crate a container that can be used to create more containers
    ```docker run -ti -v /var/run/docker.sock:/var/run/docker.sock docker``` uses image of docker not recommended
3. Container is to be created for a website and when some change is created in the website, the container should be updated as well itself (using watch-tower)
4. Write a Dockerfile
    * Install httpd / nginx server
    * Run httpd process from a non-root user


# Continuous Integration / Continuous Development(Delivery) 

## CI Tools                     ## CD Tools 
1. gitlab                       1. Spinkar
2. hudson                       2. Jenkins
3. teamcity
4. jenkins

# JENKINS

## Jenkins Installation
* Follow ```wiki.jenkins.io``` website for proper installation
* Always prefer ```Long Term Support(LTS) versions```
* You need java (8+) 
    * JDK Support
* For Ubuntu
```sh
wget -q -O - https://pkg.jenkins.io/debian/jenkins.io.key | sudo apt-key add -
sudo sh -c 'echo deb https://pkg.jenkins.io/debian-stable binary/ > /etc/apt/sources.list.d/jenkins.list'
sudo apt-get update
sudo add-apt-repository universe
sudo apt-get install jenkins
```
* To Start service ```systemctl start jenkins```
* To Enable service ```systemctl enable jenkins```
* Database location of jenkins is ```/var/lib/jenkins```
* Jenkins can be accessed through 2 ways:
    1. CLI
    2. Web UI(127.0.0.1:8080)
* Run jenkins in a container
* To find all files in ubuntu run the command,
    ```dpkg -s jenkins```
* The configuration file for jenkins is ```/etc/sysconfig/jenkins```
* Through configuration we can check/change the port/user/other default configurations for jenkins
* To check the port no boundation in os ```ss -nlpt``` or ```netstat -nlpt```
* jenkins is just a jvm process running in backend
* jenkins for docker
```sh
docker run -itd --name jenkins1 -p 8080:8080 -v /var/jenkins_home ticketfly/jenkins-example-gradle-build
```

## Jenkins with Docker
* By default, jenkins and docker can not communicate with each other
* These both are daemons access to admin over an operating system but not connected together
* To configure communication between both, add jenkins user to docker group by ```sudo usermod -aG docker jenkins```
* restart jenkins ```systemctl restart jenkins```
* Plugins Required:
  1. CloudBees Docker Build and Publish ~> Select & install without restart (most important)
  2. Docker build step
  3. Yet another docker
  4. Image Tag parameter
  5. Docker
* Docker Publish and Build
  1. Add image name such as ```pykid/firstimage```
  2. Add image tag such as ```v1```
  3. Add docker hub credentials

## Project
* To start any project in jenkins or use its CI/CD service , we have following general steps:
    1. Open the WEB GUI host ```127.0.0.1:8080```
    2. Click on create new
    3. Write description of project
    3. Add files/code to work on
    4. Set / Build trigers
    5. Click on Build Now in left panel
* The status of success/failure/pending is displayed through weather emoji's ```sunny the better```
* Jenkins can be connected to multiple host docker engines using ansible

### Post Build Project
* It is used to Build or trigger another Project made using Jenkins

## Jenkins with Github
* Select SCM as Git
* Provide Your public github profile url
* If private repo is being used then provide your credentials

## To build trigger scheduling
* Select Poll SCM
* Poll SCM ~> It is a service that can be configured in jenkins panel which lets the jenkin keep a check of git repo update at specific interval of time
* use Crontab Syntax for scheduling
* Crontab Syntax ```minutes hr date month day```
* Example for every month at 9:30 ```30 9 1 * * ```
* Every 15 minute   ```*/15 * * * *```
* Every minute ```* * * * *```

# Ansible 
* It can be used to automate
    1. Linux Servers
    2. Windows Servers
    3. Cloud Servers
    4. Cisco Devices
    5. VmWare Devices
    6. Kubernetes
               and many more..
* Can only be installed on Linux Based OS
* It uses connectors to connect with different serers:
    1. ssh ~ linux
    2. WInRn ~ Windows
    3. NetConf / NetworkCLI ~ Cisco

## Ansible Syntax
* For /etc/ansible/hosts
```
[group-name]
ip-1
ip-2
34.238.124.194

[group-name2]
ip-3
ip-1
```
* Working Workflow
Ansible ~> Configure file ~> Inventory ~> ssh ~> Parallel to all systems
where, inventory file = /etc/ansible/host
* to run simple adhoc command ``` ansible group-name1,group-name2 -u user-name -m ping -k```
* ```-k``` ~> to take password
* To get the list modules ```ansible-doc -l```
* Its not a service based tool
* Ansible Playbook
```yaml
 - hosts: group-name
   remote_user: adhoc  # this is the target machine user
   tasks:
    - name: want to run date command
      command: date
    - name: create directory
      command: mkdir /tmp/google    # another-module
```
* To run playbook ```ansible-playbook file-name.yaml -k```


## Module Examples
```yaml
---
 - hosts: localhost
   tasks:
    - name: running date command
      command: date     # i am using date command to run locally
    
    - name: print hello world essage
      debug: msg="hello world"
```

```yaml
---
 - hosts: localhost
   tasks:
    - name: installing httpd server
      yum: name=httpd state=present

    - name: starting service        # real OS not containers
      service: name=httpd  state=started

    - name: to start httpd service for containers
      shell: httpd -DFOREGROUND

```

```yaml
---
 - hosts: localhost
   vars:
    x: httpd
    y: hello
   tasks:
    - name: installing httpd
      yum: 
       name: "{{ x }}" # calling ansible variables
       state: present

    - name: start service in Real OS
      service:
       name: "{{ x }}"
       state: started

    - name:  starting service in container
      shell: httpd -DFOREGROUND
```

* To virtually run/ execute any playbook, that is not to have any changes to system byt still execute playbook , we use command
 ```ansible-playbook -C playbook-name.yml ```

```yaml
---
 - hosts: localhost
   tasks:
    - name: installing frp software
      yum:
       name: ftp
       state: present
    
    - name: checking current time
      command: date
      register: x  # to store the output of connected modules

    - name: print the value of x
      debug: var=x

    - name: print only specific output with stdout
      debug: var=x.stdout

```

* only one debug can run in 1 line and if more then one are given then only the latest will be executed


# Kubernetes
* Designed by ```Google``` using ```GO Language``` introduced in around 2014.
* This product was donated to CNCF and is pure open-source
<a href="https://kubernetes.io"> Official Docs </a>


## Things required to be Taken Care in Production
1. Security
2. Downtime
3. Upgradation ~> process must be smooth
4. Portability(with respect to Code) + Migration(with respect to complete server)
5. AutoScaling
6. Superfast Deployment ( Easy to Deploy )



## Architecture and Components of Kubernetes
* Anything which makes our application run are called ```API-Resources``` such as PODS and Services
* Requirement:
    1. Master ~> Linux Bases
    2. Minions ~> Linux or Windows
* <u>Control-Plane</u> ~> All the components discussed below are together called the ```Control Plane Components```
* <u>Container Orchestration</u> ~> A Tool that can manage the various containers in run time
e.g., Docker SWARM , Dokku , Apache Mesos , Kubernetes(K8S)
* Every minion should have docker installed
* <u>Kubernetes-Cluster</u> : Combination of Master and Minions all together
* <u>Kube-API Server</u> : Present in Master Server,request send by kubectl are received by it thus it acts as an ```end-point``` for management or any other activity over Kubernetes-Cluster
* <u>Kube-Scheduler</u> : It receives requests from ```Kube-APIServer``` to initialise a POD and it checks for the best MINION to get it done (by usings reports taken from ```Node Controller```) and schedule the task
* <u>Node Controller</u> : Checks the health of minion nodes ~> Has enough resources,add new minion at real time,disconnect minion
* <u>Replication Controller</u> : It connects with ```Kube-Scheduler``` to maintain and initialise a count of containers decided at the beginning.Basically it keeps a count of ```no. of containers launched per image```

* <u>Kube-Proxy</u> : kube-proxy is a network proxy that runs on each node in your cluster and maintains ```network rules``` on nodes. These network rules allow network-communication between your Pods from network sessions inside or outside of your cluster that is kube-proxy decided as ```which pod can communicate to which node```

* <u>ETCD</u> : 
    1. Database server (most powerfull) ~> Stored the complete status(Healthy/Unhealthy/UP/Down/Running) of Minions ~> Stores data in key:value pair ~> Runs in Master Node ~> Using NOSQL ~> Brain of Kubernetes(most important)
    2. It can be made separetly outside from Kubernetes-Cluster thus it is not a part of ```Kubernetes Control Plane```
    3. It gets its data(Input) through ```KubeAPIServer```
* <u>Kubelet</u> ~> It is the end-point of communication present in all the minions.Any communication done by KubeAPIServer is done through Kubelet as it communicates any/all information from inside the minion(Docker Engine/Pods) to outside world
* Kubernetes can not use Docker Networking across Minions as that can cause ip-conflict
* As a solution we are gonna build our own bridge (Common Bridge Technology) that will be connected to each ```Docker Engine``` and will be  ```providing ip``` to each container
* Even the Master Node will also be connected with the above ```CBT```
e.g., ```Calico```,Flannel,ACL,CiscoASI,Calloin,Weave


# Installation of K8S Cluster
## Type of Installation
1. Single Node Kubernetes Cluster : Only 1 Physical server with both Master as well as Minion ( Testing purpose )
    * <a href="https://www.youtube.com/watch?v=TTzbQdu30YA"> Installation Video </a>
    * <a href="https://github.com/redashu/k8s.git"> Installation Docs </a>
2. Multi Node K8S Cluster : platform independent
    * 1 Master + N Minions
    * N Master + N Minions
3. Kubernetes as a Service: Cloud providers like AWS( EKS ),Google(GKE),Azure(AKS),Oracle Cloud(OKE), VMWare Cloud, Alibaba


## MiniKube
* It provides an automated way for Installation of Single Node K8S Cluster
* It can use VMWare/VirtualBox/KVM/Hyper-V/Docker
* Download from official docs website
* Give Execution permission ```chmod +x /usr/bin/minikube```
* In Linux run ```minikube start --vm-driver=virtualbox``` to start minikube in Linux virtual box
(25 ~ 30 min to get kubernetes cluster ready)
* Kubectl(client side software) ~> Can be used using CMD,Powershell,Terminal : A CLI tool to connect with Kubernetes
* Minikube provides self authentication where as for master access deployed on AWS we need ```admin.conf``` that can be get using ```wget http://master-ip/admin.cnf```
* And we need to change the server private ip of ```admin.cnf``` to an public ip.
* To get list of working nodes: ```kubectl get nodes``` 
* To get list of working nodes for all nodes through master: ```kubectl get nodes --kubeconfig admin.conf```
* To get access of minikube, we can run ```minikube ssh```

# POD
* Created using Docker Image through Kubernetes
* Applications are executed over ```POD```
* Architecture  
Kubectl Communicates with----------> K8S
                                    Docker
                                      OS
* When Docker creates container it attaches IP,MAC,CPU,RAM etc but when K8S creates container using Docker, then it doesn't attach those things through docker and rather get it done by itself
* It has IP+MAC+CPU(RAM) with Application
* A Pod encapsulates an application’s container (or, in some cases, multiple containers), storage resources, a unique network identity (IP address), as well as options that govern how the container(s) should run. 

## Creating POD
* Can be Created using ```YAML``` and ```JSON```
* APIVersion,Kind,Metadata,Spec are the keywords required in ```YAML``` file of POD
* POD file
```yaml
apiVersion:v1
kind: Pod  # here P is caps
metadata:    # some info about pod
 name: piyushagarwal    # this is my pod name 
 labels:           
  x: y     # label is important if you want traffic to reach to specific port and it gets unique key:value
spec:
 containers:    # about my docker image and container info
  - name: pykidc1   # name of my container
    image: nginx     # image from docker hub (only) it doesn't take from local
    ports:
     - containerPort: 80  # same as expose in Dockerfile
```
* To run the POD ```kubectl create -f file-name.yml```
* To check POD ```kubectl get pods```
* To Delete POD ```kubectl delete pod pod-name``` or ```kubectl delete pods --all```
* To watch live status of PODs ```kubectl get pods -w```
* To get IP Address of POD ```kubectl get pods -o wide```
* To get detailed information about POD ```kubectl describe pods pod-name```
* To get detailed info about PODS / how to work with them , use command ```kubectl explain pods```, it justs like ```man``` for linux
* To check value of apiVersion ```kubectl explain pods.apiVersion```
* To check value of kind ```kubectl explain pods.kind```
* To check value of spec ```kubectl explain pods.spec```
* To check value of containers ```kubectl explain pods.spec.containers```
* To check output, but not actually bring any changes we use the command ```--dry-run```
* To create POD file using command and not create POD itself
```kubectl run pod-name --image=image-name --port port-no --restart Never --dry-run -o yaml```
* To create POD using command ```kubectl run pod-name --image=imagename --restart Never```
* To check pod label ```kubectl get pods --show-labels```
* To check the logs of POD ```kubectl logs pod-name```
* To get a list of API-Resources ```kubectl api-resources``` where API-Resources refers to all the services and commands like ```nodes,pods```
* To get a list of RC ```kubectl get rc```
* To delete everything(service,pods,rc) ```kubectl delete all --all```
* Every Node (Minion/Master) has a ```Kubelet``` which is the point communication between nodes , if it accepts the requests from ```Kube Scheduler``` then the request will be sent to Docker Engine and a container will be initialised

1. Client Uses ```Kubectl``` : (create POD)
2. Request get sent to Kube-API Server (Process)
3. Above Request is send to Kube-Scheduler : Search for best minion to get pod running
4. Kube Scheduler sends request to ```Kubelet``` of one of the minions
5. If above request is processed successfully then information regarding complete deployment,current status is sent back to API Server.

## Create vs Apply
* Create always makes a new POD
* Apply will check if its present or not
    1. If present then update it (if possible)
    2. Else create it

Note: A running POD can not be updated with a port number


# Service
* IP address of a pod / application running inside a pod can not be accessed from outside the Kubernetes Cluster
* Service ~> They have static ip and it identifies ports using
    1. IP (less efficient due to dynamic ip)
    2. Name
    3. Labels (key:value)
* Services is of 4 types:
    1. ClusterIP ~> used for internal accessing (webserver accesing database)
    2. NodePort : user use nodeport that assigns a unique port(randomly generated) to service ip which can further access the applications
    3. LoadBalancer
    4. External Name
* Service ip is not reachable to outside user
* User can only access Master-Ip(not recommended) or Worker IP

## Creating Service
```yaml
apiVersion: v1
kind: Service
metadata:
 name: myservice1

spec:
 ports:
  - name: mysvcport    # optional field
    port: 1122     # this is must and is the port of service IP
    targetPort: 80  # this much match the port number of POD
    protocol: TCP    # optional field
 selector:
  x: hello    # this label must be same as pod label to which traffic is to be forwarded
 type: NodePort
```

* to create the service file ```kubectl create -f service-file.yaml```
* To get list of services ```kubectl get services```
* kubectl run ashupod2 --image=nginx --port 80 --restart Never
* To run a service without yaml file, we run ```kubectl create service nodeport mypod2s1 --tcp 80 ```
* To access a website running pod, use url as ```http://minikube_internal_ip:svc_port```

## Best way to write a Service-Pod file 
```yaml
# pod file
apiVersion:v1
kind: Pod  # here P is caps
metadata:    # some info about pod
 name: piyushagarwal    # this is my pod name 
 labels:           
  x: y     # label is important if you want traffic to reach to specific port and it gets unique key:value
spec:
 containers:    # about my docker image and container info
  - name: pykidc1   # name of my container
    image: nginx     # image from docker hub (only) it doesn't take from local
    ports:
     - containerPort: 80  # same as expose in Dockerfile
    env:   # this must be the same variable that we define in dockerfile
     - name: color
       value: yellow

---
# service file
apiVersion: v1
kind: Service
metadata:
 name: myservice1

spec:
 ports:
  - name: mysvcport    # optional field
    port: 1122     # this is must and is the port of service IP
    targetPort: 80  # this much match the port number of POD
    protocol: TCP    # optional field
 selector:
  x: hello    # this label must be same as pod label to which traffic is to be forwarded
 type: NodePort
 ```
* To create a service of pod with type NodePort: ```kubectl expose pod pod-name --type NodePort --port 80```
* To get yaml file of already created service ```kubectl get svc service-name -o yaml > file.yaml```
* To create service of existing pod with type LoadBalancer  ```kubectl expose pod pod-name --type LoadBalancer --port 80```


* To Replace Entrypoint Parent Process in POD
```yaml
apiVersion:v1
kind: Pod  # here P is caps
metadata:    # some info about pod
 name: piyushagarwal    # this is my pod name 
 labels:           
  x: y     # label is important if you want traffic to reach to specific port and it gets unique key:value
spec:
 containers:    # about my docker image and container info
  - name: pykidc1   # name of my container
    image: nginx     # image from docker hub (only) it doesn't take from local
    command: ["/bin/sh","-c","cal"]  # command can replace parent process of entrypoint in image
```
* To connect to pod ```kubectl exec -it podname sh```

## Replication Controller
* Required how many pods you want to be handled
* Creating my RC file
```yaml
apiVersion: v1
kind: ReplicationController
metadata:
 name: myrcpiyush
 labels:
  app: web1 # this is the label of RC not label of pods

spec:
 replicas: 1 # always one pod will be present even in case of current worker node failure, how many pods you want alive
 template:
  metadata:
   name: mypod1 # podname created by RC
   labels:
    x: hellopod
   spec:
    containers:    # about my docker image and container info
  - name: pykidc1   # name of my container
    image: nginx

```
* Creating 2 Replicas
```yaml
apiVersion: v1
kind: ReplicationController
metadata:
 name: myrcpiyush
 labels:
  app: web1 # this is the label of RC not label of pods

spec:
 replicas: 2 # always one pod will be present even in case of current worker node failure, how many pods you want alive
 template:
  metadata:
   name: mypod1 # podname created by RC
   labels:
    x: hellopod
   spec:
    containers:    # about my docker image and container info
  - name: pykidc1   # name of my container
    image: nginx

```
* To increase the no of replicas ```kubectl scale rc replication-name --replicas=count-of-pods```
* We can edit the Repication Controller file as well ```kubectl edit rc rc-name```

## Replica Set
```yaml
apiVersion: apps/v1
kind: ReplicaSet
metadata:
 name: myrs1
 labels:
  app: web1 # this is the label of RC not label of pods

spec:
 selector:
  matchLabels:
   x: hellors      # here also label of pod
 replicas: 2 # always one pod will be present even in case of current worker node failure, how many pods you want alive
 template:
  metadata:
   name: mypod1 # podname created by RC
   labels:
    x: hellors
   spec:
    containers:    # about my docker image and container info
  - name: pykidc1   # name of my container
    image: nginx
    ports:
     - containerport: 80

```
* For help with replicaset ```kubectl explain rs.kind```
* Not preferred with Production because of downtime



## Exam Prep
* <a href="http://3.218.1.117/admin.conf">Admin Conf file</a>
* Download file and change the ip to ```http://3.218.1.117:6443```
* Port Range: 30000 ~ 32767 for NodePort
* Practice for Multi App Based Dockerfile
* Expose , LoadBalancer, ENV
* To Access:
  1. ssh username@3.218.1.117
  2. Password: username
  3. kubectl config use-context username-context


# Kubernetes Volume
* Can be created inside worker node
* Can be made outside and attached to any worker node or specific pod using ```hostPATH```
* ```EmptyDir``` is a type of storage which is associated with the worker node and is fast and efficient storage type used for temporary purposes
* Various Storage protocols ```NFS , CEPH, GES, CINDER```
 
```yaml
apiVersion: v1
kind: Pod
metadata:
  creationTimestap: null
  labels:
    run: alpod1 # label of pod
    x: hello # pod can have more than one label to make this unique
  name: alpod1 
spec:
 volumes: # this is for creating volume of any type
 - name: ashuvol111   # name of volume
   emptyDir: {}  # it will create a temp and random folder in worker node and if u delete pod it will be deleted
  containers:
  - image: alpine
    name: alpod1
    volumeMounts:
    - name: ashubol111  # name of volume to be mounted from above section
      mountPath: /mnt/data/  # this folder will be created automatically for mounting purpose 
    command: ["/bin/sh","-c","while true; do date >> /mnt/data/output.txt; sleep 2;done"]
    resources: {}
  dnsPolicy: ClusterFirst
  restartPolicy: Always
status: {}
```  

## HostPath
* It can mount any file,directory or socker file in any worker node
```yaml
apiVersion: v1
kind: Pod
metadata:
  creationTimestap: null
  labels:
    run: alpod1 # label of pod
    x: hello # pod can have more than one label to make this unique
  name: alpod1 
spec:
 volumes: # this is for creating volume of any type
 - name: ashuvol111   # name of volume
   hostPath:    # it will create volume on the scheduled minion
    path: /etc/passwd # file in any linux based os where usernames are stored
    type: File   # path is a file
 - name: ashuvol12   # name of volume
   hostPath:    # it will create volume on the scheduled minion
    path: /usr/share/application/ # file in any linux based os where usernames are stored
    type: Directory   # path is a file
 - name: ashuvol13   # name of volume
   hostPath:    # it will create volume on the scheduled minion
    path: /var/run/docker.sock # file in any linux based os where usernames are stored
    type: Socket    # path is a file
  containers:
  - image: alpine
    name: alpod1
    volumeMounts:
    - name: ashubol111  # name of volume to be mounted from above section
      mountPath: /usr/share/nginx/html/index.html  # mounting a file
    command: ["/bin/sh","-c","while true; do date >> /mnt/data/output.txt; sleep 2;done"]
    resources: {}
  dnsPolicy: ClusterFirst
  restartPolicy: Always
status: {}
```  

# Namespace
* Creates different regions / isolated regions for PODs to be deployed
* There are 4 types of Namespace by default:
  1. Default  ~> Generally all PODS are deployed in this namespace
  2. Kube-system ~> Control Plane components and ETCD are deployed in this by default
  3. Kube-public ~> Its like temp folder, every pod inside kube-public is available to all other namespaces
  4. Kube.Node.lease ~> Backup,maintainence,monitoring of minions . Any application that is going to do this task is deployed in this name-space

* To check available namespaces ```kubectl get ns```
* To check pods in available namespace ```kubectl get po -n namespace-name```
* To create a new namespace ```kubectl create namespace namespace-name```
* To create pod in specific namespace ```kubectl run pod-name --image=image-name -n namespace-name```
* NameSpace in ```yaml``` file is listed in metadata as
```yaml
metadata:
 namespace: name-space-name
 name: anything
```
* Best way to deploy any application is to create a namespace
* Api-resources that are not binded with namespace are:
  1. Nodes ~> Master/Worker
  2. Namespace
  3. persistent volumes
* To get list of api-resources binded or not binded with namespace using command ```kubectl api-resources --namespaced=false```
* To delete a specific namespace, first need is to empty the data/pods in particular namespace


# Deployment
* <a href="https://github.com/redashu/k8s">Blog</a>
* One new version is configured
  1. Stops taking new connections for specific pod
  2. Serve the existing connections unless they leave
  3. once pod connections are 0 , it destroys it and create the new upgraded pod
* Repeat above 3 steps for each Pod
* This strategy of upgrades is known as ```Rolling Updates``` and can help with ```RollBacks```
* Example
```bash
mkdir /tmp/dep
cat << EOF >> v1.html
<h1> Hello Deployment </h1>
EOF
cat <<EOF >> Dockerfile
FROM nginx
MAINTAINER pykid
COPY v1.html /usr/share/nginx/index.html
EOF
cp v1.html v2.html
echo "<h1> Hello Deployment </h1>" > v2.html
cat <<EOF >> Dockerfile2
FROM nginx
MAINTAINER pykid
COPY v2.html /usr/share/nginx/index.html
EOF
docker build -t pykid/deployment:v1 .
docker build -t pykid/deployment:v2 -f Dockerfile2 .
docker login
docker push pykid/deployment:v1
```
* To create deployment ```kubectl create deployment deployment-name --image=pykid/deployment:v1 -o yaml > dep1.yaml```
* Add your name space in above file
* Create svc in same namespace ```kubectl expose deployment-name --port 80 -n namespace-name```
* To scale number of pods (increase no of pods) ```kubectl scale deployment deployment-name --replicas=3 -n namespace-name```
* Fore more info ```kubectl describe deployment.apps deployment-name -n namespace``` 
* To upgrade your file, just re apply the POD with changes
* To check Rollout history, run command ```kubectl rollout history deployment deployment-name -n namespace-name```
* To rollback to previous version ```kubectl rollout undo deployment deployment-name -n namespace-name```
* To rollback to specific ```revision``` or we can say ```version``` of our ```deployment```, run command ```kubectl rollout undo deployment deployment-name -n namespace-name --to-revision=revision-no```


# NodePort vs LoadBalancer
* Port range is 30000 ~ 32767 for both
* In Production, we never use Master/Worker node IP
* EKS Control Plane run in Server which are non-accessible and non-viewable
* Over EKS , when an LoadBalancer is made for any application then EKS creates one other LoadBalancer machine which costs some extra charges but provides an IP to be accessible
* When we deploy a loadbalancer svc in K8S managed by us , the External IP is alwasys ```Pending``` because master keeps waiting for it but it doesn't get created
* LoadBalancer provides us a DNS ( kind of ) over AWS that can used in place of Ip:port
* The Same given name can be used to generate a proper Web address using Domain provider like GoDaddy
* DNS provides a web name which is mapped with DNS name provided by LoadBalancer which finally redirects the request to our ip:port and the application will be accessible
<img src="Packet Flow.png" />

# Config Map
* It is another api-resource that stores key:value pairs
* It can be used by any number of Pod,ReplicaSet, RC, DaemonSet independently
* It is a global variable that can be used inside a namespace
* To create config map, run command ```kubectl create configmap configmap-name --from-literal x=yellow --from-literal y=blue```
* To check config map, run command as ```kubectl get cm```
* It is used Pod Yaml file as:
```yaml
env
- name: color
  valueFrom:
   configMapKeyRef:
    name: config-map-name
    key: key-which-stores-data-config-map
```
* To have multiple environment variables
```yaml
env
- name: color
  valueFrom:
   configMapKeyRef:
    name: config-map-name
    key: key-which-stores-data-config-map
env
- name: color1
  valueFrom:
   configMapKeyRef:
    name: config-map-name-1  # name of configMap
    key: key-which-stores-data-config-map-1  # Dictionary key-name
```
* Config map can also be used as volumes
* It can inject new variables inside any file that is if we declare a environment variable using config then it will make it inside pod even if it did not exist earlier
* It can read values from CLI, file as volume or even as template
* To create config map from a file, ```kubectl create configmap name-config-map --from-file file.extension```
* The above made config is of volume type
```yaml
spec:
 volumes:
  name: vol-name   # name of volume to be attached to container
   configMap:
    name: config-map-name  # config-map name made from file
```
* less secure and less features because using ```kubectl describe cm cm-name``` , one can check the key-value pair values

# Secrets
* Stores data similar as configmap
* stores data in encoded format (Base64)
* Can Store Docker Hub / Registry Credentials
* Store SSL certificates / TLS
* To create secret, run command ```kubectl create secret secret-type secret-name --from-literal x=yellow```
* Secrets are of 3 types:
  1. docker-registry ~> registry credentials (username/password/server)
  2. generic ~> basic variables
  3. tls
* to create one:
```yaml
env:
- name: color
  valueFrom:
   secretKeyRef:
    name: secret-key-name
    value: key-name
```    
* To create login secret for docker registry, run the command ```kubectl create secret docker-registry azr --docker-username=name --docker-password=password --docker-server=server-name```
* To pull image from another registry, you need to use login credentials in a secure manner, so for that
```yaml
spec:
 imagePullSecrets:
 - name: secret-name
```

### Task
1. Create a Pod of Mysql
2. Create a Database named K8S from client without using exec
3. Create a table named Services and write all the name of services ( Id,Name,Ip-Address)

# User Management
* In K8S users are of 2 types:
  1. Management ~> Supposed to authenticate requests for api-resources
  2. Service-Account ~> Resources like pods/services/rc are created by this user

* Explanation:
  1. Kubectl connects with KubeApiServer using a default set username and password ( in config file )
  2. KubeApiServer verifies the received credentials and connects with namespace of specified worker node
  3. Once request is reached to a particular Namespace, the Service Account user creates the specified resources

* To check the service account name, run command ```kubectl get serviceaccount -n namespace-name```
* To create namespace, run command ```kubectl create namespace namespace-name```
* Every ServiceAccount has a secret

# Kubernetes Dashboard
* To create Kubernetes Dashboard ```kubectl apply -f https://raw.githubusercontent.com/kubernetes/dashboard/v2.0.0/aio/deploy/recommended.yaml```
* To edit svc type ```kubectl edit svc svc-name -n kubernetes-dashboard```
* Above command will change the live ongoing svc name of kubernetes-dashboard
* Its not recommended to access dashboard using kubeconfig
* To get token, run command ```kubectl describe secret kubernetes-dashboard-token -n kubernetes-dashboard```

* To practice <a href="https://github.com/redashu/CKAD-exercises">Exercise Questions </a>
* Back to <a href="https://slashreboot.blogspot.com/">SlashReboot </a>

* In Minikube, run command ```minikube addons list``` to get a list of features available with minikube
* To run dashboard using minikube, ```minikube dashboard```
* In minikube we can not put ~> Cortannus,unschedulable,ETCD can not be maintained, infrastructure can not be maintained, not all security plugins are supported


# PV and PVC
* PV ~> Persistent Volume && PVC ~> Persistent Volume Claim
* Storage Areas should always be made outside Kubernetes Cluster
* PV are independent to namespace that is they are not attached to specific namespace
* PV are used to fetch data from outside cluster
* PVC is an object created for a particular namespace to claim a PV
* PVC Binding is of 2 types:
  1. Static ~> binds a specific PV to a namespace
  2. Dynamic ~> Randomly binds any PV to a namespace
* PVC and PV has 1:1 relation that is once a PV is claimed by a specific PVC it can not be claimed by any other.
* Few points to consider before making PV are:
  1. Size of PV should be same as storage it is being attached e.g., 1MiB = 1024Kb, 1MB= 1000Kb
  2. PV consists of 
    * Storage Size
    * Storage Class (Reclaim Policy,Type of Storage)
    * Access Modes ~> How many worker node can use that storage
    * Source or Provider

* Access Modes are of  types:
  1. ReadWriteOnce(RWO) ~> can be binded with only one worker node at a time
  2. ReadWriteMany(RWM) ~> can be binded with multiple or all nodes at a time
  3. ReadOnlyMode(ROM) ~> can be binded with multiple or all nodes at a time but can only read data

* Reclaim Policy are of 3 types:
  1. Delete ~> PV is free to be claimed by any other PVC but data will be deleted
  2. Recycle ~> PV can only be claimed by previous PVC only (Data remains safe)
  3. Retain ~> PVC will be free for any other PVC and data also remains safe.

* To create yaml file of PV, use the following code
```yaml
apiVersion: v1
kind: PersistentVolume
metadata:
  name: piyushpvcname
spec:
  capacity:
    storage: 5Gi   # size of storage in resource
  volumeMode: Filesystem
  accessModes:
    - ReadWriteOnce   # Accessibilty
  persistentVolumeReclaimPolicy: Recycle
  storageClassName: slow  # type aws, azure,slow,fast,go2,hdd
  mountOptions:
    - hard
    - nfsvers=4.1
  nfs:   # source of PV storage
    path: /tmp   # location of nfs server
    server: 172.17.0.2   # ip of nfs server
```
* To Create a PVC
```yaml
apiVersion: v1
kind: PersistentVolumeClaim
metadata:
  name: personal-namespace-name
spec:
  accessModes:
    - ReadWriteOnce   # type of PV to attach with
  resources:
    requests:
      storage: 8Gi  # Size of PV to attach with
  storageClassName: slow  # type of PV
```
* In PVC, ```RWX``` stands for Read Write Many
* To check the created PVC, run command ```kubectl get pvc -n namespace-name```
* To Attach PVC as volume to a POD
```yaml
spec:
  volumes:
  - name: piyushvol
    persistentVolumeClaim:
      claimName: myclaim
  containers:
    volumeMounts:
    - name: piyushvol
      mountPath: /mnt/data/
```

# MicroServices Architecture

<img src="Architecture.png"/>
Basic Architecture

* Giving unecessary excess amount of resources also could show bad efficiency issues
* In Micro Services Architecture , tiny OS are created in which single application is deployed like one for Monitor, one for Database

<img src="MicroServices.png"/>
MicroServices


<img src="Kubernetes_Architecture1.png"/>
Wordpress Based K8S Architecture Basic 01


<img src="K8S Architecture WebData.png"/>
K8S Web Server and Database architecture

To create same architecture:
1. Create PV for both web and db
2. Create PVC for both
3. Create database deployment --mysql(5.6 version) -- supply root password using secret
```kubectl create secret generic secret-name --from-literal pp=redhat123```
```kubectl create deploy database-name --image=mysql:5.6 --dry-run=client -o yaml > database.yaml```
<img src="Database.png"/>

4. Create  webser deployment using wordpress:4.8-apache, run command ```kubectl create deployment wordpress --image=wordpress:4.8-apache --dry-run=client -o yaml > wordpress.yaml```
  * To store Ip/Name of Database server use env variable ```WORDPRESS_DB_HOST``` with value as service name of database deployment
  * To Store Wordpress Database password use env variable ```WORDPRESS_DB_PASSWORD```
  * Database username is ```root``` by default
```yaml
apiVersion: apps/v1
kind: Deployment
metadata:
  creationTimestamp: null
  labels:
    app: wordpress
  name: wordpress
spec:
  replicas: 1
  selector:
    matchLabels:
      app: wordpress
  strategy: {}
  template:
    metadata:
      creationTimestamp: null
      labels:
        app: wordpress
    spec:
      volumes:
      - name: frontvol   # name of volume we want
        persistenVolumeClaim:
          claimName: webclaim  # creating volume using pvc to store application code
      containers:
      - image: wordpress:4.8-apache
        name: wordpress
        volumeMounts:
        - name: frontvol
          mountPath: /var/www/html/    # because wordpress is using apache
        ports:
        - containerPort: 80
        env:
        - name: WORDPRESS_DB_HOST   # to store ip/name of database server
          value: appdb   # service name of database deployment
        - name: WORDPRESS_DB_PASSWORD
          valueFrom:
            secretKeyRef:
              name: wpdb   # name of secret
              key: p    # key name

        resources: {}
status: {}
```


# Kubernetes Security
* Users and namespace binding ~> Being able to only access a specific amount of resources 
* Limiting resource quota ~> limit the amount of resources that can be used in a particular namespace
* Kubectle uses https protocol to connect with KubeApiServer over 6443 port no, can be checked using ```kubectl config view``` or reading the file ```config``` which is present in Master Node at ```/etc/kubernetes/```
* Context ~> Its a combination of information in regards to specific user such as username,namespace,crt file,csr file and few more
* To check available contexts, run command ```kubectl config get-contexts```
* To use specific context, run command ```kubectl config use-context context-name```

## Create https protocol from http
1. Create private key (RSA || DSA)
2. Generate Certificate Signing Request ~> Integrate Private Key with domain
3. CSR is submitted to CA company for approval
4. The Received Certificate of our CA and CRT makes the domain https after proper server configuration

* A Config File contains:
  1. Username
  2. Private key
  3. CSR
  4. CRT
  5. CA CSR
* To Create our own Config file for specific user
  1. Create a namespace, run command ```kubectl create namespace name-of-namespace```
  2. Create a private key, run command ```openssl genrsa -out student.key 2048```
  3. Create CSR, run command ```openssl req -new -key student.key -out student.csr -subj "/CN=student/0=adhocnw"```
  4. Copy the generated csr file in ```.minikube``` folder
  5. To Create CRT, run command ```openssl x509 -req -in student.csr -CA /path-of-minikube/ca.crt  -CAkey  path-of-miniube/ca.key  -CAcreateserial -out student.crt  -days 1000```
  6. Copy generated CRT ```student.crt``` and CRT of minikube ```ca.crt``` to namespace folder
  7. Setting Credential, run command ```kubectl config set-credentials student --client-certificate=path-of-student.crt  --client-key=path-of-student-key```
  8. Create Context for user ```kubectl config set-context student-context --cluster=minikube --namespace=college  --username=student```
  9. Editing the config for our user as <!-- Will code in later -->
  

  # RBAC
  * Used to liimit resources to users based on roles
  ```yaml
  apiVersion: rbac.authorization.k8s.io/v1   # api version of role
  kind: Role
  metadata:
   name: ashurole1
   namespace: limited   # user defined
  
  rules:
   - apiGroups: ["v1","apps",""]   # "" refers to compatible to given elements as v1 or apps
     resources: ["pods","deployments"]  # defines what can be created
     verbs: ["create","get","watch","update","delete","list"]  # operations that can be used, * for all
  ```
* Creating above file will create a role and needs to be binded by a user
* For Rolebinding
```yaml
apiVersion: rbac.authorization.k8s.io/v1
kind: RoleBinding
metadata:
 name: rolebinding1
 namespace: limited

subjects:
 - kind: User
   name: default    # name of service account

roleRef:
 kind: Role
 name: ashurole1   # Same as Role defined in previous code
 apiGroup: ""
```
* Roles are of 2 types:
  1. User Role ```kubectl get roles``` ~> RoleBinding is done and this role can not work anything over cluster
  2. Cluster Role  ```kubectl get clusterroles``` ~> ClusterRoleBinding is done and this role can do things over cluster

* <u>HELM</u> ~> It is a package manager for kubernetes just like yum or apt


