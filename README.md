# Smart Store Microservices

## Create Azure Container Apps environment
```shell-session
$ az group create -n <ResourceGroup Name> -l canadacentral
$ az deployment group create -f ./deploy/main.bicep -g <ResourceGroup Name>
```

## Create Microservices for Smart Store
- [Item Service](src/item-service/README.md)
- [Pos Service](src/pos-service/README.md)
- [Stock Service](src/stock-service/README.md)

