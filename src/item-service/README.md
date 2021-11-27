# Item Service

## Secret Manager
```json
{
  "ApplicationInsights": {
    "InstrumentationKey": "InstrumentationKey for Secret Manager."
  }
}
```

## Build and Push Docker Images
```shell-session
$ docker build -t thara0402/item-service:0.1.0 ./
$ docker run --rm -it -p 8000:80 --name item-service thara0402/item-service:0.1.0
$ docker push thara0402/item-service:0.1.0
```

## Create Azure Container Apps
```shell-session
$ az containerapp create -n item-service -g <ResourceGroup Name> \
  -e <Environment Name> -i thara0402/item-service:0.6.0 \
  -v PathBase=/item,APPINSIGHTS_INSTRUMENTATIONKEY=<InstrumentationKey> \
  --ingress internal --target-port 80 \
  --revisions-mode single --scale-rules ./deploy/httpscaler.json \
  --max-replicas 10 --min-replicas 1
```
