FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["iFHMS.DotnetCodingChallenge/iFHMS.DotnetCodingChallenge.csproj", "iFHMS.DotnetCodingChallenge/"]
RUN dotnet restore "iFHMS.DotnetCodingChallenge/iFHMS.DotnetCodingChallenge.csproj"
COPY . .
WORKDIR "/src/iFHMS.DotnetCodingChallenge"
RUN dotnet build "iFHMS.DotnetCodingChallenge.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "iFHMS.DotnetCodingChallenge.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "iFHMS.DotnetCodingChallenge.dll"]
