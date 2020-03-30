# Docker

#### Current Login Connections
35.193.189.6

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
