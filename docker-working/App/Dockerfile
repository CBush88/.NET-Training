From mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App

#copy everything
Copy . ./
#restore as distinct layer
RUN dotnet restore
#Build and publish as release
RUN dotnet publish -c Release -o out

#Build runtime image
From mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "Dotnet.Docker.dll"]