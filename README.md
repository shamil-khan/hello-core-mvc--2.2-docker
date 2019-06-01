# hello-core-mvc--2.2-docker
The test project to explore asp.net core 2.2 in docker

# To build docker images and run containers  

To build the docker-image
```sh
docker build -t hello-core-mvc .
```

To check image created successfully
```sh
docker images
```

To run the docker-image in docker-container
```sh
docker run -p 3000:80 --name helloCoreMVC3000 hello-core-mvc
```

To check the docker-container is running
```sh
docker ps
docker ps -a
```

To run docker-container in interactive mode in bash
```sh
docker run -it --entrypoint "/bin/bash" -p 3000:80 --name helloCoreMVC3000 hello-core-mvc
```

# To cleanup docker images and containers

To delete docker-container 
```sh
docker rm --force helloCoreMVS3000
```

To delete docker-image 
```sh
docker rmi image hello-core-mvc
```

To delete all dangling docker-images 
```sh
docker rmi image $(docker images -f dangling=true -q)
```
