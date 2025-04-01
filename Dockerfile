# --- Stage 1: Build the .NET application ---
FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS builder

# Set working directory inside the builder container
WORKDIR /src

# Copy project file and restore as distinct layers
COPY src/SolverApp/SolverApp.csproj ./SolverApp/
RUN dotnet restore SolverApp/SolverApp.csproj

# Copy the full source code
COPY src/SolverApp ./SolverApp/

# Build the app in release mode
WORKDIR /src/SolverApp
RUN dotnet publish -c Release -o /app/publish

# --- Stage 2: Run the application ---
FROM mcr.microsoft.com/dotnet/runtime:7.0-alpine

# Set working directory in the final container
WORKDIR /app

# Copy the published app from the build stage
COPY --from=builder /app/publish .

# Set the entrypoint
ENTRYPOINT ["dotnet", "SolverApp.dll"]
