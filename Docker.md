# Docker

# Notes

### CMD vs EntryPoint
* Work of ```CMD``` tag in Dockerfile is to always run the specified command,whenever a container is created
* Work of ```Entrypoint``` tag in Dockerfile is to run the default command if no command is given at run time

### Add vs Copy
* Both work the same way in Dockerfile
* Only advantage that ```Add``` tag has over ```Copy``` is that it can copy files from a URL like ```github``` as well directly to container-image

### Docker Hub
* To upload any image over docker hub, we need
    1. docker login
    2. image to be tagged
* To tag image use
    ```docker image tag image-name:version user-name/imagename:version```
* To Push or pull images
    ```docker push user-name/imagename:version`



## Remove old pre-installed packages
```
sudo apt-get remove docker docker-engine docker.io containerd runc
```
## Install Docker CE using Repository in Ubuntu
1. Update the ```apt``` package index
    ```sudo apt-get update```
2. install packages to allow ```apt``` to use a repository over HTTPS:
    ```sh
    sudo apt-get install \
    apt-transport-https \
    ca-certificates \
    curl \
    gnupg-agent \
    software-properties-common
    ```
3. Add Docker's official GPG key:
    ```sh
    curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
    ```
    * Verify that you have the required key using
    ```sh
    sudo apt-key fingerprint 0EBFCD88
    ```
    it will show an output like
    ```
    pub   rsa4096 2017-02-22 [SCEA]
    9DC8 5822 9FC7 DD38 854A  E2D8 8D81 803C 0EBF CD88
    uid           [ unknown] Docker Release (CE deb) <docker@docker.com>
    sub   rsa4096 2017-02-22 [S]
    ```
4. Use the following command to set up stable repository
    ```sh
    sudo add-apt-repository \
   "deb [arch=amd64] https://download.docker.com/linux/ubuntu \
   bionic \
   stable"
    ```

## Install Docker Engine - Community
1. Update the ```apt``` package index
    ```sh
    sudo apt-get update
    ```
2. Install the latest version of Docker Engine-Community and containerd,or go to the next step to install a specific version
    ```sh
    sudo apt-get install docker-ce docker-ce-cli containerd.io
    ```
    * To list versions available in your repo: 
```apt-cache madison docker-ce```
    * for specific installation : ``` sudo apt-get install docker-ce=<VERSION_STRING> docker-ce-cli=<VERSION_STRING> containerd.io```
    * e.g., version_string = 5:18.09.1~3-0~ubuntu
    
3. Start the service ```sudo service docker start```


## Setup non-root user to access Docker without Sudo
1. If not created, create a docker group
    ```sudo groupadd docker```
2. Add your user to the group ```docker```
    ```sudo usermod -aG docker user-name```
3. Restart / Re-evaluate the user permissions by running the command
    ```newgrp docker```
4. Verify that docker is installed properly by running the command
    ```sh
    docker run hello-world
    ```
Note: if above command does not work,run ```docker login``` command and enter your docker hub credentials.


## Docker Containers
* There are different ways to use containers. These include:
    1. To run a single task ~> This could be a shell script or a custom app
    2. Interactively ~> This connects you to the container similar to the way you SSH into a remote server
    3. In the Background ~> For long-running services like websites and databases

1. Running a Single Task
* ```docker container run alpine hostname```
The output below shows that the alpine:latest image could not be found locally. When this happens, Docker automatically pulls it from Docker Hub.

After the image is pulled, the container’s hostname is displayed (888e89a3b36b in the example below).
```sh
 Unable to find image 'alpine:latest' locally
 latest: Pulling from library/alpine
 88286f41530e: Pull complete
 Digest: sha256:f006ecbb824d87947d0b51ab8488634bf69fe4094959d935c0c103f4820a417d
 Status: Downloaded newer image for alpine:latest
 888e89a3b36b
 ```
 * List all containers using 
    ```docker container ls --all```

2. Run an Interactive Ubuntu container
    * Run a Docker container and access its shell
    ```docker container run --interactive --tty --rm ubuntu bash```
    * In this example,we're giving Docker three parameters:

        1. ```--interactive``` says you want an interactive session
        2. ```--tty``` allocates a pseudo-tty
        3. ```--rm``` tells Docker to go ahead and remove the container when its done executing( such that when we again run ```docker container ls --all``` we won't find this container in the list)

```Note``` : Linux containers require the Docker host to be running a Linux kernel that is Linux containers cannot run directly on Windows Docker hosts and the same is true for Windows containers - they need to run on a Docker host with a Windows kernel

3. Run a background MySQL container
* Run a new MYSQL container with the following command
```sh
docker container run \
--detach\
--name mydb \
-e MYSQL_ROOT_PASSWORD=my-secret-pw \
mysql:latest
```
* In the above command:
    1. ```\``` allows to run command in different lines
    2. ```--detach``` will run the container in the background
    3. ```--name``` will name it mydb
    3. ```-e``` will use an environment variable to specify the root password (Note: This should never be done in production)
* To check whats happening inside docker container, we have two options:
    1. ```docker container logs container-name```
    2. ```docker container top container-name```
* ```docker container exec``` allows you to run a command inside a container.
* for example
```sh
docker exec -it mydb mysql --user=root --password=$MYSQL_ROOT_PASSWORD --version
```
* You can also use ```docker container exec``` to connect to a new shell process inside an already-running container. Executing the command below will give you an interactive shell (sh) inside your MySQL container
    ```docker exec -it mydb sh```

## Package and run a custom app using Docker

1. Build a Simple Website image using ```Dockerfile```
* pre-requisite: ```git clone https://github.com/dockersamples/linux_tweet_ap``` 
* Example of Dockerfile
```sh
FROM nginx:latest

COPY index.html /usr/share/nginx/html
COPY linux.png /usr/share/nginx/html

EXPOSE 80 443

CMD ["nginx","-g","daemon off;"]
```
* Lets see what each of these lines in the Dockerfile do:
    * ```FROM``` specifies the base image to use as the starting point for this new image you're creating
    * ```COPY``` copies files from the Docker host into the image, at a known location.
    In this example, ```COPY``` is used to copy two files into the image: ```index.html``` and a graphic that will be used on our webpage
    * ```EXPOSE``` documents which ports the application uses
    * ```CMD``` specifies what command to run when a container is started from the image.Notice that we can specify the command,as well as run-time arguments
* Use the ```docker image build``` command to create a new Docker image using the instructions in the Dockerfile
    ```docker image build --tag docker-id/image-name:version```
* To publish a website/image on some port, we use ```--publish``` tag
* The format of the ```--publish``` flag is ```host_port:container_port```
* Run the following command
```sh
docker container run \
 --detach \
 --publish 80:80 \
 --name linux_tweet_app \
 $DOCKERID/linux_tweet_app:1.0
 ```
 * to shutdown and remove the above container,run the following command
 ```docker container rm --force linux_tweet_app```
 * Here the ```--force``` parameter is used to remove the running container without shutting down
 * In production environment, use the ```docker container stop container-name``` to stop the container and use ```docker container rm container-name``` to permanently remove it

# Docker API Configuration (AMAZON INSTANCE)
* open docker file
```vim sudo /etc/sysconfig/docker```
* Add line ```-H tcp://0.0.0.0:2375``` in line ```OPTIONS="--default-ulimit nofile=1024:4096"```
* ```systemctl daemon-reload```
* ```systemctl restart docker```
* Add ```$env:DOCKER_HOST="tcp://public-ip:port"``` in windows powershell or 
``` export DOCKER_HOST="tcp://public-ip:port"``` in linux

## Start Containers Automatically
* Docker provides restart policies so that container can be restarted automatically when the daemon gets started
* For this task ```--restart``` tag is used with the ```docker run``` command
* The ```restart``` tag  has following values
    ```
    1. no ~> Do not automatically restart the container (default)
    2. on-failure ~> Restart the container if it exists due to an error, that is an non zero exit code is manifested
    3. always ~> Always restart the container even if its manually stopped as long as Daemon is running
    4. unless-stopped ~> restart the container unless its manually stopped
    ```

## Port Forwarding
* Used to redirect a user from single ip to multiple containers
* ```ip:port1``` can redirect to container1 and ```ip:port2``` can redirect to container2
* ```docker container run -d --name user:version -p any-4-digit-port:80 image-name```
* allow the port used for forwarding traffic in firewall rules

## .dockerignore
* This is a file used in production considered as best practice
* The Use of this file is to ignore certain files from being copied to container by the Dockerfile

## Docker Networking
* By networking the containers can communicate with each other with being isolated from each other
* ```docker inspect container-name``` used to check ip of container
* When install Docker for the first time, 3 Docker bridges are created by default
* Out of these 3, one bridge is named ```docker0``` given by OS and docker has named these 3 bridges as
    1. Bridge
    2. host
    3. None
* To check present docker bridges 
    ```docker network ls```
* To remove non-default bridges
    ```docker network rm $(docker network -q)```
* <u>Network Addressing Translation</u> ~> all containers uses the host bridge ip to connect to outside world and this process is called NAT
* To change the network of a container, we use the command
``` docker run -itd --name t5 --nework host alpine sh ```
* Containers can be configured that even being on same host , they can not communicate to each other that is possible by creating self customized containers
* To create your own new network, run the command
``` docker network create network-name ```


# Docker Storage
* Docker Storage or basically the location where all the files,images,containers are stored can be configured for:
    1. Docker Engine
    2. Containers
* In Containers, the data is temporary/emphieral/non-persistent which can be easily lost but by attaching volumes or basically ```Docker Volume``` we can save the data externally

## Docker Volume
* These are basically files/folders/hard disks/complete host storage space which can mounted as pool or distributed storage over containers
* To Create a Docker Volume,run command
    ```docker volume create volume-name```
* by default,size of above volume will be that of the host os
* To attach the created volume to a container,we need to attach/mount it when initializing the container,by running the command
    ```docker container run -it -v volume-name:\mount-folder-for-volume image-name command```
* To check volume stats, run the command
    ```docker inspect volume volume-name```
* To share a folder/file as volume , we run the command
    ```docker container run -it -v foldername:\mount-path image-name command```
* Even more then 1 volume can be mounted using the same command as above that is
    ```docker container run -it -v folder1:\mount-path1 -v folder2:\mount-path2 image-name command```
