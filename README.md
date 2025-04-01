# cs-template

Simplistic CSharp template code

## Create .NET Console App

dotnet new console -o SolverApp

dotnet add package Microsoft.Extensions.Logging.Console --version 7.0.0

## Run .NET Console App

dotnet run

## Create .NET Web API

dotnet new webapi -o SolverApi

## Run .NET Web API

dotnet run

http://localhost:5000/api/solver/3/4

## Create .NET Console App (Worker)

dotnet new console -o SolverApp

## Create .NET Unit Test project

dotnet new xunit -o SolverTests
dotnet add SolverTests/SolverTests.csproj reference ../../src/SolverApp/SolverApp.csproj

## Run Tests

dotnet test SolverTests

## Running GitHub actions locally

https://github.com/nektos/act

`act -W .github/workflows/ci.yaml -j lint-format-test`
