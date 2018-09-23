FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 54366
EXPOSE 44328

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["DomainWebApp/DomainWebApp.csproj", "DomainWebApp/"]
RUN dotnet restore "DomainWebApp/DomainWebApp.csproj"
COPY . .
WORKDIR "/src/DomainWebApp"
RUN dotnet build "DomainWebApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DomainWebApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DomainWebApp.dll"]