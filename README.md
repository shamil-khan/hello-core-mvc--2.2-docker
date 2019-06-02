# hello-core-mvc--2.2-docker
The test project to explore asp.net core 2.2 in docker

# Docker commands used
```sh
# pull mysql from docker-hub and inspect it.  "Volumes": { "/var/lib/mysql": {} }
docker pull mysql:8.0.0
docker inspect mysql:8.0.0

# create docker volume
docker volume create --name product-data

# run mysql container with docker-volume
docker run --name mysql -v product-data:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=mysecret -e bind-address=0.0.0.0 mysql:8.0.0

# find ip address of the msql container
docker network inspect bridge

# run the app container with mysql-dbhost environment variable
docker run --name helloCoreMVC3000 -p 3000:80 -e DBHOST=172.17.0.2 hello-core-mvc

# run multiple instances of app with same mysql-db.
docker run -d -p 3001:80 --name helloCoreMVC3001 -e DBHOST=172.17.0.2 -e MESSAGE="Server#3001" hello-core-mvc
docker run -d -p 3002:80 --name helloCoreMVC3002 -e DBHOST=172.17.0.2 -e MESSAGE="Server#3002" hello-core-mvc
docker run -d -p 3003:80 --name helloCoreMVC3003 -e DBHOST=172.17.0.2 -e MESSAGE="Server#3003" hello-core-mvc
```


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
