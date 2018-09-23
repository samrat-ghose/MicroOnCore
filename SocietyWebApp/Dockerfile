FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 54561
EXPOSE 44358

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["SocietyWebApp/SocietyWebApp.csproj", "SocietyWebApp/"]
RUN dotnet restore "SocietyWebApp/SocietyWebApp.csproj"
COPY . .
WORKDIR "/src/SocietyWebApp"
RUN dotnet build "SocietyWebApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SocietyWebApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SocietyWebApp.dll"]