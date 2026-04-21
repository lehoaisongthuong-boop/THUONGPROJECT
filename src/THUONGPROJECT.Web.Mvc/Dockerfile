FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/THUONGPROJECT.Web.Mvc/THUONGPROJECT.Web.Mvc.csproj", "src/THUONGPROJECT.Web.Mvc/"]
COPY ["src/THUONGPROJECT.Web.Core/THUONGPROJECT.Web.Core.csproj", "src/THUONGPROJECT.Web.Core/"]
COPY ["src/THUONGPROJECT.Application/THUONGPROJECT.Application.csproj", "src/THUONGPROJECT.Application/"]
COPY ["src/THUONGPROJECT.Core/THUONGPROJECT.Core.csproj", "src/THUONGPROJECT.Core/"]
COPY ["src/THUONGPROJECT.EntityFrameworkCore/THUONGPROJECT.EntityFrameworkCore.csproj", "src/THUONGPROJECT.EntityFrameworkCore/"]
WORKDIR "/src/src/THUONGPROJECT.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/THUONGPROJECT.Web.Mvc", "src/THUONGPROJECT.Web.Mvc"]
COPY ["src/THUONGPROJECT.Web.Core", "src/THUONGPROJECT.Web.Core"]
COPY ["src/THUONGPROJECT.Application", "src/THUONGPROJECT.Application"]
COPY ["src/THUONGPROJECT.Core", "src/THUONGPROJECT.Core"]
COPY ["src/THUONGPROJECT.EntityFrameworkCore", "src/THUONGPROJECT.EntityFrameworkCore"]
WORKDIR "/src/src/THUONGPROJECT.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "THUONGPROJECT.Web.Mvc.dll"]
