FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ToyRobotSimulator.UnitTest/ToyRobotSimulator.UnitTest.csproj", "ToyRobotSimulator.UnitTest/"]
COPY ["ToyRobotSimulator/ToyRobotSimulator.csproj", "ToyRobotSimulator/"]
RUN dotnet restore "ToyRobotSimulator.UnitTest/ToyRobotSimulator.UnitTest.csproj"
COPY . .

WORKDIR /src
RUN dotnet test

ENTRYPOINT ["dotnet", "test"]