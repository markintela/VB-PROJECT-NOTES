FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["VB-PROJECTS-NOTES/VB-PROJECTS-NOTES.csproj", "VB-PROJECTS-NOTES/"]
RUN dotnet restore "VB-PROJECTS-NOTES/VB-PROJECTS-NOTES.csproj"
COPY . .
WORKDIR "/src/VB-PROJECTS-NOTES"
RUN dotnet build "VB-PROJECTS-NOTES.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VB-PROJECTS-NOTES.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VB-PROJECTS-NOTES.dll"]