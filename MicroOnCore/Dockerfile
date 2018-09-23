FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MicroOnCore/MicroOnCore.csproj", "MicroOnCore/"]
RUN dotnet restore "MicroOnCore/MicroOnCore.csproj"
COPY . .
WORKDIR "/src/MicroOnCore"
RUN dotnet build "MicroOnCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroOnCore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroOnCore.dll"]