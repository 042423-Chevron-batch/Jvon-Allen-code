FROM mcr.microsoft.com/dotnet/sdk:7.0


WORKDIR /app
COPY Program.cs Program.cs
COPY HelloWorld.csproj HelloWorld.csproj

RUN dotnet publish -o dist


CMD [ "dotnet", "dist/HelloWorld.dll"]