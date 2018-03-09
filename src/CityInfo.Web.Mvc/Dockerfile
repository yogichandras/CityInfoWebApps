FROM microsoft/dotnet:latest

WORKDIR /app
COPY . .

RUN ["dotnet", "restore"]

ENTRYPOINT ["dotnet", "CityInfo.Web.Mvc.dll"]
