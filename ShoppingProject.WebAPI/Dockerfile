FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ShoppingProject.WebAPI/ShoppingProject.WebAPI.csproj", "ShoppingProject.WebAPI/"]
COPY ["ShoppingProject.Business/ShoppingProject.Business.csproj", "ShoppingProject.Business/"]
COPY ["ShoppingProject.Logger/ShoppingProject.Logger.csproj", "ShoppingProject.Logger/"]
COPY ["ShoppingProject.Entity/ShoppingProject.Entity.csproj", "ShoppingProject.Entity/"]
COPY ["ShoppingProject.Core/ShoppingProject.Core.csproj", "ShoppingProject.Core/"]
COPY ["ShoppingProject.Data/ShoppingProject.Data.csproj", "ShoppingProject.Data/"]
RUN dotnet restore "ShoppingProject.WebAPI/ShoppingProject.WebAPI.csproj"
COPY . .
WORKDIR "/src/ShoppingProject.WebAPI"
RUN dotnet build "ShoppingProject.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingProject.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingProject.WebAPI.dll"]