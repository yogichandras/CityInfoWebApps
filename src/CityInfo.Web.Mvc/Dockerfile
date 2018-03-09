FROM microsoft/dotnet:latest

WORKDIR /app
COPY . .

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]


ENTRYPOINT ["dotnet", "CityInfo.Web.Mvc.dll"]
