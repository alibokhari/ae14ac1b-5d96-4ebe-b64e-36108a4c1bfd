FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Simulator/Simulator.csproj", "Simulator/"]
COPY ["ToyRobotSimulator/ToyRobotSimulator.csproj", "ToyRobotSimulator/"]
RUN dotnet restore "Simulator/Simulator.csproj"
COPY . .
WORKDIR "/src/Simulator"
RUN dotnet build "Simulator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Simulator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Simulator.dll"]